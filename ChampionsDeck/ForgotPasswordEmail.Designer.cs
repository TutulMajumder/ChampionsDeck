
namespace ChampionsDeck
{
    partial class ForgotPasswordEmail
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
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.emailTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Animated = true;
            this.LoginBtn.AutoRoundedCorners = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 24;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.IndicateFocus = true;
            this.LoginBtn.Location = new System.Drawing.Point(515, 314);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(359, 51);
            this.LoginBtn.TabIndex = 24;
            this.LoginBtn.Text = "Send";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // emailTBox
            // 
            this.emailTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTBox.DefaultText = "";
            this.emailTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.emailTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTBox.Location = new System.Drawing.Point(479, 254);
            this.emailTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emailTBox.Name = "emailTBox";
            this.emailTBox.PasswordChar = '\0';
            this.emailTBox.PlaceholderText = "Enter your email";
            this.emailTBox.SelectedText = "";
            this.emailTBox.Size = new System.Drawing.Size(439, 39);
            this.emailTBox.TabIndex = 23;
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
            this.backBtn.TabIndex = 129;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ForgotPasswordEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.emailTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ForgotPasswordEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordEmail";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox emailTBox;
        private System.Windows.Forms.Button backBtn;
    }
}