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
    public partial class DebitCardView : Form
    {
        //Assigns the debitCard class a local name for this class ready to be used in the whole program
        DebitCard debitCard;
        public DebitCardView()
        {
            InitializeComponent();
        }

        //pulls all the apropriate information from the debit card class for the view form.
        public DebitCard DebitCard
        {
            get
            {
                return debitCard;
            }
            set
            {
                debitCard = value;
            }
        }

         /*Function is assigning all the data from the debit card class to the labels in the form once the user 
         clicks to load a form*/
        private void DebitCardView_Load(object sender, EventArgs e)
        {
            labelCardNameInput.Text = DebitCard.Name;
            labelCardNumberInput.Text = DebitCard.CardNumber;
            labelStartDateDayInput.Text = DebitCard.StartDateDay;
            labelStartDateYearInput.Text = DebitCard.StartDateYear;
            labelExpiryDateDayInput.Text = DebitCard.ExpiryDateDay;
            labelExpiryDateYearInput.Text = DebitCard.ExpiryDateYear;
            labelSortCodeInput.Text = DebitCard.SortCode;
            labelNameOnCardInput.Text = DebitCard.NameOnCard;
            labelAccountNumberInput.Text = DebitCard.AccountNumber;
            labelCVCInput.Text = DebitCard.CVCNumber;
        }


    }
}
