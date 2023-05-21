<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrderSalesUI.aspx.cs" Inherits="FeeBiz.Order.ViewOrderSalesUI" %>

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
        }
        .style2
        {
        }
        .style3
        {
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <div>
    <form id="form1" runat="server">
        <table width="100%">
            <tr>
                <td class="style1" bgcolor="#FF6600" colspan="3" 
                    
                    style="background-color: maroon; height: 75px; font-family: arial, Helvetica, sans-serif;" 
                    width="100%">
                    FeBiz: Fair e-Business 
                    . . . Company</td>
            </tr>
            <tr>
                <td class="style3" align="right" colspan="3" width="100%">
                    <strong><span class="style4">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style4" 
                        ForeColor="#000066"></asp:Label>
                    </strong><span class="style4"><strong>&nbsp;</strong></span><asp:Button 
                        ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:Button ID="cmdMakeOrder" runat="server" onclick="cmdMakeOrder_Click1" 
                        Text="Make Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" />
                    <asp:Button ID="cmdViewOrder" runat="server" onclick="cmdViewOrder_Click1" 
                        Text="View Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" />
                    <asp:Button ID="cmdViewEditProfile" runat="server" 
                        onclick="cmdViewEditProfile_Click" Text="View / Edit Profile" 
                        BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Bold="True" 
                        Font-Size="Medium" Font-Names="Arial"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:GridView ID="salesGridView" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="orderSalesDataSource" CellPadding="4" BackColor="White" 
                        BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
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
                                    <asp:LinkButton ID="salesLinkButton" runat="server" OnClick="viewDetails">Rate Farmer</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="orderSalesDataSource" runat="server" 
                        SelectMethod="getAllSalesInAnOrder" TypeName="FeBiz.Controller" 
                        OldValuesParameterFormatString="original_{0}">
                        <SelectParameters>
                            <asp:SessionParameter Name="orderID" SessionField="OrderId" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td class="style2">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
