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
    public partial class GameManagerDashboard : Form
    {

        public int gameManagerId;

        public GameManagerDashboard(int gamemanagerId)
        {
            InitializeComponent();
            this.gameManagerId = gamemanagerId;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-637K472;Initial Catalog=ChampionsDeck;Integrated Security=True");


        private void LoadGames()
        {
            string query = @"SELECT game_id,gamename,gameplatform,gameGenre,gameStatus,game_logo,gamemanager_id FROM Games WHERE gamemanager_id = @gamemanager_id AND gameStatus='Active'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@gamemanager_id", gameManagerId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    LoadGames();
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex,"Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            string game_id = gameIDTBox.Text.Trim();
            string gamename = gameNameTBox.Text;
            string status = statusCBox.SelectedItem?.ToString() ?? "";
            string genre = genreCBox.SelectedItem?.ToString() ?? "";
            string Platform = platformCBox.SelectedItem?.ToString() ?? "";
            string logoPath= logoPBox.ImageLocation;

            // Validate all required fields
            if (string.IsNullOrEmpty(game_id) ||
                string.IsNullOrEmpty(gamename) ||
                string.IsNullOrEmpty(genre) ||
                string.IsNullOrEmpty(Platform) ||
                string.IsNullOrEmpty(status)||
                string.IsNullOrEmpty(logoPath))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(game_id, out int gameId))
            {
                MessageBox.Show("Valid Game ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                con.Open();


                // First verify that the GameManager exists
                string checkManagerQuery = "SELECT COUNT(*) FROM GameManagers WHERE gamemanager_id = @gamemanager_id";
                using (SqlCommand Cmdcheck = new SqlCommand(checkManagerQuery, con))
                {
                    Cmdcheck.Parameters.AddWithValue("@gamemanager_id", gameManagerId);
                    int managerExists = (int)Cmdcheck.ExecuteScalar();
                    if (managerExists == 0)
                    {
                        MessageBox.Show("Invalid Game Manager ID. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string checkgamesQuery = @"SELECT COUNT(*) FROM Games WHERE game_id = @game_id";
                SqlCommand checkCmd = new SqlCommand(checkgamesQuery, con);
                checkCmd.Parameters.AddWithValue("@game_id", game_id);
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Game ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                string path = Path.Combine(@"E:\AIUB\LAB\S 6\OOP2\ETMS\ChampionsDeck\ChampionsDeck\GameLogo\"
                              +gameId+".jpg");
                string directoryPath = Path.GetDirectoryName(path);
                if(!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }


                File.Copy(logoPBox.ImageLocation, path, true);

                // Insert into Users table
                string query = "INSERT INTO Games (game_id,gamename,gameplatform,gameGenre,game_logo,gameStatus,gamemanager_id) VALUES (@game_id, @gamename, @gameplatform, @gameGenre, @gamelogo,@gameStatus, @gamemanager_id)";
                SqlCommand gameCmd = new SqlCommand(query, con);

                gameCmd.Parameters.AddWithValue("@game_id", game_id);
                gameCmd.Parameters.AddWithValue("@gamename", gamename);
                gameCmd.Parameters.AddWithValue("@gameplatform", Platform);
                gameCmd.Parameters.AddWithValue("@gameGenre", genre);
                gameCmd.Parameters.AddWithValue("@gameStatus", status);
                gameCmd.Parameters.AddWithValue("@gamelogo", path);
                gameCmd.Parameters.AddWithValue("@gamemanager_id", gameManagerId);

                gameCmd.ExecuteNonQuery();
                MessageBox.Show("GameManager added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadGames();
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
            gameIDTBox.Clear();
            gameNameTBox.Clear();
            statusCBox.SelectedIndex = -1;
            genreCBox.SelectedIndex = -1;
            platformCBox.SelectedIndex = -1;
            logoPBox.Image = null;
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string game_id = gameIDTBox.Text.Trim();
            string gamename = gameNameTBox.Text;
            string status = statusCBox.SelectedItem?.ToString() ?? "";
            string genre = genreCBox.SelectedItem?.ToString() ?? "";
            string Platform = platformCBox.SelectedItem?.ToString() ?? "";
            string logoPath = logoPBox.ImageLocation;

            // Validate all required fields
            if (string.IsNullOrEmpty(game_id) ||
                string.IsNullOrEmpty(gamename) ||
                string.IsNullOrEmpty(genre) ||
                string.IsNullOrEmpty(Platform) ||
                string.IsNullOrEmpty(status))
            {
                MessageBox.Show("All fields are required. Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(game_id, out int gameId))
            {
                MessageBox.Show("Valid Game ID is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                con.Open();


                string checkgamesQuery = @"SELECT COUNT(*) FROM Games WHERE game_id = @game_id";
                SqlCommand checkCmd = new SqlCommand(checkgamesQuery, con);
                checkCmd.Parameters.AddWithValue("@game_id", game_id);
                if ((int)checkCmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Game ID not  exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // Retrieve the existing logo path from the database
                string currentLogoPath = "";
                string getLogoQuery = "SELECT game_logo FROM Games WHERE game_id = @game_id";
                SqlCommand getLogoCmd = new SqlCommand(getLogoQuery, con);
                getLogoCmd.Parameters.AddWithValue("@game_id", gameId);
                object result = getLogoCmd.ExecuteScalar();
                if (result != null)
                {
                    currentLogoPath = result.ToString();
                }


                // Define new logo path
                string newLogoPath = Path.Combine(@"E:\AIUB\LAB\S 6\OOP2\ETMS\ChampionsDeck\ChampionsDeck\GameLogo\"+ gameId + ".jpg");

                // Only copy new file if the user selected a new image
                if (!string.IsNullOrEmpty(logoPath))
                {
                    string directoryPath = Path.GetDirectoryName(newLogoPath);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    File.Copy(logoPath, newLogoPath, true);
                }
                else
                {
                    // If no new image selected, keep the existing image path
                    newLogoPath = currentLogoPath;
                }

                // Insert into Users table
                string updateQuery = @"UPDATE Games 
                                 SET gamename = @gamename, 
                                     gameplatform = @gameplatform, 
                                     gameGenre = @gameGenre, 
                                     gameStatus = @gameStatus,
                                     game_logo=@gamelogo
                                 WHERE game_id = @game_id";


                SqlCommand Cmd = new SqlCommand(updateQuery, con);
                Cmd.Parameters.AddWithValue("@game_id", gameId);
                Cmd.Parameters.AddWithValue("@gamename", gamename);
                Cmd.Parameters.AddWithValue("@gameplatform", Platform);
                Cmd.Parameters.AddWithValue("@gameGenre", genre);
                Cmd.Parameters.AddWithValue("@gameStatus", status);
                Cmd.Parameters.AddWithValue("@gamelogo", newLogoPath);

                int rowsAffected = Cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Games updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGames();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                gameIDTBox.Text = row.Cells[0].Value.ToString();
                gameNameTBox.Text = row.Cells[1].Value.ToString();

                string platform = row.Cells[2].Value?.ToString() ?? "";
                string genre = row.Cells[3].Value?.ToString() ?? "";
                string status = row.Cells[4].Value?.ToString() ?? "";
                string imagePath = row.Cells[5].Value.ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        // Prevent locking by using a MemoryStream
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            logoPBox.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logoPBox.Image = null;
                    }
                }
                else
                {
                    logoPBox.Image = null;
                }

                if (platformCBox.Items.Contains(platform))
                    platformCBox.SelectedItem = platform;
                else
                    platformCBox.SelectedIndex = -1;

                if (genreCBox.Items.Contains(genre))
                    genreCBox.SelectedItem = genre;
                else
                    genreCBox.SelectedIndex = -1;

                if (statusCBox.Items.Contains(status))
                    statusCBox.SelectedItem = status;
                else
                    statusCBox.SelectedIndex = -1;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string game_id = gameIDTBox.Text.Trim();
            if (string.IsNullOrEmpty(game_id) || !int.TryParse(game_id, out int gameId))
            {
                MessageBox.Show("Please enter the valid Game ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Game?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    // Update the user's status to Inactive
                    string updateQuery = @"UPDATE Games SET gameStatus = 'Inactive' WHERE game_id =@game_id AND gameStatus = 'Active'";
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@game_id", gameId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("TournamentManager deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGames();
                        ClearFields();
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
            string gameId= gameIDTBox.Text.Trim();

            if (string.IsNullOrEmpty(gameId) || !int.TryParse(gameId, out int gameID))
            {
                MessageBox.Show("Please enter a valid Game ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string query = @"SELECT game_id,gamename,gameplatform,gameGenre,gameStatus,game_logo,gamemanager_id FROM Games 
                    WHERE game_id = @game_id AND gameStatus = 'Active'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@game_id", gameId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Game information found successfully.");
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        ClearFields();

                    }
                    else
                    {
                        MessageBox.Show("No matching Game found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
