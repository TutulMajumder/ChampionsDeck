using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class Login : Form
    {
        // Connection string to your database
        private string connectionString = @"Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {

            string username = usernameTBox.Text.Trim();
            string password = passwordTBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // Query to check username, hashed password, and role
                string query = "SELECT Role FROM Users WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();

                    switch (role)
                    {
                        case "admin":
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                            this.Hide();
                            break;

                        case "Viewer":
                            MessageBox.Show("Welcome Viewer!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                            break;

                        case "gamemanager":
                            GameManagerDashboard gameManagerDashboard = new GameManagerDashboard();
                            gameManagerDashboard.Show();
                            this.Hide();
                            break;

                        case "tournamentmanager":
                            TournamentManagerDashboard tournamentManagerDashboard = new TournamentManagerDashboard();
                            tournamentManagerDashboard.Show();
                            this.Hide();
                            break;

                        default:
                            MessageBox.Show("Invalid role detected.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log error (e.g., to a file or database)
                Console.WriteLine("Error: " + ex.Message);

                MessageBox.Show("An error occurred while attempting to log in. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registerBtn_Click_1(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
            this.Hide();
        }

        private void forgotpassBtn_Click_1(object sender, EventArgs e)
        {
           // ForgotPassword forgotPasswordForm = new ForgotPassword();
           // forgotPasswordForm.Show();
            //this.Hide();

        }
    }

    }

