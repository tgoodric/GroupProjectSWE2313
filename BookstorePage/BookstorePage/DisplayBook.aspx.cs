using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
#pragma warning disable 0168

namespace BookstorePage
{
    public partial class DisplayBook : System.Web.UI.Page
    {
        Cart cart;
            protected void Page_Load(object sender, EventArgs e)
            {
            cart = (Cart)Session["Cart"];
            Book current = (Book)Session["CurrentBook"];
            BookTitle.Text = current.Title;
            Author.Text = current.Author;
            ISBN.Text = current.ISBNNumber;
            Description.Text = current.Description;
            //BookPicture.ImageUrl = ("C:\\Users\\Tristan D Goodrich\\Documents\\GitHub\\GroupProjectSWE2313\\BookstorePage\\BookstorePage\\"+current.ISBNNumber+".jpg");
            BookPicture.ImageUrl = ("~/" + current.ISBNNumber + ".jpg");
            CourseSectionProfessor.Text = current.Course + "-00" + current.Section + ", Professor " + current.Professor;
            QtyNew.Text = current.QtyNew + "New: " + current.PriceNew;
            QtyUsed.Text = current.QtyUsed + "Used: " + current.PriceUsed;
            QtyRental.Text = current.QtyRental + "Rental: " + current.PriceRental;
            if (current.EBookAvailable)
            {
                EBook.Visible = true;
                EBook.Text = "E-Book :" + current.PriceEBook;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                byte qtyNew = Convert.ToByte(QuanNew.Text);
                byte qtyUsed = Convert.ToByte(QuanUsed.Text);
                byte qtyRental = Convert.ToByte(QuanRental.Text);
                bool eBook = EBookPurchased.Checked; 
                Book current = (Book)Session["CurrentBook"];
                
                cart.addNewBook(current, qtyNew, qtyUsed, qtyRental, eBook);
                
                Response.Redirect("~/CartPage.aspx");
            }
            catch (FormatException forex)
            {
                ErrMsg.Text = "Please enter non-negative numeric data only.";
                ErrMsg.Visible = true;
            }
            catch(Exception ex)
            {
                ErrMsg.Text = "Quantity entered exceeds number available.";
                ErrMsg.Visible = true;
            }
            
            

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Book current = (Book)Session["CurrentBook"];
            //current
        }
    }
}