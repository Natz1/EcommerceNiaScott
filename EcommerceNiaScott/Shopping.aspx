<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="EcommerceNiaScott.Shopping" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Formatting-->
    <style>
        th
        {
            font-size: 16px;
        }

        td
        {
            font-size: 15px;
        }
    </style>

    <br /><br />
    <h2>Preview</h2>

    <!--Display cart items-->
    <div class="container">
    <asp:Repeater ID="repeat" runat="server" OnItemCommand="DeleteClick">
        <HeaderTemplate><table style="width: 100%" align="left">
            <colgroup>
                <col span ="1" style="width: 15%"/>
                <col span ="1" style="width: 15%"/>
                <col span ="1" style="width: 15%"/>
                <col span ="1" style="width: 15%"/>
                <col span ="1" style="width: 15%"/>
                <col span ="1" style="width: 15%"/>
            </colgroup>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Description</th>
                <th>Category</th>
                <th>Quantity</th>
                <th>Subtotal ($)</th>
            </tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr>
            <td><%# Eval("FurnitureID") %></td>
            <td><%# Eval("Name") %></td>
            <td><%# Eval("Desc") %></td>
            <td><%# Eval("Cat") %></td>
            <td><%# Eval("Quan") %></td>
            <td><%# Eval("Subtotal") %></td>
            <td>
                <asp:LinkButton ID="Delete" Text="Delete" runat="server" 
                    CommandName="Delete" CommandArgument='<%# Eval("FurnitureID") %>'/>
            </td>
        </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    </div>

    <!--Display total-->
    <br />
    <asp:Label ID="Label6" runat="server" Text="" font-size="15px"></asp:Label>
    <br /><br />
    &nbsp&nbsp<br /><br />

    <!--Confirmation button: store to cart when sure you no longer want to change anything-->
    <br /><br />
    <div style="text-align:right;">
        <asp:Button ID="Confirm" runat="server" Visible="False" Text="Confirm Add" BackColor="#5E1C00" OnClick="ConfirmClick"/>
    </div>
    

    <br /><br />



    
</asp:Content>
