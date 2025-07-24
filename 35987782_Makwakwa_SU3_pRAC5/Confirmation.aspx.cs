using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _35987782_Makwakwa_SU3_pRAC5
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if query string parameters exist
                if (Request.QueryString["name"] != null && Request.QueryString["surname"] != null && Request.QueryString["sportCode"] != null)
                {
                    // Retrieve data from query string
                    string name = Request.QueryString["name"];
                    string surname = Request.QueryString["surname"];
                    string sportCode = Request.QueryString["sportCode"];

                    // Display confirmation message
                    Label2.Text = $"Hi {name} {surname}, you have successfully registered for {sportCode}. Click the calendar to view your next session.";
                }
                else
                {
                    // If query string parameters are missing, show error message
                    Label2.Text = "Error: Registration data not found.";
                }
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label3.Text = "Training session: " + Calendar1.SelectedDate.ToShortDateString()+" at 6PM";
        }
    }
}