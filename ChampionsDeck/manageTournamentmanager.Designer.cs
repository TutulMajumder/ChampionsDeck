
namespace ChampionsDeck
{
    partial class manageTournamentmanager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusCBox = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tmanagerRPasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tmanagerUEmailTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tmanagerUNameTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tmanagerPasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tmanagerIDTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tmanagerDGView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmanagerDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.statusCBox);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.tmanagerRPasswordTBox);
            this.panel1.Controls.Add(this.tmanagerUEmailTBox);
            this.panel1.Controls.Add(this.tmanagerUNameTBox);
            this.panel1.Controls.Add(this.tmanagerPasswordTBox);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.tmanagerIDTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 295);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(31, 171);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(71, 23);
            this.statusLbl.TabIndex = 39;
            this.statusLbl.Text = "Status";
            // 
            // statusCBox
            // 
            this.statusCBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCBox.FormattingEnabled = true;
            this.statusCBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCBox.Location = new System.Drawing.Point(108, 168);
            this.statusCBox.Name = "statusCBox";
            this.statusCBox.Size = new System.Drawing.Size(235, 31);
            this.statusCBox.TabIndex = 36;
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
            this.DeleteBtn.Location = new System.Drawing.Point(651, 221);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(182, 61);
            this.DeleteBtn.TabIndex = 33;
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
            this.RefreshBtn.Location = new System.Drawing.Point(862, 221);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(182, 61);
            this.RefreshBtn.TabIndex = 32;
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
            this.SearchBtn.Location = new System.Drawing.Point(450, 221);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(182, 61);
            this.SearchBtn.TabIndex = 31;
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
            this.UpdateBtn.Location = new System.Drawing.Point(244, 221);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(182, 61);
            this.UpdateBtn.TabIndex = 30;
            this.UpdateBtn.Text = "Update ";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // tmanagerRPasswordTBox
            // 
            this.tmanagerRPasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tmanagerRPasswordTBox.DefaultText = "";
            this.tmanagerRPasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tmanagerRPasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tmanagerRPasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerRPasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerRPasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerRPasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.tmanagerRPasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerRPasswordTBox.Location = new System.Drawing.Point(674, 109);
            this.tmanagerRPasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tmanagerRPasswordTBox.Name = "tmanagerRPasswordTBox";
            this.tmanagerRPasswordTBox.PasswordChar = '\0';
            this.tmanagerRPasswordTBox.PlaceholderText = "TournamentManager Re-Password";
            this.tmanagerRPasswordTBox.SelectedText = "";
            this.tmanagerRPasswordTBox.Size = new System.Drawing.Size(370, 39);
            this.tmanagerRPasswordTBox.TabIndex = 29;
            // 
            // tmanagerUEmailTBox
            // 
            this.tmanagerUEmailTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tmanagerUEmailTBox.DefaultText = "";
            this.tmanagerUEmailTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tmanagerUEmailTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tmanagerUEmailTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerUEmailTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerUEmailTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerUEmailTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.tmanagerUEmailTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerUEmailTBox.Location = new System.Drawing.Point(35, 109);
            this.tmanagerUEmailTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tmanagerUEmailTBox.Name = "tmanagerUEmailTBox";
            this.tmanagerUEmailTBox.PasswordChar = '\0';
            this.tmanagerUEmailTBox.PlaceholderText = "TournamentManager Email";
            this.tmanagerUEmailTBox.SelectedText = "";
            this.tmanagerUEmailTBox.Size = new System.Drawing.Size(473, 39);
            this.tmanagerUEmailTBox.TabIndex = 27;
            // 
            // tmanagerUNameTBox
            // 
            this.tmanagerUNameTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tmanagerUNameTBox.DefaultText = "";
            this.tmanagerUNameTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tmanagerUNameTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tmanagerUNameTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerUNameTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerUNameTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerUNameTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.tmanagerUNameTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerUNameTBox.Location = new System.Drawing.Point(334, 43);
            this.tmanagerUNameTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tmanagerUNameTBox.Name = "tmanagerUNameTBox";
            this.tmanagerUNameTBox.PasswordChar = '\0';
            this.tmanagerUNameTBox.PlaceholderText = "TournamnetManager Name";
            this.tmanagerUNameTBox.SelectedText = "";
            this.tmanagerUNameTBox.Size = new System.Drawing.Size(313, 39);
            this.tmanagerUNameTBox.TabIndex = 26;
            // 
            // tmanagerPasswordTBox
            // 
            this.tmanagerPasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tmanagerPasswordTBox.DefaultText = "";
            this.tmanagerPasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tmanagerPasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tmanagerPasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerPasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerPasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerPasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.tmanagerPasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerPasswordTBox.Location = new System.Drawing.Point(674, 43);
            this.tmanagerPasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tmanagerPasswordTBox.Name = "tmanagerPasswordTBox";
            this.tmanagerPasswordTBox.PasswordChar = '\0';
            this.tmanagerPasswordTBox.PlaceholderText = "TournamentManager Password";
            this.tmanagerPasswordTBox.SelectedText = "";
            this.tmanagerPasswordTBox.Size = new System.Drawing.Size(370, 39);
            this.tmanagerPasswordTBox.TabIndex = 25;
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
            this.AddBtn.Location = new System.Drawing.Point(35, 221);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(182, 61);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // tmanagerIDTBox
            // 
            this.tmanagerIDTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tmanagerIDTBox.DefaultText = "";
            this.tmanagerIDTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tmanagerIDTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tmanagerIDTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerIDTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tmanagerIDTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerIDTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.tmanagerIDTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tmanagerIDTBox.Location = new System.Drawing.Point(35, 43);
            this.tmanagerIDTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tmanagerIDTBox.Name = "tmanagerIDTBox";
            this.tmanagerIDTBox.PasswordChar = '\0';
            this.tmanagerIDTBox.PlaceholderText = "TournamentManager ID";
            this.tmanagerIDTBox.SelectedText = "";
            this.tmanagerIDTBox.Size = new System.Drawing.Size(269, 39);
            this.tmanagerIDTBox.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tmanagerDGView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 366);
            this.panel2.TabIndex = 2;
            // 
            // tmanagerDGView
            // 
            this.tmanagerDGView.AllowUserToAddRows = false;
            this.tmanagerDGView.AllowUserToDeleteRows = false;
            this.tmanagerDGView.AllowUserToResizeColumns = false;
            this.tmanagerDGView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tmanagerDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tmanagerDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tmanagerDGView.EnableHeadersVisualStyles = false;
            this.tmanagerDGView.Location = new System.Drawing.Point(22, 19);
            this.tmanagerDGView.Name = "tmanagerDGView";
            this.tmanagerDGView.ReadOnly = true;
            this.tmanagerDGView.RowHeadersVisible = false;
            this.tmanagerDGView.RowHeadersWidth = 51;
            this.tmanagerDGView.RowTemplate.Height = 24;
            this.tmanagerDGView.Size = new System.Drawing.Size(1040, 328);
            this.tmanagerDGView.TabIndex = 2;
            // 
            // manageTournamentmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "manageTournamentmanager";
            this.Size = new System.Drawing.Size(1085, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tmanagerDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox statusCBox;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2TextBox tmanagerRPasswordTBox;
        private Guna.UI2.WinForms.Guna2TextBox tmanagerUEmailTBox;
        private Guna.UI2.WinForms.Guna2TextBox tmanagerUNameTBox;
        private Guna.UI2.WinForms.Guna2TextBox tmanagerPasswordTBox;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox tmanagerIDTBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tmanagerDGView;
    }
}
