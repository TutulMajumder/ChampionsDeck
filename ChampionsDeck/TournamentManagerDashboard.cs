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
    public partial class TournamentManagerDashboard : Form
    {
        public int tournamentmanagerId;
        public TournamentManagerDashboard(int tournamentManagerId)
        {
            InitializeComponent();
            this.tournamentmanagerId = tournamentManagerId;
            //LoadTournaments();
            //InitializeTournamentsPanel();
            LoadTournaments();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");

        private void LoadTournaments()
        {
            try
            {
                con.Open();
                string query = "SELECT tournament_id, tournamentname, tournamenttype, proposalstatus,startdate, enddate, tournamentstatus, tournamentlogo FROM Tournaments WHERE proposalstatus='Approved'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
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
                                reader.GetSqlBytes(7).Buffer          // tournamentlogo
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
            // Create main panel to hold both button and details
            Panel mainPanel = new Panel
            {
                Width = 300,
                Height = 120,
                Margin = new Padding(20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            // Event handler for the entire panel click
            mainPanel.Click += (sender, e) =>
            {
                manageMatches manageMatches = new manageMatches(tournamentmanagerId, id);
                manageMatches.Show();
                this.Hide();
                MessageBox.Show($"Tournament {name} clicked! ID: {id}");
            };

            // Create button with tournament logo
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

            // Event handler for PictureBox (in case user clicks on it)
            logoBox.Click += (sender, e) =>
            {
                manageMatches manageMatches = new manageMatches(tournamentmanagerId,id);
                manageMatches.Show();
                this.Hide();
                MessageBox.Show($"Tournament {name} clicked! ID: {id}");
            };
            

            // Create details panel
            Panel detailsPanel = new Panel
            {
                Location = new Point(120, 10),
                Width = 180,
                Height = 180
            };
            detailsPanel.Click += (sender, e) =>
              {
                  manageMatches manageMatches = new manageMatches(tournamentmanagerId, id);
                  manageMatches.Show();
                  this.Hide();
                  MessageBox.Show($"Tournament {name} clicked! ID: {id}");
              };

            // Tournament details labels
            Label nameLabel = new Label
            {
                Text = $"{name}",
                Location = new Point(0, 10),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            Label typeLabel = new Label
            {
                Text = $"{type}",
                Location = new Point(0, 40),
                AutoSize = true
            };


            Label dateLabel = new Label
            {
                Text = $"Date: {startDate:dd MMM} - {endDate:dd MMM}",
                Location = new Point(0, 70),
                AutoSize = true
            };

            // Hover effect for better UI
            mainPanel.MouseEnter += (sender, e) => mainPanel.BackColor = Color.LightGray;
            mainPanel.MouseLeave += (sender, e) => mainPanel.BackColor = Color.White;

            // Add controls to panels
            detailsPanel.Controls.AddRange(new Control[] { nameLabel, typeLabel,dateLabel });
            mainPanel.Controls.AddRange(new Control[] { logoBox, detailsPanel });

            // Add to FlowLayoutPanel
            tournamentsFlowPanel.Controls.Add(mainPanel);
        }

        /*private void LoadTournaments()
        {
            try
            {
                con.Open();
                string query = @"SELECT tournament_id, tournamentname, tournamenttype, 
                         startdate, enddate, tournamentlogo FROM Tournaments 
                         WHERE tournamentmanager_id = @managerId AND proposalstatus='Approved'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@managerId", tournamentmanagerId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tournamentsFlowPanel.Controls.Clear();
                    int index = 0; // Track position for left/right placement

                    while (reader.Read())
                    {
                        var tournamentPanel = CreateTournamentPanel(
                            reader["tournamentlogo"] as byte[],
                            reader["tournamentname"].ToString(),
                            reader["tournamenttype"].ToString(),
                            Convert.ToDateTime(reader["startdate"]),
                            Convert.ToDateTime(reader["enddate"]),
                            reader["tournament_id"].ToString(),
                            index
                        );

                        tournamentsFlowPanel.Controls.Add(tournamentPanel);
                        index++; // Increase index for alternating positioning
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tournaments: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private Panel CreateTournamentPanel(byte[] logoBytes, string name, string type,
                                 DateTime startDate, DateTime endDate, string id, int index)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(300, 120);
            panel.BackColor = Color.White;
            panel.Cursor = Cursors.Hand;
            panel.Tag = id;
            panel.Margin = new Padding(20);
            // Calculate position (left or right)
            //int xPosition = (index % 2 == 0) ? 10 : 310;  // Alternating left (10px) and right (310px)
            //int yPosition = (index / 2) * 130; // Stack vertically with spacing

            //panel.Location = new Point(xPosition, yPosition);

            // Tournament Logo
            PictureBox logo = new PictureBox();
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Size = new Size(70, 70);
            logo.Location = new Point(20, 20);

            if (logoBytes != null && logoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(logoBytes))
                {
                    logo.Image = Image.FromStream(ms);
                }
            }

            // Tournament Details
            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(100, 20);
            nameLabel.AutoSize = true;

            Label detailsLabel = new Label();
            detailsLabel.Text = $"Type: {type}\nDates: {startDate:dd MMM yyyy} - {endDate:dd MMM yyyy}";
            detailsLabel.Location = new Point(100, 50);
            detailsLabel.AutoSize = true;

            // Clickable event
            panel.Click += Panel_Click;
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Click += Panel_Click;
            }

            panel.Controls.Add(logo);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(detailsLabel);

            return panel;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel ?? ((Control)sender).Parent as Panel;
            if (panel != null)
            {
                string tournamentId = panel.Tag.ToString();
                MessageBox.Show($"Showing details for tournament ID: {tournamentId}");
            }
        }
        /*private void InitializeTournamentsPanel()
        {
            tournamentsFlowPanel.Location = new Point(0, 95); // Set FlowPanel position after the violet panel
            tournamentsFlowPanel.Size = new Size(this.Width, this.Height - 95); // Adjust size dynamically
            tournamentsFlowPanel.Dock = DockStyle.None; // Remove full docking to allow manual positioning
            tournamentsFlowPanel.AutoScroll = true;
            tournamentsFlowPanel.WrapContents = true; // Ensures proper wrapping
            tournamentsFlowPanel.FlowDirection = FlowDirection.LeftToRight;
            this.Controls.Add(tournamentsFlowPanel);
        }*/
        /*private void LoadTournaments()
        {
            try
            {
                con.Open();
                string query = @"SELECT tournament_id, tournamentname, tournamenttype, 
                                startdate, enddate, tournamentlogo FROM Tournaments 
                                WHERE tournamentmanager_id = @managerId AND proposalstatus='Approved'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@managerId", tournamentmanagerId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tournamentsFlowPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        var tournamentPanel = CreateTournamentPanel(
                            reader["tournamentlogo"] as byte[],
                            reader["tournamentname"].ToString(),
                            reader["tournamenttype"].ToString(),
                            Convert.ToDateTime(reader["startdate"]),
                            Convert.ToDateTime(reader["enddate"]),
                            reader["tournament_id"].ToString()
                        );

                        tournamentsFlowPanel.Controls.Add(tournamentPanel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tournaments: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private Panel CreateTournamentPanel(byte[] logoBytes, string name, string type,
                         DateTime startDate, DateTime endDate, string id)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(600, 100);
            panel.Margin = new Padding(10);
            panel.BackColor = Color.White;
            panel.Cursor = Cursors.Hand;
            panel.Tag = id;  // Store tournament ID in tag

            // Tournament Logo
            PictureBox logo = new PictureBox();
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Size = new Size(80, 80);
            logo.Location = new Point(10, 10);

            if (logoBytes != null && logoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(logoBytes))
                {
                    logo.Image = Image.FromStream(ms);
                }
            }

            // Tournament Details
            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(100, 10);
            nameLabel.AutoSize = true;

            Label detailsLabel = new Label();
            detailsLabel.Text = $"Type: {type}\nDates: {startDate:dd MMM yyyy} - {endDate:dd MMM yyyy}";
            detailsLabel.Location = new Point(100, 35);
            detailsLabel.AutoSize = true;

            // Make the whole panel clickable
            panel.Click += Panel_Click;
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Click += Panel_Click; // Ensure all sub-controls trigger the event
            }

            panel.Controls.Add(logo);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(detailsLabel);

            return panel;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel ?? ((Control)sender).Parent as Panel;
            if (panel != null)
            {
                string tournamentId = panel.Tag.ToString();
                MessageBox.Show($"Showing details for tournament ID: {tournamentId}");
            }
        }*/

        /*private Panel CreateTournamentPanel(byte[] logoBytes, string name, string type,
                                 DateTime startDate, DateTime endDate, string id)
        {
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Size = new Size(600, 100);
            panel.Margin = new Padding(10);

            // Tournament Logo
            PictureBox logo = new PictureBox();
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Size = new Size(80, 80);
            logo.Location = new Point(10, 10);

            if (logoBytes != null && logoBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(logoBytes))
                {
                    logo.Image = Image.FromStream(ms);
                }
            }

            // Tournament Details
            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
            nameLabel.Location = new Point(100, 10);
            nameLabel.AutoSize = true;

            Label detailsLabel = new Label();
            detailsLabel.Text = $"ID: {id}\nType: {type}\nDates: {startDate:dd MMM yyyy} - {endDate:dd MMM yyyy}";
            detailsLabel.Location = new Point(100, 35);
            detailsLabel.AutoSize = true;

            // View Button
            Button viewButton = new Button();
            viewButton.Text = "View Details";
            viewButton.Size = new Size(100, 30);
            viewButton.Location = new Point(480, 35);
            viewButton.Tag = id;
            viewButton.Click += ViewButton_Click;

            panel.Controls.Add(logo);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(detailsLabel);
            panel.Controls.Add(viewButton);

            return panel;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tournamentId = btn.Tag.ToString();
            // Add your view details logic here
            MessageBox.Show($"Showing details for tournament ID: {tournamentId}");
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                LoadTournaments();
            }
        }*/
        private void addTournamentBtn_Click(object sender, EventArgs e)
        {
            addTournament addTournament = new addTournament(tournamentmanagerId);
            addTournament.Show();
            this.Hide();
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

        private void manageTBtn_Click(object sender, EventArgs e)
        {
            manageTeams manageTeams = new manageTeams(tournamentmanagerId);
            manageTeams.Show();
            this.Hide();
        }

        /*private void LoadTournaments()
        {
            try
            {
                con.Open();
                string query = @"SELECT tournament_id, tournamentname, tournamentstatus, tournamentlogo FROM Tournaments WHERE tournamentmanager_id = @tournamentmanager_id AND proposalstatus = 'Approved'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@tournamentmanager_id", tournamentmanagerId);

                SqlDataReader reader = cmd.ExecuteReader();
                flowLayoutPanel1.Controls.Clear(); // Clear previous buttons

                while (reader.Read())
                {
                    int tournamentId = reader.GetInt32(0);
                    string tournamentName = reader.GetString(1);
                    string tournamentStatus = reader.GetString(2);
                    byte[] logoBytes = (byte[])reader["tournamentlogo"];

                    Image tournamentImage = ByteArrayToImage(logoBytes);
                    CreateTournamentButton(tournamentId, tournamentName, tournamentStatus, tournamentImage);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tournaments: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CreateTournamentButton(int tournamentId, string tournamentName, string tournamentStatus, Image logo)
        {
            Button tournamentButton = new Button();
            tournamentButton.Text = tournamentName;
            tournamentButton.Width = 200;
            tournamentButton.Height = 100;
            tournamentButton.TextAlign = ContentAlignment.MiddleCenter;
            tournamentButton.Image = new Bitmap(logo, new Size(60, 60));
            tournamentButton.ImageAlign = ContentAlignment.MiddleLeft;
            tournamentButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            tournamentButton.Click += (sender, e) => OpenTournamentDetails(tournamentId);
            flowLayoutPanel1.Controls.Add(tournamentButton);
        }
        private Image ByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void OpenTournamentDetails(int tournamentId)
        {
            MessageBox.Show($"Tournament ID: {tournamentId}", "Tournament Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // You can open a tournament details form here
        }*/

    }
}
