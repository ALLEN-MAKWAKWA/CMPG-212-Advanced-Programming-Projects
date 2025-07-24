using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//working with database
namespace _35987782_Prac_3_Makwakwa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //dECLARE vARIABLES
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Music\35987782_Prac_3_Makwakwa\Database1.mdf;Integrated Security=True";
        SqlCommand SqlComm;
        SqlConnection SqlConn;
        SqlDataAdapter SqlDAdapter;
        SqlDataReader DR;
        DataSet DS;

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit");
            Application.Exit();//exit the application
        }

        private void listDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDVDNew viewfrm = new frmDVDNew(); // Create new instance for the form
            viewfrm.MdiParent = this; // linking to the parent
            viewfrm.Show(); // Display child


        }
    }
}
