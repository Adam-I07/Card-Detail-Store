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
    public partial class CreditCardForm : Form
    {
        // Creates a new credit card
        CreditCard newCreditCard = new CreditCard();
        string category;

        
        public CreditCardForm()
        {
            InitializeComponent();
            //automatically assigns the category for all forms
            category = "Credit Card";
        }
        /*Sends all the information inputted by the user to the DebitCard class.
        while also pulling all the apropriate information to display when the user wants to edit the existing details*/
        public CreditCard CreditCard
        {
            set
            {
                newCreditCard = value;
            }
            get
            {
                return newCreditCard;
            }
        }
        //Once save button is clicked all the information inputted by the user is sent to 'Public CreditCard CreditCard'
        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*Once the save button is clicked the information the if statement checks to make sure that
            all the text boxes have values wihtin them if not it wll display a error message and not save. */
            if (textBoxName.Text == "" || textBoxCardNumber.Text == "" || textBoxStartDateDay.Text == "" || textBoxStartDateYear.Text == "" || textBoxExpiryDateDay.Text == "" || textBoxExpiryDateYear.Text == "" || textBoxNameOnCard.Text == "" || textBoxCVC.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                newCreditCard.Name = textBoxName.Text;
                newCreditCard.Category = category;
                newCreditCard.CardNumber = textBoxCardNumber.Text;
                newCreditCard.StartDateDay = textBoxStartDateDay.Text;
                newCreditCard.StartDateYear = textBoxStartDateYear.Text;
                newCreditCard.ExpiryDateDay = textBoxExpiryDateDay.Text;
                newCreditCard.ExpiryDateYear = textBoxExpiryDateYear.Text;
                newCreditCard.NameOnCard = textBoxNameOnCard.Text;
                newCreditCard.CVCNumber = textBoxCVC.Text;
                DialogResult = DialogResult.OK;
            }
        }

        //This function is called when the user clicks cancel then it will delete all the values inputed and discard the form.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        /*This function will load all the information of the card selected by the user in the textboxes 
         ready for the user to edit and save.*/
        private void CreditCardForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = newCreditCard.Name;
            textBoxCardNumber.Text = newCreditCard.CardNumber;
            textBoxStartDateDay.Text = newCreditCard.StartDateDay;
            textBoxStartDateYear.Text = newCreditCard.StartDateYear;
            textBoxExpiryDateDay.Text = newCreditCard.ExpiryDateDay;
            textBoxExpiryDateYear.Text = newCreditCard.ExpiryDateYear;
            textBoxNameOnCard.Text = newCreditCard.NameOnCard;
            textBoxCVC.Text = newCreditCard.CVCNumber;
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
         digit or else it will send an error message.*/
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult nameValidation = MessageBox.Show("This field only accepts letters!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult cardNumberValidation = MessageBox.Show("This field only accepts numbers!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxStartDateDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult startDateDayValidation = MessageBox.Show("This field only accpets numbers between 1 and 31!","error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxStartDateYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult startDateYearValidation = MessageBox.Show("This field only accepts numbers", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxExpiryDateDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult expiryDayDateValidation = MessageBox.Show("This field only accepts numbers between 1 and 31!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxExpiryDateYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult expiryDayYearValidation = MessageBox.Show("This field only accepts numbers", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
         digit or else it will send an error message.*/
        private void textBoxNameOnCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult nameOnCardValidation = MessageBox.Show("This field only accepts letters!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult cvcNumberValidation = MessageBox.Show("This field only accepts numbers!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
