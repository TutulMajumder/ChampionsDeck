using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class manageMatches : Form
    {
        private int tournamentId;
        private int tournamentmanagerId;
        public manageMatches(int tournamentmanagerId,int tournamentId)
        {
            InitializeComponent();
            this.tournamentmanagerId = tournamentmanagerId;
            this.tournamentId = tournamentId;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");
        private void LoadTeams()
        {

            string query = @"SELECT team_id, teamname, teamlogo,tournamentmanager_id FROM Teams";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tournamentmanagerId", tournamentmanagerId);
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
        private void createMatch_Click(object sender, EventArgs e)
        {
            string teamAname = TB1.Text;
            string teamBname = TB2.Text;


            int matchId = Convert.ToInt32(matchIDTBox.Text);
            int matchRound = Convert.ToInt32(matchroundTBox.Text);
            DateTime matchDate = dateTimePicker1.Value;
            int teamAId = GetTeamIdByName(teamAname);
            int teamBId = GetTeamIdByName(teamBname);
            if (teamAId <= 0 || teamBId <= 0)
            {
                MessageBox.Show("One or both teams are invalid. Please select valid teams from the list.", "Invalid Teams", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Team A ID: {teamAId}, Team B ID: {teamBId}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (string.IsNullOrWhiteSpace(TB1.Text) || string.IsNullOrWhiteSpace(TB2.Text))
            {
                MessageBox.Show("Please select two teams before creating a match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TB1.Text.Trim().Equals(TB2.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("A team cannot play against itself. Please select two different teams.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric fields
            if (!int.TryParse(matchIDTBox.Text, out int MatchId) || matchId <= 0)
            {
                MessageBox.Show("Please enter a valid match ID number.", "Invalid Match ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(matchroundTBox.Text, out int MatchRound) || matchRound <= 0)
            {
                MessageBox.Show("Please enter a valid match round number.", "Invalid Match Round", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }






            int? teamAScore = null; 
            int? teamBScore = null; 
            int winningTeamId = 0;  

            // Insert Query
            string query = @"
        INSERT INTO Matches (match_id, tournament_id, matchround, matchdate, teamA_id, teamB_id, teamA_score, teamB_score, winningteam_id, tournamentmanager_id) 
        VALUES (@match_id, @tournament_id, @matchround, @matchdate, @teamA_id, @teamB_id, @teamA_score, @teamB_score, @winningteam_id, @tournamentmanager_id)";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@match_id", matchId);
                cmd.Parameters.AddWithValue("@tournament_id", tournamentId);
                cmd.Parameters.AddWithValue("@matchround", matchRound);
                cmd.Parameters.AddWithValue("@matchdate", matchDate);
                cmd.Parameters.AddWithValue("@teamA_id", teamAId);
                cmd.Parameters.AddWithValue("@teamB_id", teamBId);
                cmd.Parameters.AddWithValue("@teamA_score", (object)teamAScore ?? DBNull.Value); // Allow NULL
                cmd.Parameters.AddWithValue("@teamB_score", (object)teamBScore ?? DBNull.Value); // Allow NULL
                cmd.Parameters.AddWithValue("@winningteam_id", winningTeamId);
                cmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                // Execute Query
                cmd.ExecuteNonQuery();

                MessageBox.Show("Match Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void addScore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(matchIDTBox.Text) || string.IsNullOrEmpty(TeamAscore.Text) || string.IsNullOrEmpty(TeamBscore.Text))
            {
                MessageBox.Show("Please enter the match ID and both scores.");
                return;
            }

            int matchId = Convert.ToInt32(matchIDTBox.Text);
            int teamAScore = Convert.ToInt32(TeamAscore.Text);
            int teamBScore = Convert.ToInt32(TeamBscore.Text);

            int teamAId = GetTeamIdByName(TB1.Text);
            int teamBId = GetTeamIdByName(TB2.Text);
            int winningTeamId = (teamAScore > teamBScore) ? teamAId :
                                (teamBScore > teamAScore) ? teamBId : 0; // 0 means draw

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True"))
            {
                conn.Open();
                string query = "UPDATE matches SET teamA_score = @teamAScore, teamB_score = @teamBScore, " +
                               "winningteam_id = @winningTeamId WHERE match_id = @matchId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@teamAScore", teamAScore);
                cmd.Parameters.AddWithValue("@teamBScore", teamBScore);
                cmd.Parameters.AddWithValue("@winningTeamId", winningTeamId);
                cmd.Parameters.AddWithValue("@matchId", matchId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Scores Updated Successfully!");
            }




            
        }

        private void ManageTeam_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private int GetTeamIdByName(string teamName)
        {
            int teamId = -1;
            string query = "SELECT team_id FROM Teams WHERE teamname = @teamname AND tournamentmanager_id = @tournamentmanagerId";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@teamname", teamName);
                cmd.Parameters.AddWithValue("@tournamentmanagerId", tournamentmanagerId);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    teamId = Convert.ToInt32(result);
                }
            }
            return teamId;
        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Extract Team Data
                string teamName = selectedRow.Cells["teamname"].Value.ToString();
                Bitmap teamLogo = selectedRow.Cells["TeamLogo"].Value as Bitmap;

                // Assign the first selected team
                if (string.IsNullOrWhiteSpace(TB1.Text)) // Check if Team 1 is empty
                {
                    TB1.Text = teamName;
                    pictureBox1.Image = teamLogo;
                }
                else if (string.IsNullOrWhiteSpace(TB2.Text)) // Assign second team
                {
                    TB2.Text = teamName;
                    pictureBox2.Image = teamLogo;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TournamentManagerDashboard tournamentManagerDashboard = new TournamentManagerDashboard(tournamentmanagerId);
            tournamentManagerDashboard.Show();
            this.Hide();

        }
    }
}
