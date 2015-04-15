using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
#pragma warning disable 0168

namespace BookstorePage
{
    public partial class OrderConfirmationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //display cart via html magic
        }

        protected void Button1_Click(object sender, EventArgs e) //check this
        {
            List<Book> booksList = (List<Book>)Session["Books"];
            Cart cart = (Cart)Session["Cart"];
            //begin new code
            for (int i = 0; i < cart.books.Count; i++) //outer loop iterates through cart
            {
                for (int j = 0; j < booksList.Count; j++) //inner loop iterates through list of books
                {
                    if (cart.books[i].Book.Equals(booksList[j]))
                    {
                        booksList[j].QtyNew -= cart.books[i].QuantityNew;
                        booksList[j].QtyUsed -= cart.books[i].QuantityUsed;
                        booksList[j].QtyRental -= cart.books[i].QuantityRental;
                    }
                }
            }
            StreamWriter booksOut = null;
            try
            {
                booksOut = new StreamWriter(Server.MapPath("bookDataVersion1.txt"));
                //I think that's the right command...
                for (int i = 0; i < booksList.Count; i++)
                {
                    booksOut.WriteLine(booksList[i].ToString());
                }
            }
            catch (IOException ioex)
            {
                //display something saying it's borked
            }
            finally
            {
                booksOut.Close();
            }
            //end new code
        }
    }
}