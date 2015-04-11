using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookstorePage
{
    public partial class CreditCardValidation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Month0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cosmetic, does nothing
        }

        protected void Month1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private string removeNonDigits(string input)
        {
            string retVal = "";
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])//inelegant, but it works
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        {
                            retVal += input[i];
                            break;
                        }
                    default:
                        break;
                }
            }
            TestingLbl.Text = retVal;
            TestingLbl.Visible = true;
            return retVal;
        }
        
        protected void Submit_Click(object sender, EventArgs e)
        {
            NumericDataOnly.Visible = false;
            CardNumberContainsLetters.Visible = false;
            CardNumberWrongLength.Visible = false;
            ErrorSecurityCode.Visible = false;
            ExpiredCard.Visible = false;
            string cardNumber = null; //temp
            int expirationYear = 0;
            int expirationMonth = 0;
            int securityCode = 0;
            bool valid = true;
            DateTime expirationDate = new DateTime();
            try
            {
                expirationYear = Convert.ToInt32(Year.Text);
                expirationMonth = Convert.ToInt32(Month.Text);
                securityCode = Convert.ToInt32(SecCode.Text);
                cardNumber = CardNumBox.Text;
                cardNumber = removeNonDigits(cardNumber);
                expirationDate=new DateTime(expirationYear, expirationMonth, 1);
                if(expirationDate < DateTime.Now)
                {
                    ExpiredCard.Visible = true;
                    valid = false;
                }
                if (securityCode!=777)
                {
                    ErrorSecurityCode.Visible = true;
                    valid = false;
                }
                if(cardNumber.Length != 16)//check for 16 digits
                {
                    CardNumberWrongLength.Visible = true;
                    valid = false;
                    //throw new Exception();
                }

            }
            catch(FormatException fex)
            {
                NumericDataOnly.Visible = true;
            }
            catch(Exception ex)
            {
                //deliberately
            }
            if (valid)
            {
                Response.Redirect("~/OrderConfirmationPage.aspx");
            }
        }

        protected void Month_TextChanged(object sender, EventArgs e)
        {

        }
    }
}