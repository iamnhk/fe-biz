<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyRegistration.aspx.cs" Inherits="FeeBiz.Company.CompanyRegistration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style7
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #FF6600;
        }
        .style8
        {
            text-align: left;
        }
        .style3
        {
            width: 955px;
            text-align: left;
        }
        .style2
        {
            width: 132px;
        }
        .style5
        {
            width: 132px;
            }
        .style6
        {
            height: 23px;
        }
        .style10
        {
            width: 195px;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
        }
        .style11
        {
            width: 195px;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            height: 23px;
        }
        .style12
        {
            width: 955px;
            text-align: left;
            height: 23px;
        }
        .style13
        {
            text-align: left;
            font-size: medium;
        }
        .style21
        {
            font-size: small;
            color: #666666;
        }
        </style>
</head>
<body>
    <div align = "center">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="style7" colspan="4" 
                    style="font-family: arial, Helvetica, sans-serif; height: 75px; background-color: Maroon; text-align: left;">
                    <strong>FeBiz: Fair e-Business 
                    . . . Company Registration</strong></td>
            </tr>
            <tr>
                <td class="style13" colspan="2">
                    With a FeBiz Compnay account, maximize the quality of your staples and minimize 
                    your outgo. </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8" colspan="2">
                    <span id="search" class="style21" style=""><span id="search0"><strong>Please 
                    note that all fields marked with an asterisk (*) are required.</strong></span></span></td>
                <td class="style5" rowspan="13">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" 
                        
                        style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; font-size: small" 
                        Font-Names="Arial"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    <strong>Personal Info</strong></td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    Name *</td>
                <td class="style3">
                    <asp:TextBox ID="txtFname" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    Email *</td>
                <td class="style3">
                    <asp:TextBox ID="TxtEmail" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Password *</td>
                <td class="style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px" 
                        BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#FF9966" 
                    style="background-color: #FFFFFF; color: #FFFFFF;">
                    </td>
                <td class="style12">
                    </td>
                <td class="style6">
                    </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    <strong>Company Info</strong></td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Name *</td>
                <td class="style3">
                    <asp:TextBox ID="txtCompanyName" runat="server" Width="150px" 
                        BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    Branch</td>
                <td class="style3">
                    <asp:TextBox ID="txtBranch" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Address 1 *</td>
                <td class="style3">
                    <asp:TextBox ID="txtAddress1" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    Address 2</td>
                <td class="style3">
                    <asp:TextBox ID="txtAddress2" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Postal code *</td>
                <td class="style3">
                    <asp:TextBox ID="txtPostalCode" runat="server" Width="150px" 
                        BorderColor="Maroon"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;City *</td>
                <td class="style3">
                    <asp:TextBox ID="txtCity" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Country *</td>
                <td class="style3">
                    <asp:TextBox ID="txtCountry" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Phone *</td>
                <td class="style3">
                    <asp:TextBox ID="txtPhone" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="background-color: Maroon; color: #FFFFFF;">
                    &nbsp;Fax *</td>
                <td class="style3">
                    <asp:TextBox ID="txtFax" runat="server" Width="150px" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                   &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="cmdSubmit" runat="server" Text="Submit" 
                        onclick="cmdSubmit_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" />
                    <asp:Button ID="cmdCancel" runat="server" Text="Cancel" 
                        onclick="cmdCancel_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>
