
namespace ChampionsDeck
{
    partial class manageViewer
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
            this.viewerPnl = new System.Windows.Forms.Panel();
            this.viewerDGView = new System.Windows.Forms.DataGridView();
            this.dltBtn = new Guna.UI2.WinForms.Guna2Button();
            this.refreshBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.vIdTbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewerDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerPnl
            // 
            this.viewerPnl.BackColor = System.Drawing.Color.White;
            this.viewerPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewerPnl.Controls.Add(this.viewerDGView);
            this.viewerPnl.Controls.Add(this.dltBtn);
            this.viewerPnl.Controls.Add(this.refreshBtn);
            this.viewerPnl.Controls.Add(this.searchBtn);
            this.viewerPnl.Controls.Add(this.vIdTbox);
            this.viewerPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPnl.Location = new System.Drawing.Point(0, 0);
            this.viewerPnl.Name = "viewerPnl";
            this.viewerPnl.Size = new System.Drawing.Size(1085, 680);
            this.viewerPnl.TabIndex = 1;
            // 
            // viewerDGView
            // 
            this.viewerDGView.AllowUserToAddRows = false;
            this.viewerDGView.AllowUserToDeleteRows = false;
            this.viewerDGView.AllowUserToResizeColumns = false;
            this.viewerDGView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewerDGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewerDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewerDGView.EnableHeadersVisualStyles = false;
            this.viewerDGView.Location = new System.Drawing.Point(30, 230);
            this.viewerDGView.Name = "viewerDGView";
            this.viewerDGView.ReadOnly = true;
            this.viewerDGView.RowHeadersVisible = false;
            this.viewerDGView.RowHeadersWidth = 51;
            this.viewerDGView.RowTemplate.Height = 24;
            this.viewerDGView.Size = new System.Drawing.Size(1018, 366);
            this.viewerDGView.TabIndex = 36;
            this.viewerDGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewerDGView_CellClick_1);
            // 
            // dltBtn
            // 
            this.dltBtn.Animated = true;
            this.dltBtn.AutoRoundedCorners = true;
            this.dltBtn.BackColor = System.Drawing.Color.Transparent;
            this.dltBtn.BorderRadius = 26;
            this.dltBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dltBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dltBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dltBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dltBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.dltBtn.ForeColor = System.Drawing.Color.White;
            this.dltBtn.IndicateFocus = true;
            this.dltBtn.Location = new System.Drawing.Point(435, 103);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(201, 54);
            this.dltBtn.TabIndex = 35;
            this.dltBtn.Text = "Delete";
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Animated = true;
            this.refreshBtn.AutoRoundedCorners = true;
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BorderRadius = 26;
            this.refreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.IndicateFocus = true;
            this.refreshBtn.Location = new System.Drawing.Point(656, 103);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(201, 54);
            this.refreshBtn.TabIndex = 34;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Animated = true;
            this.searchBtn.AutoRoundedCorners = true;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderRadius = 26;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.IndicateFocus = true;
            this.searchBtn.Location = new System.Drawing.Point(214, 103);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(201, 54);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // vIdTbox
            // 
            this.vIdTbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vIdTbox.DefaultText = "";
            this.vIdTbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vIdTbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vIdTbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vIdTbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vIdTbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vIdTbox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.vIdTbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vIdTbox.Location = new System.Drawing.Point(318, 34);
            this.vIdTbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.vIdTbox.Name = "vIdTbox";
            this.vIdTbox.PasswordChar = '\0';
            this.vIdTbox.PlaceholderText = "Viewer Id";
            this.vIdTbox.SelectedText = "";
            this.vIdTbox.Size = new System.Drawing.Size(439, 39);
            this.vIdTbox.TabIndex = 32;
            // 
            // manageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewerPnl);
            this.Name = "manageViewer";
            this.Size = new System.Drawing.Size(1085, 680);
            this.viewerPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewerDGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewerPnl;
        private Guna.UI2.WinForms.Guna2Button dltBtn;
        private Guna.UI2.WinForms.Guna2Button refreshBtn;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2TextBox vIdTbox;
        private System.Windows.Forms.DataGridView viewerDGView;
    }
}
