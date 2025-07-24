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
namespace _35987782_Makwakwa_Prac4
{
    public partial class ViewProductFrm : Form
    {
        public ViewProductFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Music\35987782_Makwakwa_Prac4\Database1.mdf;Integrated Security=True");
        DataTable dt; // Class-level variable to store DataTable

        private void ViewProductFrm_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView on form load
            LoadData();
            PopulateBrandComboBox();
            btnSearch.BackColor = Color.Green;
            btnRefresh.BackColor = Color.Purple;

            // Set ComboBox display text
            comboBox1.Text = "Brand Name";

            // Set TextBox placeholder text
            txtSearch.Text = "Type Product Name";
            txtSearch.ForeColor = Color.Gray; // Set the color to gray

        }
        private void LoadData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string filterExpression = "";

                // Check if the user has typed anything in the search box and it's not the placeholder text
                if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "Type Product Name")
                {
                    filterExpression = $"ProductName LIKE '%{txtSearch.Text}%'";
                }

                // Check if a brand is selected in the ComboBox
                if (comboBox1.SelectedItem != null && comboBox1.Text != "Brand Name")
                {
                    // If there's already a filter expression, append "AND"
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " AND ";

                    // Append the brand filter
                    filterExpression += $"Brand = '{comboBox1.SelectedItem}'";
                }

                // Apply the filter to the DataView and rebind it to the DataGridView
                DataView dv = dt.DefaultView;
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

            txtSearch.Text = "Type Product Name";
            txtSearch.ForeColor = Color.Gray;
            comboBox1.Text = "Brand Name";

        }
        private void PopulateBrandComboBox()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Brand FROM Products", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Brand"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Type Product Name")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black; // Change text color to black when typing
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Type Product Name";
                txtSearch.ForeColor = Color.Gray; // Change text color to gray when not typing
            }
        }

    }
}
