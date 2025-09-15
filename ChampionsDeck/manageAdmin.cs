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
    public partial class manageAdmin : UserControl
    {
        public manageAdmin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");


        private void LoadData()
        {
            string query1 = @"SELECT a.admin_id,u.username,u.email,u.password,u.Role,u.status,u.user_id FROM Admins a 
                                     INNER JOIN Users u ON a.user_id=u.user_id WHERE u.status='Active'";

            SqlCommand cmd = new SqlCommand(query1, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adminDGView.DataSource = dt;
            adminDGView.Refresh();
            adminDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

            string admin_id = adminIDTBox.Text.Trim();
            string email = adminEmailTBox.Text;
            string username = adminNameTBox.Text;
            string password = adminPasswordTBox.Text.Trim();
            string rPassword = adminRPasswordTBox.Text.Trim();
            string status = adminStatusCBox.SelectedItem?.ToString() ?? "";
            string Role = "Admin";

            // Validate all required fields
            if (string.IsNullOrEmpty(admin_id) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(rPassword) ||
                string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(adminIDTBox.Text, out int adminId))
            {
                MessageBox.Show("Valid Admin ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password match
            if (adminPasswordTBox.Text != adminRPasswordTBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(adminEmailTBox.Text))
            {
                MessageBox.Show("A valid email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
            con.Open();
                // Check if admin_id already exists
                string checkAdminQuery = @"SELECT COUNT(*) FROM Admins WHERE admin_id = @adminId";
                SqlCommand checkCmd = new SqlCommand(checkAdminQuery,con);
                checkCmd.Parameters.AddWithValue("@adminId", admin_id);

                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Admin ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Insert into Users table
                string userQuery = @"INSERT INTO Users (username, email, password, Role, status)VALUES (@username, @email, @password,@Role, @status);SELECT CAST(SCOPE_IDENTITY() AS INT)";

                SqlCommand userCmd = new SqlCommand(userQuery, con);
                userCmd.Parameters.AddWithValue("@username", username);
                userCmd.Parameters.AddWithValue("@email", email);
                userCmd.Parameters.AddWithValue("@password", password);
                userCmd.Parameters.AddWithValue("@Role", Role);
                userCmd.Parameters.AddWithValue("@status", status);

                int newUserId = Convert.ToInt32(userCmd.ExecuteScalar());

                // Insert into Admins table
                string adminQuery = @"INSERT INTO Admins(admin_id, user_id) VALUES (@adminId, @userId)";

                SqlCommand adminCmd = new SqlCommand(adminQuery, con);
                adminCmd.Parameters.AddWithValue("@adminId", adminIDTBox.Text);
                adminCmd.Parameters.AddWithValue("@userId", newUserId);
                adminCmd.ExecuteNonQuery();


                MessageBox.Show("Admin added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadData();

                /*string query1 = @"SELECT a.admin_id,u.username,u.email,u.password,u.Role,u.status,u.user_id FROM Admins a 
                                     INNER JOIN Users u ON a.user_id=u.user_id WHERE u.status='Active'";

                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adminDGView.DataSource = dt;
                adminDGView.Refresh();
                adminDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                adminDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                */
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

            string admin_id = adminIDTBox.Text.Trim();
            string email = adminEmailTBox.Text;
            string username = adminNameTBox.Text;
            string password = adminPasswordTBox.Text.Trim();
            string rPassword = adminRPasswordTBox.Text.Trim();
            string status = adminStatusCBox.SelectedItem?.ToString() ?? "";


            // Validate all required fields
            if (string.IsNullOrEmpty(admin_id) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(rPassword) ||
                string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(adminIDTBox.Text, out int adminId))
            {
                MessageBox.Show("Valid Admin ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password match
            if (adminPasswordTBox.Text != adminRPasswordTBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!IsValidEmail(adminEmailTBox.Text))
            {
                MessageBox.Show("A valid email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                con.Open();
                // Check if admin_id already exists
                string checkAdminQuery = @"SELECT COUNT(*) FROM Admins a INNER JOIN Users u 
                                         ON a.user_id = u.user_id WHERE a.admin_id = @admin_id AND u.status = 'Active'";


                SqlCommand checkCmd = new SqlCommand(checkAdminQuery, con);
                checkCmd.Parameters.AddWithValue("@admin_id", admin_id);

                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Admin ID not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Insert into Users table
                string updateQuery = @"UPDATE Users 
                                 SET username = @username, 
                                     email = @email, 
                                     password = @password, 
                                     status = @status 
                                 WHERE user_id = (SELECT user_id FROM Admins WHERE admin_id = @admin_id)";


                SqlCommand adminCmd = new SqlCommand(updateQuery, con);
                adminCmd.Parameters.AddWithValue("@admin_id", adminId);
                adminCmd.Parameters.AddWithValue("@username", username);
                adminCmd.Parameters.AddWithValue("@email", email);
                adminCmd.Parameters.AddWithValue("@password", password);
                adminCmd.Parameters.AddWithValue("@status", status);

                int rowsAffected = adminCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                   /* string query1 = @"SELECT a.admin_id,u.username,u.email,u.password,u.Role,u.status,u.user_id FROM Admins a 
                                     INNER JOIN Users u ON a.user_id=u.user_id WHERE u.status='Active'";

                    SqlCommand cmd = new SqlCommand(query1, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    adminDGView.DataSource = dt;
                    adminDGView.Refresh();
                    adminDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    adminDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                   */
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
            string admin_id = adminIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(admin_id)|| !int.TryParse(admin_id, out int adminId))
            {
                MessageBox.Show("Please enter a valid Admin ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(con.State==ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string query = @"SELECT a.admin_id, u.username, u.email, u.password, u.Role, u.status, u.user_id FROM Admins a 
                           INNER JOIN Users u ON a.user_id = u.user_id WHERE a.admin_id = @admin_id AND u.status = 'Active'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@admin_id", admin_id);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Admin information found successfully.");
                        adminDGView.DataSource = dt;
                        adminDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        adminDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                    else
                    {
                        MessageBox.Show("No matching admin found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string aid = adminIDTBox.Text.Trim();
            if (string.IsNullOrEmpty(aid) || !int.TryParse(aid, out int admin_id))
            {
                MessageBox.Show("Please enter the valid Admin ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    string updateQuery = @"UPDATE Users SET status = 'Inactive' WHERE user_id = (SELECT user_id FROM Admins WHERE admin_id = @admin_id) AND status = 'Active'";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@admin_id", aid);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh the DataGridView to show active admins
                        
                    }
                    else
                    {
                        MessageBox.Show("No admin was deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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





        private void ClearFields()
        {
            adminIDTBox.Clear();
            adminNameTBox.Clear();
            adminEmailTBox.Clear();
            adminPasswordTBox.Clear();
            adminRPasswordTBox.Clear();
            adminStatusCBox.SelectedIndex = -1;
        }

        private bool IsValidEmail(string email)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void adminDGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = adminDGView.Rows[e.RowIndex];
                adminIDTBox.Text = row.Cells[0].Value.ToString();
                adminNameTBox.Text= row.Cells[1].Value.ToString();
                adminEmailTBox.Text= row.Cells[2].Value.ToString();
                adminPasswordTBox.Text = row.Cells[3].Value.ToString();
                adminRPasswordTBox.Text = row.Cells[3].Value.ToString();

                string status = row.Cells[5].Value?.ToString() ?? ""; 
                if (adminStatusCBox.Items.Contains(status))
                {
                    adminStatusCBox.SelectedItem = status;
                }
                else
                {
                    adminStatusCBox.SelectedIndex = -1; // Reset if the value is not in the ComboBox
                }
            }
        }
    }
}
