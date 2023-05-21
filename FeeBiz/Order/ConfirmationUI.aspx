<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmationUI.aspx.cs" Inherits="FeeBiz.Order.ConfirmationUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirmation</title>
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
    <div align = "center">
    <form id="form1" runat="server" style="width: 100%">
        <table>
            <tr>
                <td class="style1" bgcolor="#FF6600" colspan="3" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; height: 75px" 
                    width="100%">
                    FeBiz: Fair e-Business 
                    . . . Company</td>
            </tr>
            <tr>
                <td class="style3" align="right" colspan="3" width="100%">
                    <strong><span class="style4">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style4" 
                        ForeColor="#000066"></asp:Label>
                    </strong>&nbsp;<asp:Button ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" 
                        Font-Names="Arial" ForeColor="Black" />
                </td>
            </tr>
            <tr>
                <td class="style3" align="left" width="100%">
                    <asp:Button ID="cmdMakeOrder" runat="server" onclick="cmdMakeOrder_Click1" 
                        Text="Make Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" ForeColor="Black" />
                    <asp:Button ID="cmdViewOrder" runat="server" onclick="cmdViewOrder_Click1" 
                        Text="View Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" ForeColor="Black" />
                    <asp:Button ID="cmdViewEditProfile" runat="server" 
                        onclick="cmdViewEditProfile_Click" Text="View / Edit Profile" 
                        BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" Font-Names="Arial" 
                        ForeColor="Black" />
                </td>
                <td class="style2" width="100%">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:Label ID="msgLabel" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="Medium"></asp:Label>
                    <br />
                </td>
                <td class="style2" rowspan="4" width="100%">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
                <td rowspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="ObjectDataSource1" Visible="False" CellPadding="4" 
                        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                                SortExpression="ProductID" />
                            <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                                SortExpression="ProductName" />
                            <asp:BoundField DataField="OfferExpiry" HeaderText="OfferExpiry" 
                                SortExpression="OfferExpiry" />
                            <asp:BoundField DataField="AvailableQuantity" HeaderText="AvailableQuantity" 
                                SortExpression="AvailableQuantity" />
                            <asp:BoundField DataField="PacketSize" HeaderText="PacketSize" 
                                SortExpression="PacketSize" />
                            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                            <asp:BoundField DataField="Quality" HeaderText="Quality" 
                                SortExpression="Quality" />
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
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="getAnOrder" TypeName="FeeBiz.Order.ConfirmationUI">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" width="100%">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
