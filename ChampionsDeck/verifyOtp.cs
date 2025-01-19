using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class verifyOtp : Form
    {
        private string connectionString = @"Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True";
        private string username;
        private string email;
        private string password;
        private string preferredGames;
        private string country;
        private string generatedOTP;
        public verifyOtp(string username, string email, string password, string preferredGames, string country, string generatedOTP)
        {
            InitializeComponent();
            this.username = username;
            this.email = email;
            this.password = password;
            this.preferredGames = preferredGames;
            this.country = country;
            this.generatedOTP = generatedOTP;

            // Attach TextChanged event handlers to all text boxes
            otpTBox1.TextChanged += new EventHandler(TextBox_TextChanged);
            otpTBox2.TextChanged += new EventHandler(TextBox_TextChanged);
            otpTBox3.TextChanged += new EventHandler(TextBox_TextChanged);
            otpTBox4.TextChanged += new EventHandler(TextBox_TextChanged);
            otpTBox5.TextChanged += new EventHandler(TextBox_TextChanged);
            otpTBox6.TextChanged += new EventHandler(TextBox_TextChanged);

            // Set focus to the first text box
            otpTBox1.Focus();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var currentTextBox = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (currentTextBox != null)
            {
                string input = currentTextBox.Text;

                // Ensure the text box contains only one digit
                if (input.Length > 1)
                {
                    currentTextBox.Text = input[0].ToString();
                    currentTextBox.SelectionStart = currentTextBox.Text.Length; // Move cursor to end
                }

                // Handle moving to the next or previous text box based on input length
                if (input.Length == 1)
                {
                    // Move to the next text box if input length is 1
                    if (currentTextBox == otpTBox1)
                        otpTBox2.Focus();
                    else if (currentTextBox == otpTBox2)
                        otpTBox3.Focus();
                    else if (currentTextBox == otpTBox3)
                        otpTBox4.Focus();
                    else if (currentTextBox == otpTBox4)
                        otpTBox5.Focus();
                    else if (currentTextBox == otpTBox5)
                        otpTBox6.Focus();
                }
                else if (input.Length == 0)
                {
                    // Move to the previous text box if Backspace is pressed and current text box is empty
                    if (currentTextBox == otpTBox2)
                        otpTBox1.Focus();
                    else if (currentTextBox == otpTBox3)
                        otpTBox2.Focus();
                    else if (currentTextBox == otpTBox4)
                        otpTBox3.Focus();
                    else if (currentTextBox == otpTBox5)
                        otpTBox4.Focus();
                    else if (currentTextBox == otpTBox6)
                        otpTBox5.Focus();
                }
            }
        }

        private void verifyOtp_Load(object sender, EventArgs e)
        {


        }



        private void votpButton_Click(object sender, EventArgs e)
        {
            string otpEntered = string.Join("", GetTextBoxes().Select(tb => tb.Text));

            if (otpEntered.Length == 6 && otpEntered.All(char.IsDigit))
            {
                // Convert to integer and compare with the expected OTP (if needed)
                if (otpEntered == generatedOTP)
                {
                    MessageBox.Show("OTP Verified Successfully!");

                    // Insert into database
                    RegisterUser();

                    this.Close(); // Close the Verify OTP form
                }
                else
                {
                    MessageBox.Show("Incorrect OTP.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a 6-digit OTP.");
            }

        }

        private void RegisterUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert into Users table
                    string insertUserQuery = "INSERT INTO Users (username, email, password, Role) VALUES (@UserName, @Email, @Password, 'Viewer');SELECT CAST(SCOPE_IDENTITY() AS INT);";
                    SqlCommand userCommand = new SqlCommand(insertUserQuery, connection);
                    userCommand.Parameters.AddWithValue("@UserName", username);
                    userCommand.Parameters.AddWithValue("@Email", email);
                    userCommand.Parameters.AddWithValue("@Password", password);
                    
                    
                    int userId = Convert.ToInt32(userCommand.ExecuteScalar());

                    // Insert into Viewers table
                    string insertViewerQuery = "INSERT INTO Viewers (user_id, preferredGames, country) VALUES (@UserId, @PreferredGames, @Country)";
                    SqlCommand viewerCommand = new SqlCommand(insertViewerQuery, connection);
                    viewerCommand.Parameters.AddWithValue("@UserId", userId);
                    viewerCommand.Parameters.AddWithValue("@PreferredGames", preferredGames);
                    viewerCommand.Parameters.AddWithValue("@Country", country);
                    viewerCommand.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Guna.UI2.WinForms.Guna2TextBox[] GetTextBoxes()
        {
            return new Guna.UI2.WinForms.Guna2TextBox[] { otpTBox1, otpTBox2, otpTBox3, otpTBox4, otpTBox5, otpTBox6 };
        }


        private void otpTBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
