<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="EcommerceNiaScott.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br /><br />
<h2>Add To Cart</h2>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Cart1" runat="server" Text=""></asp:Label>

    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Cart2" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Cart3" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Cart4" runat="server" Text=""></asp:Label>
    
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Cart5" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Enter Product Quantity: "></asp:Label>
    <asp:TextBox ID="TextBox1"  BackColor="#5E1C00" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" Text=" *Product quantity must be entered" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>


    <br /><br />
    <asp:Button ID="Button7" BackColor="#5E1C00" runat="server" Text="Calculate Subtotal" OnClick="SubtotalClick"/>
    &nbsp&nbsp
    <asp:Button ID="Button9" Visible="False" BackColor="#5E1C00" runat="server" Text="Return to Products" OnClick="ReturnClick"/>
    &nbsp&nbsp
    <asp:Button ID="Button8" Visible="False" BackColor="#5E1C00" runat="server" Text="Head to Shopping Cart" OnClick="ListClick"/>

</asp:Content>

