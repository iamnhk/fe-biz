<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="FeeBiz.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 2452px;
            height: 25px;
        }
        .style6
        {
            width: 2452px;
            font-size: xx-large;
            font-family: Arial, Helvetica, sans-serif;
            height: 75px;
            color: #FFFFFF;
        }
        .style9
        {
            height: 26px;
        }
        .style12
        {
            width: 2526px;
            height: 26px;
        }
        .style16
        {
            font-weight: bold;
            text-align: left;
        }
        .style19
        {
            width: 2526px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            color: #666666;
            height: 26px;
        }
        .style20
        {
            width: 47%;
            height: 534px;
        }
        .style25
        {
            width: 2452px;
            height: 251px;
        }
        .style26
        {
            width: 2471px;
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
        }
        .style27
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
            font-size: small;
            color: #666666;
        }
        .style28
        {
            width: 2471px;
            height: 26px;
            text-align: center;
        }
        .style29
        {
            width: 2471px;
            height: 251px;
        }
    </style> 

</head>
<body>
<div align = "center">
    <form id="form1" runat="server">
        <table class="style20">
            <tr>
                <td class="style6" colspan="2" align="center" bgcolor="#003366" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; height: 75px">
                    <strong>FeBiz: Fair e-Business</strong></td>
            </tr>
            <tr>
                <td class="style1" colspan="2" align="center">
                    <asp:Label ID="lblLoginFail" runat="server" ForeColor="Red" 
                        Text="Invalid email or password. Please try again using your full email." 
                        Font-Names="Arial" Font-Bold="True" Font-Size="Small"></asp:Label>
                </td>
            </tr>
            <span style="font-size: medium">
            <tr>
                <td class="style26" align="right">
                    Email:</span></td>
                <td class="style12" align="left">
                    <asp:TextBox ID="txtUserID" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style26" align="right">
                    &nbsp;</td>
                <td class="style19" align="left">
                    (e.g. abc@xyz.com)</td>
            </tr>
            <tr>
                <td class="style26" align="right">
                    <span style="font-size: medium">Password:&nbsp;
                    </span>
                    </td>
                <td class="style12" align="left">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style28">
                    </td>
                <td class="style12" align="left" valign="top">
                    <asp:Button ID="cmdLogin" runat="server" onclick="cmdLogin_Click" 
                        Text="Sign In" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Names="Arial" Font-Size="Medium" ForeColor="Black" Font-Bold="True" 
                        Height="25px" />
                </td>
            </tr>
            <tr>
                <td class="style29" align="center">
                    <asp:Image ID="Image1" runat="server" Height="250px" 
                        ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
                <td class="style25" align="center">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
            </tr>
            <tr>
                <td class="style9" align="right" colspan="2">
                    <h3 class="style27" style="text-align: center">
                        Don&#39;t have a FeBiz account? Create a new account.</h3>
                </td>
            </tr>
            <tr>
                <td class="style28" align="right">
                    <asp:Button ID="cmdFarmerRegistration" runat="server" BackColor="#003366" 
                        BorderColor="#003366" CssClass="style16" Font-Bold="True" 
                        Font-Names="Arial" Font-Size="Medium" ForeColor="White" 
                        Text="Farmer Registration" onclick="cmdFarmerRegistration_Click1" />
                </td>
                <td class="style12">
                    <asp:Button ID="cmdCompanyRegistration" runat="server" BackColor="Maroon" 
                        BorderColor="Maroon" CssClass="style16" Font-Bold="True" 
                        Font-Names="Arial" Font-Size="Medium" ForeColor="White" 
                        Text="Company Registration" onclick="cmdCompanyRegistration_Click1" />
                </td>
            </tr>
        </table>
     </form>
    </div>
   
</body>
</html>
