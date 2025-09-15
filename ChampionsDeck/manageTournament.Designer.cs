
namespace ChampionsDeck
{
    partial class manageTournament
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tournamentDGView = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ApprovedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tournamentIDTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tournamentDGView);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ApprovedBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.tournamentIDTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 680);
            this.panel1.TabIndex = 0;
            // 
            // tournamentDGView
            // 
            this.tournamentDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentDGView.Location = new System.Drawing.Point(61, 52);
            this.tournamentDGView.Name = "tournamentDGView";
            this.tournamentDGView.RowHeadersWidth = 51;
            this.tournamentDGView.RowTemplate.Height = 24;
            this.tournamentDGView.Size = new System.Drawing.Size(962, 321);
            this.tournamentDGView.TabIndex = 152;
            this.tournamentDGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamentDGView_CellClick);
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
            this.RefreshBtn.Location = new System.Drawing.Point(636, 575);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(182, 61);
            this.RefreshBtn.TabIndex = 150;
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
            this.SearchBtn.Location = new System.Drawing.Point(435, 575);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(182, 61);
            this.SearchBtn.TabIndex = 149;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ApprovedBtn
            // 
            this.ApprovedBtn.Animated = true;
            this.ApprovedBtn.AutoRoundedCorners = true;
            this.ApprovedBtn.BackColor = System.Drawing.Color.Transparent;
            this.ApprovedBtn.BorderRadius = 29;
            this.ApprovedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ApprovedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ApprovedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApprovedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ApprovedBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.ApprovedBtn.ForeColor = System.Drawing.Color.White;
            this.ApprovedBtn.IndicateFocus = true;
            this.ApprovedBtn.Location = new System.Drawing.Point(229, 575);
            this.ApprovedBtn.Name = "ApprovedBtn";
            this.ApprovedBtn.Size = new System.Drawing.Size(182, 61);
            this.ApprovedBtn.TabIndex = 148;
            this.ApprovedBtn.Text = "Approve";
            this.ApprovedBtn.Click += new System.EventHandler(this.ApprovedBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 147;
            this.label2.Text = "Proposal Status";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rejected",
            "Pending",
            "Approved"});
            this.comboBox2.Location = new System.Drawing.Point(675, 448);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 31);
            this.comboBox2.TabIndex = 146;
            // 
            // tournamentIDTBox
            // 
            this.tournamentIDTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tournamentIDTBox.DefaultText = "";
            this.tournamentIDTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tournamentIDTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tournamentIDTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tournamentIDTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tournamentIDTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tournamentIDTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.tournamentIDTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tournamentIDTBox.Location = new System.Drawing.Point(124, 448);
            this.tournamentIDTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tournamentIDTBox.Name = "tournamentIDTBox";
            this.tournamentIDTBox.PasswordChar = '\0';
            this.tournamentIDTBox.PlaceholderText = "Tournament ID";
            this.tournamentIDTBox.SelectedText = "";
            this.tournamentIDTBox.Size = new System.Drawing.Size(465, 39);
            this.tournamentIDTBox.TabIndex = 139;
            // 
            // manageTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "manageTournament";
            this.Size = new System.Drawing.Size(1085, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tournamentIDTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button ApprovedBtn;
        private System.Windows.Forms.DataGridView tournamentDGView;
    }
}
