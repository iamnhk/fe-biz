using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Order
{
    public partial class ConfirmationUI : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            
            lblCompanyName.Text = (string) Session["LoginName"];
            msgLabel.Text = " Your order was successfully placed.";
            

        }

        public List<FeBiz.Package> getAnOrder()
        {
            List<FeBiz.Package> oL = (List<FeBiz.Package>)Session["OrderList"];
            return oL;
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