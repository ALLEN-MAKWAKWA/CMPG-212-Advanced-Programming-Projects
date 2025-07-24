using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35987782_Prac5_Makwakwa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stationeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewfrm ViewStionery = new viewfrm();
            ViewStionery.MdiParent = this;
            ViewStionery.Show();
        }

        private void editProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editForm viewedit = new editForm();

            viewedit.MdiParent = this;
            viewedit.Show();
            //viewedit.ShowDialog();
        }
    }
}
