using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace act1_SU3_Makwakwa_359877782
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            groceryList.Items.Add(textItems.Text);
        }

        protected void groceryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groceryList.SelectedIndex != -1)
            {
                int SelectedIndex = groceryList.SelectedIndex;
                string removedItem = groceryList.Items[SelectedIndex].Text;
                groceryList.Items.RemoveAt(SelectedIndex);
                lblMessage.Text = $"{texName.Text}, {removedItem } removed from the list";

            }
            texName.Text = "";
            textItems.Text = "";
        }

        protected void texName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}