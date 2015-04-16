using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace BookstorePage
{

    public partial class SearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e, List<Book> b)
        {
            List<Book> searchResultsList = (List<Book>)Session["Results"];
            DataTable resultsTable = new DataTable();
            b= searchResultsList;
            GridView gridView1 = new GridView();
           
            //Putting results into grid
            foreach (Book i in searchResultsList)
            {// IMAGE COLUMN: resultsTable.Columns.Add(new DataColumn(i.Cover, typeof(Image))); 
                resultsTable.Rows.Add(i.ImageUrl, i.Title, i.Author, i.Description, i.ISBNNumber, i.CRNNumber, i.Course, i.Section, i.Semester, i.Professor);
                //resultsTable.Columns.Add(new DataColumn(i.Title, typeof(string))); 
                //resultsTable.Columns.Add(new DataColumn(i.Author, typeof(string)));
                //resultsTable.Columns.Add(new DataColumn(i.Description, typeof(string))); 
                //resultsTable.Columns.Add(new DataColumn(i.ISBNNumber, typeof(string))); 
                //resultsTable.Columns.Add(new DataColumn(i.CRNNumber, i.Course, i.Section, i.Semester, i.Professor, typeof(string))); 
         
            }
            gridView1.DataSource= resultsTable;
        }
        
            //MIGHT NOT NEED THIS HTML CONVERSION
//            protected string convertTabletoHTML (DataTable dt)  
//{  
    
//StringBuilder htmlStringConvert = new StringBuilder();  
//htmlStringConvert.Append("<html >");  
//htmlStringConvert.Append("<head>");  
//htmlStringConvert.Append("</head>");  
//htmlStringConvert.Append("<body>");  
//htmlStringConvert.Append("<table border='1px' cellpadding='1' cellspacing='1' bgcolor='lightyellow' style='font-family:Garamond; font-size:smaller'>");  
  
//htmlStringConvert.Append("<tr >");  
//foreach (DataColumn myColumn in dt.Columns)  
//{  
//htmlStringConvert.Append("<td >");  
//htmlStringConvert.Append(myColumn.ColumnName);  
//htmlStringConvert.Append("</td>");  
  
//}  
//htmlStringConvert.Append("</tr>");  
  
  
//foreach (DataRow myRow in dt.Rows)  
//{  
  
//htmlStringConvert.Append("<tr >");  
//foreach (DataColumn myColumn in dt.Columns)  
//{  
//htmlStringConvert.Append("<td >");  
//htmlStringConvert.Append(myRow[myColumn.ColumnName].ToString());  
//htmlStringConvert.Append("</td>");  
  
//}  
//htmlStringConvert.Append("</tr>");  
//}  
  
////Close tags.  
//htmlStringConvert.Append("</table>");  
//htmlStringConvert.Append("</body>");  
//htmlStringConvert.Append("</html>");  
  
//string htmlstringTable = htmlStringConvert.ToString();  
  
//return htmlstringTable;  
  
//}  
            
        }


    }
