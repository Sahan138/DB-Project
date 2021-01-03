namespace Library_Management_System
{
    partial class frmLogin
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
            this.linklblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linklblCreateAccount
            // 
            this.linklblCreateAccount.AutoSize = true;
            this.linklblCreateAccount.Location = new System.Drawing.Point(321, 310);
            this.linklblCreateAccount.Name = "linklblCreateAccount";
            this.linklblCreateAccount.Size = new System.Drawing.Size(105, 17);
            this.linklblCreateAccount.TabIndex = 0;
            this.linklblCreateAccount.TabStop = true;
            this.linklblCreateAccount.Text = "Create Account";
            this.linklblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCreateAccount_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linklblCreateAccount);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblCreateAccount;
    }
}

