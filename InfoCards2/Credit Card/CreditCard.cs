using System.Windows.Forms;

namespace Assignment
{
    public class CreditCard : IInfoCard
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
        string _nameOnCard;
        string _cvcNumber;


        //Opens forms ready to use in functions.
        CreditCardView creditCardView = null;
        CreditCardForm creditCardFormView;

        //Sets all the private variables to null ready to store values
        public CreditCard()
        {
            _cardName = "";
            _category = "Credit Card";
            _cardNumber = "";
            _startDateDay = "";
            _startDateYear = "";
            _expiryDateDay = "";
            _expiryDateYear = "";
            _nameOnCard = "";
            _cvcNumber = "";

        }

        //Assigns the values of the private variables to local strings.
        public CreditCard(
                string Name,
                string Category,
                string CardNumber,
                string StartDateDay,
                string StartDateYear,
                string ExpiryDateDay,
                string ExpiryDateYear,
                string NameOnCard,
                string CVCNumber)
        {
            _cardName = Name;
            _category = Category;
            _cardNumber = CardNumber;
            _startDateDay = StartDateDay;
            _startDateYear = StartDateYear;
            _expiryDateDay = ExpiryDateDay;
            _expiryDateYear = ExpiryDateYear;
            _nameOnCard = NameOnCard;
            _cvcNumber = CVCNumber;

        }

        /*These get and set functions are assigned the private variables containing the values from the form
        ready to use via public strings created below.*/
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
            if (creditCardView.Visible == true)
            {
                new CreditCardView().Show();
                this.CloseDisplay();
                creditCardView.Visible = false;
            }

        }

        //This function displays data currently saved within the program for the user to see when selected.
        public void DisplayData(Panel displayPanel)
        {
            creditCardView = new CreditCardView();
            creditCardView.CreditCard = this;
            if (creditCardView.ShowDialog() == DialogResult.OK)
            {
                creditCardView.Visible = true;
            }
            
        }

        /*This function gets all the values inputted by the user in the CreditCardForm and assigns them to 
         local variables ready to use within this class.*/
        public bool EditData()
        {
            creditCardFormView = new CreditCardForm();
            creditCardFormView.CreditCard = this;
            if (creditCardFormView.ShowDialog() == DialogResult.OK)
            {
                Name = creditCardFormView.CreditCard.Name;
                CardNumber = creditCardFormView.CreditCard.CardNumber;
                StartDateDay = creditCardFormView.CreditCard.StartDateDay;
                StartDateYear = creditCardFormView.CreditCard.StartDateYear;
                ExpiryDateDay = creditCardFormView.CreditCard.ExpiryDateDay;
                ExpiryDateYear = creditCardFormView.CreditCard.ExpiryDateYear;
                NameOnCard = creditCardFormView.CreditCard.NameOnCard;
                CVCNumber = creditCardFormView.CreditCard.CVCNumber;
                return true;
            }
            
            return false;
        }


       /*This function gets all the data within the local variables and writes all of the values in one string
        seperated by the '|' symbol ready to be used in the factory.*/
        public string GetDataAsString()
        {
            
            string[] strdataJoined = { Category, Name, CardNumber, StartDateDay, StartDateYear, ExpiryDateDay, ExpiryDateYear, NameOnCard, CVCNumber };
            string str = string.Join("|", strdataJoined);
            return str;
        }
    }
}
