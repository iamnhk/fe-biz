<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RateFarmer.aspx.cs" Inherits="FeeBiz.Order.RateFarmer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Rate Farmer</title>
    <style type="text/css">
        .style1
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #CC3300;
        }
        .style2
        {
            font-family: "Comic Sans MS";
        }
        .style3
        {
            font-family: "Comic Sans MS";
            font-size: large;
            width: 816px;
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
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:100%;">
            <tr>
                <td class="style1" colspan="5" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; height: 75px">
                    FeBiz: Fair e-Business . . . Company</td>
            </tr>
            <tr>
                <td class="style8" align="left">
                    <asp:Button ID="cmdBack" runat="server" onclick="cmdBack_Click" 
                        Text="Back to Farmer Main Page" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Names="Arial" ForeColor="Black" 
                        style="font-weight: 700" Font-Bold="True" />
                </td>
                <td class="style3" align="left">
                    &nbsp;</td>
                <td class="style3" align="right" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    <strong><span class="style4">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style4" 
                        ForeColor="#000066"></asp:Label>
                    </strong><span class="style4"><strong>&nbsp;</strong></span><asp:Button 
                        ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7" colspan="5" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    Rate Farmer
                    (5 Best and 1 Lowest): 
                    <asp:DropDownList ID="cboRate" runat="server">
                        <asp:ListItem Selected="True">1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style8" colspan="3" align="left">
                    <asp:Button ID="cmdRate" runat="server" onclick="cmdRate_Click" 
                        Text="Update Rating" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" ForeColor="Black" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="3" align="right">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
