using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
#pragma warning disable 0168, 0659 //ignores unused var names warning

namespace BookstorePage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Attempts"] = 0;
        }

        protected void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //System.IO.StreamReader fileIn = new System.IO.StreamReader("C:\\Users\\Tristan D Goodrich\\Documents\\GitHub\\GroupProjectSWE2313\\BookstorePage\\BookstorePage\\passwords.txt");
            System.IO.StreamReader fileIn = new System.IO.StreamReader(Server.MapPath("passwords.txt"));
            bool matchFound = false;
            string current = null;
            string[] split = null;
            string username = UserName.Text;
            string password = Password.Text;
            char[] delimiters = { ',' };
            try
            {
                while (!matchFound && fileIn.Peek() != -1)
                {
                    current = fileIn.ReadLine();
                    split = current.Split(delimiters);
                    if (username.Equals(split[0]) && password.Equals(split[1]))
                    {
                        matchFound = true;
                    }
                }
            }
            catch (IOException ioex)
            {
                //Label1.Visible = true;
                //Label1.Text = "Error accessing database, please try again later";
            }
            //UsernameField.Text
            finally
            {
                fileIn.Close();
            }
            if(matchFound)
            {
                Session["Username"] = username;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Session["Attempts"] = (Int32)Session["Attempts"] + 1;
                //Label1.Visible = true;
                //Label1.Text = "Login failed. You have "+ (3 - (Int32)Session["Attempts"])+" attempt(s) remaining";
            }
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Welcome.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}