using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class DebitCard : IInfoCard
    {
        /*All the private variables that will be used to store the values pulled from the editCreditCardForm
          are created here*/
        string _cardName;
        string _category;
        string _cardNumber;
        string _startDateDay;
        string _startDateYear;
        string _expiryDateDay;
        string _expiryDateYear;
        string _sortCode;
        string _nameOnCard;
        string _accountNumber;
        string _cvcNumber;

        //Opens forms ready to use in functions.
        DebitCardForm debitCardFormView;
        DebitCardView debitCardView = null;

        //Sets all the private variables to null ready to store values
        public DebitCard()
        {
            _cardName = "";
            _category = "Debit Card";
            _cardNumber = "";
            _startDateDay = "";
            _startDateYear = "";
            _expiryDateDay = "";
            _expiryDateYear = "";
            _sortCode = "";
            _nameOnCard = "";
            _accountNumber = "";
            _cvcNumber = "";
        }
        //Assigns the values of the private variables to local strings.
        public DebitCard(string Name,
            string Category,
            string CardNumber,
            string StartDateDay,
            string StartDateYear,
            string ExpiryDateDay,
            string ExpiryDateYear,
            string SortCode,
            string NameOnCard,
            string AccountNumber,
            string CVCNumber)
        {
            _cardName = Name;
            _category = Category;
            _cardNumber = CardNumber;
            _startDateDay = StartDateDay;
            _startDateYear = StartDateYear;
            _expiryDateDay = ExpiryDateDay;
            _expiryDateYear = ExpiryDateYear;
            _sortCode = SortCode;
            _nameOnCard = NameOnCard;
            _accountNumber = AccountNumber;
            _cvcNumber = CVCNumber;
        }

        /*These get and set functions are assigned from the private variables containing the values from 
        the form ready to use via public strings created below.*/
        public string Name
        {
            get
            {
                return _cardName;
            }
            set
            {
                _cardName = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public string CardNumber
        {
            get
            {
                return _cardNumber;
            }
            set
            {
                _cardNumber = value;
            }
        }

        public string StartDateDay
        {
            get
            {
                return _startDateDay;
            }
            set
            {
                _startDateDay = value;
            }
        }

        public string StartDateYear
        {
            get
            {
                return _startDateYear;
            }
            set
            {
                _startDateYear = value;
            }
        }

        public string ExpiryDateDay
        {
            get
            {
                return _expiryDateDay;
            }
            set
            {
                _expiryDateDay = value;
            }
        }

        public string ExpiryDateYear
        {
            get
            {
                return _expiryDateYear;
            }
            set
            {
                _expiryDateYear = value;
            }
        }

        public string SortCode
        {
            get
            {
                return _sortCode;
            }
            set
            {
                _sortCode = value;
            }
        }

        public string NameOnCard
        {
            get
            {
                return _nameOnCard;
            }
            set
            {
                _nameOnCard = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        public string CVCNumber
        {
            get
            {
                return _cvcNumber;
            }
            set
            {
                _cvcNumber = value;
            }
        }

        //This function is used to close the DisplayData function
        public void CloseDisplay()
        {
            if (debitCardView.Visible == true)
            {
                new DebitCardView().Show();
                this.CloseDisplay();
                debitCardView.Visible = false;

            }
        }

        //This function displays data currently saved within the program for the user to see when selected.
        public void DisplayData(Panel displayPanel)
        {
            debitCardView = new DebitCardView();
            debitCardView.DebitCard = this;
            if (debitCardView.ShowDialog() == DialogResult.OK)
            {
                debitCardView.Visible = true;
            }
        }

        /*This function gets all the values inputted by the user in the CreditCardForm and assigns them to 
        local variables ready to use within this class.*/
        public bool EditData()
        {
            debitCardFormView = new DebitCardForm();
            debitCardFormView.DebitCard = this;
            if (debitCardFormView.ShowDialog() == DialogResult.OK)
            {
                Name = debitCardFormView.DebitCard.Name;
                CardNumber = debitCardFormView.DebitCard.CardNumber;
                StartDateDay = debitCardFormView.DebitCard.StartDateDay;
                StartDateYear = debitCardFormView.DebitCard.StartDateYear;
                ExpiryDateDay = debitCardFormView.DebitCard.ExpiryDateDay;
                ExpiryDateYear = debitCardFormView.DebitCard.ExpiryDateYear;
                SortCode = debitCardFormView.DebitCard.SortCode;
                NameOnCard = debitCardFormView.DebitCard.NameOnCard;
                AccountNumber = debitCardFormView.DebitCard.AccountNumber;
                CVCNumber = debitCardFormView.DebitCard.CVCNumber;
                return true;
            }
            return false;
        }

        /*This function gets all the data within the local variables and writes all of the values in one string
         seperated by the '|' symbol ready to be used in the factory.*/
        public string GetDataAsString()
        {
            string[] strDataJoined = { Category, Name, CardNumber, StartDateDay, StartDateYear, ExpiryDateDay, ExpiryDateYear, SortCode, NameOnCard, AccountNumber, CVCNumber };
            string str = string.Join("|", strDataJoined);
            return str;
        
        }
    }
}
