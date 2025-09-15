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
    public partial class ForgotPasswordEmail : Form
    {
        private string connectionString = @"Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True";
        private string generatedOTP = string.Empty;
        public ForgotPasswordEmail()
        {
            InitializeComponent();
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
                string subject = "Password Reset Request";
                string body = $"We received a request to reset your password. Your OTP for password reset is: {otp}. Please enter this code to proceed. If you did not request this, please ignore this email.";

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTBox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckEmailExists(email))
            {
                generatedOTP = GenerateOTP();
                SendOTP(email, generatedOTP);

                // Open verification form
                ForgotPasswordOtp fpOtp = new ForgotPasswordOtp(email,generatedOTP);
                fpOtp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email not found", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
