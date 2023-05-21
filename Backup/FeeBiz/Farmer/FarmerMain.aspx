<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FarmerMain.aspx.cs" Inherits="FeeBiz.Farmer.FarmerMain" %>

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
            height: 75px;
        }
        .style2
        {
            width: 132px;
        }
        .style3
        {
            width: 997px;
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
            <td class="style1" bgcolor="#003366" colspan="3" align="left" 
                
                style="font-family: arial, Helvetica, sans-serif; background-color: #003366; ">
                FeBiz: Fair e-Business 
                . . . Farmer</td>
        </tr>
        <tr>
            <td class="style3" align="left">
                <asp:Button ID="cmdViewProduct" runat="server" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Names="Arial" ForeColor="Black" 
                    onclick="cmdViewProduct_Click" Text="ViewProduct" Font-Bold="True" 
                    Width="112px" />
&nbsp;<asp:Button ID="cmdProducts" runat="server" BackColor="#FF9900" BorderColor="#FF9900" Font-Names="Arial" 
                    ForeColor="Black" onclick="cmdProducts_Click" 
                    Text="Manage Products" Font-Bold="True" Width="149px" />
&nbsp;<asp:Button ID="cmdAddProducts" runat="server" BackColor="#FF9900" BorderColor="#FF9900" Font-Names="Arial" 
                    ForeColor="Black" onclick="cmdAddProducts_Click" 
                    Text="Add Products" Font-Bold="True" Width="120px" />
&nbsp;<asp:Button ID="cmdViewEditProfile" runat="server" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Names="Arial" ForeColor="Black" 
                    onclick="cmdViewEditProfile_Click" Text="View Edit Profile" 
                    Font-Bold="True" Width="142px" />
                &nbsp;<asp:Button ID="cmdAddCategory" runat="server" Text="Add Category" 
                        onclick="cmdAddCategory_Click" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Names="Arial" ForeColor="Black" 
                    Font-Bold="True" Width="115px" />
                &nbsp;<asp:Button ID="cbdViewsales" runat="server" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Names="Arial" ForeColor="Black" onclick="cbdViewsales_Click" 
                    Text="View Sales" Font-Bold="True" Width="93px" />
                </td>
            <td class="style2">
                <span class="style4"><strong>Hi,</strong></span>&nbsp;
                <asp:Label ID="lblLoginID" runat="server" Font-Bold="True" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
            </td>
            <td>
                <asp:Button ID="cmdLogout" runat="server" onclick="cmdLogout_Click" 
                    Text="Logout" style="height: 26px" BackColor="#FF9900" 
                    BorderColor="#FF9900" Font-Bold="True" />
            </td>
        </tr>
        <tr>
            <td class="style3" align="left">
                <asp:Label ID="msgLabel" runat="server" ForeColor="Red" Font-Names="Arial" 
                    Font-Size="Medium"></asp:Label>
                </td>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" align="left">
                <asp:GridView ID="GridProducts" runat="server" DataSourceID="ViewProductObject" 
                    Visible="False" AutoGenerateColumns="False" 
                    onselectedindexchanged="GridProducts_SelectedIndexChanged" CellPadding="4" 
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                            SortExpression="ProductID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="OfferExpiry" HeaderText="OfferExpiry" 
                            SortExpression="OfferExpiry" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="TotalQuantity" HeaderText="TotalQuantity" 
                            SortExpression="TotalQuantity" />
                        <asp:BoundField DataField="SoldQuantity" HeaderText="SoldQuantity" 
                            SortExpression="SoldQuantity" />
                        <asp:BoundField DataField="PacketSize" HeaderText="PacketSize" 
                            SortExpression="PacketSize" />
                        <asp:BoundField DataField="PacketSizeUnit" HeaderText="PacketSizeUnit" 
                            SortExpression="PacketSizeUnit" />
                        <asp:CheckBoxField DataField="Active" HeaderText="Active" 
                            SortExpression="Active" />
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        <asp:BoundField DataField="Quality" HeaderText="Quality" 
                            SortExpression="Quality" />
                        <asp:BoundField DataField="RegistrationDate" HeaderText="RegistrationDate" 
                            SortExpression="RegistrationDate" DataFormatString="{0:d}" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003366" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ViewProductObject" runat="server" 
                    SelectMethod="getAllProductsOfAFarmer" TypeName="FeBiz.Controller" 
                    OldValuesParameterFormatString="original_{0}" 
                    UpdateMethod="getAllProductsOfAFarmer">
                    <SelectParameters>
                        <asp:SessionParameter Name="farmerID" SessionField="FarmerID" Type="Int32" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="farmerID" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <asp:Button ID="cmdRefresh" runat="server" onclick="cmdRefresh_Click" 
                    Text="Refresh" Visible="False" BackColor="#FF9900" BorderColor="#FF9900" 
                    Font-Bold="True" />
            </td>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="250px" 
                    ImageUrl="~/Images/Farmer.png" style="margin-right: 0px" />
            </td>
            <td>
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
    </form>
    </div>
</body>
</html>
