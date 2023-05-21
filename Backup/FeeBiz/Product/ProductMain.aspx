<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductMain.aspx.cs" Inherits="FeeBiz.Product.ProductMain" %>

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
            width: 132px;
        }
        .style3
        {
            text-align: left;
        }
        .style4
        {
            width: 172px;
            text-align: left;
        }
        </style>
</head>
<body>
<div align = "center" >
    <form id="form2" runat="server">
    <table style="width:100%; height: 373px;">
        <tr>
            <td class="style1" colspan="6" align="left" 
                style="font-family: arial, Helvetica, sans-serif; background-color: #003366; height: 75px">
                FeBiz: Fair e-Business 
                . . . Farmer</td>
        </tr>
        <tr>
            <td colspan="3" align="left">
                <asp:Button ID="cmdMPS" runat="server" BackColor="#FF9900" ForeColor="Black" 
                    onclick="cmdMPS_Click1" Text="Change Product Status" 
                    BorderColor="#FF9900" Font-Names="Arial" Width="191px" Font-Bold="True" />
                <asp:Button ID="cmdSSP" runat="server" BackColor="#FF9900" ForeColor="Black" 
                    onclick="cmdSSP_Click" Text="Check Product Status" 
                    BorderColor="#FF9900" Font-Names="Arial" Width="182px" Font-Bold="True" />
                <asp:Button ID="cmdRP" runat="server" BackColor="#FF9900" ForeColor="Black" 
                    onclick="cmdRP_Click" Text="Renew Product" 
                    BorderColor="#FF9900" Font-Names="Arial" Font-Bold="True" />
                <asp:Button ID="cmdPA" runat="server" BackColor="#FF9900" ForeColor="Black" 
                    onclick="cmdPA_Click" Text="Change Product Quantity" 
                    BorderColor="#FF9900" Font-Names="Arial" Width="211px" Font-Bold="True" />
                <asp:Button ID="cmdFarmerMain" runat="server" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Names="Arial" ForeColor="Black" onclick="cmdFarmerMain_Click" 
                    Text="Main" Font-Bold="True" />
            </td>
            <td colspan="3" align="right">
                &nbsp;<span class="style4"><strong>Hi,</strong></span>&nbsp;
                <asp:Label ID="lblLoginID" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
            &nbsp;<asp:Button ID="cmdLogout" runat="server" onclick="cmdLogOut_Click" 
                    Text="Logout" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" 
                    Font-Names="Arial" ForeColor="Black" />
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                <asp:Label ID="lblHeader" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="Black" Text="Mark a product as sold" style="text-align: left"></asp:Label>
            </td>
            <td class="style3">
                &nbsp;</td>
            <td class="style3" colspan="2">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                <asp:Label ID="msgLabel" runat="server" Font-Names="Arial" ForeColor="Red" 
                    Font-Size="Medium"></asp:Label>
            </td>
            <td class="style3">
                &nbsp;</td>
            <td class="style3" colspan="2">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                <asp:Label ID="lblPID" runat="server" Text="Product Name :     " 
                    ForeColor="Black"></asp:Label>
                <asp:DropDownList ID="cboProduct" runat="server" DataSourceID="ProductObject" 
                    DataTextField="Name" DataValueField="ProductID" >
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ProductObject" runat="server" 
                    SelectMethod="getAllProductsOfAFarmer" TypeName="FeBiz.Controller">
                    <SelectParameters>
                        <asp:SessionParameter Name="farmerID" SessionField="FarmerID" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:Calendar ID="clnExpDate" runat="server" Visible="False"></asp:Calendar>
            </td>
            <td class="style3" rowspan="3">
                &nbsp;</td>
            <td class="style3" align="right" rowspan="3" colspan="2">
                &nbsp;</td>
            <td class="style2" rowspan="3">
                <asp:Image ID="Image1" runat="server" Height="250px" 
                    ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
            </td>
            <td rowspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                <asp:Label ID="lblActive" runat="server" Text="Active :"></asp:Label>
                    &nbsp;
                    <asp:RadioButtonList ID="rdoActive" runat="server" Height="20px" Width="59px">
                        <asp:ListItem Selected="True" Value="1">Yes</asp:ListItem>
                        <asp:ListItem Value="0">No</asp:ListItem>
                    </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                <asp:Label ID="lblNewQty" runat="server" Text="New Quantity :   "></asp:Label>
                <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
                <asp:Button ID="cmdExecute" runat="server" onclick="cmdExecute_Click" 
                    Text="Execute" BackColor="#FF9900" BorderColor="#FF9900" Font-Bold="True" 
                    Font-Names="Arial" ForeColor="Black" />
            </td>
        </tr>
        <tr>
            <td class="style3" style="font-family: arial, Helvetica, sans-serif">
                <asp:Label ID="lblOutput" runat="server" Text="Output"></asp:Label>
            </td>
            <td class="style3">
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
