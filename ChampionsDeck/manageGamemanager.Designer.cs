
namespace ChampionsDeck
{
    partial class manage_manager
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
            this.gmanagerRPasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gmanagerUEmailTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gmanagerUNameTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gmanagerPasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gmanagerIDTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.managerDGView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerDGView)).BeginInit();
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
            this.panel1.Controls.Add(this.gmanagerRPasswordTBox);
            this.panel1.Controls.Add(this.gmanagerUEmailTBox);
            this.panel1.Controls.Add(this.gmanagerUNameTBox);
            this.panel1.Controls.Add(this.gmanagerPasswordTBox);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.gmanagerIDTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 295);
            this.panel1.TabIndex = 0;
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
            // gmanagerRPasswordTBox
            // 
            this.gmanagerRPasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmanagerRPasswordTBox.DefaultText = "";
            this.gmanagerRPasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gmanagerRPasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gmanagerRPasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerRPasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerRPasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerRPasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gmanagerRPasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerRPasswordTBox.Location = new System.Drawing.Point(674, 109);
            this.gmanagerRPasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gmanagerRPasswordTBox.Name = "gmanagerRPasswordTBox";
            this.gmanagerRPasswordTBox.PasswordChar = '\0';
            this.gmanagerRPasswordTBox.PlaceholderText = "GameManager Re-Password";
            this.gmanagerRPasswordTBox.SelectedText = "";
            this.gmanagerRPasswordTBox.Size = new System.Drawing.Size(370, 39);
            this.gmanagerRPasswordTBox.TabIndex = 29;
            // 
            // gmanagerUEmailTBox
            // 
            this.gmanagerUEmailTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmanagerUEmailTBox.DefaultText = "";
            this.gmanagerUEmailTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gmanagerUEmailTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gmanagerUEmailTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerUEmailTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerUEmailTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerUEmailTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gmanagerUEmailTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerUEmailTBox.Location = new System.Drawing.Point(35, 109);
            this.gmanagerUEmailTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gmanagerUEmailTBox.Name = "gmanagerUEmailTBox";
            this.gmanagerUEmailTBox.PasswordChar = '\0';
            this.gmanagerUEmailTBox.PlaceholderText = "GameManager Email";
            this.gmanagerUEmailTBox.SelectedText = "";
            this.gmanagerUEmailTBox.Size = new System.Drawing.Size(473, 39);
            this.gmanagerUEmailTBox.TabIndex = 27;
            // 
            // gmanagerUNameTBox
            // 
            this.gmanagerUNameTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmanagerUNameTBox.DefaultText = "";
            this.gmanagerUNameTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gmanagerUNameTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gmanagerUNameTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerUNameTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerUNameTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerUNameTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gmanagerUNameTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerUNameTBox.Location = new System.Drawing.Point(319, 43);
            this.gmanagerUNameTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gmanagerUNameTBox.Name = "gmanagerUNameTBox";
            this.gmanagerUNameTBox.PasswordChar = '\0';
            this.gmanagerUNameTBox.PlaceholderText = "GameManager Name";
            this.gmanagerUNameTBox.SelectedText = "";
            this.gmanagerUNameTBox.Size = new System.Drawing.Size(313, 39);
            this.gmanagerUNameTBox.TabIndex = 26;
            // 
            // gmanagerPasswordTBox
            // 
            this.gmanagerPasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmanagerPasswordTBox.DefaultText = "";
            this.gmanagerPasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gmanagerPasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gmanagerPasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerPasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerPasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerPasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gmanagerPasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerPasswordTBox.Location = new System.Drawing.Point(673, 43);
            this.gmanagerPasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gmanagerPasswordTBox.Name = "gmanagerPasswordTBox";
            this.gmanagerPasswordTBox.PasswordChar = '\0';
            this.gmanagerPasswordTBox.PlaceholderText = "GameManager Password";
            this.gmanagerPasswordTBox.SelectedText = "";
            this.gmanagerPasswordTBox.Size = new System.Drawing.Size(370, 39);
            this.gmanagerPasswordTBox.TabIndex = 25;
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
            // gmanagerIDTBox
            // 
            this.gmanagerIDTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmanagerIDTBox.DefaultText = "";
            this.gmanagerIDTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gmanagerIDTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gmanagerIDTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerIDTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gmanagerIDTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerIDTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.gmanagerIDTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gmanagerIDTBox.Location = new System.Drawing.Point(35, 43);
            this.gmanagerIDTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gmanagerIDTBox.Name = "gmanagerIDTBox";
            this.gmanagerIDTBox.PasswordChar = '\0';
            this.gmanagerIDTBox.PlaceholderText = "GameManager ID";
            this.gmanagerIDTBox.SelectedText = "";
            this.gmanagerIDTBox.Size = new System.Drawing.Size(250, 39);
            this.gmanagerIDTBox.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.managerDGView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 366);
            this.panel2.TabIndex = 1;
            // 
            // managerDGView
            // 
            this.managerDGView.AllowUserToAddRows = false;
            this.managerDGView.AllowUserToDeleteRows = false;
            this.managerDGView.AllowUserToResizeColumns = false;
            this.managerDGView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.managerDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.managerDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerDGView.EnableHeadersVisualStyles = false;
            this.managerDGView.Location = new System.Drawing.Point(22, 19);
            this.managerDGView.Name = "managerDGView";
            this.managerDGView.ReadOnly = true;
            this.managerDGView.RowHeadersVisible = false;
            this.managerDGView.RowHeadersWidth = 51;
            this.managerDGView.RowTemplate.Height = 24;
            this.managerDGView.Size = new System.Drawing.Size(1040, 328);
            this.managerDGView.TabIndex = 1;
            this.managerDGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerDGView_CellClick);
            // 
            // manage_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "manage_manager";
            this.Size = new System.Drawing.Size(1085, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managerDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2TextBox gmanagerRPasswordTBox;
        private Guna.UI2.WinForms.Guna2TextBox gmanagerUEmailTBox;
        private Guna.UI2.WinForms.Guna2TextBox gmanagerUNameTBox;
        private Guna.UI2.WinForms.Guna2TextBox gmanagerPasswordTBox;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox gmanagerIDTBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView managerDGView;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private System.Windows.Forms.ComboBox statusCBox;
        private System.Windows.Forms.Label statusLbl;
    }
}
