<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Search_Click(object sender, EventArgs e)
    {
        //REDIRECT TO SEARCH RESULTS PAGE
        //Response.Redirect("SearchResults.aspx");
    }

</script>




<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
    
            <asp:Image ID="Image1" runat="server" Height="179px" ImageUrl="~/Images/bookstorebanner.png" Width="1373px" />
        </p>
    <div>
    
        <p style = "font: bold 40px arial;">&nbsp;Home</p></div>
    <p style="font-style: normal; font-variant: normal;  font-size: 30px; line-height: normal; font-family: arial">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p style="font-style: normal; font-variant: normal;  font-size: 20px; line-height: normal; font-family: arial">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        search by <asp:DropDownList ID="DropDownList1" runat="server" Height="90px" Width="129px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Title</asp:ListItem>
                <asp:ListItem>Author</asp:ListItem>
                <asp:ListItem>ISBN</asp:ListItem>
                <asp:ListItem>CRN</asp:ListItem>
                <asp:ListItem>Semester</asp:ListItem>
                <asp:ListItem>Class</asp:ListItem>
                <asp:ListItem>Professor</asp:ListItem>
            </asp:DropDownList>
        &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="620px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Search_Click" Text="Search" />
        </p>
    </form>
    </body>
</html>
