using ChampionsDeck.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class Registration : Form
    {
        private string connectionString = @"Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True";
        private string generatedOTP = string.Empty;
        public Registration()
        {
            InitializeComponent();
            
        }

        private void HideValidationElements()
        {
            labelheading.Visible = false;

            characterlbl.Visible = false;
            characterPBox.Visible = false;

            numberlbl.Visible = false;
            numberPBox.Visible = false;

            uppercaselbl.Visible = false;
            uppercasePBox.Visible = false;

            lowercaselbl.Visible = false;
            lowercasePBox.Visible = false;

            scharacterlbl.Visible = false;
            scharacterPBox.Visible = false;
        }

        private void ShowValidationElemnets()
        {
            labelheading.Visible = true;

            characterlbl.Visible = true;
            characterPBox.Visible = true;

            numberlbl.Visible = true;
            numberPBox.Visible = true;

            uppercaselbl.Visible = true;
            uppercasePBox.Visible = true;

            lowercaselbl.Visible = true;
            lowercasePBox.Visible = true;

            scharacterlbl.Visible = true;
            scharacterPBox.Visible = true;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(passwordTBox.Text))
            {
                HideValidationElements();
            }*/
        }

        private void passwordTBox_TextChanged(object sender, EventArgs e)
        {
         //ValidatePassword();
        }


        private bool ValidatePassword()
        {
            /*
            string password = passwordTBox.Text;

            if (string.IsNullOrEmpty(password))
            {
                HideValidationElements();
                return false;
            }

            ShowValidationElemnets();

            bool hasNumber = Regex.IsMatch(password, @"\d");
            bool hasUppercase = Regex.IsMatch(password, @"[A-Z]");
            bool hasLowercase = Regex.IsMatch(password, @"[a-z]");
            bool hasSymbol = Regex.IsMatch(password, @"[!@#$%^&*(),.?"":{}|<>]");
            bool hasValidLength = password.Length >= 8 && password.Length < 16;

            // Update UI based on validation
            UpdateValidationUI(characterlbl, characterPBox, isValidLength);
            UpdateValidationUI(numberlbl, numberPBox, hasNumber);
            UpdateValidationUI(uppercaselbl, uppercasePBox, hasUppercase);
            UpdateValidationUI(lowercaselbl, lowercasePBox, hasLowercase);
            UpdateValidationUI(scharacterlbl, scharacterPBox, hasSymbol);

            return hasUppercase && hasLowercase && hasSymbol && hasValidLength && hasNumber;
            */
            return true;
        }

        private void UpdateValidationUI(Label label, PictureBox pictureBox, bool isValid)
        {
            label.ForeColor = isValid ? Color.Green : Color.Red;
            pictureBox.Image = isValid ? Resources.Ok : Resources.No;
        }


        private bool IsDuplicateUser(string email, string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM [Users] WHERE Email = @email OR UserName = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        
        



        private void CreateABtn_Click(object sender, EventArgs e)
        {

            // Check if any text box is empty
            if (string.IsNullOrEmpty(userNameTBox.Text) ||
                string.IsNullOrEmpty(emailTBox.Text) ||
                string.IsNullOrEmpty(passwordTBox.Text) ||
                string.IsNullOrEmpty(RpasswordTBox.Text) ||
                string.IsNullOrEmpty(preferredGamesTBox.Text) ||
                countryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate individual fields
            if (!IsValidEmail(emailTBox.Text))
            {
                MessageBox.Show("A valid email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordTBox.Text != RpasswordTBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(preferredGamesTBox.Text))
            {
                MessageBox.Show("Preferred games are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (countryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidatePassword())
            {
                MessageBox.Show("Password does not meet the required criteria.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate user
            if (IsDuplicateUser(emailTBox.Text.Trim(), userNameTBox.Text.Trim()))
            {
                MessageBox.Show("Email or username already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!termsConditionsCBox.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions to proceed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Generate OTP and proceed
            generatedOTP = GenerateOTP();
            SendOTP(emailTBox.Text.Trim(), generatedOTP);

            verifyOtp verifyOTPForm = new verifyOtp(
                userNameTBox.Text,
                emailTBox.Text,
                passwordTBox.Text,
                preferredGamesTBox.Text,
                countryComboBox.SelectedItem.ToString(),
                generatedOTP
            );

            verifyOTPForm.Show();
            this.Hide();
        }

        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOTP(string email, string otp)
        {
            try
            {
                string fromEmail = "tutulm.364.aiub@gmail.com"; 
                string fromPassword = "paynvdatrmxhbrvk";
                string subject = "Your OTP for Registration";
                string body = $"Here is your registration verification code : {otp}";

                MailMessage mail = new MailMessage(fromEmail, email, subject, body);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("OTP sent to your email address.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending OTP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void SigninBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void termsConditionsBtn_Click(object sender, EventArgs e)
        {
            SignUpTermsConditions terms_Conditions = new SignUpTermsConditions();
            terms_Conditions.Show();
            this.Hide();
        }
    }
}
