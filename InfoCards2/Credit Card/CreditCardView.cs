using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCardView : Form
    {
        //Assigns the credit card class as a local name ready to be used in the whole program
        CreditCard creditCard;
        public CreditCardView()
        {
            InitializeComponent();
        }

        //pulls all the apropriate information from the credit card class for the view form.
        public CreditCard CreditCard
        {
            get
            {
                return creditCard;
            }
            set
            {
                creditCard = value;
            }
        }

        /*Function is assigning all the data from the credit card class to the labels in the form once the user 
          clicks to load a form*/
        private void CreditCardView_Load(object sender, EventArgs e)
        {
            labelCardNameInput.Text = CreditCard.Name;
            labelCardNumberInput.Text =  CreditCard.CardNumber;
            labelStartDateInput.Text = CreditCard.StartDateDay;
            labelStartDateYearInput.Text = CreditCard.StartDateYear;
            labelExpiryDateDayInput.Text = CreditCard.ExpiryDateDay;
            labelExpiryDateYearInput.Text = CreditCard.ExpiryDateYear;
            labelNameOnCardInput.Text = CreditCard.NameOnCard;
            labelCVCInput.Text = CreditCard.CVCNumber;
        }
    }
}
