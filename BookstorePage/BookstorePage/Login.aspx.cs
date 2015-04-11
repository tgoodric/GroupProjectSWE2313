using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstorePage
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int attempts = 0;
        }

        protected void UsernameField_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader fileIn = new System.IO.StreamReader("passwords.txt");
            bool matchFound = false;
            string current = null;
            string[] split = null;
            string username = UsernameField.Text;
            string password = PasswordField.Text;
            char[] delimiters = { ',' };
            while(!matchFound && fileIn.Peek()!=-1)
            {
                current = fileIn.ReadLine();
                split = current.Split(delimiters); 
                if(username.Equals(split[0]) && password.Equals(split[1]))
                {
                    matchFound = true;
                }
            }
            //UsernameField.Text
            fileIn.Close();
        }
    }
}