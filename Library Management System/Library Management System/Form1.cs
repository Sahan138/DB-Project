using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount fca = new frmCreateAccount();
            this.Hide();
            fca.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if((txtLUsername.Text == "") || (txtLPassword.Text == ""))
            {
                MessageBox.Show("Please Enter Correct Credintials");
            }

            SqlConnection con1 = new SqlConnection(@"Data Source=MSI\SAHANSQL;Initial Catalog=DBProject;Integrated Security=True");
            string qry1 = "select * from DBuser where username = '" + txtLUsername.Text + "' AND password = '" + txtLPassword.Text + "'";
            SqlCommand cmd1 = new SqlCommand(qry1, con1);

            try
            {
                con1.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("   Welcome !    ");
                    frmHome fh = new frmHome();
                    fh.Show();
                    this.Hide();
                }
          
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show("" + ex1);
            }
        }
    }
}
