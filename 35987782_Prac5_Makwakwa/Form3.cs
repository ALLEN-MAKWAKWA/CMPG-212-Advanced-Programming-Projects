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
    public partial class editForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\35987782_Prac5_Makwakwa\Database1.mdf;Integrated Security=True");
        public editForm()
        {
            InitializeComponent();
            viewfrm.populatecombobox(dltCOmbobox);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Stationery (ProductID, ProductName, Category, ProductPrice) VALUES (@ProductID, @ProductName, @Category, @ProductPrice)", con);

                // Add parameters
                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@ProductPrice", txtPrice.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product inserted successfully.");


            }
            catch(Exception EX)
            {
                MessageBox.Show("Error occured " + EX.Message);
            }
        }

        private void btnDeleteID_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                con.Open();

                // Define the SQL command with parameterized query
                SqlCommand cmd = new SqlCommand("DELETE FROM Stationery WHERE ProductID = @ProductID", con);

                // Add the parameter
                cmd.Parameters.AddWithValue("@ProductID", txtID.Text);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Close the connection
                con.Close();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No product found with the provided ID.");
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a category is selected
                if (dltCOmbobox.SelectedItem != null)
                {
                    // Open the connection
                    con.Open();

                    // Define the SQL command with parameterized query
                    SqlCommand cmd = new SqlCommand("DELETE FROM Stationery WHERE Category = @Category", con);

                    // Add the parameter
                    cmd.Parameters.AddWithValue("@Category", dltCOmbobox.SelectedItem.ToString());

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Close the connection
                    con.Close();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category deleted successfully.");
                        // Clear the combo box and repopulate
                        dltCOmbobox.Items.Clear();
                        viewfrm.populatecombobox(dltCOmbobox);

                        //viewfrm.populatecombobox(viewfrm.comboBox1);
                    }
                    else
                    {
                        MessageBox.Show("No products found for the selected category.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to delete.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            dltCOmbobox.Text = "Select Category";
        }
    }
}
