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
            List<Book> results = (List<Book>)Session["Results"];
            List<Label> bookInformation = new List<Label>(); //Might not need
            for (int i = 0; i < results.Count; i++)
            {
                //Console.WriteLine(results[i].Title);
                bookInformation.Add(new Label());
                //bookInformation[i].Text = results[i];
            }
        }
    }
}