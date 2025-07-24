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
    public partial class EditFrm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Music\35987782_Makwakwa_Prac4\Database1.mdf;Integrated Security=True");
        public EditFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if ProductID is empty
                if (string.IsNullOrWhiteSpace(txtProductID.Text))
                {
                    MessageBox.Show("Please enter a Product ID.");
                    return;
                }

                // Check if Price is empty or not a valid decimal
                decimal price;
                if (!decimal.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductsID, ProductName, Brand, Price) VALUES (@ProductsID, @ProductName, @Brand, @Price)", con);
                cmd.Parameters.AddWithValue("@ProductsID", txtProductID.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Price", price); // Use the parsed price
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if ProductID is empty
                if (string.IsNullOrWhiteSpace(txtProductID.Text))
                {
                    MessageBox.Show("Please enter a Product ID.");
                    return;
                }

                // Check if ProductID is not a valid integer
                int productId;
                if (!int.TryParse(txtProductID.Text, out productId))
                {
                    MessageBox.Show("Please enter a valid Product ID.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductsID = @ProductsID", con);
                cmd.Parameters.AddWithValue("@ProductsID", productId);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Product deleted successfully.");
                else
                    MessageBox.Show("Product with provided ID not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
