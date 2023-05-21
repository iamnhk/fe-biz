using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Product
{
    public partial class AddCategory : System.Web.UI.Page
    {
        int CatogoryID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginID.Text = (string)Session["LoginName"];
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "")
                msgLabel.Text = " Please enter product type";
            else if (txtSubType.Text == "")
                msgLabel.Text = " Please enter product subtype";
            else
            {
                msgLabel.Text = "";
                FeBiz.Controller AddCategoryController = new FeBiz.Controller();
                AddCategoryController.addCategory(txtType.Text, txtSubType.Text);
                Response.Redirect("AddProduct.aspx");
            }
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Farmer/FarmerMain.aspx");
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }
    }
}