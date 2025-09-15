
namespace ChampionsDeck
{
    partial class GameManagerDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameManagerDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusCBox = new System.Windows.Forms.ComboBox();
            this.ilogoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoPBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.gGenreLbl = new System.Windows.Forms.Label();
            this.genreCBox = new System.Windows.Forms.ComboBox();
            this.gPlatformLbl = new System.Windows.Forms.Label();
            this.platformCBox = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gameNameTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gameIDTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.statusCBox);
            this.panel1.Controls.Add(this.ilogoBtn);
            this.panel1.Controls.Add(this.logoPBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gGenreLbl);
            this.panel1.Controls.Add(this.genreCBox);
            this.panel1.Controls.Add(this.gPlatformLbl);
            this.panel1.Controls.Add(this.platformCBox);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.gameNameTBox);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.gameIDTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 703);
            this.panel1.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(62, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 304);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(812, 539);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(71, 23);
            this.statusLbl.TabIndex = 65;
            this.statusLbl.Text = "Status";
            // 
            // statusCBox
            // 
            this.statusCBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCBox.FormattingEnabled = true;
            this.statusCBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCBox.Location = new System.Drawing.Point(891, 535);
            this.statusCBox.Name = "statusCBox";
            this.statusCBox.Size = new System.Drawing.Size(235, 31);
            this.statusCBox.TabIndex = 64;
            // 
            // ilogoBtn
            // 
            this.ilogoBtn.Animated = true;
            this.ilogoBtn.AutoRoundedCorners = true;
            this.ilogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.ilogoBtn.BorderRadius = 29;
            this.ilogoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ilogoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ilogoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ilogoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ilogoBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.ilogoBtn.ForeColor = System.Drawing.Color.White;
            this.ilogoBtn.IndicateFocus = true;
            this.ilogoBtn.Location = new System.Drawing.Point(1156, 595);
            this.ilogoBtn.Name = "ilogoBtn";
            this.ilogoBtn.Size = new System.Drawing.Size(151, 61);
            this.ilogoBtn.TabIndex = 63;
            this.ilogoBtn.Text = "Import";
            this.ilogoBtn.Click += new System.EventHandler(this.ilogoBtn_Click);
            // 
            // logoPBox
            // 
            this.logoPBox.BackColor = System.Drawing.Color.DarkGray;
            this.logoPBox.Location = new System.Drawing.Point(1165, 451);
            this.logoPBox.Name = "logoPBox";
            this.logoPBox.Size = new System.Drawing.Size(133, 135);
            this.logoPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPBox.TabIndex = 62;
            this.logoPBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.logOutBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 65);
            this.panel2.TabIndex = 61;
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
            this.logOutBtn.Location = new System.Drawing.Point(1240, 7);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(139, 50);
            this.logOutBtn.TabIndex = 63;
            this.logOutBtn.Text = "  Logout";
            this.logOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // gGenreLbl
            // 
            this.gGenreLbl.AutoSize = true;
            this.gGenreLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGenreLbl.Location = new System.Drawing.Point(482, 538);
            this.gGenreLbl.Name = "gGenreLbl";
            this.gGenreLbl.Size = new System.Drawing.Size(69, 23);
            this.gGenreLbl.TabIndex = 60;
            this.gGenreLbl.Text = "Genre";
            // 
            // genreCBox
            // 
            this.genreCBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreCBox.FormattingEnabled = true;
            this.genreCBox.Items.AddRange(new object[] {
            "MOBA",
            "FPS",
            "Battle Royale"});
            this.genreCBox.Location = new System.Drawing.Point(557, 534);
            this.genreCBox.Name = "genreCBox";
            this.genreCBox.Size = new System.Drawing.Size(235, 31);
            this.genreCBox.TabIndex = 59;
            // 
            // gPlatformLbl
            // 
            this.gPlatformLbl.AutoSize = true;
            this.gPlatformLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPlatformLbl.Location = new System.Drawing.Point(106, 538);
            this.gPlatformLbl.Name = "gPlatformLbl";
            this.gPlatformLbl.Size = new System.Drawing.Size(96, 23);
            this.gPlatformLbl.TabIndex = 58;
            this.gPlatformLbl.Text = "Platform";
            // 
            // platformCBox
            // 
            this.platformCBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformCBox.FormattingEnabled = true;
            this.platformCBox.Items.AddRange(new object[] {
            "All Platforms",
            "Mobile",
            "PC/Console"});
            this.platformCBox.Location = new System.Drawing.Point(210, 534);
            this.platformCBox.Name = "platformCBox";
            this.platformCBox.Size = new System.Drawing.Size(235, 31);
            this.platformCBox.TabIndex = 56;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.AutoRoundedCorners = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BorderRadius = 29;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.IndicateFocus = true;
            this.DeleteBtn.Location = new System.Drawing.Point(690, 595);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(182, 61);
            this.DeleteBtn.TabIndex = 55;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Animated = true;
            this.RefreshBtn.AutoRoundedCorners = true;
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BorderRadius = 29;
            this.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.IndicateFocus = true;
            this.RefreshBtn.Location = new System.Drawing.Point(901, 595);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(182, 61);
            this.RefreshBtn.TabIndex = 54;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Animated = true;
            this.SearchBtn.AutoRoundedCorners = true;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BorderRadius = 29;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.IndicateFocus = true;
            this.SearchBtn.Location = new System.Drawing.Point(489, 595);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(182, 61);
            this.SearchBtn.TabIndex = 53;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.AutoRoundedCorners = true;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BorderRadius = 29;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IndicateFocus = true;
            this.UpdateBtn.Location = new System.Drawing.Point(283, 595);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(182, 61);
            this.UpdateBtn.TabIndex = 52;
            this.UpdateBtn.Text = "Update ";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // gameNameTBox
            // 
            this.gameNameTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameNameTBox.DefaultText = "";
            this.gameNameTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gameNameTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gameNameTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gameNameTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gameNameTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameNameTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gameNameTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameNameTBox.Location = new System.Drawing.Point(618, 451);
            this.gameNameTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gameNameTBox.Name = "gameNameTBox";
            this.gameNameTBox.PasswordChar = '\0';
            this.gameNameTBox.PlaceholderText = "Game Name";
            this.gameNameTBox.SelectedText = "";
            this.gameNameTBox.Size = new System.Drawing.Size(420, 39);
            this.gameNameTBox.TabIndex = 50;
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.BorderRadius = 29;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.IndicateFocus = true;
            this.AddBtn.Location = new System.Drawing.Point(74, 595);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(182, 61);
            this.AddBtn.TabIndex = 48;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // gameIDTBox
            // 
            this.gameIDTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameIDTBox.DefaultText = "";
            this.gameIDTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gameIDTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gameIDTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gameIDTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gameIDTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameIDTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gameIDTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gameIDTBox.Location = new System.Drawing.Point(157, 451);
            this.gameIDTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gameIDTBox.Name = "gameIDTBox";
            this.gameIDTBox.PasswordChar = '\0';
            this.gameIDTBox.PlaceholderText = "Game ID";
            this.gameIDTBox.SelectedText = "";
            this.gameIDTBox.Size = new System.Drawing.Size(380, 39);
            this.gameIDTBox.TabIndex = 47;
            // 
            // GameManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameManagerDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox platformCBox;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2TextBox gameNameTBox;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox gameIDTBox;
        private System.Windows.Forms.Label gPlatformLbl;
        private System.Windows.Forms.Label gGenreLbl;
        private System.Windows.Forms.ComboBox genreCBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logOutBtn;
        private Guna.UI2.WinForms.Guna2Button ilogoBtn;
        private System.Windows.Forms.PictureBox logoPBox;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox statusCBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}