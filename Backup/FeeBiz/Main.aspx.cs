using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblLoginFail.Visible = false;
            }
        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            string LoginRole;

            FeBiz.Controller LoginController = new FeBiz.Controller();

            LoginRole = LoginController.login(txtUserID.Text, txtPassword.Text);
            
            Session["LoginEmail"] = txtUserID.Text;
            Session["LoginName"] = LoginController.getFarmerOrCompanyName(txtUserID.Text);

            if (LoginRole == "Farmer" ) 
            {   Session["FarmerID"] = LoginController.getBusinessID(txtUserID.Text);
                Response.Redirect("Farmer/FarmerMain.aspx");
            }

            else if (LoginRole == "Company")
            { Session["CompanyID"] = LoginController.getBusinessID(txtUserID.Text);
                Response.Redirect("Company/CompanyMain.aspx");
            }
            else
            { lblLoginFail.Visible = true; }
        }

        protected void cmdFarmerRegistration_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Farmer/FarmerRegistration.aspx");
        }

        protected void cmdCompanyRegistration_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Company/CompanyRegistration.aspx");
        }
    }
}