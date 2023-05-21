using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;


namespace FeeBiz.Company 
{ 
    public partial class CompanyRegistration : System.Web.UI.Page
    {
        int CompanyID;
        String VerificationCode = "H4KD8F7RH4";

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

            if (txtFname.Text == "")
                msgLabel.Text = " Please Enter Your Name";
            else if (TxtEmail.Text == "" || !isEmail(TxtEmail.Text))
                msgLabel.Text = " Please Enter a Valid E-Mail";
            else if (txtPassword.Text == "")
                msgLabel.Text = " Please Enter Password";
            else if (txtCompanyName.Text == "")
                msgLabel.Text = " Please Enter Company Name";
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
                FeBiz.Controller CompanyController = new FeBiz.Controller();

                CompanyID = CompanyController.addCompany(txtPhone.Text, txtFax.Text, TxtEmail.Text, txtPassword.Text, DateTime.Now,
                true, txtAddress1.Text, txtAddress2.Text, txtPostalCode.Text, txtCity.Text, txtCountry.Text, VerificationCode,
                txtCompanyName.Text, txtFname.Text, txtBranch.Text);

                Session["CompanyID"] = CompanyID;
                Session["LoginName"] = txtCompanyName.Text;
                Session["LoginEmail"] = TxtEmail.Text;
                Response.Redirect("CompanyMain.aspx");

                Response.Redirect("CompanyMain.aspx");
            }
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }


    }
}