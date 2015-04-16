<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="BookstorePage.SearchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="BannerImg" runat="server" Height="179px" ImageUrl="~/Images/bookstorebanner.png" Width="1373px" />

        <br />
        
       <p style=" font: bold 20px arial"> DISPLAYING SEARCH RESULTS</p>
    
       

       <asp:GridView ID="gridView1" runat="server" />
        

        <br />

    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
