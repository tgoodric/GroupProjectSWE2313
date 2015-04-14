﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="BookstorePage.Login" %>

<!DOCTYPE html>

<script runat="server">

    protected void Page_Load(object sender,EventArgs e)//Oh god please work
    {
        #pragma warning disable 0168
        {
            char[] delimiters = { '\t' };
            string currentBook = null;
            string[] split = null;
            System.IO.StreamReader fileIn = null;
            //List<Book> booksList = new List<Book>();
            Session["Books"] = new List<BookstorePage.Book>();
            Session["Cart"] = new BookstorePage.Cart();
            List<BookstorePage.Book> booksList = (List<BookstorePage.Book>)Session["Books"];
            try
            {
                //fileIn = new StreamReader("C:\\Users\\Tristan D Goodrich\\Documents\\GitHub\\GroupProjectSWE2313\\BookstorePage\\BookstorePage\\bookDataVersion1.txt");
                fileIn = new System.IO.StreamReader(Server.MapPath("bookDataVersion1.txt"));
                while (fileIn.Peek() != -1)
                {
                    //create new Book objects
                    currentBook = fileIn.ReadLine();
                    //Label1.Text = currentBook; //debug code
                    if (currentBook[0] == '9')
                    {
                        split = currentBook.Split(delimiters);
                        //nasty constructor call changed for the sake of not having a 4-line constructor call
                        booksList.Add(new BookstorePage.Book(split));
                    }
                }
                Session["Books"] = booksList;
            }
            catch (System.IO.IOException ioex)
            {
                //LabelError.Text = "Error: file parsing failure, aborting operation";
            }
            catch (FormatException forex)
            {
                //Label1.Text = booksList[booksList.Count - 1].ISBNNumber;
            }
            finally
            {
                fileIn.Close();
            }

        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string searchBy = "";
        searchBy = "Title";
        Session["SearchKey"] = searchBy;
    
    }

    protected void Search_Click(object sender, EventArgs e)
    {
        //REDIRECT TO SEARCH RESULTS PAGE
        Session["SearchResults"] = new List<BookstorePage.Book>();
        List<BookstorePage.Book> results = (List<BookstorePage.Book>)Session["SearchResults"];
        string searchBy = (string)Session["SearchKey"];
        //List[]
        List<BookstorePage.Book> books = (List<BookstorePage.Book>)Session["Books"];
        //provisional:
        string searchTerm;
        for (int i = 0; i < books.Count; i++)
        {
            searchTerm = TextBox1.Text;
            switch (searchBy)
            {
                case "Title":
                    {
                        if (books[i].Title.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }    
                        break;
                    }
                case "Author":
                    {
                        if (books[i].Author.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                case "Professor":
                    {
                        if (books[i].Professor.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                case "Course":
                    {
                        if (books[i].Course.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                case "CRN"://workaround
                    {
                        
                        if (books[i].CRNNumber.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                case "ISBN":
                    {
                        if (books[i].ISBNNumber.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                case "Semester":
                    {
                        if (books[i].Semester.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                case "Section":
                    {
                        if (books[i].Semester.Contains(searchTerm))
                        {
                            results.Add(books[i]);
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            
        }
        Session["SearchResults"] = results;
        Response.Redirect("SearchResultsPage.aspx");
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
        &nbsp;&nbsp;search by <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="129px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
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
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
    </form>
    </body>
</html>