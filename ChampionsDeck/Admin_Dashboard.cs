using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsDeck
{
    public partial class Admin_Dashboard : Form
    {
        public int AdminId { get; set; }

        public Admin_Dashboard(int adminId)
        {
            
            InitializeComponent();
            this.AdminId = adminId;
            spnl.Height = sbBtn1.Height;

            manage_manager1.AdminId = adminId;
            manageTournamentmanager1.AdminId = adminId;

        }

        private void sbBtn1_Click(object sender, EventArgs e)
        {
            spnl.Height = sbBtn1.Height;
            spnl.Visible = true;
            spnl2.Visible = false;
            spnl3.Visible = false;
            spnl4.Visible = false;
            spnl5.Visible = false;

            manageViewer1.Visible = true;
            manage_manager1.Visible = false;
            manageAdmin1.Visible = false;
            manageTournamentmanager1.Visible = false;
            manageTournament1.Visible = false;

        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            spnl.Visible = true;
            spnl2.Visible = false;
            spnl3.Visible = false;
            spnl4.Visible = false;
            spnl5.Visible = false;
        }

        private void sbBtn2_Click(object sender, EventArgs e)
        {
            spnl.Height = sbBtn2.Height;
            spnl.Visible = false;
            spnl2.Visible = true;
            spnl3.Visible = false;
            spnl4.Visible = false;
            spnl5.Visible = false;

            manageViewer1.Visible = false;
            manage_manager1.Visible = true;
            manageAdmin1.Visible = false;
            manageTournamentmanager1.Visible = false;
            manageTournament1.Visible = false;
        }

        private void sbBtn3_Click(object sender, EventArgs e)
        {
            spnl.Height = sbBtn2.Height;
            spnl.Visible = false;
            spnl2.Visible = false;
            spnl3.Visible = false;
            spnl4.Visible = false;
            spnl5.Visible = true;

            manageViewer1.Visible = false;
            manage_manager1.Visible = false;
            manageTournamentmanager1.Visible = true;
            manageAdmin1.Visible = false;
            manageTournament1.Visible = false;
        }

        private void sbBtn4_Click(object sender, EventArgs e)
        {
            spnl.Visible = false;
            spnl2.Visible = false;
            spnl3.Visible = true;
            spnl4.Visible = false;
            spnl5.Visible = false;
            manageViewer1.Visible = false;
            manage_manager1.Visible = false;
            manageAdmin1.Visible = false;
            manageTournamentmanager1.Visible = false;
            manageTournament1.Visible = true;
        }

        private void sbBtn5_Click(object sender, EventArgs e)
        {
            spnl.Visible = false;
            spnl2.Visible = false;
            spnl3.Visible = false;
            spnl4.Visible = true;
            spnl5.Visible = false;

            manageViewer1.Visible = false;
            manage_manager1.Visible = false;
            manageAdmin1.Visible = true;
            manageTournamentmanager1.Visible = false;
            manageTournament1.Visible = false;
        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure.You want to log out?", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
