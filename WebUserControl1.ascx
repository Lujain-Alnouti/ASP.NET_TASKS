<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Task1P21P2.WebUserControl1" %>

<style>
    .divv{
        width:150px;
        margin-left:20%;
        border:2px solid black;

    }
</style>



 <div class="divv">
     <h4>Your Opinion</h4>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="1">Excellent</asp:ListItem>
            <asp:ListItem Value="2">VeryGoood</asp:ListItem>
            <asp:ListItem Value="3">Good</asp:ListItem>
            <asp:ListItem Value="4">Poor</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>