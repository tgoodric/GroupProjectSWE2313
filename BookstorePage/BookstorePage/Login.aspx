<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookstorePage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Please enter your username and password or sign in as guest.
        <br />
        <br />
        Username:<br />
    </div>
        <asp:TextBox ID="UsernameField" runat="server" OnTextChanged="UsernameField_TextChanged"></asp:TextBox>
        <br />
        <br />
        Password:<br />
        <asp:TextBox ID="PasswordField" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Guest" />
    </form>
</body>
</html>
