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

    public partial class SearchPage : System.Web.UI.Page
    {
        List<Book> searchResultsList;
        protected void Page_Load(object sender, EventArgs e)
        {
            searchResultsList = (List<Book>)Session["SearchResults"];
            DataTable resultsTable = new DataTable();
            

            resultsTable.Columns.Add("Cover");
            resultsTable.Columns.Add("Title");
            resultsTable.Columns.Add("Author");
            resultsTable.Columns.Add("Description");
            resultsTable.Columns.Add("ISBN");
            resultsTable.Columns.Add("CRN");
            resultsTable.Columns.Add("Course");
            resultsTable.Columns.Add("Section");
            resultsTable.Columns.Add("Semester");
            resultsTable.Columns.Add("Professor");
            resultsTable.Columns.Add("Recommended/Required");
           
            //Putting results into grid

            for (int i = 0; i < searchResultsList.Count; i++ )
            { 
                DataRow dRow = resultsTable.NewRow();
                dRow["Title"] = searchResultsList[i].Title;
                dRow["Author"] = searchResultsList[i].Author;
                dRow["Description"] = searchResultsList[i].Description;
                dRow["ISBN"] = searchResultsList[i].ISBNNumber;
                dRow["CRN"] = searchResultsList[i].CRNNumber;
                dRow["Course"] = searchResultsList[i].Course;
                dRow["Section"] = searchResultsList[i].Section;
                dRow["Semester"] = searchResultsList[i].Semester;
                dRow["Professor"] = searchResultsList[i].Professor;
                dRow["Recommended/Required"] = searchResultsList[i].Use;

                Image img = new Image();
                img.ImageUrl = Server.MapPath("~/" + searchResultsList[i].ISBNNumber + ".jpg");

                dRow["Cover"] = ResolveUrl("~/" + searchResultsList[i].ISBNNumber + ".jpg");


                resultsTable.Rows.Add(dRow);
                resultsTable.AcceptChanges();
        
            }

               gridView1.DataSource = resultsTable;
            gridView1.DataBind();

            gridView1.Visible = true;

            for (int i = 0; i < searchResultsList.Count; i++)
            {
                //COVER IMAGE BUTTON 
                ImageButton imgButt = new ImageButton();
                imgButt.ID = "" + i;
                imgButt.Height = 400;
                imgButt.Width = 200;

                imgButt.ImageUrl = ResolveUrl(searchResultsList[i].ISBNNumber + ".jpg");
                gridView1.Rows[i].Cells[0].Controls.Add(imgButt);
                imgButt.Click += button_Select;

            }
        }

        

            private void button_Select(object button, ImageClickEventArgs e)
            {
                ImageButton temporary = button as ImageButton;
                Session.Add("CurrentBook", searchResultsList[Convert.ToInt32(temporary.ID)]);
                
                Response.Redirect("DisplayBook.aspx");

            }
            
         
            
        }

    }



