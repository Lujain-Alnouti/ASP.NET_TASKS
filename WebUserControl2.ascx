<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl2.ascx.cs" Inherits="Task1P21P2.WebUserControl2" %>
<style>
    .divv{
        width:150px;
        margin-left:20%;
        border:2px solid black;
    }
    .md{
        width:150px;
        display:inline-block;
    }
    .sd{
        background-color:aquamarine;
    }
</style>

<div class="divv">
<h4>Your Opinion</h4>
    <asp:Label ID="Label1" runat="server" Text="Excellent"></asp:Label>
    <div class="md">
    <asp:Label ID="exp" runat="server" Text="" Width="" Height="20px" CssClass="sd"></asp:Label>
    </div>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Verygood"></asp:Label>
    <div class="md">
    <asp:Label ID="vgp" runat="server" Text="" Width="" Height="20px" CssClass="sd"></asp:Label></div>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Good"></asp:Label>
     <div class="md">
    <asp:Label ID="gp" runat="server" Text="" Width=""   Height="20px" CssClass="sd"></asp:Label></div>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Poor"></asp:Label>
          <div class="md">
    <asp:Label ID="ppp" runat="server" Text="" Width=""  Height="20px" CssClass="sd"></asp:Label></div>
    <br />
    

</div>