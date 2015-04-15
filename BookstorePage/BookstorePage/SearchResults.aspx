<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="BookstorePage.SearchResults" %>

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
    
       

       <asp:Table ID="resultsTable" runat="server" />

    </div>
    </form>
</body>
</html>
