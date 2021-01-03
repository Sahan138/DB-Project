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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLUsername = new System.Windows.Forms.TextBox();
            this.txtLPassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linklblCreateAccount
            // 
            this.linklblCreateAccount.AutoSize = true;
            this.linklblCreateAccount.Location = new System.Drawing.Point(130, 227);
            this.linklblCreateAccount.Name = "linklblCreateAccount";
            this.linklblCreateAccount.Size = new System.Drawing.Size(105, 17);
            this.linklblCreateAccount.TabIndex = 0;
            this.linklblCreateAccount.TabStop = true;
            this.linklblCreateAccount.Text = "Create Account";
            this.linklblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCreateAccount_LinkClicked);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(130, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(133, 147);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtLUsername
            // 
            this.txtLUsername.Location = new System.Drawing.Point(324, 78);
            this.txtLUsername.Name = "txtLUsername";
            this.txtLUsername.Size = new System.Drawing.Size(100, 22);
            this.txtLUsername.TabIndex = 3;
            // 
            // txtLPassword
            // 
            this.txtLPassword.Location = new System.Drawing.Point(324, 141);
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.PasswordChar = '*';
            this.txtLPassword.Size = new System.Drawing.Size(100, 22);
            this.txtLPassword.TabIndex = 4;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(324, 222);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 27);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtLPassword);
            this.Controls.Add(this.txtLUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.linklblCreateAccount);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblCreateAccount;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLUsername;
        private System.Windows.Forms.TextBox txtLPassword;
        private System.Windows.Forms.Button btnlogin;
    }
}

