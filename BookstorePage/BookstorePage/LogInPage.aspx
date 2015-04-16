<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookstorePage.Login" %>
<!DOCTYPE html>

<script runat="server">
       

  
    protected void Button2_Click(object sender, EventArgs e)
    {

        Response.Redirect("Welcome.aspx");
        
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="179px" ImageUrl="~/Images/bookstorebanner.png" Width="1373px" />
    
    </div>
    <p style =" font: bold 30px arial;">
        Log in to your student account</p>
    <p style="font-style: normal; font-variant: normal;font-size: 20px; line-height: normal; font-family: arial">
        SPSU email address:
        <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="225px"></asp:TextBox>
    </p>
        <p style="font-style: normal; font-variant: normal;font-size: 20px; line-height: normal; font-family: arial">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; password:
            <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="224px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </p>
    <p style="font-style: normal; font-variant: normal; font-weight: bold; font-size: 30px; line-height: normal; font-family: arial">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" />
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log in" />
        </p>
    </form>
    </body>
</html>
