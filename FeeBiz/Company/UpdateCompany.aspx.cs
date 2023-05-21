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
    public partial class UpdateCompany : System.Web.UI.Page
    {
        FeBiz.Controller UpdateController = new FeBiz.Controller();
        FeBiz.Company CompanyInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = (string)Session["LoginName"];
            if (!IsPostBack)
            {
                CompanyInfo = UpdateController.viewCompanyProfile((int)Session["CompanyID"]);

                txtAddress1.Text = CompanyInfo.AddressLine1;
                txtAddress2.Text = CompanyInfo.AddressLine2;
                txtBranch.Text = CompanyInfo.BranchName;
                txtCity.Text = CompanyInfo.City;
                txtCompanyName.Text = CompanyInfo.CompanyName;
                txtFname.Text = CompanyInfo.ContactPersonName;
                txtCountry.Text = CompanyInfo.Country;
                txtFax.Text = CompanyInfo.Fax;
                txtPhone.Text = CompanyInfo.Phone;
                txtPostalCode.Text = CompanyInfo.PostCode;
            }
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

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyMain.aspx");
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
                msgLabel.Text = " Please Enter Your Name";
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
                UpdateController.editCompanyProfile((int)Session["CompanyID"], txtPhone.Text, txtFax.Text, txtAddress1.Text, txtAddress2.Text, txtPostalCode.Text, txtCity.Text, txtCountry.Text, txtCompanyName.Text, txtFname.Text, txtBranch.Text);
                Response.Redirect("CompanyMain.aspx");
            }
        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }
    }
}