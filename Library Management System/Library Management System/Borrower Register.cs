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
    public partial class frmRegisterBorrower : Form
    {
        public frmRegisterBorrower()
        {
            InitializeComponent();
        }

        private void btnExitRB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBackRB_Click(object sender, EventArgs e)
        {
            frmHome fh = new frmHome();
            this.Hide();
            fh.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                        

            if (txtBorrowerID.Text.Trim() == "" || txtName.Text.Trim() == "" || txtTelephone.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtMembershipDuration.Text.Trim() == "" || txtBranchID.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            { 
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SAHANSQL;Initial Catalog=DBProject;Integrated Security=True");
                string qry = "insert into borrower values('"+ txtBorrowerID.Text.Trim() + "','"+ txtName.Text.Trim() + "','"+ txtTelephone.Text.Trim() + "','"+ txtAddress.Text.Trim() + "','"+ txtMembershipDuration.Text.Trim() + "','"+ txtBranchID.Text.Trim()+ "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Registered Successfully !");
                }
                catch(Exception ex2)
                {
                    MessageBox.Show("" + ex2);
                }
            }


        }
    }
}
