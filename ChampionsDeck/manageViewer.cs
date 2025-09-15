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
    public partial class manageViewer : UserControl
    {
        public manageViewer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");

        private void LoadData()
        {
            string query = @"SELECT v.viewer_id,u.username,u.email,u.password,u.Role,v.preferredgames,v.country,u.status,u.user_id FROM Viewers v
                    INNER JOIN Users u ON v.user_id = u.user_id WHERE u.status = 'Active'";


            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            viewerDGView.DataSource = dt;
            viewerDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewerDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string vid = vIdTbox.Text.Trim(); // Get the input from the TextBox

            if (string.IsNullOrEmpty(vid) || !int.TryParse(vid, out int user_id))
            {
                MessageBox.Show("Please enter the Viewer ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();

                        // Updated query to search by either viewer_id or email
                        string query = @"SELECT v.viewer_id, u.username, u.email, u.password, u.Role,v.preferredgames, v.country,u.status, u.user_id FROM Viewers v
                        INNER JOIN Users u ON v.user_id = u.user_id WHERE v.viewer_id = @viewer_id AND u.status = 'Active'";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@viewer_id", vid); 

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Viewer information found successfully.");
                            viewerDGView.DataSource = dt;
                            viewerDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            viewerDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given details.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Closed)
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

        private void dltBtn_Click(object sender, EventArgs e)
        {
            string vid = vIdTbox.Text.Trim();
            if (string.IsNullOrEmpty(vid)|| !int.TryParse(vid, out int user_id))
            {
                MessageBox.Show("Please enter the Viewer ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    string query = @"UPDATE Users SET status = 'Inactive' WHERE user_id = (SELECT user_id FROM Viewers WHERE viewer_id = @viewer_id) AND status = 'Active'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@viewer_id", vid);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Viewer successfully deleted");

                        // Fetch and display only Active viewers in the DataGridView
                        LoadData();


                    }
                    else
                    {
                        MessageBox.Show("No Active viewer found with the provided email ID.");
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



        private void viewerDGView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = viewerDGView.Rows[e.RowIndex];
                vIdTbox.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
