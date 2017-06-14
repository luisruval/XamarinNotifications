<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="devxamarinService.demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial;
        }
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server" class="newStyle1">
        <div>
        </div>
    <p class="newStyle1">
        Demo Azure Push Notifications</p>
    <p class="newStyle1">
        Sending notifications</p>
        <p class="newStyle1">
            &nbsp;</p>
        <p class="newStyle1">
            Text to Send</p>
        <p class="newStyle1">
            <asp:TextBox ID="txtToSend" runat="server" CssClass="auto-style1" Width="431px"></asp:TextBox>
        </p>
        <asp:Button ID="btnSendNotifications" runat="server" OnClick="btnSendNotifications_Click" Text="Button" />
    </form>
    </body>
</html>
