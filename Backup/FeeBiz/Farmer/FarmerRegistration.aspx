<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FarmerRegistration.aspx.cs" Inherits="FeeBiz.Farmer.FarmerRegistration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style7
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: xx-large;
            color: #FFFFFF;
            background-color: #99CCFF;
            text-align: left;
            height: 68px;
        }
        .style2
        {
            width: 132px;
        }
        .style9
        {
            height: 23px;
            font-family: Arial, Helvetica, sans-serif;
            text-align: left;
            font-size: medium;
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
            background-color: #99CCFF;
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style11
        {
            width: 997px;
            text-align: left;
        }
        .style12
        {
            width: 195px;
            text-align: left;
        }
        .style13
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: 700;
            font-size: small;
        }
        .style14
        {
            width: 997px;
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style15
        {
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style16
        {
            width: 195px;
            background-color: #99CCFF;
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            height: 26px;
        }
        .style17
        {
            width: 997px;
            text-align: left;
            height: 26px;
        }
        .style18
        {
            width: 132px;
            height: 26px;
        }
        .style19
        {
            height: 26px;
        }
        .style20
        {
            background-color: #003366;
        }
        .style21
        {
            font-size: small;
            color: #666666;
        }
        .style22
        {
            width: 195px;
            background-color: #99CCFF;
            text-align: left;
            font-family: Arial, Helvetica, sans-serif;
            height: 29px;
        }
        .style23
        {
            width: 997px;
            text-align: left;
            height: 29px;
        }
        .style24
        {
            height: 29px;
        }
    </style>
</head>
<body>
    <div align = "center">
    <form id="form1" runat="server">    
        <table style="width:100%;">
            <tr>
                <td class="style7" colspan="4" bgcolor="#003366" 
                    style="font-family: Arial, Helvetica, sans-serif; background-color: #003366; height: 75px;">
                    <strong><span class="style20">FeBiz: Fair e-Business 
                    . . . Farmer Registration</span></strong></td>
            </tr>
            <tr>
                <td class="style9" colspan="2">
                    With a FeBiz Farmer account, raise your harvest revenue by selling your products 
                    to a global market.
                </td>
                <td class="style5" rowspan="9">
                    <asp:Image ID="Image1" runat="server" Height="250px" 
                        ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
                </td>
                <td class="style6">
                </td>
            </tr>
            <tr>
                <td class="style15" colspan="2">
                    <span id="search" class="style21" style=""><span id="search0"><strong>Please 
                    note that all fields marked with an asterisk (*) are required.</strong></span></span></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;</td>
                <td class="style11">
                    <asp:Label ID="msgLabel" runat="server" ForeColor="Red" CssClass="style13" 
                        Font-Names="Arial"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    <strong>Personal Info</strong></td>
                <td class="style14">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Name *</td>
                <td class="style11">
                    <asp:TextBox ID="txtFname" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Email *</td>
                <td class="style11">
                    <asp:TextBox ID="txtEmail" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style22" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Password *</td>
                <td class="style23">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px" 
                        CssClass="style13" BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style24">
                    </td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Address 1 *</td>
                <td class="style11">
                    <asp:TextBox ID="txtAddress1" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Address 2 </td>
                <td class="style11">
                    <asp:TextBox ID="txtAddress2" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Postal code *</td>
                <td class="style11">
                    <asp:TextBox ID="txtPostalCode" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;City *</td>
                <td class="style11">
                    <asp:TextBox ID="txtCity" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Country *</td>
                <td class="style11">
                    <asp:TextBox ID="txtComtry" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Phone *</td>
                <td class="style11">
                    <asp:TextBox ID="txtPhone" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    &nbsp;Fax *</td>
                <td class="style11">
                    <asp:TextBox ID="txtFax" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #FFFFFF; ">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    <strong>Bank Info</strong></td>
                <td class="style14">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    Bank Name </td>
                <td class="style11">
                    <asp:TextBox ID="txtBankName" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    Account Number</td>
                <td class="style11">
                    <asp:TextBox ID="txtAccountNumber" runat="server" Width="150px" 
                        CssClass="style13" BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    Branch Name</td>
                <td class="style11">
                    <asp:TextBox ID="txtBankBranchName" runat="server" Width="150px" 
                        CssClass="style13" BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    Account Title</td>
                <td class="style11">
                    <asp:TextBox ID="txtAccountTitle" runat="server" Width="150px" 
                        CssClass="style13" BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style16" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    IBAN</td>
                <td class="style17">
                    <asp:TextBox ID="txtIBAN" runat="server" Width="150px" CssClass="style13" 
                        BorderColor="#003366"></asp:TextBox>
                </td>
                <td class="style18">
                    </td>
                <td class="style19">
                    </td>
            </tr>
            <tr>
                <td class="style10" 
                    style="background-color: #003366; font-family: arial, Helvetica, sans-serif; color: #FFFFFF">
                    SWIFT 
                    / BIC</td>
                <td class="style11">
                    <asp:TextBox ID="txtSwiftBIC" runat="server" Width="150px" CssClass="style13" 
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
                <td class="style11">
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
        </table>
    </form>
    </div>
</body>
</html>
