<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDatabase.aspx.cs" Inherits="EcommerceNiaScott.OrderDatabase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Formatting-->
    <style>
        .grid
        {
            background-color: #5E1C00;
            height: 300px;
            width: 100%;
            border: solid 4px black;
            text-align: center;
            font-size: 15px;
        }

        .header
        {
            background-color: #4A0404;
            text-align: center;
            border: none;
            font-size: 16px;
        }
    </style>

    <!--Grid View-->
    <br /><br />
    <h2>Order Details</h2>
    <br />

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DataObjectTypeName="EcommerceNiaScott.Classes.Checkout" InsertMethod="AddOrder" SelectMethod="GetCart" 
        TypeName="EcommerceNiaScott.Classes.CheckoutRepository"></asp:ObjectDataSource>

    <asp:GridView ID="GridView1" CssClass="grid" FooterStyle-CssClass="footer" 
        runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" 
        ShowFooter="true">
        <Columns>
            <asp:BoundField DataField="dateTime" HeaderText="Date and Time" HeaderStyle-CssClass="header" SortExpression="dateTime" />
            <asp:BoundField DataField="OrderID" HeaderText="Order ID" HeaderStyle-CssClass="header" SortExpression="OrderID" />
            <asp:BoundField DataField="ProductID" HeaderText="Product ID" HeaderStyle-CssClass="header" SortExpression="ProductID" />
            <asp:BoundField DataField="Username" HeaderText="Username" HeaderStyle-CssClass="header" SortExpression="Username" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" HeaderStyle-CssClass="header" SortExpression="Quantity"/>
            <asp:BoundField DataField="Subtotal" HeaderText="Subtotal ($)" HeaderStyle-CssClass="header" SortExpression="Subtotal" />
        </Columns>
    </asp:GridView>
</asp:Content>
