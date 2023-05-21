using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Farmer
{
    public partial class ViewEditFarmer : System.Web.UI.Page
    {
        FeBiz.Controller UpdateController = new FeBiz.Controller();
        FeBiz.Farmer FarmerInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginID.Text = (string)Session["LoginName"];
            if (!IsPostBack)
            {
                FarmerInfo = UpdateController.viewFarmerProfile((int)Session["FarmerID"]);
                txtEmail.Text = FarmerInfo.Email;
                txtRegistrationDate.Text = FarmerInfo.RegistrationDate.ToString();
                txtAddress1.Text = FarmerInfo.AddressLine1;
                txtAddress2.Text = FarmerInfo.AddressLine2;
                txtAccountNumber.Text = FarmerInfo.BankAccountNumber;
                txtAccountTitle.Text = FarmerInfo.BankAccountTitle;
                txtBankBranchName.Text = FarmerInfo.BankBranchName;
                txtBankName.Text = FarmerInfo.BankName;
                txtCity.Text = FarmerInfo.City;
                txtCountry.Text = FarmerInfo.Country;
                txtFax.Text = FarmerInfo.Fax;
                txtIBAN.Text = FarmerInfo.IBAN;
                txtFname.Text = FarmerInfo.Name;
                txtPhone.Text = FarmerInfo.Phone;
                txtPostalCode.Text = FarmerInfo.PostCode;
                txtSwiftBIC.Text = FarmerInfo.SwiftBIC;
            }
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {

            if (txtFname.Text == "")
                msgLabel.Text = " Please Enter Your Name";
            else if (txtAddress1.Text == "")
                msgLabel.Text = " Please Enter Address";
            else if (txtPostalCode.Text == "")
                msgLabel.Text = " Please Enter Postal Code";
            else if (txtCity.Text == "")
                msgLabel.Text = " Please Enter City";
            else if (txtCountry.Text == "")
                msgLabel.Text = " Please Enter Country";
            else if (txtPhone.Text == "")
                msgLabel.Text = " Please Enter Phone Number";
            else if (txtFax.Text == "")
                msgLabel.Text = " Please Enter Fax Number";
            else
            {
                UpdateController.editFarmerProfile(UpdateController.getBusinessID((string)Session["LoginEmail"]), txtPhone.Text, txtFax.Text, txtAddress1.Text, txtAddress2.Text, txtPostalCode.Text, txtCity.Text, txtCountry.Text, txtFname.Text, txtAccountNumber.Text, txtAccountTitle.Text, txtIBAN.Text, txtSwiftBIC.Text, txtBankName.Text, txtBankBranchName.Text);
                Response.Redirect("FarmerMain.aspx");
            }
        }


        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FarmerMain.aspx");
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }
    }
}