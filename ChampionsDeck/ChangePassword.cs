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
    public partial class ChangePassword : Form
    {
        private string email;
        public ChangePassword(string Email)
        {
            InitializeComponent();
            this.email = Email;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = passwordTBox.Text;
            string confirmPassword = RePasswordTBox.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsPasswordStrong(newPassword))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain a mix of uppercase, lowercase,symbol and numbers.",
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();


                string updatePasswordQuery = "UPDATE Users SET password = @Password WHERE email = @Email";
                using (SqlCommand updateCmd = new SqlCommand(updatePasswordQuery, con))
                {
                    updateCmd.Parameters.AddWithValue("@Password", newPassword);
                    updateCmd.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private bool IsPasswordStrong(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit)&&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            passwordTBox.UseSystemPasswordChar = true;
            RePasswordTBox.UseSystemPasswordChar = true;
        }

        private void showPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCBox.Checked)
            {
                passwordTBox.UseSystemPasswordChar = false;
            }

            else
            {
                passwordTBox.UseSystemPasswordChar = true;
            }
        }

        private void showRPassCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showRPassCBox.Checked)
            {
                RePasswordTBox.UseSystemPasswordChar = false;
            }

            else
            {
                RePasswordTBox.UseSystemPasswordChar = true;
            }
        }
    }
    
}
