using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Order
{
    public partial class RateFarmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = (string)Session["LoginName"];
        }

        protected void cmdRate_Click(object sender, EventArgs e)
        {
             FeBiz.Controller UpdateController = new FeBiz.Controller();

            int saleid = (int)Session["salesId"];                  
            UpdateController.rateFarmer(saleid, int.Parse(cboRate.SelectedValue));
            Response.Redirect("ViewOrderSalesUI.aspx");
        }

        protected void cmdBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewOrderSalesUI.aspx");
        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }
        }
    }
