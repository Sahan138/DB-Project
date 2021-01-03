namespace Library_Management_System
{
    partial class frmHome
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
            this.btnRegisterBorrower = new System.Windows.Forms.Button();
            this.btnDeleteBorrower = new System.Windows.Forms.Button();
            this.datagridBorrower = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBorrower)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterBorrower
            // 
            this.btnRegisterBorrower.Location = new System.Drawing.Point(92, 114);
            this.btnRegisterBorrower.Name = "btnRegisterBorrower";
            this.btnRegisterBorrower.Size = new System.Drawing.Size(134, 49);
            this.btnRegisterBorrower.TabIndex = 0;
            this.btnRegisterBorrower.Text = "Register Borrower";
            this.btnRegisterBorrower.UseVisualStyleBackColor = true;
            this.btnRegisterBorrower.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDeleteBorrower
            // 
            this.btnDeleteBorrower.Location = new System.Drawing.Point(92, 189);
            this.btnDeleteBorrower.Name = "btnDeleteBorrower";
            this.btnDeleteBorrower.Size = new System.Drawing.Size(134, 49);
            this.btnDeleteBorrower.TabIndex = 1;
            this.btnDeleteBorrower.Text = "Delete Borrower";
            this.btnDeleteBorrower.UseVisualStyleBackColor = true;
            this.btnDeleteBorrower.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // datagridBorrower
            // 
            this.datagridBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBorrower.Location = new System.Drawing.Point(434, 22);
            this.datagridBorrower.Name = "datagridBorrower";
            this.datagridBorrower.RowHeadersWidth = 51;
            this.datagridBorrower.RowTemplate.Height = 24;
            this.datagridBorrower.Size = new System.Drawing.Size(326, 344);
            this.datagridBorrower.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(565, 387);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.datagridBorrower);
            this.Controls.Add(this.btnDeleteBorrower);
            this.Controls.Add(this.btnRegisterBorrower);
            this.Name = "frmHome";
            this.Text = "   Home";
            ((System.ComponentModel.ISupportInitialize)(this.datagridBorrower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterBorrower;
        private System.Windows.Forms.Button btnDeleteBorrower;
        private System.Windows.Forms.DataGridView datagridBorrower;
        private System.Windows.Forms.Button btnRefresh;
    }
}