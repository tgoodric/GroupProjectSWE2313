using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
#pragma warning disable 0168, 0659

namespace BookstorePage
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            char[] delimiters = { '\t' };
            string currentBook = null;
            string[] split = null;
            StreamReader fileIn = null;
            //List<Book> booksList = new List<Book>();
            Session["BooksList"] = new List<Book>();
            Session["Cart"] = new Cart();
            List<Book> booksList = (List<Book>)Session["BooksList"];
            try
            {
                //fileIn = new StreamReader("C:\\Users\\Tristan D Goodrich\\Documents\\GitHub\\GroupProjectSWE2313\\BookstorePage\\BookstorePage\\bookDataVersion1.txt");
                fileIn = new StreamReader("bookDataVersion1.txt");

                while (fileIn.Peek() != -1)
                {
                    //create new Book objects
                    currentBook = fileIn.ReadLine();
                    //Label1.Text = currentBook; //debug code
                    if (currentBook[0] == '9')
                    {
                        split = currentBook.Split(delimiters);
                        //nasty constructor call changed for the sake of not having a 4-line constructor call
                        booksList.Add(new Book(split));
                    }
                }
                Session["BooksList"] = booksList;
            }
            catch (IOException ioex)
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
}