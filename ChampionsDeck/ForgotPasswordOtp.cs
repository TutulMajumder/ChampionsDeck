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
    public partial class ForgotPasswordOtp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");
        private string email;
        private string generatedOTP;
        public ForgotPasswordOtp(string Email,string generatedOTP)
        {
            InitializeComponent();
            this.email = Email;
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordEmail forgotPasswordEmail = new ForgotPasswordEmail();
            forgotPasswordEmail.Show();
            this.Hide();
        }

        private void votpBtn_Click(object sender, EventArgs e)
        {
            // Example validation: Check if all text boxes contain exactly one digit
            string otpEntered = string.Join("", GetTextBoxes().Select(tb => tb.Text));

            if (otpEntered.Length == 6 && otpEntered.All(char.IsDigit))
            {
                // Convert to integer and compare with the expected OTP (if needed)
                if (otpEntered == generatedOTP)
                {
                    MessageBox.Show("Your OTP has been successfully verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChangePassword changePassword = new ChangePassword(email);
                    changePassword.Show();
                    this.Hide();

                    //this.Close(); // Close the Verify OTP form
                }
                else
                {
                    MessageBox.Show("The OTP you entered is incorrect. Please try again.", "OTP Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP! Please ensure you enter all 6 digits.", "Invalid OTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private Guna.UI2.WinForms.Guna2TextBox[] GetTextBoxes()
        {
            return new Guna.UI2.WinForms.Guna2TextBox[] { otpTBox1, otpTBox2, otpTBox3, otpTBox4, otpTBox5, otpTBox6 };
        }

        private void otpTBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
