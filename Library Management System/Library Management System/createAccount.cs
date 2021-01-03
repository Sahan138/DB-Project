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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void linklabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fName, lName, address, username, password,cpassword;
            string telephone;

            fName = txtFName.Text;
            lName = txtLName.Text;
            telephone = txtTelephone.Text;
            address = txtAddress.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            cpassword = txtCPassword.Text;


            if ((fName == "") || (lName == "") || (telephone == "") || (address == "") || (username == "") || (password == ""))
            {
                MessageBox.Show("Please Enter Data to the Required Fields !");
            }

            if (!(password == "") && !(cpassword == ""))
            {
                if (password == cpassword)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=MSI\SAHANSQL;Initial Catalog=DBProject;Integrated Security=True");
                    string qry = "insert into DBuser values('" + fName + "','" + lName + "','" + telephone + "','" + address + "','" + username + "','" + password + "')";
                    SqlCommand cmd = new SqlCommand(qry, con);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Submission Successful");

                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match Please Re Enter !");
                }
            }
           




        }
    }
}
