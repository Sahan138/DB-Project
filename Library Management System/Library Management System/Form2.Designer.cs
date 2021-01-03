namespace Library_Management_System
{
    partial class frmDeleteBorrower
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExitDB = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserIDDeleteBorrower = new System.Windows.Forms.TextBox();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExitDB
            // 
            this.btnExitDB.Location = new System.Drawing.Point(706, 415);
            this.btnExitDB.Name = "btnExitDB";
            this.btnExitDB.Size = new System.Drawing.Size(82, 23);
            this.btnExitDB.TabIndex = 1;
            this.btnExitDB.Text = "Exit";
            this.btnExitDB.UseVisualStyleBackColor = true;
            this.btnExitDB.Click += new System.EventHandler(this.btnExitDB_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(154, 126);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(89, 17);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "Enter UserID";
            // 
            // txtUserIDDeleteBorrower
            // 
            this.txtUserIDDeleteBorrower.Location = new System.Drawing.Point(290, 123);
            this.txtUserIDDeleteBorrower.Name = "txtUserIDDeleteBorrower";
            this.txtUserIDDeleteBorrower.Size = new System.Drawing.Size(143, 22);
            this.txtUserIDDeleteBorrower.TabIndex = 3;
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(290, 170);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDB.TabIndex = 4;
            this.btnDeleteDB.Text = "Delete";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // frmDeleteBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.txtUserIDDeleteBorrower);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnExitDB);
            this.Controls.Add(this.btnBack);
            this.Name = "frmDeleteBorrower";
            this.Text = "Delete Borrower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExitDB;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserIDDeleteBorrower;
        private System.Windows.Forms.Button btnDeleteDB;
    }
}