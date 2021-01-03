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
    }
}
