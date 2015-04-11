<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCardValidation.aspx.cs" Inherits="BookstorePage.CreditCardValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Checkout Step 2/2:<br />
        <br />
        Enter Billing Address:<br />
        <br />
        Street:
        <asp:TextBox ID="TextBox1" runat="server" Width="287px"></asp:TextBox>
        <br />
        <br />
        City: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;State:
        <asp:TextBox ID="TextBox3" runat="server" Width="46px"></asp:TextBox>
        Zip:<asp:TextBox ID="TextBox4" runat="server" Width="84px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="CardNumberWrongLength" runat="server" Text="Card Number Must Be 16 Digits" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="CardNumberContainsLetters" runat="server" Text="Card number must only contain digits 0-9." Visible="False"></asp:Label>
        <br />
        <asp:Label ID="ExpiredCard" runat="server" Text="Card expiration date must be in future" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="ErrorSecurityCode" runat="server" Text="Security Code Mismatch" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="NumericDataOnly" runat="server" Text="Enter Only Numeric Data" Visible="False"></asp:Label>
        <br />
        <br />
        Select Card Type:<br />
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Visa</asp:ListItem>
            <asp:ListItem>MasterCard</asp:ListItem>
            <asp:ListItem>American Express</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Enter expiration date:<br />
        <br />
        <asp:TextBox ID="Month" runat="server" OnTextChanged="Month_TextChanged" Width="30px">MM</asp:TextBox>
        <asp:TextBox ID="Year" runat="server" OnTextChanged="Month0_TextChanged" Width="49px">YYYY</asp:TextBox>
        <br />
        <br />
        Enter Card Number:<br />
        <br />
        <asp:TextBox ID="CardNumBox" runat="server" Height="22px" OnTextChanged="Month1_TextChanged" Width="217px"></asp:TextBox>
        <br />
        <br />
        Enter Security Code:<br />
        <br />
        <asp:TextBox ID="SecCode" runat="server" Width="48px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="CancelButton" runat="server" OnClick="Button1_Click" Text="Cancel" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
