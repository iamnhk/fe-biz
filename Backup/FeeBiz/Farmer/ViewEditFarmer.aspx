<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEditFarmer.aspx.cs" Inherits="FeeBiz.Farmer.ViewEditFarmer" %>

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
        }
        .style2
        {
            font-family: "Comic Sans MS";
        }
        .style3
        {
            font-family: "Comic Sans MS";
            font-size: large;
            text-align: left;
        }
        .style7
        {
            font-family: "Comic Sans MS";
            font-size: large;
            text-align: left;
        }
        .style8
        {
            width: 145px;
            height: 35px;
        }
        .style9
        {
            width: 145px;
            height: 10px;
            text-align: left;
        }
        .style10
        {
            font-family: "Comic Sans MS";
            font-size: large;
            width: 816px;
            height: 10px;
        }
        .style11
        {
            width: 145px;
            font-family: "Comic Sans MS";
        }
        .style12
        {
            text-align: left;
        }
        .style13
        {
            font-family: "Comic Sans MS";
            font-size: large;
            width: 816px;
            text-align: left;
        }
        .style14
        {
            width: 145px;
            font-family: "Comic Sans MS";
            text-align: left;
        }
        .style21
        {
            font-size: small;
            color: #666666;
        }
        .style4
        {
            font-family: Arial, Helvetica, sans-serif;
        }
        .style22
        {
            font-family: "Comic Sans MS";
            font-size: large;
            text-align: left;
            height: 35px;
        }
    </style>
</head>
<body>
    <div align = "center">
    <form id="form1" runat="server">
     <table style="width:100%;">
            <tr>
                <td class="style1" colspan="4" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; height: 75px">
                    FeBiz: Fair e-Business 
                    . . . Farmer</td>
            </tr>
            <tr>
                <td class="style8" align="right">
                    </td>
                <td align="right" colspan="3">
                <span class="style4"><strong>Hi,</strong></span>&nbsp;
                <asp:Label ID="lblLoginID" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
            &nbsp;<asp:Button ID="cmdLogout" runat="server" onclick="cmdLogout_Click" 
                    Text="Logout" style="height: 26px" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Bold="True" />
                </td>
            </tr>
            <tr>
                <td class="style7" colspan="4" 
                    style="font-family: arial, Helvetica, sans-serif; font-size: medium">
                    <strong>View and Update Farmer Profile</strong></td>
            </tr>
            <tr>
                <td class="style12" colspan="2" style="background-color: #FFFFFF">
                    <span id="search" class="style21" style=""><span id="search0"><strong>Please 
                    note that all fields marked with an asterisk (*) are required.</strong></span></span></td>
                <td class="style2" colspan="2" rowspan="14" style="background-color: #FFFFFF">
                    <asp:Image ID="Image1" runat="server" Height="250px" 
                        ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" style="background-color: #FFFFFF">
                    &nbsp;</td>
                <td class="style13" style="background-color: #FFFFFF">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Bold="True" 
                        Font-Names="Arial" Font-Size="Small"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    <strong>Personal Info</strong></td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Name*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtFname" runat="server" Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Email*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtEmail" runat="server" Enabled="False" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    RegistrationDate</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtRegistrationDate" runat="server" Enabled="False" 
                        Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Address 1*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtAddress1" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Address 2</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtAddress2" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Postal code*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtPostalCode" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;City*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtCity" runat="server" Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Country*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtCountry" runat="server" Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Phone*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtPhone" runat="server" Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style14" bgcolor="#99CCFF" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    &nbsp;Fax*</td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtFax" runat="server" Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    </td>
                <td class="style10" style="font-family: arial, Helvetica, sans-serif">
                    </td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    <strong>Bank Info</strong></td>
                <td class="style13" style="font-family: arial, Helvetica, sans-serif">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Bank Name</td>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtBankName" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Account Number</td>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtAccountNumber" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Branch Name</td>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtBankBranchName" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    Account Title</td>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtAccountTitle" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    IBAN</td>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtIBAN" runat="server" Width="150px" BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style11" bgcolor="#99CCFF" align="left" 
                    style="font-family: arial, Helvetica, sans-serif; background-color: #003366; color: #FFFFFF;">
                    SWIFT 
                    / BIC</td>
                <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                    <asp:TextBox ID="txtSwiftBIC" runat="server" Width="150px" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style12">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="cmdSubmit" runat="server" Text="Submit" 
                        onclick="cmdSubmit_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" ForeColor="Black" />
                    <asp:Button ID="cmdCancel" runat="server" Text="Cancel" 
                        onclick="cmdCancel_Click" BackColor="#FF9900" BorderColor="#FF9900" 
                        Font-Bold="True" Font-Names="Arial" ForeColor="Black" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table
    </form>
    </div>
</body>
</html>
