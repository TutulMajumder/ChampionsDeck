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
    public partial class manageTournament : UserControl
    {
        public manageTournament()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");
        private void LoadTournaments()
        {

            string query = @"SELECT tournament_id, tournamentname, tournamenttype, 
                                proposalstatus, startdate, enddate, 
                                tournamentlogo, tournamentmanager_id, tournamentstatus 
                         FROM Tournaments ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Debugging: Print fetched rows in the console
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"ID: {row["tournament_id"]}, Name: {row["tournamentname"]}, Status: {row["proposalstatus"]}");
            }

            // Convert binary image data to Bitmap and add a new column
            DataTable dtWithImages = dt.Clone(); // Clone structure
            dtWithImages.Columns.Add("Banner", typeof(Bitmap)); // New column for actual images

            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = dtWithImages.NewRow();
                newRow.ItemArray = row.ItemArray; // Copy existing data

                if (row["tournamentlogo"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["tournamentlogo"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        newRow["Banner"] = new Bitmap(ms);
                    }
                }

                dtWithImages.Rows.Add(newRow);
            }

            // Remove the binary image column and use the new Image column
            dtWithImages.Columns.Remove("tournamentlogo");

            // Bind data to DataGridView
            tournamentDGView.DataSource = null;
            tournamentDGView.Rows.Clear();
            tournamentDGView.Columns.Clear();
            tournamentDGView.DataSource = dtWithImages;
            tournamentDGView.Refresh();

            // Ensure rows are not hidden
            foreach (DataGridViewRow row in tournamentDGView.Rows)
            {
                row.Visible = true;
            }

            // Adjust column sizes for better UI
            tournamentDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Ensure Image column displays correctly
            if (tournamentDGView.Columns.Contains("Banner"))
            {
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)tournamentDGView.Columns["Banner"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ensures full image fits
                imgColumn.Width = 100; // Adjust width if needed
            }


        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    LoadTournaments();
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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string tournamentId = tournamentIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(tournamentId) || !int.TryParse(tournamentId, out int TournamentsId))
            {
                MessageBox.Show("Please enter a valid Tournament ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();


                string query = @"SELECT tournament_id, tournamentname, tournamenttype, 
                                proposalstatus, startdate, enddate, 
                                tournamentlogo, tournamentmanager_id, tournamentstatus 
                         FROM Tournaments
                         WHERE tournament_id = @tournament_id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@tournament_id", TournamentsId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tournament information found successfully.");


                    DataTable dtWithImages = dt.Clone();
                    dtWithImages.Columns.Add("Banner", typeof(Bitmap));

                    foreach (DataRow row in dt.Rows)
                    {
                        DataRow newRow = dtWithImages.NewRow();
                        newRow.ItemArray = row.ItemArray;

                        if (row["tournamentlogo"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])row["tournamentlogo"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                newRow["Banner"] = new Bitmap(ms);
                            }
                        }

                        dtWithImages.Rows.Add(newRow);
                    }


                    dtWithImages.Columns.Remove("tournamentlogo");


                    tournamentDGView.DataSource = dtWithImages;
                    tournamentDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    tournamentDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                    if (tournamentDGView.Columns.Contains("Banner"))
                    {
                        DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)tournamentDGView.Columns["Banner"];
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; 
                        imgColumn.Width = 100; 
                    }
                }
                else
                {
                    MessageBox.Show("No matching Tournament found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tournamentDGView.DataSource = null; 
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

        private void ApprovedBtn_Click(object sender, EventArgs e)
        {
            string tournamentId = tournamentIDTBox.Text.Trim();
            string proposalstatus = comboBox2.SelectedItem?.ToString() ?? "";

            // Validate all required fields
            if (string.IsNullOrEmpty(tournamentId) ||
                string.IsNullOrEmpty(proposalstatus))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tournamentId, out int TournamentId))
            {
                MessageBox.Show("Valid Tournament ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                con.Open();


                string checkQuery = @"SELECT COUNT(*) FROM Tournaments WHERE tournament_id = @tournament_id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@tournament_id", tournamentId);
                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Tournament ID not  exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Insert into Users table
                string updateQuery = @"UPDATE Tournaments 
                                 SET proposalstatus = @proposalstatus
                                 WHERE tournament_id = @tournament_id";


                SqlCommand Cmd = new SqlCommand(updateQuery, con);
                Cmd.Parameters.AddWithValue("@tournament_id", tournamentId);
                Cmd.Parameters.AddWithValue("@proposalstatus", proposalstatus);

                int rowsAffected = Cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tournaments Approved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTournaments();
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


        private void ClearFields()
        {
            tournamentIDTBox.Clear();
            comboBox2.SelectedIndex = -1;
        }

        private void tournamentDGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = tournamentDGView.Rows[e.RowIndex];
                tournamentIDTBox.Text = row.Cells[0].Value.ToString();
                string proposalstatus = row.Cells[3].Value?.ToString() ?? "";
                if (comboBox2.Items.Contains(proposalstatus))
                {
                    comboBox2.SelectedItem = proposalstatus;
                }
                else
                {
                    comboBox2.SelectedIndex = -1; // Reset if the value is not in the ComboBox
                }
            }
        }
    }
}
