
namespace ChampionsDeck
{
    partial class ChangePassword
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
            this.changePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RePasswordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.showRPassCBox = new System.Windows.Forms.CheckBox();
            this.showPassCBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Animated = true;
            this.changePasswordBtn.AutoRoundedCorners = true;
            this.changePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.BorderRadius = 29;
            this.changePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordBtn.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold);
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.IndicateFocus = true;
            this.changePasswordBtn.Location = new System.Drawing.Point(458, 394);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(402, 61);
            this.changePasswordBtn.TabIndex = 25;
            this.changePasswordBtn.Text = "Submit";
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // RePasswordTBox
            // 
            this.RePasswordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePasswordTBox.DefaultText = "";
            this.RePasswordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RePasswordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RePasswordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePasswordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RePasswordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePasswordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.RePasswordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RePasswordTBox.Location = new System.Drawing.Point(439, 295);
            this.RePasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RePasswordTBox.Name = "RePasswordTBox";
            this.RePasswordTBox.PasswordChar = '\0';
            this.RePasswordTBox.PlaceholderText = "Enter your Password again\r\n";
            this.RePasswordTBox.SelectedText = "";
            this.RePasswordTBox.Size = new System.Drawing.Size(439, 39);
            this.RePasswordTBox.TabIndex = 24;
            // 
            // passwordTBox
            // 
            this.passwordTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTBox.DefaultText = "";
            this.passwordTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.passwordTBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTBox.Location = new System.Drawing.Point(439, 198);
            this.passwordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.PasswordChar = '\0';
            this.passwordTBox.PlaceholderText = "Enter your Password";
            this.passwordTBox.SelectedText = "";
            this.passwordTBox.Size = new System.Drawing.Size(439, 39);
            this.passwordTBox.TabIndex = 23;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Navy;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(1230, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(140, 50);
            this.cancelBtn.TabIndex = 130;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // showRPassCBox
            // 
            this.showRPassCBox.AutoSize = true;
            this.showRPassCBox.BackColor = System.Drawing.Color.Transparent;
            this.showRPassCBox.Location = new System.Drawing.Point(726, 342);
            this.showRPassCBox.Name = "showRPassCBox";
            this.showRPassCBox.Size = new System.Drawing.Size(152, 21);
            this.showRPassCBox.TabIndex = 132;
            this.showRPassCBox.Text = "Show Re-Password";
            this.showRPassCBox.UseVisualStyleBackColor = false;
            this.showRPassCBox.CheckedChanged += new System.EventHandler(this.showRPassCBox_CheckedChanged);
            // 
            // showPassCBox
            // 
            this.showPassCBox.AutoSize = true;
            this.showPassCBox.BackColor = System.Drawing.Color.Transparent;
            this.showPassCBox.Location = new System.Drawing.Point(749, 245);
            this.showPassCBox.Name = "showPassCBox";
            this.showPassCBox.Size = new System.Drawing.Size(129, 21);
            this.showPassCBox.TabIndex = 131;
            this.showPassCBox.Text = "Show Password";
            this.showPassCBox.UseVisualStyleBackColor = false;
            this.showPassCBox.CheckedChanged += new System.EventHandler(this.showPassCBox_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.showRPassCBox);
            this.Controls.Add(this.showPassCBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.RePasswordTBox);
            this.Controls.Add(this.passwordTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
        private Guna.UI2.WinForms.Guna2TextBox RePasswordTBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox showRPassCBox;
        private System.Windows.Forms.CheckBox showPassCBox;
    }
}