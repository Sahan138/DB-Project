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
    public partial class frmDeleteBorrower : Form
    {
        public frmDeleteBorrower()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome fh = new frmHome();
            this.Hide();
            fh.Show();
        }

        private void btnExitDB_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
           if(txtUserIDDeleteBorrower.Text.Trim()=="")
            {
                MessageBox.Show("Please enter a valid userID");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SAHANSQL;Initial Catalog=DBProject;Integrated Security=True");
                string qry = "delete from borrower where borrowerID = '"+txtUserIDDeleteBorrower.Text+"'";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
