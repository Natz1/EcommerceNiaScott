<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FurnitureDatabase.aspx.cs" Inherits="EcommerceNiaScott.FurnitureDatabase" %>
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

        table
        {
            margin-left: auto;
            margin-right: auto;
        }
        
        td
        {
            border: solid 4px black;
            background-color: #5E1C00;
            font-size: 15px;
        }

        th
        {
            background-color: #4A0404;
            text-align: center;
            border: solid 4px black;
            font-size: 16px;
        }
    </style>
    
    <br /><br />
    <h2>View Inventory</h2>
    
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="EcommerceNiaScott.Classes.FurnitureInventory" InsertMethod="AddFurnishing" SelectMethod="GetStorage" TypeName="EcommerceNiaScott.Classes.InventoryRepository" DeleteMethod="DeleteFurnishing" UpdateMethod="UpdateFurnishing"></asp:ObjectDataSource>
    <!--Grid Display -->
    <asp:GridView ID="GridView1" runat="server" CssClass="grid" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1" OnRowDeleting="Delete_Click" OnRowEditing="Edit_Click" 
        ShowFooter="false">
        
        <Columns>
            <asp:BoundField DataField="InventoryID" HeaderText="Inventory ID" HeaderStyle-CssClass="header" SortExpression="InventoryID"/>
            <asp:BoundField DataField="FurnitureID" HeaderText="Furniture ID" HeaderStyle-CssClass="header" SortExpression="FurnitureID" />
            <asp:BoundField DataField="Name" HeaderText="Name" HeaderStyle-CssClass="header" SortExpression="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" HeaderStyle-CssClass="header" SortExpression="Description" />
            <asp:BoundField DataField="Category" HeaderText="Category" HeaderStyle-CssClass="header" SortExpression="Category" />
            <asp:BoundField DataField="Price" HeaderText="Price ($)" HeaderStyle-CssClass="header" SortExpression="Price" />
            <asp:CommandField ShowEditButton="true" ButtonType="Button" HeaderStyle-CssClass="header" ControlStyle-BackColor="#4A0404"/>
            <asp:CommandField ShowDeleteButton="true" ButtonType="Button" HeaderStyle-CssClass="header" ControlStyle-BackColor="#4A0404"/>
        </Columns>
        <EmptyDataTemplate>
            <h3>Inventory is currently empty.</h3> 
        </EmptyDataTemplate>
    </asp:GridView>
    <br />

    <!--Add Display -->
    <br /><br />
    <h2>Add to Inventory</h2>
    <br />
    
    <table>
      <tr>
        <th><asp:Label ID="Label1" runat="server" Text="Furniture ID"></asp:Label></th>
        <th><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></th>
        <th><asp:Label ID="Label3" runat="server" Text="Description"></asp:Label></th>
        <th><asp:Label ID="Label4" runat="server" Text="Category"></asp:Label></th>
        <th><asp:Label ID="Label5" runat="server" Text="Price"></asp:Label></th>
      </tr>
      <tr>
        <td><asp:TextBox ID="id" runat="server" BackColor="#5E1C00"></asp:TextBox></td>
        <td><asp:TextBox ID="name" runat="server" BackColor="#5E1C00"></asp:TextBox></td>
        <td><asp:TextBox ID="desc" runat="server" BackColor="#5E1C00"></asp:TextBox></td>
        <td><asp:TextBox ID="cat" runat="server" BackColor="#5E1C00"></asp:TextBox></td>
        <td><asp:TextBox ID="price" runat="server" BackColor="#5E1C00"></asp:TextBox></td>
      </tr>
    </table>

    <br /><br />
    <!--Adding to inventory-->
    <div style="text-align:right;">
        <asp:Button ID="Add" runat="server" BackColor="#5E1C00" Text="Add to Inventory" OnClick="Add_Click" />
    </div>
    <br /><br />
</asp:Content>
