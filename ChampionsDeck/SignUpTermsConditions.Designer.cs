
namespace ChampionsDeck
{
    partial class SignUpTermsConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpTermsConditions));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.theadingsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 53);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1176, 758);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // theadingsLbl
            // 
            this.theadingsLbl.AutoSize = true;
            this.theadingsLbl.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theadingsLbl.Location = new System.Drawing.Point(272, 22);
            this.theadingsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.theadingsLbl.Name = "theadingsLbl";
            this.theadingsLbl.Size = new System.Drawing.Size(542, 27);
            this.theadingsLbl.TabIndex = 1;
            this.theadingsLbl.Text = "Terms and Conditions for Champions Deck";
            this.theadingsLbl.Click += new System.EventHandler(this.theadingsLbl_Click);
            // 
            // SignUp_Terms_Conditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 717);
            this.Controls.Add(this.theadingsLbl);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUp_Terms_Conditions";
            this.Text = "SignUp_Terms_Conditions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label theadingsLbl;
    }
}