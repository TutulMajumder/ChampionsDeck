
namespace ChampionsDeck
{
    partial class manageAdmin
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
            this.adminStatusCBox = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminRPasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminEmailTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminNameTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminPasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminIDTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminDGView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusLbl);
            this.panel1.Controls.Add(this.adminStatusCBox);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.adminRPasswordTBox);
            this.panel1.Controls.Add(this.adminEmailTBox);
            this.panel1.Controls.Add(this.adminNameTBox);
            this.panel1.Controls.Add(this.adminPasswordTBox);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.adminIDTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 308);
            this.panel1.TabIndex = 2;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(31, 174);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(71, 23);
            this.statusLbl.TabIndex = 37;
            this.statusLbl.Text = "Status";
            // 
            // adminStatusCBox
            // 
            this.adminStatusCBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminStatusCBox.FormattingEnabled = true;
            this.adminStatusCBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.adminStatusCBox.Location = new System.Drawing.Point(109, 172);
            this.adminStatusCBox.Name = "adminStatusCBox";
            this.adminStatusCBox.Size = new System.Drawing.Size(235, 31);
            this.adminStatusCBox.TabIndex = 36;
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
            // adminRPasswordTBox
            // 
            this.adminRPasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminRPasswordTBox.DefaultText = "";
            this.adminRPasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminRPasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminRPasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminRPasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminRPasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminRPasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.adminRPasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminRPasswordTBox.Location = new System.Drawing.Point(674, 109);
            this.adminRPasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminRPasswordTBox.Name = "adminRPasswordTBox";
            this.adminRPasswordTBox.PasswordChar = '\0';
            this.adminRPasswordTBox.PlaceholderText = "Admin Re-Password";
            this.adminRPasswordTBox.SelectedText = "";
            this.adminRPasswordTBox.Size = new System.Drawing.Size(370, 39);
            this.adminRPasswordTBox.TabIndex = 29;
            // 
            // adminEmailTBox
            // 
            this.adminEmailTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminEmailTBox.DefaultText = "";
            this.adminEmailTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminEmailTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminEmailTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEmailTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminEmailTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEmailTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.adminEmailTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminEmailTBox.Location = new System.Drawing.Point(35, 109);
            this.adminEmailTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminEmailTBox.Name = "adminEmailTBox";
            this.adminEmailTBox.PasswordChar = '\0';
            this.adminEmailTBox.PlaceholderText = "Admin Email";
            this.adminEmailTBox.SelectedText = "";
            this.adminEmailTBox.Size = new System.Drawing.Size(473, 39);
            this.adminEmailTBox.TabIndex = 27;
            // 
            // adminNameTBox
            // 
            this.adminNameTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminNameTBox.DefaultText = "";
            this.adminNameTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminNameTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminNameTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminNameTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminNameTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminNameTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.adminNameTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminNameTBox.Location = new System.Drawing.Point(319, 43);
            this.adminNameTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminNameTBox.Name = "adminNameTBox";
            this.adminNameTBox.PasswordChar = '\0';
            this.adminNameTBox.PlaceholderText = "Admin Name";
            this.adminNameTBox.SelectedText = "";
            this.adminNameTBox.Size = new System.Drawing.Size(313, 39);
            this.adminNameTBox.TabIndex = 26;
            // 
            // adminPasswordTBox
            // 
            this.adminPasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminPasswordTBox.DefaultText = "";
            this.adminPasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminPasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminPasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminPasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminPasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminPasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.adminPasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminPasswordTBox.Location = new System.Drawing.Point(674, 43);
            this.adminPasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminPasswordTBox.Name = "adminPasswordTBox";
            this.adminPasswordTBox.PasswordChar = '\0';
            this.adminPasswordTBox.PlaceholderText = "Admin Password";
            this.adminPasswordTBox.SelectedText = "";
            this.adminPasswordTBox.Size = new System.Drawing.Size(370, 39);
            this.adminPasswordTBox.TabIndex = 25;
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
            // adminIDTBox
            // 
            this.adminIDTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminIDTBox.DefaultText = "";
            this.adminIDTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminIDTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminIDTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminIDTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminIDTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminIDTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.adminIDTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminIDTBox.Location = new System.Drawing.Point(35, 43);
            this.adminIDTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.adminIDTBox.Name = "adminIDTBox";
            this.adminIDTBox.PasswordChar = '\0';
            this.adminIDTBox.PlaceholderText = "Admin ID";
            this.adminIDTBox.SelectedText = "";
            this.adminIDTBox.Size = new System.Drawing.Size(250, 39);
            this.adminIDTBox.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminDGView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 366);
            this.panel2.TabIndex = 3;
            // 
            // adminDGView
            // 
            this.adminDGView.AllowUserToAddRows = false;
            this.adminDGView.AllowUserToDeleteRows = false;
            this.adminDGView.AllowUserToResizeColumns = false;
            this.adminDGView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDGView.EnableHeadersVisualStyles = false;
            this.adminDGView.Location = new System.Drawing.Point(22, 19);
            this.adminDGView.Name = "adminDGView";
            this.adminDGView.ReadOnly = true;
            this.adminDGView.RowHeadersVisible = false;
            this.adminDGView.RowHeadersWidth = 51;
            this.adminDGView.RowTemplate.Height = 24;
            this.adminDGView.Size = new System.Drawing.Size(1040, 328);
            this.adminDGView.TabIndex = 1;
            this.adminDGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDGView_CellClick);
            // 
            // manageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "manageAdmin";
            this.Size = new System.Drawing.Size(1085, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox adminStatusCBox;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2TextBox adminRPasswordTBox;
        private Guna.UI2.WinForms.Guna2TextBox adminEmailTBox;
        private Guna.UI2.WinForms.Guna2TextBox adminNameTBox;
        private Guna.UI2.WinForms.Guna2TextBox adminPasswordTBox;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2TextBox adminIDTBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView adminDGView;
        private System.Windows.Forms.Label statusLbl;
    }
}
