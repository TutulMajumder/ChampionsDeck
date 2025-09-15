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
    public partial class manage_manager : UserControl
    {
        public int AdminId { get; set; }
        public manage_manager()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");

        public void LoadData()
        {
            string query1 = @"SELECT g.gamemanager_id,u.username,u.email,u.password,u.Role,u.status,u.user_id,g.admin_id FROM GameManagers g 
                                     INNER JOIN Users u ON g.user_id=u.user_id WHERE u.status='Active'";

            SqlCommand cmd = new SqlCommand(query1, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            managerDGView.DataSource = dt;
            managerDGView.Refresh();
            managerDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            managerDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string gmanager_id = gmanagerIDTBox.Text.Trim();
            string email = gmanagerUEmailTBox.Text;
            string username = gmanagerUNameTBox.Text;
            string password = gmanagerPasswordTBox.Text.Trim();
            string rPassword = gmanagerRPasswordTBox.Text.Trim();
            string status = statusCBox.SelectedItem?.ToString() ??"";
            string Role = "gamemanager";





            // Validate all required fields
            if (string.IsNullOrEmpty(gmanager_id) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(rPassword) ||
                string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(gmanager_id, out int gamemanagerId))
            {
                MessageBox.Show("Valid GameManager ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string checkgmQuery = @"SELECT COUNT(*) FROM GameManagers WHERE gamemanager_id = @gamemanager_id";
                SqlCommand checkCmd = new SqlCommand(checkgmQuery, con);
                checkCmd.Parameters.AddWithValue("@gamemanager_id", gmanager_id);
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("GameManager ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string gmQuery = @"INSERT INTO GameManagers (gamemanager_id, user_id, admin_id) VALUES (@gamemanager_id, @userId, @admin_id)";
                SqlCommand gmCmd = new SqlCommand(gmQuery, con);
                gmCmd.Parameters.AddWithValue("@gamemanager_id", gmanager_id);
                gmCmd.Parameters.AddWithValue("@userId", newUserId);
                gmCmd.Parameters.AddWithValue("@admin_id", AdminId); // Use the retrieved admin_id
                gmCmd.ExecuteNonQuery();

                MessageBox.Show("GameManager added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string gmanager_id = gmanagerIDTBox.Text.Trim();
            string email = gmanagerUEmailTBox.Text;
            string username = gmanagerUNameTBox.Text;
            string password = gmanagerPasswordTBox.Text.Trim();
            string rPassword = gmanagerRPasswordTBox.Text.Trim();
            string status = statusCBox.SelectedItem?.ToString() ?? "";



            // Validate all required fields
            if (string.IsNullOrEmpty(gmanager_id) ||
                 string.IsNullOrEmpty(username) ||
                 string.IsNullOrEmpty(email) ||
                 string.IsNullOrEmpty(password) ||
                 string.IsNullOrEmpty(rPassword) ||
                 string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(gmanager_id, out int gamemanagerId))
            {
                MessageBox.Show("Valid GameManager ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string checkAdminQuery = @"SELECT COUNT(*) FROM GameManagers g INNER JOIN Users u 
                                         ON g.user_id = u.user_id WHERE g.gamemanager_id = @gamemanager_id AND u.status = 'Active'";


                SqlCommand checkCmd = new SqlCommand(checkAdminQuery, con);
                checkCmd.Parameters.AddWithValue("@gamemanager_id", gmanager_id);

                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("GameManager ID not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Insert into Users table
                string updateQuery = @"UPDATE Users 
                                 SET username = @username, 
                                     email = @email, 
                                     password = @password, 
                                     status = @status 
                                 WHERE user_id = (SELECT user_id FROM GameManagers WHERE gamemanager_id = @gamemanager_id)";


                SqlCommand adminCmd = new SqlCommand(updateQuery, con);
                adminCmd.Parameters.AddWithValue("@gamemanager_id", gamemanagerId);
                adminCmd.Parameters.AddWithValue("@username", username);
                adminCmd.Parameters.AddWithValue("@email", email);
                adminCmd.Parameters.AddWithValue("@password", password);
                adminCmd.Parameters.AddWithValue("@status", status);

                int rowsAffected = adminCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("GameManager updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string gmid = gmanagerIDTBox.Text.Trim();
            if (string.IsNullOrEmpty(gmid) || !int.TryParse(gmid, out int gamemanagerId))
            {
                MessageBox.Show("Please enter the valid GameManager ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    // Update the user's status to Inactive
                    string updateQuery = @"UPDATE Users SET status = 'Inactive' WHERE user_id = (SELECT user_id FROM GameManagers WHERE gamemanager_id = @gamemanager_id) AND status = 'Active'";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@gamemanager_id", gmid);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("GameManager deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string gmid = gmanagerIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(gmid) || !int.TryParse(gmid, out int gamemanagerId))
            {
                MessageBox.Show("Please enter a valid GameManager ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string query = @"SELECT g.gamemanager_id, u.username, u.email, u.password, u.Role, u.status, u.user_id,g.admin_id FROM GameManagers g 
                           INNER JOIN Users u ON g.user_id = u.user_id WHERE g.gamemanager_id = @gamemanager_id AND u.status = 'Active'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@gamemanager_id", gmid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("GameManager information found successfully.");
                        managerDGView.DataSource = dt;
                        managerDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        managerDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                    else
                    {
                        MessageBox.Show("No matching GameManager found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void managerDGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = managerDGView.Rows[e.RowIndex];
                gmanagerIDTBox.Text = row.Cells[0].Value.ToString();
                gmanagerUNameTBox.Text = row.Cells[1].Value.ToString();
                gmanagerUEmailTBox.Text = row.Cells[2].Value.ToString();
                gmanagerPasswordTBox.Text = row.Cells[3].Value.ToString();
                gmanagerRPasswordTBox.Text = row.Cells[3].Value.ToString();

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

        private void ClearFields()
        {
            gmanagerIDTBox.Clear();
            gmanagerUEmailTBox.Clear();
            gmanagerUNameTBox.Clear();
            gmanagerPasswordTBox.Clear();
            gmanagerRPasswordTBox.Clear();
            statusCBox.SelectedIndex = -1;
        }

        private bool IsValidEmail(string email)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
