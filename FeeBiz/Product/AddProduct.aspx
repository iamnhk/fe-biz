<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="FeeBiz.Product.AddProduct" %>

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
            text-align: left;
        }
        .style2
        {
            font-family: "Comic Sans MS";
            width: 172px;
            text-align: left;
        }
        .style3
        {
            background-color: #99CCFF;
            width: 172px;
            text-align: left;
        }
        .style4
        {
            width: 172px;
            text-align: left;
        }
        .style5
        {
            background-color: #99CCFF;
            width: 172px;
            height: 30px;
            text-align: left;
        }
        .style6
        {
            height: 30px;
        }
        .style7
        {}
        .style10
        {
            text-align: left;
        }
        .style11
        {
            height: 30px;
            text-align: left;
        }
        .style12
        {
            width: 172px;
            text-align: left;
            height: 23px;
        }
        .style13
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <div align = "center">
    <form id="form1" runat="server"> 
        <table style="width:100%;">
            <tr>
                <td class="style1" colspan="3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; height: 75px">
                    FeBiz: Fair e-Business 
                    . . . Farmer</td>
            </tr>
            <tr>
                <td class="style12">
                    </td>
                <td class="style13">
                    </td>
                <td align="right">
                <span class="style4"><strong>Hi,</strong></span>&nbsp;
                <asp:Label ID="lblLoginID" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
            &nbsp;<asp:Button ID="cmdLogout" runat="server" onclick="cmdLogout_Click" 
                    Text="Logout" style="height: 26px" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Bold="True" />
                    </td>
            </tr>
            <tr>
                <td class="style2" style="font-family: arial, Helvetica, sans-serif">
                    <strong>Add Product</strong></td>
                <td class="style7" style="font-family: arial, Helvetica, sans-serif">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4" style="font-family: arial, Helvetica, sans-serif">
                    &nbsp;</td>
                <td style="font-family: arial, Helvetica, sans-serif" align="left">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Product Name</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtProductName" runat="server" BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Offer Expiry</td>
                <td align="left" class="style10" 
                    style="font-family: arial, Helvetica, sans-serif">
                    <asp:Calendar ID="clnOfferExpiry" runat="server"></asp:Calendar>
                </td>
                <td>
                <asp:Image ID="Image1" runat="server" Height="250px" 
                    ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Total&nbsp; Quantity of Packets</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtTotalQuantity" runat="server" BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Packet Size</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="TxtPacketSize" runat="server" BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Packet Size Unit</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="cboUnit" runat="server">
                        <asp:ListItem Selected="True">KG</asp:ListItem>
                        <asp:ListItem>Liter</asp:ListItem>
                        <asp:ListItem>Pound</asp:ListItem>
                        <asp:ListItem>Count</asp:ListItem>
                        <asp:ListItem>Dozen</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Active</td>
                <td style="font-family: arial, Helvetica, sans-serif" align="left">
                    <asp:RadioButtonList ID="rdoActive" runat="server" Height="20px" Width="59px">
                        <asp:ListItem Selected="True" Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Price (€)</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtPrice" runat="server" BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Quality</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="cboQuality" runat="server">
                        <asp:ListItem Selected="True">1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;(5 : Best and 1 : Lowest)</td>
                <td class="style6">
                    </td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Type</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="cboType" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="cboType_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Sub Type</td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    <asp:DropDownList ID="cboSubType" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style10">
                    <asp:Button ID="cmdSubmit" runat="server" onclick="cmdSubmit_Click" 
                        Text="Submit" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                    <asp:Button ID="cmdCancel" runat="server" onclick="cmdCancel_Click" 
                        Text="Cancel" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
