using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FeeBiz.Order
{
    public partial class ConfirmOrderUI : System.Web.UI.Page
    {
        FeBiz.Controller OrderController = new FeBiz.Controller();
        List<FeBiz.Package> orderList = new List<FeBiz.Package>();

        int numberOfPackage = 0;
        int totalOrderedQuantity = 0;

        string email;
        string unit;
        string orderName;
        int companyId;
        int categoryId;
        int quality;
        int orderId;
        int quantity;


        protected void Page_Load(object sender, EventArgs e)
        {
            
            email = (string)Session["LoginEmail"];
          
            orderName = (string)Session["OrderName"];
            unit = (string)Session["OrderUnit"];
            categoryId = (int)Session["OrderCategory"];
            quality = (int)Session["OrderQuality"];
            quantity = (int)Session["OrderQuantity"];
            companyId = OrderController.getBusinessID(email);

            lblCompanyName.Text = (string)Session["LoginName"];
            headerLabel.Text = "Please enter desired number of packets and then confirm your order.";


            if (packageGridView.Rows.Count == 0)
            {
                confirmOrderButton.Visible = false;
                cancelButton.Visible = false;
                headerLabel.Text = "";
                msgLabel.Text = "There are no available packages for your order.";
            }

        }

        protected void cmdLogOut_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("../Main.aspx");
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Company/CompanyMain.aspx");
        }

        protected void confirmOrderButton_Click(object sender, EventArgs e)
        {

            int flag = 1;
            int rowCount = 0;

            // Iterate through the packageGridView.Rows property 
            foreach (GridViewRow row in packageGridView.Rows)
            {
                // Access the CheckBox 
                TextBox nPacket = (TextBox)row.FindControl("packetTextBox");
                FeBiz.Package objPackage = null;

                if (nPacket != null && nPacket.Text != "")
                {
                    objPackage = new FeBiz.Package();
                    rowCount++;

                    objPackage.ProductID = Convert.ToInt32(packageGridView.Rows[row.RowIndex].Cells[0].Text);
                    objPackage.ProductName = Convert.ToString(packageGridView.Rows[row.RowIndex].Cells[1].Text);
                    objPackage.OfferExpiry = Convert.ToDateTime(packageGridView.Rows[row.RowIndex].Cells[2].Text);
                    objPackage.AvailableQuantity = Convert.ToInt32(packageGridView.Rows[row.RowIndex].Cells[3].Text);
                    objPackage.PacketSize = Convert.ToInt32(packageGridView.Rows[row.RowIndex].Cells[4].Text);
                    objPackage.Price = Convert.ToDouble(packageGridView.Rows[row.RowIndex].Cells[5].Text);
                    objPackage.Quality = Convert.ToInt32(packageGridView.Rows[row.RowIndex].Cells[6].Text);
                    orderList.Add(objPackage);

                    numberOfPackage++;
                    totalOrderedQuantity += objPackage.PacketSize * objPackage.AvailableQuantity;

                    int packet = Convert.ToInt32(nPacket.Text);

                    if (packet > objPackage.AvailableQuantity)
                    {
                        msgLabel.Text = "Product No." + objPackage.ProductID + " does not have enough desired packets";
                        orderList.Clear();
                        flag = 0;
                        break;
                    }
                    else
                        objPackage.AvailableQuantity = packet;

                }
            }

            if (rowCount <= 0)
                msgLabel.Text = "You have not mentioned your desired packets";

            if (flag == 1 && rowCount > 0)
            {
                DateTime dt = DateTime.Now;
                // Create an order
                orderId = OrderController.addOrder(orderName, dt, quantity, unit, quality, categoryId, companyId);

                int nTotalRecords = orderList.Count;
                for (int i = 0; i < nTotalRecords; i++)
                {
                    int productId = orderList[i].ProductID;
                    int orderedPacket = orderList[i].AvailableQuantity;

                    OrderController.addSale(orderedPacket, 0, 0, productId, orderId);
                }

                Response.Redirect("ConfirmationUI.aspx");
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