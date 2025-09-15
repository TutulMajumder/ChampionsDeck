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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            LoadTournaments("All");
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");

        private void LoadTournaments(string filter)
        {
            try
            {
                con.Open();
                string query = "SELECT tournament_id, tournamentname, tournamenttype, proposalstatus, startdate, enddate, tournamentstatus, tournamentlogo FROM Tournaments WHERE proposalstatus='Approved'";

                // Apply filtering condition
                if (filter != "All")
                {
                    query += " AND tournamentstatus = @status";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (filter != "All")
                    {
                        cmd.Parameters.AddWithValue("@status", filter);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Clear existing tournaments before adding new ones
                        flowLayoutPanel1.Controls.Clear();

                        while (reader.Read())
                        {
                            CreateTournamentButton(
                                reader.GetInt32(0),                    // tournament_id
                                reader.GetString(1),                   // tournamentname
                                reader.GetString(2),                   // tournamenttype
                                reader.GetString(3),                   // proposalstatus
                                reader.GetDateTime(4),                 // startdate
                                reader.GetDateTime(5),                 // enddate
                                reader.GetString(6),                   // tournamentstatus
                                reader.GetSqlBytes(7).Buffer           // tournamentlogo
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tournaments: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
                }
        private void CreateTournamentButton(int id, string name, string type,
     string proposalStatus, DateTime startDate, DateTime endDate,
     string status, byte[] logoBytes)
        {
            Panel mainPanel = new Panel
            {
                Width = 300,
                Height = 130,
                Margin = new Padding(20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };

            // Tooltip for hover info
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(mainPanel, $"Tournament: {name}\nType: {type}\nStatus: {status}\nProposal: {proposalStatus}");

            mainPanel.Click += (sender, e) =>
            {
                MessageBox.Show($"Tournament {name} clicked! ID: {id}");
            };

            PictureBox logoBox = new PictureBox
            {
                Width = 100,
                Height = 80,
                Location = new Point(10, 20),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (logoBytes != null && logoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(logoBytes))
                {
                    logoBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Optional: Set a default image if logoBytes is null
                // logoBox.Image = Properties.Resources.default_logo;
            }

            logoBox.Click += (sender, e) =>
            {
                MessageBox.Show($"Tournament {name} clicked! ID: {id}");
            };

            Panel detailsPanel = new Panel
            {
                Location = new Point(120, 10),
                Width = 170,
                Height = 110
            };
            detailsPanel.Click += (sender, e) =>
            {
                MessageBox.Show($"Tournament {name} clicked! ID: {id}");
            };

            Label nameLabel = new Label
            {
                Text = $"{name}",
                Location = new Point(0, 5),
                AutoSize = true,
                Font = new Font("Arial", 11, FontStyle.Bold)
            };

            Label typeLabel = new Label
            {
                Text = $"Type: {type}",
                Location = new Point(0, 30),
                AutoSize = true
            };

            Label dateLabel = new Label
            {
                Text = $"Date: {startDate:dd MMM} - {endDate:dd MMM}",
                Location = new Point(0, 55),
                AutoSize = true
            };

            Label statusLabel = new Label
            {
                Text = status,
                Location = new Point(0, 80),
                AutoSize = true,
                Font = new Font("Arial", 9, FontStyle.Italic),
                ForeColor = status == "Ongoing" ? Color.Green :
                            status == "Upcoming" ? Color.Blue :
                            Color.Red
            };

            mainPanel.MouseEnter += (sender, e) => mainPanel.BackColor = Color.LightGray;
            mainPanel.MouseLeave += (sender, e) => mainPanel.BackColor = Color.White;

            detailsPanel.Controls.AddRange(new Control[] { nameLabel, typeLabel, dateLabel, statusLabel });
            mainPanel.Controls.AddRange(new Control[] { logoBox, detailsPanel });

            flowLayoutPanel1.Controls.Add(mainPanel);
        }


        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure.You want to log out?", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
        private void LoadData()
        {
            string status=comboBox2.SelectedItem?.ToString() ?? "";
            string query = "SELECT tournamentstatus WHERE tournamentstatus=@tournamentstatus";

            SqlCommand checkCmd = new SqlCommand(query, con);
            checkCmd.Parameters.AddWithValue("@tournamentstatus", status);

        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox2.SelectedItem.ToString();
            LoadTournaments(selectedFilter);
        }
    }

}
