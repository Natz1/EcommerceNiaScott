<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="EcommerceNiaScott.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <h2>Available Products</h2>

    <h4 id="beds">Beds</h4>
    <asp:Image ID="Image2" src="Images/bed6.jpg" runat="server" Height="35%" Width="30%" BorderColor="White" />
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="ID: "></asp:Label>
    <asp:Label ID="Label12" runat="server" Text="8796"></asp:Label>
    <br />
    <asp:Label ID="Label13" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="Label14" runat="server" Text="Sunset Bed Frame"></asp:Label>
    <br />
    <asp:Label ID="Label15" runat="server" Text="Description: "></asp:Label>
    <asp:Label ID="Label16" runat="server" Text="Queen sized bed frame"></asp:Label>
    <br />
    <asp:Label ID="Label17" runat="server" Text="Category: "></asp:Label>
    <asp:Label ID="Label18" runat="server" Text="Bedding"></asp:Label>
    <br />
    <asp:Label ID="Label19" runat="server" Text="Unit Price: J$"></asp:Label>
    <asp:Label ID="Label20" runat="server" Text="80000.00"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" BackColor="#5E1C00" runat="server" Text="Add To Cart" OnClick="Button1_Click" />
    <br />
    <br />

    <h4 id="dining">Dining Sets</h4>
    <asp:Image ID="Image3" src="Images/dining.jpg" runat="server" Height="35%" Width="30%" BorderColor="White" />
    <br />
    <br />
    <asp:Label ID="Label21" runat="server" Text="ID: "></asp:Label>
    <asp:Label ID="Label22" runat="server" Text="9983"></asp:Label>
    <br />
    <asp:Label ID="Label23" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="Label24" runat="server" Text="Moon Dining Table"></asp:Label>
    <br />
    <asp:Label ID="Label25" runat="server" Text="Description: "></asp:Label>
    <asp:Label ID="Label26" runat="server" Text="Seven piece dining set"></asp:Label>
    <br />
    <asp:Label ID="Label27" runat="server" Text="Category: "></asp:Label>
    <asp:Label ID="Label28" runat="server" Text="Dining"></asp:Label>
    <br />
    <asp:Label ID="Label29" runat="server" Text="Unit Price: J$"></asp:Label>
    <asp:Label ID="Label30" runat="server" Text="75000.00"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button2" BackColor="#5E1C00" runat="server" Text="Add To Cart" OnClick="Button2_Click" />
    <br />
    <br />

    <h4 id="sofa">Sofas</h4>
    <asp:Image ID="Image5" src="Images/sofa2.jpg" runat="server" Height="35%" Width="30%" BorderColor="White" />
    <br />
    <br />
    <asp:Label ID="Label31" runat="server" Text="ID: "></asp:Label>
    <asp:Label ID="Label32" runat="server" Text="3943"></asp:Label>
    <br />
    <asp:Label ID="Label33" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="Label34" runat="server" Text="Ocean Living Room Suite"></asp:Label>
    <br />
    <asp:Label ID="Label35" runat="server" Text="Description: "></asp:Label>
    <asp:Label ID="Label36" runat="server" Text="Three piece living room suite"></asp:Label>
    <br />
    <asp:Label ID="Label37" runat="server" Text="Category: "></asp:Label>
    <asp:Label ID="Label38" runat="server" Text="Living Room"></asp:Label>
    <br />
    <asp:Label ID="Label39" runat="server" Text="Unit Price: J$"></asp:Label>
    <asp:Label ID="Label40" runat="server" Text="85000.00"></asp:Label>
    <br />
    <br />
    
    <asp:Button ID="Button3" BackColor="#5E1C00" runat="server" Text="Add To Cart" OnClick="Button3_Click" />
    <br />
    
    <br />

    <h4 id="kitchen">Kitchen</h4>
    <asp:Image ID="Image7" src="Images/fridge4.jpg" runat="server" Height="35%" Width="30%" BorderColor="White" />
    <br />
    <br />
    <asp:Label ID="Label41" runat="server" Text="ID: "></asp:Label>
    <asp:Label ID="Label42" runat="server" Text="1235"></asp:Label>
    <br />
    <asp:Label ID="Label43" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="Label44" runat="server" Text="Riptide Fridge"></asp:Label>
    <br />
    <asp:Label ID="Label45" runat="server" Text="Description: "></asp:Label>
    <asp:Label ID="Label46" runat="server" Text="26 cu. ft. black refridgerator"></asp:Label>
    <br />
    <asp:Label ID="Label47" runat="server" Text="Category: "></asp:Label>
    <asp:Label ID="Label48" runat="server" Text="Kitchen Appliances"></asp:Label>
    <br />
    <asp:Label ID="Label49" runat="server" Text="Unit Price: J$"></asp:Label>
    <asp:Label ID="Label50" runat="server" Text="200000.00"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button4" BackColor="#5E1C00" runat="server" Text="Add To Cart" OnClick="Button4_Click" />
    <br />
    <br /> 

    <h4 id="lamp">Lamps</h4>
    <asp:Image ID="Image9" src="Images/lamp.jpg" runat="server" Height="35%" Width="30%" BorderColor="White" />
    <br />
    <br />
    <asp:Label ID="Label51" runat="server" Text="ID: "></asp:Label>
    <asp:Label ID="Label52" runat="server" Text="5486"></asp:Label>
    <br />
    <asp:Label ID="Label53" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="Label54" runat="server" Text="Maple Floor Lamp"></asp:Label>
    <br />
    <asp:Label ID="Label55" runat="server" Text="Description: "></asp:Label>
    <asp:Label ID="Label56" runat="server" Text="Black floor lamp with LED lighting"></asp:Label>
    <br />
    <asp:Label ID="Label57" runat="server" Text="Category: "></asp:Label>
    <asp:Label ID="Label58" runat="server" Text="Lighting"></asp:Label>
    <br />
    <asp:Label ID="Label59" runat="server" Text="Unit Price: J$"></asp:Label>
    <asp:Label ID="Label60" runat="server" Text="12000.00"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button5" runat="server" BackColor="#5E1C00" Text="Add To Cart" OnClick="Button5_Click" />
    <br />
    <br />

    <h4 id="appliances">Appliances</h4>
    <asp:Image ID="Image11" src="Images/fan4.jpg" runat="server" Height="35%" Width="30%" BorderColor="White" />
    <br />
    <br />
    <asp:Label ID="Label61" runat="server" Text="ID: "></asp:Label>
    <asp:Label ID="Label62" runat="server" Text="9990"></asp:Label>
    <br />
    <asp:Label ID="Label63" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="Label64" runat="server" Text="Midnight Standing Fan"></asp:Label>
    <br />
    <asp:Label ID="Label65" runat="server" Text="Description: "></asp:Label>
    <asp:Label ID="Label66" runat="server" Text="Tall, quiet, black pedastal fan with oscillation"></asp:Label>
    <br />
    <asp:Label ID="Label67" runat="server" Text="Category: "></asp:Label>
    <asp:Label ID="Label68" runat="server" Text="Cooling Devices"></asp:Label>
    <br />
    <asp:Label ID="Label69" runat="server" Text="Unit Price: J$"></asp:Label>
    <asp:Label ID="Label70" runat="server" Text="10000.00"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button6" runat="server" BackColor="#5E1C00" Text="Add To Cart" OnClick="Button6_Click" />
    <br />

</asp:Content>