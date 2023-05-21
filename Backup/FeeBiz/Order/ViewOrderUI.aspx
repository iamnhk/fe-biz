<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrderUI.aspx.cs" Inherits="FeeBiz.Order.ViewOrderUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Order</title>
    <style type="text/css">
        .style1
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: #FFFFFF;
            background-color: maroon;
        }
        .style2
        {
        }
        .style3
        {
            width: 997px;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
        }
       
        .style5
        {
            width: 132px;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style6
        {
            font-family: Arial, Helvetica, sans-serif;
            text-align: right;
        }
       
    </style>
</head>
<body>
    <div>
    <form id="form1" runat="server">
        <table width="100%">
            <tr>
                <td class="style1" colspan="3" style="height: 75px;" width="100%">
                    FeBiz: Fair e-Business 
                    . . . Company</td>
            </tr>
            <tr>
                <td class="style6" colspan="3" width="100%">
                    <strong><span class="style4">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style4" 
                        ForeColor="#000066"></asp:Label>
                    </strong>
                    <asp:Button ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:Button ID="cmdMakeOrder" runat="server" onclick="cmdMakeOrder_Click1" 
                        Text="Make Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        CssClass="style4" Font-Bold="True" />
                    <asp:Button ID="cmdViewOrder" runat="server" onclick="cmdViewOrder_Click1" 
                        Text="View Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        CssClass="style4" Font-Bold="True" />
                    <asp:Button ID="cmdViewEditProfile" runat="server" 
                        onclick="cmdViewEditProfile_Click" Text="View / Edit Profile" 
                        BackColor="#FF9900" BorderColor="#FF9900" CssClass="style4" Font-Bold="True" />
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" CssClass="style4" 
                        Font-Bold="True" Font-Size="Medium" Font-Names="Arial"></asp:Label>
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:GridView ID="orderGridView" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="OrderDataSource" CellPadding="4" BackColor="White" 
                        BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CssClass="style4">
                        <Columns>
                            <asp:BoundField DataField="OrderID" HeaderText="Order ID" 
                                SortExpression="OrderID" />
                            <asp:BoundField DataField="OrderName" HeaderText="Order Name" 
                                SortExpression="OrderName" />
                            <asp:BoundField DataField="OrderDate" DataFormatString="{0:d}" 
                                HeaderText="Order Date" SortExpression="OrderDate" />
                            <asp:BoundField DataField="QuantityOrdered" HeaderText="Quantity Ordered" 
                                SortExpression="QuantityOrdered" Visible="False" />
                            <asp:BoundField DataField="Unit" HeaderText="Unit" SortExpression="Unit" />
                            <asp:BoundField DataField="MinimumQuality" HeaderText="Minimum Quality" 
                                SortExpression="MinimumQuality" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="salesLinkButton" runat="server" OnClick="viewDetails">View Details</asp:LinkButton>
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
                    <asp:ObjectDataSource ID="OrderDataSource" runat="server" 
                        SelectMethod="getAllOrdersOfACompany" TypeName="FeBiz.Controller">
                        <SelectParameters>
                            <asp:SessionParameter DefaultValue="" Name="companyID" SessionField="CompanyId" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
