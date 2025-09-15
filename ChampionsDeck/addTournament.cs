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
    public partial class addTournament : Form
    {
        public int tournamentmanagerId;
        public addTournament(int tournamentmanagerId)
        {
            InitializeComponent();
            this.tournamentmanagerId = tournamentmanagerId;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string tournamentId = tournamentIDTBox.Text.Trim();
            string tournamentname = tournamentNameTBox.Text;
            string type = tTypeCBox.SelectedItem?.ToString() ?? "";
            string proposalstatus = comboBox2.SelectedItem?.ToString() ?? "";
            DateTime startdate=dateTimePicker1.Value;
            DateTime enddate = dateTimePicker2.Value;




            if (string.IsNullOrEmpty(tournamentId) ||
                string.IsNullOrEmpty(tournamentname) ||
                string.IsNullOrEmpty(type) ||
                string.IsNullOrEmpty(proposalstatus)) 
            {
                MessageBox.Show("Please fill in all the required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image for the tournament.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tournamentId, out int tournamentid))
            {
                MessageBox.Show("Valid Tournament ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (enddate < startdate)
            {
                MessageBox.Show("End date must be after start date", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tournamentstatus;
            if (startdate > DateTime.Now)
            {
                tournamentstatus = "Upcoming";
            }
            else if (startdate <= DateTime.Now && enddate >= DateTime.Now)
            {
                tournamentstatus = "Ongoing";
            }
            else
            {
                tournamentstatus = "Completed";
            }
            try
            {
                con.Open();


                // First verify that the GameManager exists

                string checktmQuery = @"SELECT COUNT(*) FROM Tournaments WHERE tournament_id = @tournament_id";
                SqlCommand checkCmd = new SqlCommand(checktmQuery, con);
                checkCmd.Parameters.AddWithValue("@tournament_id", tournamentId);
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Tournament ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] imageBytes = ImageToByteArray(pictureBox1.Image);

                // Insert into Users table
                string query = "INSERT INTO Tournaments (tournament_id,tournamentname,tournamenttype,proposalstatus,startdate,enddate,tournamentstatus,tournamentlogo,tournamentmanager_id) VALUES (@tournament_id,@tournamentname,@tournamenttype,@proposalstatus,@startdate,@enddate,@tournamentstatus,@tournamentlogo,@tournamentmanager_id)";
                SqlCommand gameCmd = new SqlCommand(query, con);

                gameCmd.Parameters.AddWithValue("@tournament_id", tournamentId);
                gameCmd.Parameters.AddWithValue("@tournamentname", tournamentname);
                gameCmd.Parameters.AddWithValue("@tournamenttype", type);
                gameCmd.Parameters.AddWithValue("@proposalstatus", proposalstatus);
                gameCmd.Parameters.AddWithValue("@startdate", startdate);
                gameCmd.Parameters.AddWithValue("@enddate", enddate);
                gameCmd.Parameters.AddWithValue("@tournamentstatus", tournamentstatus);
                gameCmd.Parameters.AddWithValue("@tournamentlogo", imageBytes);
                gameCmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                gameCmd.ExecuteNonQuery();
                MessageBox.Show("Tournament added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearFields();
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
            tournamentNameTBox.Clear();
         
            tTypeCBox.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            // Reset both DateTimePickers
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;  // Reset End Date

            // Clear Image
            pictureBox1.Image = null;
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Convert to JPEG format
                return ms.ToArray(); // Return byte array
            }
        }


        private void addImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
