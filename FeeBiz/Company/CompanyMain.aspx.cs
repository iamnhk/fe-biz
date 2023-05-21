using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Company
{
    public partial class CompanyMain : System.Web.UI.Page
    {
        FeBiz.Controller CompanyController = new FeBiz.Controller();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = (string) Session["LoginName"];
            Session["CompanyId"] = CompanyController.getBusinessID((string)Session["LoginEmail"]);
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
             Response.Redirect("UpdateCompany.aspx");
        }

      
    }
}