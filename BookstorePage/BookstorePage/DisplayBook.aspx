<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayBook.aspx.cs" Inherits="BookstorePage.DisplayBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="BookTitle" runat="server" Text="Title"></asp:Label>
        <br />
        <br />
        <asp:Image ID="BookPicture" runat="server" Height="600px" Width="400px" />
        <br />
        <br />
        <asp:Label ID="Author" runat="server" Text="Author"></asp:Label>
        <br />
        <asp:Label ID="ISBN" runat="server" Text="ISBN"></asp:Label>
        <br />
        <asp:Label ID="Description" runat="server" Text="Description"></asp:Label>
        <br />
        <asp:Label ID="CourseSectionProfessor" runat="server" Text="CourseSectionProfessor"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ErrMsg" runat="server" Text="Error" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="QtyNew" runat="server" Text="QtyNew @ Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="QuanNew" runat="server" OnTextChanged="TextBox1_TextChanged">0</asp:TextBox>
        <asp:Label ID="NewErrMsg" runat="server" Text="New"></asp:Label>
        <br />
        <asp:Label ID="QtyUsed" runat="server" Text="QtyUsed @ Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="QuanUsed" runat="server" OnTextChanged="TextBox1_TextChanged">0</asp:TextBox>
&nbsp;<asp:Label ID="UsedErrMsg" runat="server" Text="Used"></asp:Label>
&nbsp;&nbsp;
        <br />
        <asp:Label ID="QtyRental" runat="server" Text="QtyRental @ Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="QuanRental" runat="server" OnTextChanged="TextBox1_TextChanged">0</asp:TextBox>
        <asp:Label ID="RentalErrMsg" runat="server" Text="Rental"></asp:Label>
        <br />
        <asp:Label ID="EBook" runat="server" Text="EBook @ Price" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="EBookPurchased" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Purchase E-Book?" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="PurchaseButton" runat="server" OnClick="Button1_Click" Text="Add to Cart" />
    
    </div>
    </form>
</body>
</html>
