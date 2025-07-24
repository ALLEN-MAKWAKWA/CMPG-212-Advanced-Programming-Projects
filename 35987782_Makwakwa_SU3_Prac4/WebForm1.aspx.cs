using System;
using System.Data;
using System.Web.UI.WebControls;

namespace _35987782_Makwakwa_SU3_Prac4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label8.Visible = false;
            if (!IsPostBack)
            {
                // Add the modules to the DropDownList
                DropDownSELECTmodule.Items.Add(new ListItem("Select a module", "")); // Default message
                DropDownSELECTmodule.Items.Add(new ListItem("CMPG111", "CMPG111"));
                DropDownSELECTmodule.Items.Add(new ListItem("CMPG121", "CMPG121"));
                DropDownSELECTmodule.Items.Add(new ListItem("CMPG125", "CMPG125"));
                // Add other modules as needed

                // Set the default selection to "Select a module"
                DropDownSELECTmodule.SelectedIndex = 0;
            }
        }

        protected void BTNback_Click(object sender, EventArgs e)
        {
            if (TimeSlotRadioButtonList.SelectedIndex == -1)
            {
                Label8.Visible = true;
                Label8.Text = "Please select a time slot.";
            }
            else
            {
                Label8.Visible = false;
                Label8.Text = ""; // Clear the error message if a time slot is selected

                // Retrieve selected time slot from RadioButtonList
                string timeSlot = TimeSlotRadioButtonList.SelectedItem.Text;

                // Your existing code for handling the submission
                string name = TextName.Text;
                string surname = TextSurname.Text;
                string studID = TextStudID.Text;

                DataTable dt;
                if (ViewState["BookingDetails"] != null)
                {
                    dt = (DataTable)ViewState["BookingDetails"];
                }
                else
                {
                    dt = new DataTable();
                    dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Name"), new DataColumn("Surname"), new DataColumn("StudentID"), new DataColumn("Module"), new DataColumn("TimeSlot") });
                }
                DataRow dr = dt.NewRow();
                dr["Name"] = name;
                dr["Surname"] = surname;
                dr["StudentID"] = studID;
                dr["Module"] = DropDownSELECTmodule.SelectedValue;
                dr["TimeSlot"] = timeSlot;

                dt.Rows.Add(dr);

                ViewState["BookingDetails"] = dt;

                // Bind the DataTable to the GridView
                GridView1.DataSource = dt;
                GridView1.DataBind();

                // Clear input fields
                TextName.Text = "";
                TextSurname.Text = "";
                TextStudID.Text = "";
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void DropDownSELECTmodule_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label7.Text = "Your next session: " + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TimeSlotRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
