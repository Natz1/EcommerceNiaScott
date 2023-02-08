<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="EcommerceNiaScott.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .center {
          display: block;
          margin-left: auto;
          margin-right: auto;
          width: 50%;
        }
    </style>

    <br /><br />
    <h2>Who We Are</h2>
    <p>&nbsp;</p>
    <asp:Image ID="Image1" class="center" src="Images/table.jpg" runat="server" Height="60%" Width="50%" BorderColor="White" />
    <br />
    <br />
    <p>In 1996, Castle Home Furnishings was founded with the intention of providing our customers with
        the finest quality pieces of furniture to decorate their living spaces. Our services are deeply 
        rooted in our work values, promoting efficient, on-time delivery, brilliant customer service and quality-made 
        furnishings for each consumer to purchase at their leisure.
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
