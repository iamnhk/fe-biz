using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Farmer
{
    public partial class FarmerMain : System.Web.UI.Page
    {
        FeBiz.Controller ViewProductsController = new FeBiz.Controller();
        List<FeBiz.Product> FarmerProducts;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginID.Text = (string) Session["LoginName"];
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }

        protected void cmdProducts_Click(object sender, EventArgs e)
        {
         Response.Redirect("../Product/ProductMain.aspx");
          
        }

        protected void cmdViewProduct_Click(object sender, EventArgs e)
        {
            //FarmerProducts = ViewProductsController.getAllProductsOfAFarmer(ViewProductsController.getBusinessID((string)Session["LoginEmail"]));

          //  GridProducts.DataSource = FarmerProducts;
            if (GridProducts.Rows.Count == 0)
            {
                msgLabel.Text = "There are no products available.";
            }
            else
            {
                msgLabel.Text = "";
                GridProducts.Visible = true;
                cmdRefresh.Visible = true;
            }

        }

        protected void cmdAddProducts_Click(object sender, EventArgs e)
        {
          Response.Redirect("../Product/AddProduct.aspx");
        }

        protected void cmdViewEditProfile_Click(object sender, EventArgs e)
        {
          Response.Redirect("ViewEditFarmer.aspx");
           
        }

        protected void GridProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Session["ProductID"] = (int) GridProducts.SelectedValue;
        
        }

        protected void cmdAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Product/AddCategory.aspx");
        }

        protected void cbdViewsales_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSales.aspx");
        }

        protected void cmdRefresh_Click(object sender, EventArgs e)
        {
            ViewProductObject.Update();
            
            
        }
     
    }
}