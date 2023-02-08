<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartDatabase.aspx.cs" Inherits="EcommerceNiaScott.CartDatabase" %>
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
    <h2>Shopping Cart</h2>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="EcommerceNiaScott.Classes.FurnitureCart" InsertMethod="AddFurnishing" SelectMethod="GetStorage" TypeName="EcommerceNiaScott.Classes.CartRepository" DeleteMethod="DeleteFurnishing"></asp:ObjectDataSource>
    <asp:GridView ID="GridView1" runat="server" CssClass="grid" OnRowDeleting="Delete_Click" 
        DataSourceID="ObjectDataSource1" AllowPaging="True" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CartID" HeaderText="Cart ID" HeaderStyle-CssClass="header" SortExpression="CartID" />
            <asp:BoundField DataField="FurnitureID" HeaderText="Furniture ID" HeaderStyle-CssClass="header" SortExpression="FurnitureID" />
            <asp:BoundField DataField="Name" HeaderText="Name" HeaderStyle-CssClass="header" SortExpression="Name" />
            <asp:BoundField DataField="Desc" HeaderText="Description" HeaderStyle-CssClass="header" SortExpression="Desc" />
            <asp:BoundField DataField="Cat" HeaderText="Category" HeaderStyle-CssClass="header" SortExpression="Cat" />
            <asp:BoundField DataField="Price" HeaderText="Price ($)" HeaderStyle-CssClass="header" SortExpression="Price" />
            <asp:BoundField DataField="Quan" HeaderText="Quantity" HeaderStyle-CssClass="header" SortExpression="Quan" />
            <asp:BoundField DataField="Subtotal" HeaderText="Subtotal ($)" HeaderStyle-CssClass="header" SortExpression="Subtotal" />
            <asp:CommandField ShowDeleteButton="true" ButtonType="Button" HeaderStyle-CssClass="header" ControlStyle-BackColor="#4A0404"/>
        </Columns>
        <EmptyDataTemplate>
            <h3>Nothing was added to cart.</h3> 
        </EmptyDataTemplate>
    </asp:GridView>

    <!--Order button-->
    <br /><br />
    <div style="text-align:right;">
        <asp:Button ID="Purchase" Visible="false" runat="server" Text="Purchase Order" BackColor="#5E1C00" OnClick="Purchase_Click"/>
    </div>
</asp:Content>
