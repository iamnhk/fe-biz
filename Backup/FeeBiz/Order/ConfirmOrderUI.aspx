<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmOrderUI.aspx.cs" Inherits="FeeBiz.Order.ConfirmOrderUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Order</title>
    <style type="text/css">
        .style1
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
        }
        .style2
        {
            width: 132px;
        }
        .style3
        {
            width: 997px;
        }
        .style4
        {
            height: 24px;
        }
        .style7
        {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <div align = "center">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="style1" bgcolor="#FF6600" colspan="3" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; height: 75px">
                    FeBiz: Fair e-Business 
                    . . . Company</td>
            </tr>
            <tr>
                <td class="style4" align="right" colspan="3">
                    <strong><span class="style7">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style7" 
                        ForeColor="#000066"></asp:Label>
                    </strong>&nbsp;<asp:Button ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                    </td>
            </tr>
            <tr>
                <td class="style3" align="left">
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
                <td class="style2" align="left">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif; " 
                    align="left">
                    <asp:Label ID="headerLabel" runat="server"></asp:Label>
                </td>
                <td class="style2" rowspan="4">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
                <td rowspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; " align="center" 
                    valign="top">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Bold="True" 
                        Font-Names="Arial" Font-Size="Medium"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:GridView ID="packageGridView" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="PackageDataSource" CellPadding="4" BackColor="White" 
                        BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="Product ID" 
                                SortExpression="ProductID" />
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name" 
                                SortExpression="ProductName" />
                            <asp:BoundField DataField="OfferExpiry" DataFormatString="{0:d}" 
                                HeaderText="Offer Expiry" SortExpression="OfferExpiry" />
                            <asp:BoundField DataField="AvailableQuantity" HeaderText="Available Packets" 
                                SortExpression="AvailableQuantity" />
                            <asp:BoundField DataField="PacketSize" HeaderText="Packet Size" 
                                SortExpression="PacketSize" />
                            <asp:BoundField DataField="Price" HeaderText="Unit Price" 
                                SortExpression="Price" />
                            <asp:BoundField DataField="Quality" HeaderText="Quality" 
                                SortExpression="Quality" />
                            <asp:TemplateField HeaderText="Desired Packets">
                                <ItemTemplate>
                                    <asp:TextBox ID="packetTextBox" runat="server"></asp:TextBox>
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
                    <asp:ObjectDataSource ID="PackageDataSource" runat="server" 
                        SelectMethod="getAllPackagesForAnOrder" TypeName="FeBiz.Controller">
                        <SelectParameters>
                            <asp:SessionParameter Name="categoryID" SessionField="OrderCategory" 
                                Type="Int32" />
                            <asp:SessionParameter DefaultValue="" Name="unit" SessionField="OrderUnit" 
                                Type="String" />
                            <asp:SessionParameter DefaultValue="" Name="minimumQuality" 
                                SessionField="OrderQuality" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="style3" align="center">
                    <asp:Button ID="confirmOrderButton" runat="server" Text="Confirm Order" 
                        onclick="confirmOrderButton_Click" BackColor="#FF9900" 
                        BorderColor="#FF9900" Font-Bold="True" />
                    <asp:Button ID="cancelButton" runat="server" Text="Cancel" 
                        onclick="cancelButton_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" />
                </td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
