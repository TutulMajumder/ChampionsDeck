
namespace ChampionsDeck
{
    partial class manageMatches
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
            this.addScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createMatch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamAscore = new Guna.UI2.WinForms.Guna2TextBox();
            this.TeamBscore = new Guna.UI2.WinForms.Guna2TextBox();
            this.matchIDTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.matchroundTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TB1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TB2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addScore
            // 
            this.addScore.BackColor = System.Drawing.Color.Navy;
            this.addScore.ForeColor = System.Drawing.Color.White;
            this.addScore.Location = new System.Drawing.Point(745, 627);
            this.addScore.Name = "addScore";
            this.addScore.Size = new System.Drawing.Size(251, 55);
            this.addScore.TabIndex = 20;
            this.addScore.Text = "Add Score";
            this.addScore.UseVisualStyleBackColor = false;
            this.addScore.Click += new System.EventHandler(this.addScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "-";
            // 
            // createMatch
            // 
            this.createMatch.BackColor = System.Drawing.Color.Navy;
            this.createMatch.ForeColor = System.Drawing.Color.White;
            this.createMatch.Location = new System.Drawing.Point(423, 627);
            this.createMatch.Name = "createMatch";
            this.createMatch.Size = new System.Drawing.Size(249, 55);
            this.createMatch.TabIndex = 13;
            this.createMatch.Text = "Create Match";
            this.createMatch.UseVisualStyleBackColor = false;
            this.createMatch.Click += new System.EventHandler(this.createMatch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(871, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(423, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 265);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // TeamAscore
            // 
            this.TeamAscore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TeamAscore.DefaultText = "";
            this.TeamAscore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TeamAscore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TeamAscore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeamAscore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeamAscore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeamAscore.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.TeamAscore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeamAscore.Location = new System.Drawing.Point(578, 458);
            this.TeamAscore.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TeamAscore.Name = "TeamAscore";
            this.TeamAscore.PasswordChar = '\0';
            this.TeamAscore.PlaceholderText = "";
            this.TeamAscore.SelectedText = "";
            this.TeamAscore.Size = new System.Drawing.Size(81, 54);
            this.TeamAscore.TabIndex = 80;
            // 
            // TeamBscore
            // 
            this.TeamBscore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TeamBscore.DefaultText = "";
            this.TeamBscore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TeamBscore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TeamBscore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeamBscore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeamBscore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeamBscore.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.TeamBscore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeamBscore.Location = new System.Drawing.Point(745, 458);
            this.TeamBscore.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TeamBscore.Name = "TeamBscore";
            this.TeamBscore.PasswordChar = '\0';
            this.TeamBscore.PlaceholderText = "";
            this.TeamBscore.SelectedText = "";
            this.TeamBscore.Size = new System.Drawing.Size(81, 54);
            this.TeamBscore.TabIndex = 81;
            // 
            // matchIDTBox
            // 
            this.matchIDTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matchIDTBox.DefaultText = "";
            this.matchIDTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.matchIDTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.matchIDTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matchIDTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matchIDTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matchIDTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.matchIDTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matchIDTBox.Location = new System.Drawing.Point(423, 350);
            this.matchIDTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.matchIDTBox.Name = "matchIDTBox";
            this.matchIDTBox.PasswordChar = '\0';
            this.matchIDTBox.PlaceholderText = "Match ID";
            this.matchIDTBox.SelectedText = "";
            this.matchIDTBox.Size = new System.Drawing.Size(187, 39);
            this.matchIDTBox.TabIndex = 140;
            // 
            // matchroundTBox
            // 
            this.matchroundTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matchroundTBox.DefaultText = "";
            this.matchroundTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.matchroundTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.matchroundTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matchroundTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.matchroundTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matchroundTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.matchroundTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.matchroundTBox.Location = new System.Drawing.Point(688, 350);
            this.matchroundTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.matchroundTBox.Name = "matchroundTBox";
            this.matchroundTBox.PasswordChar = '\0';
            this.matchroundTBox.PlaceholderText = "Match Round";
            this.matchroundTBox.SelectedText = "";
            this.matchroundTBox.Size = new System.Drawing.Size(187, 39);
            this.matchroundTBox.TabIndex = 141;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(900, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 147;
            this.label2.Text = "Match Date";
            // 
            // TB1
            // 
            this.TB1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB1.DefaultText = "";
            this.TB1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB1.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.TB1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB1.Location = new System.Drawing.Point(399, 557);
            this.TB1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TB1.Name = "TB1";
            this.TB1.PasswordChar = '\0';
            this.TB1.PlaceholderText = "";
            this.TB1.SelectedText = "";
            this.TB1.Size = new System.Drawing.Size(187, 39);
            this.TB1.TabIndex = 149;
            this.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB2
            // 
            this.TB2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB2.DefaultText = "";
            this.TB2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB2.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.TB2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB2.Location = new System.Drawing.Point(842, 557);
            this.TB2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TB2.Name = "TB2";
            this.TB2.PasswordChar = '\0';
            this.TB2.PlaceholderText = "";
            this.TB2.SelectedText = "";
            this.TB2.Size = new System.Drawing.Size(187, 39);
            this.TB2.TabIndex = 150;
            this.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Navy;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(1230, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(140, 50);
            this.backBtn.TabIndex = 151;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // manageMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matchroundTBox);
            this.Controls.Add(this.matchIDTBox);
            this.Controls.Add(this.TeamBscore);
            this.Controls.Add(this.TeamAscore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "manageMatches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageTeam";
            this.Load += new System.EventHandler(this.ManageTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createMatch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox TeamAscore;
        private Guna.UI2.WinForms.Guna2TextBox TeamBscore;
        private Guna.UI2.WinForms.Guna2TextBox matchIDTBox;
        private Guna.UI2.WinForms.Guna2TextBox matchroundTBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TB1;
        private Guna.UI2.WinForms.Guna2TextBox TB2;
        private System.Windows.Forms.Button backBtn;
    }
}