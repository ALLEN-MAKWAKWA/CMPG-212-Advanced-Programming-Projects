using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_pRAC2_Makwakwa_35987782
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LSubmited.Text = " ";
            if (!IsPostBack)
            {
                // Add the modules to the DropDownList

                
                DropDownList1.Items.Add(new ListItem("cmpg111", "cmpg111"));
                DropDownList1.Items.Add(new ListItem("cmpg121", "cmpg121"));
                DropDownList1.Items.Add(new ListItem("cmpg125", "cmpg125"));
                DropDownList1.SelectedIndex = -1;
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*String name = TXTNAME.Text;
            string surname = TXTSURNAME.Text;
            string email = TXTEMAIL.Text;
            string studid = TXTSTUDENTID.Text;
            int hours = int.Parse(TXTNUMHOURS.Text);
            string module = DropDownList1.SelectedItem.Text;
            LSubmited.Text = "submitted ";*/
            if (Page.IsValid)
            {
                // Form fields processing here
                LSubmited.Text = "Submitted";
            }

        }

        protected void TXTEMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}