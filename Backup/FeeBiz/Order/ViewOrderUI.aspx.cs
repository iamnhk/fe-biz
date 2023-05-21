using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Order
{
    public partial class ViewOrderUI : System.Web.UI.Page
    {

        FeBiz.Controller OrderController = new FeBiz.Controller(); 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = (string) Session["LoginName"];

            
            if (orderGridView.Rows.Count == 0)
            {       
                msgLabel.Text = "There is no order for this company";

            }
        }

        public int getCompanyId()
        {
            string email = (string)Session["LoginEmail"];
            int companyId = OrderController.getBusinessID(email);
            return companyId;
        
        }


        protected void viewDetails(object sender, System.EventArgs e)
        {
            LinkButton salesLinkButton = (LinkButton)sender;
            int rowIndex = ((GridViewRow)(salesLinkButton.Parent.Parent)).RowIndex;
            int orderId = Convert.ToInt32(orderGridView.Rows[rowIndex].Cells[0].Text);
            Session["OrderId"] = orderId;
            Response.Redirect("../Order/ViewOrderSalesUI.aspx");

        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
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