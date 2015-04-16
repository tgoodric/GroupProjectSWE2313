<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="BookstorePage.CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Cart:<br />
        <br />
    <asp:GridView ID="gridViewCart" runat="server" />

    </div>
        <p style="margin-left: 600px">
            TOTAL:
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="margin-left: 600px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Proceed to Checkout" />
            <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" style="margin-top: 0px" Text="Back to Search" />
        </p>
    </form>
</body>
</html>
