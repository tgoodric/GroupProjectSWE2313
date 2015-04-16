using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace BookstorePage
{
    public partial class CartPage : System.Web.UI.Page
    {
        List<BookOrder> cartList = new List<BookOrder>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Cart cart = (Cart)Session["Cart"];
            DataTable resultsTable = new DataTable();
            cartList = cart.books;

            resultsTable.Columns.Add("Cover");
            resultsTable.Columns.Add("Title");
            resultsTable.Columns.Add("Author");
            resultsTable.Columns.Add("Quantity New");
            resultsTable.Columns.Add("Quantity Used");
            resultsTable.Columns.Add("Quantity Rental");
            resultsTable.Columns.Add("eBook?");
            resultsTable.Columns.Add("Price");
         
           
            //Putting results into grid

            for (int i = 0; i < cartList.Count; i++ )
            { 
                DataRow dRow = resultsTable.NewRow();
                dRow["Title"] = cartList[i].Book.Title;
                dRow["Author"] = cartList[i].Book.Author;
                dRow["Quantity New"] = cartList[i].QuantityNew;
                dRow["Quantity Used"] = cartList[i].QuantityUsed;
                dRow["Quantity Rental"] = cartList[i].QuantityRental;
                dRow["eBook?"] = cartList[i].EBookPurchased;
                dRow["Price"] = "$" + cartList[i].getTotal();
                

                Image img = new Image();
                img.ImageUrl = Server.MapPath("~/" + cartList[i].Book.ISBNNumber + ".jpg");

                dRow["Cover"] = ResolveUrl("~/" + cartList[i].Book.ISBNNumber + ".jpg");


                resultsTable.Rows.Add(dRow);
                resultsTable.AcceptChanges();
        
            }

               gridViewCart.DataSource = resultsTable;
            gridViewCart.DataBind();

            gridViewCart.Visible = true;

            for (int i = 0; i < cartList.Count; i++)
            {
                //COVER IMAGE BUTTON 
                ImageButton imgButt = new ImageButton();
                imgButt.ID = "" + i;
                imgButt.Height = 400;
                imgButt.Width = 200;

                imgButt.ImageUrl = ResolveUrl(cartList[i].Book.ISBNNumber + ".jpg");
                gridViewCart.Rows[i].Cells[0].Controls.Add(imgButt);
                imgButt.Click += button_Select;
                Label2.Text = "$" + cart.getOrderTotal();
            }
        }

        

            private void button_Select(object button, ImageClickEventArgs e)
            {
                ImageButton temporary = button as ImageButton;
                Session.Add("CurrentBook", cartList[Convert.ToInt32(temporary.ID)]);
                
                Response.Redirect("DisplayBook.aspx");

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/Checkout.aspx");
            }

            protected void Button2_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/HomePage.aspx");
            }
            
         
            
        }

        }
    