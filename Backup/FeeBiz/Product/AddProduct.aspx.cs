using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace FeeBiz.Product
{
    public partial class AddProduct : System.Web.UI.Page
    {
        FeBiz.Controller AddProductController = new FeBiz.Controller();
        int ProductID;
        List<string> TypeString, subTypeString;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginID.Text = (string)Session["LoginName"];
            if (!IsPostBack)
            {

                TypeString = AddProductController.getAllUniqueCategoryTypes();
                for (int i = 0; i < TypeString.Count; i++)
                {
                    cboType.Items.Add(TypeString.ElementAt(i));
                }

                cboType.SelectedIndex = 1;

                subTypeString = AddProductController.getAllSubTypesOfAType(cboType.SelectedValue);
                for (int i = 0; i < subTypeString.Count; i++)
                {
                    cboSubType.Items.Add(subTypeString.ElementAt(i));
                }
            }
                
        }

        public bool isPositiveNunmber(string value)
        {

            Regex objNotPositive = new Regex("[^0-9]");
            return !objNotPositive.IsMatch(value);

        }

        public bool isCurrency(string value)
        {

           // Regex objNotPositive = new Regex("[^\\d+(\\.\\d\\d)?$]");
            Regex objNotPositive = new Regex("^(\\+)?\\d+(\\.\\d+)?$");
           // Regex objNotPositive = new Regex("[^[^0-9\\.]*]");
            return objNotPositive.IsMatch(value);

        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Farmer/FarmerMain.aspx");
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            DateTime dt = clnOfferExpiry.SelectedDate;
            msgLabel.Text = dt.ToShortDateString();

            if (txtPrice.Text == "" || !isCurrency(txtPrice.Text))
                msgLabel.Text = " Please enter valid price";
            else

                msgLabel.Text = "valid price";
           /* if (txtProductName.Text == "")
                msgLabel.Text = " Please enter product name";
            else if (dt.ToShortDateString() == "1.1.0001")
                msgLabel.Text = " Please select a date";
            else if (txtTotalQuantity.Text == "" || !isPositiveNunmber(txtTotalQuantity.Text))
                msgLabel.Text = " Please enter numaric quantity";
            else if (TxtPacketSize.Text == "" || !isPositiveNunmber(TxtPacketSize.Text))
                msgLabel.Text = " Please enter numeric packet size";
            else if (txtPrice.Text == "" || !isPositiveNunmber(txtPrice.Text))
                msgLabel.Text = " Please enter valid price";
            else
            {

                bool chkActive = true;
                if (rdoActive.SelectedValue == "1")
                { chkActive = true; }
                else { chkActive = false; }

                ProductID = AddProductController.addProduct(txtProductName.Text, clnOfferExpiry.SelectedDate, int.Parse(txtTotalQuantity.Text), int.Parse(TxtPacketSize.Text),
               cboUnit.SelectedValue, chkActive, int.Parse(txtPrice.Text), int.Parse(cboQuality.SelectedValue), DateTime.Today, AddProductController.getCategroyID(cboType.SelectedValue, cboSubType.SelectedValue), (int)Session["FarmerID"]);

                Response.Redirect("../Farmer/FarmerMain.aspx");
            }*/

            /*AddProductController.addProduct(233, txtProductName.Text, clnOfferExpiry.SelectedDate, int.Parse(txtQuantity.Text), int.Parse(TxtPacketSize.Text), 
            txtPacketSizeUnit.Text, chkActive , int.Parse(txtPrice.Text), int.Parse(txtQuantity.Text), DateTime.Today , int.Parse(txtCategory.Text), txtType.Text, txtSubType.Text, 9999);
        */
        
        
        }

      
        protected void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSubType.Items.Clear();
            subTypeString = AddProductController.getAllSubTypesOfAType(cboType.SelectedValue);

            for (int i = 0; i < subTypeString.Count; i++)
            {
                cboSubType.Items.Add(subTypeString.ElementAt(i));
            }
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }

    
    }
}