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

namespace _35987782_Makwakwa_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //dECLARE vARIABLES
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\35987782_Makwakwa_Assignment2\Database1.mdf;Integrated Security=True";
        SqlCommand SqlComm;
        SqlConnection SqlConn;
        SqlDataAdapter SqlDAdapter;
        SqlDataReader DR;
        DataSet DS;
        

        private void bShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection(conStr);
                string query = "SELECT * FROM [Table]"; 
                SqlDAdapter = new SqlDataAdapter(query, SqlConn);
                DS = new DataSet();
                SqlDAdapter.Fill(DS);
                dataGridView.DataSource = DS.Tables[0];

                SqlConn.Close(); // Close the connection

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);//error message
            }
            

        }

        private void bMeal_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection(conStr);
                string query = "SELECT Meal Code,Price FROM [Table]"; 
                SqlDAdapter = new SqlDataAdapter(query, SqlConn);
                DS = new DataSet();
                SqlDAdapter.Fill(DS);
                dataGridView.DataSource = DS.Tables[0];

                SqlConn.Close(); // Close the connection

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);//error message

            }
            
        }

        private void bMealWiltPrice_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection(conStr);
                string query = "SELECT * FROM [Table] WHERE Meal LIKE '%Chips%'";
                SqlDAdapter = new SqlDataAdapter(query, SqlConn);
                DS = new DataSet();
                SqlDAdapter.Fill(DS);
                dataGridView.DataSource = DS.Tables[0];

                SqlConn.Close(); // Close the connection

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);

            }
            

        }

        private void bAbove150_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection(conStr);
                string query = "SELECT * FROM [Table] WHERE Price > 150"; 
                SqlDAdapter = new SqlDataAdapter(query, SqlConn);
                DS = new DataSet();
                SqlDAdapter.Fill(DS);
                dataGridView.DataSource = DS.Tables[0];

                SqlConn.Close(); // Close the connection

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);//error message
            }
            

        }

        private void bSortByPrice_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection(conStr);
                string query = "SELECT * FROM [Table] ORDER BY Price ASC"; 
                SqlDAdapter = new SqlDataAdapter(query, SqlConn);
                DS = new DataSet();
                SqlDAdapter.Fill(DS);
                dataGridView.DataSource = DS.Tables[0];

                SqlConn.Close(); // Close the connection

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);

            }
            

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit");
            Application.Exit();//exit the application

        }
    }
}
