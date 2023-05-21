using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace FeeBiz.Order
{
    public partial class MakeOrderUI : System.Web.UI.Page
    {

        FeBiz.Controller OrderController = new FeBiz.Controller(); 
        private List<String> CategoryList = new List<string>();
        private List<String> SubCategoryList = new List<string>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = (string) Session["LoginName"];

            if (!IsPostBack)
            {
                CategoryList = OrderController.getAllUniqueCategoryTypes();
                productTypeDropDownList.Items.Add("Select");
                subTypeDropDownList.Items.Add("Select");

                int nTotalRecords = CategoryList.Count;
                for (int i = 0; i < nTotalRecords; i++)
                {
                    productTypeDropDownList.Items.Add(CategoryList[i]);
                }
            }
        }


        public bool isPositiveNunmber(string value)
        {

            Regex objNotPositive = new Regex("[^0-9]");
            return !objNotPositive.IsMatch(value);

        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }

   

        protected void productTypeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String type = productTypeDropDownList.Text;
            SubCategoryList = OrderController.getAllSubTypesOfAType(type);

            subTypeDropDownList.Items.Clear();
            subTypeDropDownList.Items.Add("Select");

            int nTotalRecords = SubCategoryList.Count;
            for (int i = 0; i < nTotalRecords; i++)
            {
                subTypeDropDownList.Items.Add(SubCategoryList[i]);
            }
           
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("../Company/CompanyMain.aspx");
        }

        protected void placeOrderButton_Click(object sender, EventArgs e)
        {

            if (orderNameTextBox.Text == "")
                msgLabel.Text = " Please enter order name";
            else if (productTypeDropDownList.Text == "Select")
                msgLabel.Text = " Please select a  Tyte";
            else if (subTypeDropDownList.Text == "Select")
                msgLabel.Text = " Please select a Subtype";
            else if (productUnitDropDownList.Text == "Select")
                msgLabel.Text = " Please select product unit";
            else if (qualityDropDownList.Text == "Select")
                msgLabel.Text = " Please select minimum product quality";
            else
            {
                //int quantity = Convert.ToInt32(quantityTextBox.Text);
                int categoryId = OrderController.getCategroyID(productTypeDropDownList.Text, subTypeDropDownList.Text);
                int quality = Convert.ToInt32(qualityDropDownList.Text);
                
                Session["OrderName"] = (string)orderNameTextBox.Text;
                Session["OrderUnit"] = (string)productUnitDropDownList.Text;
                Session["OrderCategory"] = categoryId;
                Session["OrderQuality"] = quality;
                Session["OrderQuantity"] = 0;

                Response.Redirect("ConfirmOrderUI.aspx");

            }
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