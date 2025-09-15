using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class manageTournamentmanager : UserControl
    {
        public int AdminId { get; set; }
        public manageTournamentmanager()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");

        private void LoadData()
        {
            string query1 = @"SELECT t.tournamentmanager_id,u.username,u.email,u.password,u.Role,u.status,u.user_id,t.admin_id FROM TournamentManagers t 
                                     INNER JOIN Users u ON t.user_id=u.user_id WHERE u.status='Active'";

            SqlCommand cmd = new SqlCommand(query1, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            tmanagerDGView.DataSource = dt;
            tmanagerDGView.Refresh();
            tmanagerDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tmanagerDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string tmanager_id = tmanagerIDTBox.Text.Trim();
            string email = tmanagerUEmailTBox.Text;
            string username = tmanagerUNameTBox.Text;
            string password = tmanagerPasswordTBox.Text.Trim();
            string rPassword = tmanagerRPasswordTBox.Text.Trim();
            string status = statusCBox.SelectedItem?.ToString() ?? "";
            string Role = "tournamentmanager";





            // Validate all required fields
            if (string.IsNullOrEmpty(tmanager_id) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(rPassword) ||
                string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tmanager_id, out int tournamnetmanagerId))
            {
                MessageBox.Show("Valid TournamentManager ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password match
            if (password != rPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("A valid email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                // Check if GameManager ID already exists
                string checkgmQuery = @"SELECT COUNT(*) FROM TournamentManagers WHERE tournamentmanager_id = @tournamentmanager_id";
                SqlCommand checkCmd = new SqlCommand(checkgmQuery, con);
                checkCmd.Parameters.AddWithValue("@tournamentmanager_id", tmanager_id);
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("TournamnetManager ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert into Users table
                string userQuery = @"INSERT INTO Users (username, email, password, Role, status) VALUES (@username, @email, @password, @Role, @status);
                                   SELECT CAST(SCOPE_IDENTITY() AS INT)";
                SqlCommand userCmd = new SqlCommand(userQuery, con);
                userCmd.Parameters.AddWithValue("@username", username);
                userCmd.Parameters.AddWithValue("@email", email);
                userCmd.Parameters.AddWithValue("@password", password);
                userCmd.Parameters.AddWithValue("@Role", Role);
                userCmd.Parameters.AddWithValue("@status", status);
                int newUserId = Convert.ToInt32(userCmd.ExecuteScalar());

                // Insert into GameManagers table with admin_id
                string tmQuery = @"INSERT INTO TournamentManagers (tournamentmanager_id, user_id, admin_id) VALUES (@tournamentmanager_id, @userId, @admin_id)";
                SqlCommand tmCmd = new SqlCommand(tmQuery, con);
                tmCmd.Parameters.AddWithValue("@tournamentmanager_id", tmanager_id);
                tmCmd.Parameters.AddWithValue("@userId", newUserId);
                tmCmd.Parameters.AddWithValue("@admin_id", AdminId); // Use the retrieved admin_id
                tmCmd.ExecuteNonQuery();

                MessageBox.Show("TournamentManager added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void ClearFields()
        {
            tmanagerIDTBox.Clear();
            tmanagerUEmailTBox.Clear();
            tmanagerUNameTBox.Clear();
            tmanagerPasswordTBox.Clear();
            tmanagerRPasswordTBox.Clear();
            statusCBox.SelectedIndex = -1;
        }

        private bool IsValidEmail(string email)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string tmanager_id = tmanagerIDTBox.Text.Trim();
            string email = tmanagerUEmailTBox.Text;
            string username = tmanagerUNameTBox.Text;
            string password = tmanagerPasswordTBox.Text.Trim();
            string rPassword = tmanagerRPasswordTBox.Text.Trim();
            string status = statusCBox.SelectedItem?.ToString() ?? "";



            // Validate all required fields
            if (string.IsNullOrEmpty(tmanager_id) ||
                 string.IsNullOrEmpty(username) ||
                 string.IsNullOrEmpty(email) ||
                 string.IsNullOrEmpty(password) ||
                 string.IsNullOrEmpty(rPassword) ||
                 string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tmanager_id, out int tournamentmanagerId))
            {
                MessageBox.Show("Valid TournamnetManager ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password match
            if (password != rPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("A valid email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                // Check if admin_id already exists
                string checktmQuery = @"SELECT COUNT(*) FROM TournamentManagers t INNER JOIN Users u 
                                         ON t.user_id = u.user_id WHERE t.tournamentmanager_id = @tournamentmanager_id AND u.status = 'Active'";


                SqlCommand checkCmd = new SqlCommand(checktmQuery, con);
                checkCmd.Parameters.AddWithValue("@tournamentmanager_id", tmanager_id);

                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("TournamentManager ID not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Insert into Users table
                string updateQuery = @"UPDATE Users 
                                 SET username = @username, 
                                     email = @email, 
                                     password = @password, 
                                     status = @status 
                                 WHERE user_id = (SELECT user_id FROM TournamentManagers WHERE tournamentmanager_id = @tournamentmanager_id)";


                SqlCommand adminCmd = new SqlCommand(updateQuery, con);
                adminCmd.Parameters.AddWithValue("@tournamentmanager_id", tmanager_id);
                adminCmd.Parameters.AddWithValue("@username", username);
                adminCmd.Parameters.AddWithValue("@email", email);
                adminCmd.Parameters.AddWithValue("@password", password);
                adminCmd.Parameters.AddWithValue("@status", status);

                int rowsAffected = adminCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("TournamentManager updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string tmid = tmanagerIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(tmid) || !int.TryParse(tmid, out int tournamentmanagerId))
            {
                MessageBox.Show("Please enter a valid TournamentManager ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string query = @"SELECT t.tournamentmanager_id, u.username, u.email, u.password, u.Role, u.status, u.user_id,t.admin_id FROM TournamentManagers t 
                           INNER JOIN Users u ON t.user_id = u.user_id WHERE t.tournamentmanager_id = @tournamentmanager_id AND u.status = 'Active'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@tournamentmanager_id", tmid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("TournamentManager information found successfully.");
                        tmanagerDGView.DataSource = dt;
                        tmanagerDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        tmanagerDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                    else
                    {
                        MessageBox.Show("No matching TournamentManager found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string tmid = tmanagerIDTBox.Text.Trim();
            if (string.IsNullOrEmpty(tmid) || !int.TryParse(tmid, out int tournamentmanagerId))
            {
                MessageBox.Show("Please enter the valid TournamentManager ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Tournament Manager?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    // Update the user's status to Inactive
                    string updateQuery = @"UPDATE Users SET status = 'Inactive' WHERE user_id = (SELECT user_id FROM TournamentManagers WHERE tournamentmanager_id = @tournamentmanager_id) AND status = 'Active'";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@tournamentmanager_id", tmid);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("TournamentManager deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh the DataGridView to show active admins
                    }
                    else
                    {
                        MessageBox.Show("No Tournament was deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void tmanagerDGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = tmanagerDGView.Rows[e.RowIndex];
                tmanagerIDTBox.Text = row.Cells[0].Value.ToString();
                tmanagerUNameTBox.Text = row.Cells[1].Value.ToString();
                tmanagerUEmailTBox.Text = row.Cells[2].Value.ToString();
                tmanagerPasswordTBox.Text = row.Cells[3].Value.ToString();
                tmanagerRPasswordTBox.Text = row.Cells[3].Value.ToString();

                string status = row.Cells[5].Value?.ToString() ?? "";
                if (statusCBox.Items.Contains(status))
                {
                    statusCBox.SelectedItem = status;
                }
                else
                {
                    statusCBox.SelectedIndex = -1; // Reset if the value is not in the ComboBox
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
