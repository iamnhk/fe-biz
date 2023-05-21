<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSales.aspx.cs" Inherits="FeeBiz.Farmer.ViewSales" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #99CCFF;
        }
        .style3
        {
            font-family: "Comic Sans MS";
            font-size: large;
            }
        .style7
        {
            font-family: "Comic Sans MS";
            font-size: large;
            }
        .style8
        {
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
        }
        .style9
        {
            width: 694px;
        }
        </style>
</head>
<body>
    <div >
    <form id="form1" runat="server">
     <table style="width:100%;">
            <tr>
                <td class="style1" colspan="4" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; height: 75px;">
                    FeBiz - Fair e-Business 
                    . . . Farmer</td>
            </tr>
            <tr>
                <td class="style9" align="left">
                    <asp:Button ID="cmdBack" runat="server" onclick="cmdBack_Click" 
                        Text="Back to Farmer Main Page" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Names="Arial" ForeColor="Black" Font-Bold="True" />
                </td>
                <td class="style3" align="right" colspan="2" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                <span class="style4"><strong>Hi,</strong></span>&nbsp;
                <asp:Label ID="lblLoginID" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
            &nbsp;<asp:Button ID="cmdLogout" runat="server" onclick="cmdLogout_Click" 
                    Text="Logout" style="height: 26px" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Bold="True" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7" colspan="4" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2" align="left" valign="top">
                    <asp:Label ID="Label1" runat="server" 
                        Text="Select a product to view its sales." Font-Names="Arial" 
                        Font-Size="Medium"></asp:Label>
                    <asp:DropDownList ID="cboProduct" runat="server" 
                        DataSourceID="ProductListObject" DataTextField="Name" 
                        DataValueField="ProductID" AutoPostBack="True" 
                        onselectedindexchanged="cboProduct_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ProductListObject" runat="server" 
                        SelectMethod="getAllProductsOfAFarmer" TypeName="FeBiz.Controller">
                        <SelectParameters>
                            <asp:SessionParameter Name="farmerID" SessionField="FarmerID" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="FarmerProductSales" CellPadding="4" BackColor="White" 
                        BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                        onrowdatabound="ratingCompany">
                        <Columns>
                            <asp:BoundField DataField="SaleID" HeaderText="SaleID" 
                                SortExpression="SaleID" />
                            <asp:BoundField DataField="NumberOfPackets" HeaderText="NumberOfPackets" 
                                SortExpression="NumberOfPackets" />
                            <asp:BoundField DataField="FarmerToCompanyRating" 
                                HeaderText="FarmerToCompanyRating" SortExpression="FarmerToCompanyRating" />
                            <asp:BoundField DataField="CompanyToFarmerRating" 
                                HeaderText="CompanyToFarmerRating" SortExpression="CompanyToFarmerRating" />
                       
                        <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="salesLinkButton" runat="server" OnClick="viewDetails">Rate Company</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                       
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003366" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="FarmerProductSales" runat="server" 
                        SelectMethod="getAllSalesOfAProduct" TypeName="FeBiz.Controller">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="cboProduct" Name="productID" 
                                PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Names="Arial" 
                        Font-Size="Medium"></asp:Label>
                </td>
                <td align="right">
                    <asp:Image ID="Image1" runat="server" Height="250px" 
                        ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    </div>
  </body>
</html>