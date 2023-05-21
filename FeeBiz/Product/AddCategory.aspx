<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="FeeBiz.Product.AddCategory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            font-family: "Comic Sans MS";
            font-size: large;
            text-align: left;
        }
        .style3
        {
            width: 87px;
            text-align: left;
        }
        .style4
        {
            width: 59px;
        }
        .style5
        {
            text-align: left;
        }
        .style1
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
        }
        </style>
</head>
<body>
    <div align = "center">
    <form id="form1" runat="server">
      <table style="width:100%;">
            <tr>
            <td class="style1" bgcolor="#003366" colspan="3" align="left" 
                style="font-family: arial, Helvetica, sans-serif; background-color: #003366; height: 75px;">
                FeBiz: Fair e-Business 
                . . . Farmer</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td align="right" colspan="2" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                <span class="style4"><strong>Hi,</strong></span>&nbsp;
                <asp:Label ID="lblLoginID" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
            &nbsp;<asp:Button ID="cmdLogout" runat="server" onclick="cmdLogout_Click" 
                    Text="Logout" style="height: 26px" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="3" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium;">
                    <strong>Add Category</strong></td>
            </tr>
            <tr>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    &nbsp;</td>
                <td class="style5" style="font-family: arial, Helvetica, sans-serif">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="style4" rowspan="9">
                <asp:Image ID="Image1" runat="server" Height="250px" 
                    ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
            </tr>
            <tr>
                <td class="style3" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Type</td>
                <td class="style5" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtType" runat="server" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Sub Type</td>
                <td class="style5" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtSubType" runat="server" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    &nbsp;</td>
                <td class="style5" style="font-family: arial, Helvetica, sans-serif">
                    <asp:Button ID="cmdSubmit" runat="server" onclick="cmdSubmit_Click" 
                        Text="Submit" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                    <asp:Button ID="cmdCancel" runat="server" onclick="cmdCancel_Click" 
                        Text="Cancel" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
