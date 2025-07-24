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


namespace _35987782_Prac_3_Makwakwa
{
    public partial class frmDVDNew : Form
    {
        // Establish connection to the SQL Server database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Music\35987782_Prac_3_Makwakwa\Database1.mdf;Integrated Security=True");
        DataTable dt; // Class-level variable to store DataTable

        public frmDVDNew()
        {
            InitializeComponent();
        }

        private void btnActionMovies_Click(object sender, EventArgs e)
        {
            try
            {
                // Filter records by movies with 'ACT' in Type field
                DataView dv = new DataView(dt);
                dv.RowFilter = "Type LIKE '%ACT%'";
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                // Filter records by Age using scrollbar value
                DataView dv = new DataView(dt);
                dv.RowFilter = "Age <= " + hScrollBar1.Value;
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmDVDNew_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView on form load
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DVDs", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable(); // Initialize the class-level DataTable
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
