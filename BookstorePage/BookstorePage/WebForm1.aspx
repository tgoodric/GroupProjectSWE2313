<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BookstorePage.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Search by: "></asp:Label>
    
    &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="SearchBy" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Course</asp:ListItem>
            <asp:ListItem>Section</asp:ListItem>
            <asp:ListItem>Professor</asp:ListItem>
            <asp:ListItem>Title</asp:ListItem>
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Semester</asp:ListItem>
            <asp:ListItem>CRN</asp:ListItem>
            <asp:ListItem>ISBN</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="SearchBar" runat="server" OnTextChanged="TextBox1_TextChanged" Width="180px"></asp:TextBox>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
    
    </div>
    </form>
</body>
</html>
