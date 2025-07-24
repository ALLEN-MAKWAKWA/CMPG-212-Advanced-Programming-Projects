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

namespace _35987782_Prac5_Makwakwa
{
    public partial class viewfrm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\35987782_Prac5_Makwakwa\Database1.mdf;Integrated Security=True");
        public viewfrm()
        {
            InitializeComponent();
        }
        DataTable dt;


        private void viewfrm_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select Category";
            loaddata();
            populatecombobox(comboBox1);
            txtSearch.Text = "Search by Name...";
            txtSearch.ForeColor = Color.Gray;

        }
        public static void populatecombobox(ComboBox comboBox1)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\35987782_Prac5_Makwakwa\Database1.mdf;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT Category FROM Stationery", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Category"].ToString());
                    }
                    con.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void loaddata()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Stationery", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable(); 
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

                // Apply filtering based on the search criteria
                if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "Search by Name...")
                {
                    filterExpression = $"ProductName LIKE '%{txtSearch.Text}%'";

                    // Combine with existing filter if a category is selected
                    if (comboBox1.SelectedItem != null && comboBox1.Text != "Select Category")
                    {
                        filterExpression += $" AND Category = '{comboBox1.SelectedItem}'";
                    }
                }
                else
                {
                    // If no search criteria, apply only category filter if selected
                    if (comboBox1.SelectedItem != null && comboBox1.Text != "Select Category")
                    {
                        filterExpression = $"Category = '{comboBox1.SelectedItem}'";
                    }
                }

                // Apply the filter
                DataView dv = dt.DefaultView;
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            // Clear the combo box
            comboBox1.SelectedIndex = -1;

            comboBox1.Text = "Select Category"; ;

            // Load all data
            loaddata();

            // Set default search text
            txtSearch.Text = "Search by Name...";
            txtSearch.ForeColor = Color.Gray;

        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            try
            {

                DataView dv = new DataView(dt);
                string sortExpression = "Productprice ASC"; // Default sorting expression

                // If a category is selected, filter the DataView first
                if (comboBox1.SelectedItem != null && comboBox1.Text != "Select Category")
                {
                    dv.RowFilter = $"Category = '{comboBox1.SelectedItem}'";
                }

                // Apply the sort expression
                dv.Sort = sortExpression;
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnViewSale_Click(object sender, EventArgs e)
        {
            try
            {
                string filterExpression = "ProductPrice <= 25";

                // Apply filtering based on the selected category
                if (comboBox1.SelectedItem != null && comboBox1.Text != "Select Category")
                {
                    filterExpression += $" AND Category = '{comboBox1.SelectedItem}'";
                }

                // Apply the filter
                DataView dv = dt.DefaultView;
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
