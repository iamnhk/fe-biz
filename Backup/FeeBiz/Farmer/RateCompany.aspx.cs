using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Farmer
{
    public partial class RateCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginID.Text = (string)Session["LoginName"];
        }

        protected void cmdRate_Click(object sender, EventArgs e)
        {
            FeBiz.Controller UpdateController = new FeBiz.Controller();

            int saleid = (int)Session["salesId"];
            UpdateController.rateCompany(saleid, int.Parse(cboRate.SelectedValue));
Response.Redirect("ViewSales.aspx");
        }

        protected void cmdBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSales.aspx");
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }

        
    }
}