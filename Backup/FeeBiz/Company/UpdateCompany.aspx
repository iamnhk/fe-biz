<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCompany.aspx.cs" Inherits="FeeBiz.Company.UpdateCompany" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            font-family: "Comic Sans MS";
        }
        .style3
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            width: 717px;
        }
        .style7
        {
            font-family: "Comic Sans MS";
            font-size: medium;
            text-align: left;
        }
        .style8
        {
            width: 222px;
        }
        .style9
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #FF6600;
            text-align: left;
        }
        .style10
        {
            width: 222px;
            font-family: "Comic Sans MS";
            text-align: left;
        }
        .style11
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            width: 717px;
            text-align: left;
        }
        .style12
        {
            width: 222px;
            text-align: left;
        }
        .style21
        {
            font-size: small;
            color: #666666;
        }
        .style22
        {
            width: 222px;
            font-family: "Comic Sans MS";
            text-align: left;
            height: 28px;
        }
        .style23
        {
            font-family: "Comic Sans MS";
            font-size: xx-large;
            width: 717px;
            text-align: left;
            height: 28px;
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
                <td class="style9" colspan="5" 
                    
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; height: 75px">
                    FeBiz: Fair e-Business . . . Company</td>
            </tr>
            <tr>
                <td class="style7" colspan="2" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    <strong>View and update company profile</strong></td>
                <td colspan="3" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium" 
                    align="right">
                    <strong><span class="style4">Hi, </span>
                    <asp:Label ID="lblCompanyName" runat="server" CssClass="style4" 
                        ForeColor="#000066"></asp:Label>
                    </strong>
                    <asp:Button ID="cmdLogOut" runat="server" onclick="cmdLogOut_Click" 
                        Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style7" colspan="5" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    <span id="search" class="style21" style=""><span id="search0"><strong>Please 
                    note that all fields marked with an asterisk (*) are required.</strong></span></span></td>
            </tr>
            <tr>
                <td class="style7" colspan="5" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Bold="True" 
                        Font-Names="Arial" Font-Size="Small"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Contact Person Name*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtFname" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td class="style2" colspan="2" rowspan="9">
                    <asp:Image ID="Image2" runat="server" Height="250px" 
                        ImageUrl="~/Images/Company.png" />
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Company
                    Name*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtCompanyName" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style22" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Branch</td>
                <td class="style23" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtBranch" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Address 1*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtAddress1" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Address 2</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtAddress2" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Postal code*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtPostalCode" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    City*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtCity" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Country*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtCountry" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    Phone*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtPhone" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style10" bgcolor="#FF9966" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: maroon; color: #FFFFFF; font-size: medium;">
                    &nbsp;Fax*</td>
                <td class="style11" style="font-family: arial, Helvetica, sans-serif" 
                    colspan="2">
                    <asp:TextBox ID="txtFax" runat="server" BorderColor="Maroon"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style12">
                    &nbsp;</td>
                <td class="style11" colspan="2">
                    <asp:Button ID="cmdSubmit" runat="server" Text="Submit" 
                        onclick="cmdSubmit_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" />
                    <asp:Button ID="cmdCancel" runat="server" Text="Cancel" 
                        onclick="cmdCancel_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    &nbsp;</td>
                <td class="style3" colspan="2">
                    &nbsp;</td>
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
