
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
            this.TBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.RePasswordTBox.Location = new System.Drawing.Point(439, 307);
            this.RePasswordTBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RePasswordTBox.Name = "RePasswordTBox";
            this.RePasswordTBox.PasswordChar = '\0';
            this.RePasswordTBox.PlaceholderText = "Enter your Password again\r\n";
            this.RePasswordTBox.SelectedText = "";
            this.RePasswordTBox.Size = new System.Drawing.Size(439, 39);
            this.RePasswordTBox.TabIndex = 24;
            // 
            // TBox
            // 
            this.TBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBox.DefaultText = "";
            this.TBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBox.Font = new System.Drawing.Font("Lucida Bright", 12F);
            this.TBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBox.Location = new System.Drawing.Point(439, 228);
            this.TBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TBox.Name = "TBox";
            this.TBox.PasswordChar = '\0';
            this.TBox.PlaceholderText = "Enter your Password";
            this.TBox.SelectedText = "";
            this.TBox.Size = new System.Drawing.Size(439, 39);
            this.TBox.TabIndex = 23;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.RePasswordTBox);
            this.Controls.Add(this.TBox);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
        private Guna.UI2.WinForms.Guna2TextBox RePasswordTBox;
        private Guna.UI2.WinForms.Guna2TextBox TBox;
    }
}