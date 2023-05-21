<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeOrderUI.aspx.cs" Inherits="FeeBiz.Order.MakeOrderUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Place Order</title>
    <style type="text/css">
        .style1
        {
            width: 2452px;
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
        .style5
        {
            width: 132px;
            height: 100px;
        }
        .style6
        {
            height: 100px;
        }
        .style7
        {
            height: 41px;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
        }
        .style10
        {
            width: 469px;
        }
        .style12
        {
            width: 135px;
        }
    </style>


</head>
<body>
    <div align = "center">
    <form id="form1" runat="server">
        <table width="100%">
            <tr>
                <td class="style1" bgcolor="Maroon" colspan="5" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; height: 75px;">
                    FeBiz: Fair e-Business 
                    . . . Company</td>
            </tr>
            <tr>
                <td class="style3" colspan="5" align="right">
                    <strong><span class="style9">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style9" 
                        ForeColor="#000066"></asp:Label>
                    </strong>&nbsp;<asp:Button ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2" align="left">
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
                <td class="style2" colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7" align="left" colspan="2" 
                    style="font-family: arial, Helvetica, sans-serif; ">
                    Please select your preferences for placing an order.</td>
                <td class="style5" rowspan="9" align="right">
                    &nbsp;</td>
                <td class="style5" rowspan="9" align="right">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
                <td class="style6" rowspan="9">
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    </td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Bold="True" 
                        Font-Size="Small"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" bgcolor="Maroon" 
                    style="font-family: arial, Helvetica, sans-serif; color: #FFFFFF;">
                    Order Name</td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="orderNameTextBox" runat="server" BorderColor="Maroon" 
                        ForeColor="Black"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" bgcolor="Maroon" 
                    style="font-family: arial, Helvetica, sans-serif; color: #FFFFFF;">
                    Product Type</td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="productTypeDropDownList" runat="server" 
                        onselectedindexchanged="productTypeDropDownList_SelectedIndexChanged" 
                        AutoPostBack="True" ForeColor="Black">
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" bgcolor="Maroon" 
                    style="font-family: arial, Helvetica, sans-serif; color: #FFFFFF;">
                    Product Sub Type</td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="subTypeDropDownList" runat="server" ForeColor="Black">
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" bgcolor="Maroon" 
                    style="font-family: arial, Helvetica, sans-serif; color: #FFFFFF;">
                    Product Unit</td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="productUnitDropDownList" runat="server" ForeColor="Black">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>KG</asp:ListItem>
                        <asp:ListItem>Liter</asp:ListItem>
                        <asp:ListItem>Pound</asp:ListItem>
                        <asp:ListItem>Count</asp:ListItem>
                        <asp:ListItem>Dozen</asp:ListItem>
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" bgcolor="Maroon" 
                    style="font-family: arial, Helvetica, sans-serif; color: #FFFFFF;">
                    Minimum Quality</td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="qualityDropDownList" runat="server" ForeColor="Black">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    </td>
                <td class="style10" align="left" 
                    style="font-family: arial, Helvetica, sans-serif">
                    </td>
            </tr>
            <tr>
                <td class="style12" align="left">
                    </td>
                <td class="style10" align="left">
                    <asp:Button ID="placeOrderButton" runat="server" Text="Search Products" 
                        onclick="placeOrderButton_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" />
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
