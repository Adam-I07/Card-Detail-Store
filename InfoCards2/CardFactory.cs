using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CardFactory : IInfoCardFactory
    {
        string[] _categoriesSupported = { "Credit Card", "Debit Card" };
        
        public string[] CategoriesSupported
        {
            get
            {
                return _categoriesSupported;
            }
            set
            {
                _categoriesSupported = value;
            }
        }

        /*This function pulls all the data joined in getDataAsString() then it splits the data from the  
         '|' function and assigns the split data to the correct variable and saves it to the text file. */
        public IInfoCard CreateInfoCard(string initialDetails)
        {
            string cardInformation = initialDetails;
            string[] cardInformationSplit = cardInformation.Split('|');
            string category = cardInformationSplit[0];

            if (category == "Credit Card")
            {
                CreditCard creditCard = new CreditCard();
                creditCard.Category = cardInformationSplit[0];
                creditCard.Name = cardInformationSplit[1];
                creditCard.CardNumber = cardInformationSplit[2];
                creditCard.StartDateDay = cardInformationSplit[3];
                creditCard.StartDateYear = cardInformationSplit[4];
                creditCard.ExpiryDateDay = cardInformationSplit[5];
                creditCard.ExpiryDateYear = cardInformationSplit[6];
                creditCard.NameOnCard = cardInformationSplit[7];
                creditCard.CVCNumber = cardInformationSplit[8];
                return creditCard;
            }
            else if (category == "Debit Card")
            {
                DebitCard debitCard = new DebitCard();
                debitCard.Category = cardInformationSplit[0];
                debitCard.Name = cardInformationSplit[1];
                debitCard.CardNumber = cardInformationSplit[2];
                debitCard.StartDateDay = cardInformationSplit[3];
                debitCard.StartDateYear = cardInformationSplit[4];
                debitCard.ExpiryDateDay = cardInformationSplit[5];
                debitCard.ExpiryDateYear = cardInformationSplit[6];
                debitCard.SortCode = cardInformationSplit[7];
                debitCard.NameOnCard = cardInformationSplit[8];
                debitCard.AccountNumber = cardInformationSplit[9];
                debitCard.CVCNumber = cardInformationSplit[10];
                return debitCard;
            }
            else
            {
                return null;
            }
        }

        //This function returns the class for the user when they click to create a new form in the program
        public IInfoCard CreateNewInfoCard(string category)
        {
            CreditCard creditCard = new CreditCard();
            DebitCard debitCard = new DebitCard();
            if (category == "Credit Card")
            {
                return creditCard;
            }
            else if(category == "Debit Card")
            {
                return debitCard;
            }
            else
            {
                return null;
            }
        }

        /* When the user click 'New...' the program returna the descriptions for the creditcard and 
         * debitcard from here.*/
        public string GetDescription(string category)
        {
            string description;

            if (category == "Credit Card")
            {
                description = "Store details of your current Credit Card.";
                return description;
            }
            else if (category == "Debit Card")
            {
                description = "Store details of your Debit Card.";
                return description;
            }
            else
            {
                return null;
            }
        }
    }
}
