<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="task1P2.aspx.cs" Inherits="Task1P21P2.task1P2" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<%@ Register Src="~/WebUserControl2.ascx" TagPrefix="uc1" TagName="WebUserControl2" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WebUserControl1 runat="server" id="WebUserControl1"/>
            <uc1:WebUserControl2 runat="server" id="WebUserControl2" Visible = "false"/>
        </div>
        
    </form>
</body>
</html>
