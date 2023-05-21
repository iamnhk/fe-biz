<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RateCompany.aspx.cs" Inherits="FeeBiz.Farmer.RateCompany" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #99CCFF;
        }
        .style2
        {
            font-family: "Comic Sans MS";
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
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:100%;">
            <tr>
                <td class="style1" colspan="4" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; height: 75px">
                    FeBiz: Fair e-Business 
                    . . . Farmer</td>
            </tr>
            <tr>
                <td class="style8" align="left">
                    <asp:Button ID="cmdBack" runat="server" onclick="cmdBack_Click" 
                        Text="Back to Farmer Main Page" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Names="Arial" ForeColor="Black" Font-Bold="True" />
                </td>
                <td class="style3" align="right" colspan="2" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: large">
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
                    Rate Company
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
                <td colspan="2" align="left" valign="top">
                    <asp:Button ID="cmdRate" runat="server" onclick="cmdRate_Click" 
                        Text="Update Rating" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" ForeColor="Black" />
                </td>
                <td class="style2" align="right" rowspan="5">
                    <asp:Image ID="Image1" runat="server" Height="250px" 
                        ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
                <td rowspan="5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2" align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2" align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2" align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2" align="left">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
