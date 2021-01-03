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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string con2 = @"Data Source=MSI\SAHANSQL;Initial Catalog=DBProject;Integrated Security=True";
            string qry2 = "select * from borrower ";

            SqlDataAdapter da1 = new SqlDataAdapter(qry2,con2);
            DataSet ds1 = new DataSet();

            da1.Fill(ds1,"borrower");
            datagridBorrower.DataSource = ds1.Tables["borrower"];

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterBorrower fr = new frmRegisterBorrower();
            this.Hide();
            fr.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteBorrower fdb = new frmDeleteBorrower();
            this.Hide();
            fdb.Show();
        }

        private void btnExitHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
