using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
