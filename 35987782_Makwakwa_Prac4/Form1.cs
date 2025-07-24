using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35987782_Makwakwa_Prac4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit");
            Application.Exit();//exit the application
        }

        private void listAndSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProductFrm viewfrm = new ViewProductFrm(); // Create new instance for the form
            viewfrm.MdiParent = this; // linking to the parent
            viewfrm.Show(); // Display child

        }

        private void insertAndDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFrm Vieweditfrm = new EditFrm();
            Vieweditfrm.MdiParent = this;
            Vieweditfrm.Show(); // Display child
        }
    }
}
