using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstorePage
{
    public partial class OrderConfirmationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Book> booksList = (List<Book>)Session["Books"];
            Cart cart = (Cart)Session["Cart"];
            for (int i = 0; i < cart.books.Count; i++)
            {
                //Update book entries 
                //= cart.books[i].
            } 
        }
    }
}