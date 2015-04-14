using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstorePage
{
    public partial class SearchResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> results = (List<Book>)Session["SearchResults"];
            if (results.Count < 1)
            {
                //Results.Text = (string)Session["SearchKey"];
                Results.Text = "No results found.";
            }
            else
            {
                Results.Text = results.Count + " Matches found:";
               //here there be dragons: HTML
               for (int i = 0; i < results.Count; i++)
               {
                   //magic happens, results appear
                   //Blake, Disney, this one's on you guys.
               }
            }
            
        }
    }
}