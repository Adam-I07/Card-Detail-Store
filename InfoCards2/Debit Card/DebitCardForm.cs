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
    public partial class DebitCardForm : Form
    {
        // Creates a new debit card
        DebitCard newDebitCard = new DebitCard();
        string category;
        public DebitCardForm()
        {
            InitializeComponent();
            //assigns the category  
            category = "Debit Card";
            
        }

        //Sends all the information inputted by the user to the DebitCard class.
        //Also pulls all the apropriate information to display when the user wants to edit the existing details.
        public DebitCard DebitCard
        {
            set
            {
                newDebitCard = value;
            }
            get
            {
                return newDebitCard;
            }
        }

        //Once save button is clicked all the information inputted by the user is sent to 'Public DebitCard DebitCard'
        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*Once the save button is clicked the information the if statement checks to make sure that
            all the text boxes have values wihtin them if not it wll display a error message and not save. */
            if (textBoxName.Text == "" || textboxCardNumber.Text == "" || textBoxStartDateDay.Text == "" || textBoxStartDateYear.Text == "" || textBoxExpiryDateDay.Text == "" || textBoxExpiryDateYear.Text == "" || textBoxSortCode.Text == "" || textBoxNameOnCard.Text == "" || textBoxAccountNumber.Text == "" || textBoxCVCNumber.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                newDebitCard.Name = textBoxName.Text;
                newDebitCard.Category = category;
                newDebitCard.CardNumber = textboxCardNumber.Text;
                newDebitCard.StartDateDay = textBoxStartDateDay.Text;
                newDebitCard.StartDateYear = textBoxStartDateYear.Text;
                newDebitCard.ExpiryDateDay = textBoxExpiryDateDay.Text;
                newDebitCard.ExpiryDateYear = textBoxExpiryDateYear.Text;
                newDebitCard.SortCode = textBoxSortCode.Text;
                newDebitCard.NameOnCard = textBoxNameOnCard.Text;
                newDebitCard.AccountNumber = textBoxAccountNumber.Text;
                newDebitCard.CVCNumber = textBoxCVCNumber.Text;
                DialogResult = DialogResult.OK;
            }
        }

        //This function is called when the user clicks cancel then it will delete all the values inputed and discard the form.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /*This function will load all the information of the card selected by the user in the textboxes 
        ready for the user to edit and save.*/
        private void DebitCardForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = newDebitCard.Name;
            textboxCardNumber.Text = newDebitCard.CardNumber;
            textBoxStartDateDay.Text = newDebitCard.StartDateDay;
            textBoxStartDateYear.Text = newDebitCard.StartDateYear;
            textBoxExpiryDateDay.Text = newDebitCard.ExpiryDateDay;
            textBoxExpiryDateYear.Text = newDebitCard.ExpiryDateYear;
            textBoxSortCode.Text = newDebitCard.SortCode;
            textBoxNameOnCard.Text = newDebitCard.NameOnCard;
            textBoxAccountNumber.Text = newDebitCard.AccountNumber;
            textBoxCVCNumber.Text = newDebitCard.CVCNumber;
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
         digit or else it will send an error message.*/
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult nameValidation = MessageBox.Show("This field only accepts letters!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult cardNumberValidation = MessageBox.Show("This field only accepts numbers!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/  
        private void textBoxStartDateDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult startDateDayValidation = MessageBox.Show("This field only accepts numbers between 1 and 31!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
          letter or else it will send an error message.*/
        private void textBoxSortCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult sortCodeValidation = MessageBox.Show("This field only accepts numbers", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void textBoxAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult accountNumberValidation = MessageBox.Show("This field only accepts numbers", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*When the user is typing in this textbox this function will make sure they dont enter a
          letter or else it will send an error message.*/
        private void textBoxCVCNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult cvcNumberValidation = MessageBox.Show("This field only accepts numbers!", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
