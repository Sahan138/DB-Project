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
            int borrowerID, telephone, membershipDuration, branchID;
            string borrowerName, borrowerAddress;

            borrowerID = int.Parse(txtBorrowerID.Text);
            borrowerName = txtName.Text;
            telephone = int.Parse(txtTelephone.Text);
            borrowerAddress = txtAddress.Text;
            membershipDuration = int.Parse(txtMembershipDuration.Text);
            branchID = int.Parse(txtBranchID.Text);


            if ((txtBorrowerID.Text == "") || (borrowerName == "") || (txtTelephone.Text == "") || (borrowerAddress == "") || (txtMembershipDuration.Text == "") || (txtBranchID.Text == ""))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                string qry = "insert into borrower values('"+borrowerID+ "','"+borrowerName+ "','"+telephone+ "','"+borrowerAddress+ "','"+membershipDuration+ "','"+branchID+"')";
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
