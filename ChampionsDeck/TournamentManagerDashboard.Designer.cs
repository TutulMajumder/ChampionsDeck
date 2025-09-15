
namespace ChampionsDeck
{
    partial class TournamentManagerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentManagerDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tournamentsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manageTBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.addTournamentBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.manageTBtn);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.addTournamentBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 95);
            this.panel1.TabIndex = 0;
            // 
            // tournamentsFlowPanel
            // 
            this.tournamentsFlowPanel.AutoScroll = true;
            this.tournamentsFlowPanel.Location = new System.Drawing.Point(0, 95);
            this.tournamentsFlowPanel.Name = "tournamentsFlowPanel";
            this.tournamentsFlowPanel.Size = new System.Drawing.Size(1382, 608);
            this.tournamentsFlowPanel.TabIndex = 1;
            // 
            // manageTBtn
            // 
            this.manageTBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.manageTBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manageTBtn.BackgroundImage")));
            this.manageTBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageTBtn.ForeColor = System.Drawing.Color.White;
            this.manageTBtn.Location = new System.Drawing.Point(889, 12);
            this.manageTBtn.Name = "manageTBtn";
            this.manageTBtn.Size = new System.Drawing.Size(151, 67);
            this.manageTBtn.TabIndex = 65;
            this.manageTBtn.Text = "Manage Teams";
            this.manageTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageTBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageTBtn.UseVisualStyleBackColor = false;
            this.manageTBtn.Click += new System.EventHandler(this.manageTBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.Location = new System.Drawing.Point(1231, 19);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(139, 50);
            this.logOutBtn.TabIndex = 64;
            this.logOutBtn.Text = "  Logout";
            this.logOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // addTournamentBtn
            // 
            this.addTournamentBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTournamentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTournamentBtn.BackgroundImage")));
            this.addTournamentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTournamentBtn.ForeColor = System.Drawing.Color.White;
            this.addTournamentBtn.Location = new System.Drawing.Point(1065, 12);
            this.addTournamentBtn.Name = "addTournamentBtn";
            this.addTournamentBtn.Size = new System.Drawing.Size(160, 67);
            this.addTournamentBtn.TabIndex = 2;
            this.addTournamentBtn.Text = "Add Tournament";
            this.addTournamentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTournamentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTournamentBtn.UseVisualStyleBackColor = false;
            this.addTournamentBtn.Click += new System.EventHandler(this.addTournamentBtn_Click);
            // 
            // TournamentManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.tournamentsFlowPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TournamentManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TournamentManagerDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addTournamentBtn;
        private System.Windows.Forms.FlowLayoutPanel tournamentsFlowPanel;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button manageTBtn;
    }
}