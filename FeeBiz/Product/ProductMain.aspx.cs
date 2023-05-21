using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Product
{
    public partial class ProductMain : System.Web.UI.Page
    {
       // String SelectedCommand;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLoginID.Text = (string)Session["LoginName"];
            
            if (!IsPostBack)
            {
                lblHeader.Visible = false;
                lblPID.Visible = false;
                
                cboProduct.Visible = false;
                cmdExecute.Visible = false;
                clnExpDate.Visible = false;
                lblOutput.Visible = false;
                lblNewQty.Visible = false;
                txtQty.Visible = false;
                lblActive.Visible = false;
                rdoActive.Visible = false;
            }
        }
        
        protected void cmdMPS_Click1(object sender, EventArgs e)
        {
            cboProduct.DataBind();

            if (cboProduct.Items.Count == 0)
            {
                msgLabel.Text = "There is no product";
            }
            else
            {
                lblHeader.Text = " Change Product Status ";
                msgLabel.Text = "";
                lblHeader.Visible = true;
                lblPID.Visible = true;
                cboProduct.Visible = true;
                cmdExecute.Visible = true;
                clnExpDate.Visible = false;
                lblOutput.Visible = false;
                lblNewQty.Visible = false;
                txtQty.Visible = false;
                lblActive.Visible = true;
                rdoActive.Visible = true;
                Session["SelectedCommand"] = "MPS";
            }
        }
      

        protected void cmdSSP_Click(object sender, EventArgs e)
        {
            cboProduct.DataBind();

            if (cboProduct.Items.Count == 0)
            {
                msgLabel.Text = "There is no product";
            }
            else
            {

                lblHeader.Text = " Check Product Status ";
                msgLabel.Text = "";
                lblHeader.Visible = true;
                lblPID.Visible = true;
                cboProduct.Visible = true;
                cmdExecute.Visible = true;
                clnExpDate.Visible = false;
                lblOutput.Visible = false;
                lblNewQty.Visible = false;
                txtQty.Visible = false;
                lblActive.Visible = false;
                rdoActive.Visible = false;

                Session["SelectedCommand"] = "SSP";
            }

        }

          
        protected void cmdRP_Click(object sender, EventArgs e)
        {
            cboProduct.DataBind();
            //clnExpDat

            if (cboProduct.Items.Count == 0)
            {
                msgLabel.Text = "There is no product";
            }
            else
            {
                lblHeader.Text = " Renew Product ";
                msgLabel.Text = "";
                lblHeader.Visible = true;
                lblPID.Visible = true;
                cboProduct.Visible = true;
                cmdExecute.Visible = true;
                clnExpDate.Visible = true;
                lblOutput.Visible = false;
                lblNewQty.Visible = false;
                txtQty.Visible = false;
                lblActive.Visible = false;
                rdoActive.Visible = false;

                Session["SelectedCommand"] = "RP";
            }
        }

        protected void cmdPA_Click(object sender, EventArgs e)
        {
            cboProduct.DataBind();

            if (cboProduct.Items.Count == 0)
            {
                msgLabel.Text = "There is no product";
            }
            else
            {
                lblHeader.Text = " Change Product Quantity ";
                msgLabel.Text = "";
                lblHeader.Visible = true;
                lblPID.Visible = true;
                cboProduct.Visible = true;
                cmdExecute.Visible = true;
                clnExpDate.Visible = false;
                lblOutput.Visible = false;
                lblNewQty.Visible = true;
                txtQty.Visible = true;
                lblActive.Visible = false;
                rdoActive.Visible = false;

                Session["SelectedCommand"] = "PA";
            }
        }

        protected void cmdExecute_Click(object sender, EventArgs e)
        {
                  FeBiz.Controller ProductMainController = new FeBiz.Controller();

                  if ((string)Session["SelectedCommand"] == "MPS")
                  {
                      bool chkActive = true;
                      if (rdoActive.SelectedValue == "1")
                      { chkActive = true; }
                      else 
                      { 
                          chkActive = false; 
                      }
                      ProductMainController.markProductAsActiveORInactive(int.Parse(cboProduct.SelectedValue), chkActive);
                      lblOutput.Text = "Product status has been changed";
                      lblOutput.Visible = true;
                  }
                  else if ((string)Session["SelectedCommand"] == "SSP")//Check product status
                  { 
                      bool ProductStatus;
                      ProductStatus = ProductMainController.checkProductStatus(int.Parse(cboProduct.SelectedValue));
                      if (ProductStatus == true)
                      {
                        lblOutput.Text = " Product is available ";
                        lblOutput.Visible = true;
                      }
              
                      else
                      {
                          lblOutput.Text = "Product is not available";
                          lblOutput.Visible = true;    
                      }
                  }
                  else if ((string)Session["SelectedCommand"] == "RP")//Renew product
                  {
                      DateTime dt = clnExpDate.SelectedDate;

                      if (dt.ToShortDateString() == "1.1.0001")
                      {
                          msgLabel.Text = "Please select new expiry date";
                      }
                      else
                      {
                          msgLabel.Text = "";
                          ProductMainController.renewProduct(DateTime.Today, int.Parse(cboProduct.SelectedValue), clnExpDate.SelectedDate);
                          lblOutput.Text = "Product is now renewed ";
                          lblOutput.Visible = true; 
                      }
                      
                  }
                  else if ((string)Session["SelectedCommand"] == "PA")// Product quantity
                  {
                      if (txtQty.Text == "")
                      {
                          msgLabel.Text = "Please enter new quantity";
                      }
                      else
                      {
                          msgLabel.Text = "";
                          ProductMainController.changeTotalQuantityOfProduct(int.Parse(cboProduct.SelectedValue), int.Parse(txtQty.Text));
                          lblOutput.Text = "Product Quantity is now changed";
                          lblOutput.Visible = true;
                      }
                  }

        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
                  Response.Redirect("../Main.aspx");
        }

        protected void cmdFarmerMain_Click(object sender, EventArgs e)
        {
                  Response.Redirect("../Farmer/FarmerMain.aspx");
        }

    }
}