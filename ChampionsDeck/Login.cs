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
            passwordTBox.UseSystemPasswordChar = true;
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            
            string userEmail = usernameTBox.Text.Trim();
            string password = passwordTBox.Text.Trim();

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int userId = 0;
                    string role = "";
                    string status = "";

                    // Step 1: Get user details
                    string userQuery = @"SELECT user_id, Role, status FROM Users WHERE email = @userEmail AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userEmail", userEmail);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32(reader.GetOrdinal("user_id"));
                                role = reader.GetString(reader.GetOrdinal("Role"));
                                status = reader.GetString(reader.GetOrdinal("status"));
                            }
                        }
                    }

                    // If no user found
                    if (userId == 0)
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                        return;
                    }

                    // If account is not active
                    if (status != "Active")
                    {
                        MessageBox.Show("Your account is not active. Please contact support.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int adminId = 0;
                    int gameManagerId = 0;
                    int tournamentManagerId = 0;

                    // Step 2: Get admin ID if user is an admin
                    if (role == "Admin")
                    {
                        string adminQuery = @"SELECT a.admin_id FROM Admins a INNER JOIN Users u ON a.user_id = u.user_id WHERE u.user_id = @userId";
                        using (SqlCommand cmd = new SqlCommand(adminQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                adminId = Convert.ToInt32(result);
                            }
                        }
                    }

                    // Step 3: Get game manager ID if user is a game manager
                    if (role == "gamemanager")
                    {
                        string gmQuery = @"SELECT g.gamemanager_id FROM GameManagers g INNER JOIN Users u ON g.user_id = u.user_id WHERE u.user_id = @userId";
                        using (SqlCommand cmd = new SqlCommand(gmQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            object result = cmd.ExecuteScalar();
                            if (result == null || result == DBNull.Value)
                            {
                                MessageBox.Show("GameManager record not found. Please contact support.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            gameManagerId = Convert.ToInt32(result);
                        }
                    }
                    if (role == "tournamentmanager")
                    {
                        string tmQuery = @"SELECT t.tournamentmanager_id FROM TournamentManagers t INNER JOIN Users u ON t.user_id = u.user_id WHERE u.user_id = @userId";
                        using (SqlCommand cmd = new SqlCommand(tmQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            object result = cmd.ExecuteScalar();
                            if (result == null || result == DBNull.Value)
                            {
                                MessageBox.Show("TournamentManager record not found. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            tournamentManagerId = Convert.ToInt32(result);
                        }
                    }

                    // Step 4: Redirect user based on their role
                    switch (role)
                    {
                        case "Admin":
                            //MessageBox.Show($"Debug: GameManager ID = {adminId}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show($"Debug: GameManager ID = {userId}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Admin_Dashboard adminDashboard = new Admin_Dashboard(adminId);
                            adminDashboard.Show();
                            this.Hide();
                            break;

                        case "Viewer":
                            MessageBox.Show("Welcome Viewer!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HomePage home = new HomePage();
                            home.Show();
                            this.Hide();
                            break;

                        case "gamemanager":
                            //MessageBox.Show($"Debug: GameManager ID = {gameManagerId}","Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GameManagerDashboard gameManagerDashboard = new GameManagerDashboard(gameManagerId);
                            gameManagerDashboard.Show();
                            this.Hide();
                            break;

                        case "tournamentmanager":
                           // MessageBox.Show($"Debug: GameManager ID = {tournamentManagerId}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TournamentManagerDashboard tournamentManagerDashboard = new TournamentManagerDashboard(tournamentManagerId);
                            tournamentManagerDashboard.Show();
                            this.Hide();
                            break;

                        default:
                            MessageBox.Show("Invalid role detected.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred while attempting to log in. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
           ForgotPasswordEmail forgotPasswordEmail = new ForgotPasswordEmail();
           forgotPasswordEmail.Show();
           this.Hide();

        }

        private void ClearFields()
        {
            //usernameTBox.Clear();
            passwordTBox.Clear();
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
    }

    }

