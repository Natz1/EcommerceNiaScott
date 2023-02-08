<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcommerceNiaScott._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .product { 
            margin: 1vw; 
            width: 25vw; 
            height: 30vh;
        }

        .click {
            margin-left: 1vw
        }
    </style>

    <div class="row">
        <br /><br />
        <h2>Browse our varied products</h2> 
        <br />
        <table style="width:100%">
            <tr>
                <td><asp:Image ID="Image1" class="product" src="Images/bed1.jpg" runat="server"/></td>
                <td><asp:Image ID="Image2" class="product" src="Images/dining.jpg" runat="server"/></td>
                <td><asp:Image ID="Image3" class="product" src="Images/sofa.jpg" runat="server"/></td>
            </tr>

            <tr>
                <td><asp:Button ID="Button1" class="click" runat="server" BackColor="#5E1C00" Height="33px" Text="Beds" Width="90px" OnClick="Button1_Click" /></td>
                <td><asp:Button ID="Button2" class="click" runat="server" BackColor="#5E1C00" Height="33px" Text="Dining Sets" Width="90px" OnClick="Button2_Click" /></td>
                <td><asp:Button ID="Button3" class="click" runat="server" BackColor="#5E1C00" Height="33px" Text="Sofas" Width="90px" OnClick="Button3_Click" /></td>
            </tr>

            <tr>
                <td><asp:Image ID="Image4" class="product" src="Images/fridge1.jpg" runat="server"/></td>
                <td><asp:Image ID="Image5" class="product" src="Images/lamp.jpg" runat="server"/></td>
                <td><asp:Image ID="Image6" class="product" src="Images/fan.jpg" runat="server"/></td>
               </tr>
            
            <tr>
                <td><asp:Button ID="Button4" class="click" runat="server" BackColor="#5E1C00" Height="33px" Text="Kitchen" Width="90px" OnClick="Button4_Click" /></td>
                <td><asp:Button ID="Button5" class="click" runat="server" BackColor="#5E1C00" Height="33px" Text="Lamps" Width="90px" OnClick="Button5_Click" /></td>
                <td><asp:Button ID="Button6" class="click" runat="server" BackColor="#5E1C00" Height="33px" Text="Appliances" Width="90px" OnClick="Button6_Click" /></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>

</asp:Content>
