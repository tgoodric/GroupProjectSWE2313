using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Text;
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
            string username = (string) Session["Username"];
            StringBuilder sb = new StringBuilder();
            try
            {
                StreamReader reader = new StreamReader(Server.MapPath("TransactionRecord.txt"));
                while(reader.Peek() != -1)
                {
                    sb.AppendLine(reader.ReadLine());
                }
                
            }
            catch(IOException ioex)
            {
                //display end of file
            }
            
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
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(Server.MapPath("bookDataVersion1.txt"));
                //I think that's the right command...
                for (int i = 0; i < booksList.Count; i++)
                {
                    writer.WriteLine(booksList[i].ToString());
                }
            }
            catch (IOException ioex)
            {
                //display something saying it's borked
            }
            finally
            {
                writer.Close();
                writer = null;
            }
            //Begin record code: may be eliminated in future
            try
            {
                writer = new StreamWriter(Server.MapPath("TransactionRecord.txt"));
                //dump records to file
                //add books and total to new record
                sb.Append(username + "\t");
                foreach (BookOrder order in cart.books)
                {
                    sb.Append(order.Book.Title);
                }
                writer.Write(sb.ToString());
            }
            catch(IOException ioex)
            {
                //do the same thing as above
            }
            finally
            {
                writer.Close();
                writer = null;
            }
            //end new code
        }
    }
}