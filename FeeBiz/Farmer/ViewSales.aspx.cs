using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Farmer
{
    public partial class ViewSales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            msgLabel.Text = "";
            lblLoginID.Text = (string)Session["LoginName"];
            if (!IsPostBack)
            {
                cboProduct.DataBind();
                cboProduct.SelectedIndex = 0;
                if (cboProduct.Items.Count == 0)
                {
                    msgLabel.Text = "There is no product to view sales ";
                    cboProduct.Visible = false;
                    Label1.Visible = false;
                }
                else
                {
                    GridView1.DataBind();
                    if (GridView1.Rows.Count == 0)
                    {
                        msgLabel.Text = "There is no available sale for your selected product";
                    }
                    GridView1.Visible = true;
                }
            }
           
        }

        protected void cmdBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FarmerMain.aspx");
        }

        protected void viewDetails(object sender, System.EventArgs e)
        {
            LinkButton salesLinkButton = (LinkButton)sender;
            int rowIndex = ((GridViewRow)(salesLinkButton.Parent.Parent)).RowIndex;
            int salesId = Convert.ToInt32(GridView1.Rows[rowIndex].Cells[0].Text);

            Session["salesId"] = salesId;
            Response.Redirect("RateCompany.aspx");
        }


        protected void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataBind();
            if (GridView1.Rows.Count == 0)
            {
                msgLabel.Text = "There is no available sale for your selected product";
            }
            GridView1.Visible = true; 

        }

        protected void ratingCompany(object sender, GridViewRowEventArgs e)
        {
            // Iterate through the packageGridView.Rows property 
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (GridView1.Rows[row.RowIndex].Cells[2].Text == "0")
                {
                    GridView1.Rows[row.RowIndex].Cells[2].ForeColor = System.Drawing.Color.Red;
                    GridView1.Rows[row.RowIndex].Cells[2].Text = "Not Rated";
                }
                if (GridView1.Rows[row.RowIndex].Cells[3].Text == "0")
                {
                    GridView1.Rows[row.RowIndex].Cells[3].ForeColor = System.Drawing.Color.Red;
                    GridView1.Rows[row.RowIndex].Cells[3].Text = "Not Rated";
                }

            }

            GridView1.Visible = true; 
        }

        protected void cmdLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Main.aspx");
        }

      
    }
}