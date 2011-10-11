<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Administrator_Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administrator Page</title>
    <link href="css/login-box.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <div style="padding: 200px 0 0 400px;">
    <div id="login-box">

    <H2>Đăng nhập</H2>
    Hệ thống quản trị website GTSVN.NET
    <br />
    <br />
    <div id="login-box-name" style="margin-top:20px;">ID:</div><div id="login-box-field" style="margin-top:20px;">
        <asp:TextBox ID="txtId" runat="server" CssClass="form-login" Width="200" MaxLength="1024"></asp:TextBox></div>
    <div id="login-box-name">Mật khẩu:</div><div id="login-box-field"><asp:TextBox ID="txtPass" runat="server" CssClass="form-login" Width="200" MaxLength="1024" TextMode="Password"></asp:TextBox></div>
    <br />
    <span class="login-box-options"><input type="checkbox" name="1" value="1"> Ghi nhớ <a href="#" style="margin-left:30px;">Quên mật khẩu?</a></span>
    <br />
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:ImageButton ID="btnLogin" ImageUrl="img/login-btn.png" width="103" height="42" 
            style="margin-left:90px;" runat="server" onclick="btnLogin_Click" />
    <br />
    <br />
    <span class="login-box-options" style="color:Red"><asp:Label ID="txtStatus" runat="server" Text=""></asp:Label></span>
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    </div>
    </form>
</body>
</html>
