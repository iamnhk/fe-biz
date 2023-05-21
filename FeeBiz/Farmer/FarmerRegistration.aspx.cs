using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data;
using System.Text.RegularExpressions;

namespace FeeBiz.Farmer
{
    public partial class FarmerRegistration : System.Web.UI.Page
    {
        int FarmerID;
        String VerificationCode = "GF5CR3L4YT";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static bool isEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {

            FeBiz.Controller FarmerController = new FeBiz.Controller();

            if (txtFname.Text == "")
                msgLabel.Text = " Please Enter Your Name";
            else if (txtEmail.Text == "" || !isEmail(txtEmail.Text))
                msgLabel.Text = " Please Enter a Valid E-Mail";
            else if (txtPassword.Text == "")
                msgLabel.Text = " Please Enter Password";
            else if (txtAddress1.Text == "")
                msgLabel.Text = " Please Enter Address";
            else if (txtPostalCode.Text == "")
                msgLabel.Text = " Please Enter Postal Code";
            else if (txtCity.Text == "")
                msgLabel.Text = " Please Enter City";
            else if (txtComtry.Text == "")
                msgLabel.Text = " Please Enter Country";
            else if (txtPhone.Text == "")
                msgLabel.Text = " Please Enter Phone Number";
            else if (txtFax.Text == "")
                msgLabel.Text = " Please Enter Fax Number";
            else
            {
                FarmerID = FarmerController.addFarmer(txtPhone.Text, txtFax.Text, txtEmail.Text, txtPassword.Text, DateTime.Now, true,
                txtAddress1.Text, txtAddress2.Text, txtPostalCode.Text, txtCity.Text, txtComtry.Text, VerificationCode, txtFname.Text,
                txtAccountNumber.Text, txtAccountTitle.Text, txtIBAN.Text, txtSwiftBIC.Text, txtBankName.Text, txtBankBranchName.Text);

                Session["FarmerID"] = FarmerID;
                Session["LoginEmail"] = txtEmail.Text;
                Session["LoginName"] = txtFname.Text;

                Response.Redirect("FarmerMain.aspx");
            }
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
           
            
            Response.Redirect("../Main.aspx");
        }
    }
}