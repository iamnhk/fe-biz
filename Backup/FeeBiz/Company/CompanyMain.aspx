<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyMain.aspx.cs" Inherits="FeeBiz.Company.CompanyMain" %>

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
            text-align: left;
        }
        .style4
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
                <td class="style1" bgcolor="Maroon" colspan="3" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; height: 75px">
                    FeBiz: Fair e-Business 
                    . . . Company</td>
            </tr>
            <tr>
                <td align="right" colspan="3">
                    <span class="style4"><strong>Hi,&nbsp; </strong></span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style4" 
                        Font-Bold="True" ForeColor="#000066"></asp:Label>
                    <asp:Button ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="cmdMakeOrder" runat="server" onclick="cmdMakeOrder_Click1" 
                        Text="Make Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" />
                    <asp:Button ID="cmdViewOrder" runat="server" onclick="cmdViewOrder_Click1" 
                        Text="View Order" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" />
                    <asp:Button ID="cmdViewEditProfile" runat="server" 
                        onclick="cmdViewEditProfile_Click" Text="View / Edit Profile" 
                        BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" Font-Names="Arial" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
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
