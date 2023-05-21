using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Order
{
    public partial class ViewOrderSalesUI : System.Web.UI.Page
    {

        FeBiz.Controller OrderController = new FeBiz.Controller(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = (string) Session["LoginName"];

            salesGridView.Visible = false;

            // Iterate through the packageGridView.Rows property 
            foreach (GridViewRow row in salesGridView.Rows)
            {
                LinkButton rateLinkButton = (LinkButton)row.FindControl("salesLinkButton");

                if (salesGridView.Rows[row.RowIndex].Cells[2].Text == "0")
                {
                    salesGridView.Rows[row.RowIndex].Cells[2].ForeColor = System.Drawing.Color.Red;
                    salesGridView.Rows[row.RowIndex].Cells[2].Text = "Not Rated";
                }
                
                if (salesGridView.Rows[row.RowIndex].Cells[3].Text == "0")
                {
                    salesGridView.Rows[row.RowIndex].Cells[3].ForeColor = System.Drawing.Color.Red;
                    salesGridView.Rows[row.RowIndex].Cells[3].Text = "Not Rated";
                }

            }

            salesGridView.Visible = true;

        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }

      

        protected void viewDetails(object sender, System.EventArgs e)
        {
            LinkButton salesLinkButton = (LinkButton)sender;
            int rowIndex = ((GridViewRow)(salesLinkButton.Parent.Parent)).RowIndex;
            int salesId = Convert.ToInt32(salesGridView.Rows[rowIndex].Cells[0].Text);
            Session["salesId"] = salesId;
            Response.Redirect("RateFarmer.aspx");
        }

        protected void cmdMakeOrder_Click1(object sender, EventArgs e)
        {
       Response.Redirect("../Order/MakeOrderUI.aspx");
        }

        protected void cmdViewOrder_Click1(object sender, EventArgs e)
        {
   Response.Redirect("../Order/ViewOrderUI.aspx");
        }

        protected void cmdViewEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Company/UpdateCompany.aspx");
        }
    }
}