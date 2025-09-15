using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class manageTeams : Form
    {
        private int tournamentmanagerId;
        public manageTeams(int tournamentManagerId)
        {
            InitializeComponent();
            this.tournamentmanagerId = tournamentManagerId;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");
        private void LoadTeams() 
        {

            string query = @"SELECT team_id,teamname,teamlogo,tournamentmanager_id FROM Teams ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            // Convert binary image data to Bitmap and add a new column
            DataTable dtWithImages = dt.Clone(); // Clone structure
            dtWithImages.Columns.Add("TeamLogo", typeof(Bitmap)); // New column for actual images

            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = dtWithImages.NewRow();
                newRow.ItemArray = row.ItemArray; // Copy existing data

                if (row["teamlogo"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["teamlogo"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        newRow["TeamLogo"] = new Bitmap(ms);
                    }
                }

                dtWithImages.Rows.Add(newRow);
            }

            // Remove the binary image column and use the new Image column
            dtWithImages.Columns.Remove("teamlogo");

            // Bind data to DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dtWithImages;
            dataGridView1.Refresh();

            // Ensure rows are not hidden
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }

            // Adjust column sizes for better UI
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Ensure Image column displays correctly
            if (dataGridView1.Columns.Contains("TeamLogo"))
            {
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView1.Columns["TeamLogo"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ensures full image fits
                imgColumn.Width = 100; // Adjust width if needed
            }


        }

        private void ilogoBtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    logoPBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    LoadTeams();
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
            string teamId = teamIDTBox.Text.Trim();
            string teamname = teamNameTBox.Text;

            if (string.IsNullOrEmpty(teamId) ||
                string.IsNullOrEmpty(teamname))
            {
                MessageBox.Show("Please fill in all the required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (logoPBox.Image == null)
            {
                MessageBox.Show("Please select an image for the tournament.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(teamId, out int TeamId))
            {
                MessageBox.Show("Valid Team ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();




                byte[] imageBytes = ImageToByteArray(logoPBox.Image);


                string query = "INSERT INTO Teams (team_id,teamname,teamlogo,tournamentmanager_id) VALUES (@team_id,@teamname,@teamlogo,@tournamentmanager_id)";
                SqlCommand gameCmd = new SqlCommand(query, con);

                gameCmd.Parameters.AddWithValue("@team_id", teamId);
                gameCmd.Parameters.AddWithValue("@teamname", teamname);
                gameCmd.Parameters.AddWithValue("@teamlogo", imageBytes);
                gameCmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                gameCmd.ExecuteNonQuery();
                MessageBox.Show("Team added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTeams();

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

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray(); 
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            TournamentManagerDashboard managerDashboard = new TournamentManagerDashboard(tournamentmanagerId);
            managerDashboard.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string teamid = teamIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(teamid) || !int.TryParse(teamid, out int teamId))
            {
                MessageBox.Show("Please enter a valid Team ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string query = @"SELECT team_id,teamname,teamlogo,tournamentmanager_id FROM Teams WHERE team_id = @team_id ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@team_id", teamid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Team information found successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dt.Columns.Add("TeamLogo", typeof(Bitmap));
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["teamlogo"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])row["teamlogo"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    row["TeamLogo"] = new Bitmap(ms);
                                }
                            }
                        }
                        dt.Columns.Remove("teamlogo");

                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        if (dataGridView1.Columns.Contains("TeamLogo"))
                        {
                            DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView1.Columns["TeamLogo"];
                            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            imgColumn.Width = 100;
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("No matching Team found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string teamIdText = teamIDTBox.Text.Trim();
            string teamname = teamNameTBox.Text.Trim();

            if (string.IsNullOrEmpty(teamIdText) || string.IsNullOrEmpty(teamname))
            {
                MessageBox.Show("Please fill in all the required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(teamIdText, out int teamId))
            {
                MessageBox.Show("Valid Team ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM Teams WHERE team_id = @team_id AND tournamentmanager_id = @tournamentmanager_id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@team_id", teamId);
                checkCmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("No matching team found or you don't have permission to update this team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] imageBytes = null;

                if (logoPBox.Image != null) 
                {
                    imageBytes = ImageToByteArray(logoPBox.Image);
                }


                string updateQuery = @"UPDATE Teams SET teamname = @teamname,teamlogo =@teamlogo
            WHERE team_id = @team_id AND tournamentmanager_id = @tournamentmanager_id";

                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.Parameters.AddWithValue("@team_id", teamId);
                updateCmd.Parameters.AddWithValue("@teamname", teamname);
                updateCmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);
                updateCmd.Parameters.AddWithValue("@teamlogo", (object)imageBytes ?? DBNull.Value); 

                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Team updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeams();
                }
                else
                {
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string teamIdText = teamIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(teamIdText) || !int.TryParse(teamIdText, out int teamId))
            {
                MessageBox.Show("Please enter a valid Team ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();


                string checkQuery = "SELECT COUNT(*) FROM Teams WHERE team_id = @team_id AND tournamentmanager_id = @tournamentmanager_id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@team_id", teamId);
                checkCmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("No matching team found or you don't have permission to delete this team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this team?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                {
                    return;
                }


                string deleteQuery = "DELETE FROM Teams WHERE team_id = @team_id AND tournamentmanager_id = @tournamentmanager_id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                deleteCmd.Parameters.AddWithValue("@team_id", teamId);
                deleteCmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Team deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeams();
                }
                else
                {
                    MessageBox.Show("Deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                teamIDTBox.Text = row.Cells[0].Value?.ToString(); 
                teamNameTBox.Text = row.Cells[1].Value?.ToString(); 

               
                if (row.Cells["TeamLogo"].Value != null && row.Cells["TeamLogo"].Value is Bitmap)
                {
                    logoPBox.Image = (Bitmap)row.Cells["TeamLogo"].Value;
                }
                else
                {
                    logoPBox.Image = null; 
                }
            }
        }
    }
}
