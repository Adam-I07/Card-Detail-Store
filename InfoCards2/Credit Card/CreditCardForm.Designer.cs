
namespace Assignment
{
    partial class CreditCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.labelCVC = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStartDateDay = new System.Windows.Forms.TextBox();
            this.textBoxExpiryDateDay = new System.Windows.Forms.TextBox();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.startDateSlash = new System.Windows.Forms.Label();
            this.expiryDateSlash = new System.Windows.Forms.Label();
            this.textBoxStartDateYear = new System.Windows.Forms.TextBox();
            this.textBoxExpiryDateYear = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCVC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(33, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(33, 58);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(72, 13);
            this.labelCardNumber.TabIndex = 1;
            this.labelCardNumber.Text = "Card Number:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(33, 93);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(58, 13);
            this.labelStartDate.TabIndex = 2;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Location = new System.Drawing.Point(33, 123);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(64, 13);
            this.labelExpiryDate.TabIndex = 3;
            this.labelExpiryDate.Text = "Expiry Date:";
            // 
            // labelNameOnCard
            // 
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(33, 150);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(78, 13);
            this.labelNameOnCard.TabIndex = 4;
            this.labelNameOnCard.Text = "Name on Card:";
            // 
            // labelCVC
            // 
            this.labelCVC.AutoSize = true;
            this.labelCVC.Location = new System.Drawing.Point(37, 179);
            this.labelCVC.Name = "labelCVC";
            this.labelCVC.Size = new System.Drawing.Size(34, 13);
            this.labelCVC.TabIndex = 5;
            this.labelCVC.Text = "CVC: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(111, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(229, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxStartDateDay
            // 
            this.textBoxStartDateDay.Location = new System.Drawing.Point(111, 86);
            this.textBoxStartDateDay.Name = "textBoxStartDateDay";
            this.textBoxStartDateDay.Size = new System.Drawing.Size(31, 20);
            this.textBoxStartDateDay.TabIndex = 8;
            this.textBoxStartDateDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartDateDay_KeyPress);
            // 
            // textBoxExpiryDateDay
            // 
            this.textBoxExpiryDateDay.Location = new System.Drawing.Point(111, 116);
            this.textBoxExpiryDateDay.Name = "textBoxExpiryDateDay";
            this.textBoxExpiryDateDay.Size = new System.Drawing.Size(31, 20);
            this.textBoxExpiryDateDay.TabIndex = 9;
            this.textBoxExpiryDateDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpiryDateDay_KeyPress);
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(111, 147);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(229, 20);
            this.textBoxNameOnCard.TabIndex = 10;
            this.textBoxNameOnCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameOnCard_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(239, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 39);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(111, 214);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 39);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // startDateSlash
            // 
            this.startDateSlash.AutoSize = true;
            this.startDateSlash.Location = new System.Drawing.Point(148, 93);
            this.startDateSlash.Name = "startDateSlash";
            this.startDateSlash.Size = new System.Drawing.Size(12, 13);
            this.startDateSlash.TabIndex = 14;
            this.startDateSlash.Text = "/";
            // 
            // expiryDateSlash
            // 
            this.expiryDateSlash.AutoSize = true;
            this.expiryDateSlash.Location = new System.Drawing.Point(148, 123);
            this.expiryDateSlash.Name = "expiryDateSlash";
            this.expiryDateSlash.Size = new System.Drawing.Size(12, 13);
            this.expiryDateSlash.TabIndex = 15;
            this.expiryDateSlash.Text = "/";
            // 
            // textBoxStartDateYear
            // 
            this.textBoxStartDateYear.Location = new System.Drawing.Point(166, 86);
            this.textBoxStartDateYear.Name = "textBoxStartDateYear";
            this.textBoxStartDateYear.Size = new System.Drawing.Size(60, 20);
            this.textBoxStartDateYear.TabIndex = 16;
            this.textBoxStartDateYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartDateYear_KeyPress);
            // 
            // textBoxExpiryDateYear
            // 
            this.textBoxExpiryDateYear.Location = new System.Drawing.Point(167, 116);
            this.textBoxExpiryDateYear.Name = "textBoxExpiryDateYear";
            this.textBoxExpiryDateYear.Size = new System.Drawing.Size(59, 20);
            this.textBoxExpiryDateYear.TabIndex = 17;
            this.textBoxExpiryDateYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpiryDateYear_KeyPress);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(111, 55);
            this.textBoxCardNumber.Mask = "0000-0000-0000-0000";
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(229, 20);
            this.textBoxCardNumber.TabIndex = 18;
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Location = new System.Drawing.Point(111, 179);
            this.textBoxCVC.Mask = "000";
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(229, 20);
            this.textBoxCVC.TabIndex = 19;
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 273);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.textBoxExpiryDateYear);
            this.Controls.Add(this.textBoxStartDateYear);
            this.Controls.Add(this.expiryDateSlash);
            this.Controls.Add(this.startDateSlash);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxNameOnCard);
            this.Controls.Add(this.textBoxExpiryDateDay);
            this.Controls.Add(this.textBoxStartDateDay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCVC);
            this.Controls.Add(this.labelNameOnCard);
            this.Controls.Add(this.labelExpiryDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelName);
            this.Name = "CreditCardForm";
            this.Text = "Edit Credit Card Details";
            this.Load += new System.EventHandler(this.CreditCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.Label labelNameOnCard;
        private System.Windows.Forms.Label labelCVC;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStartDateDay;
        private System.Windows.Forms.TextBox textBoxExpiryDateDay;
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label startDateSlash;
        private System.Windows.Forms.Label expiryDateSlash;
        private System.Windows.Forms.TextBox textBoxStartDateYear;
        private System.Windows.Forms.TextBox textBoxExpiryDateYear;
        private System.Windows.Forms.MaskedTextBox textBoxCardNumber;
        private System.Windows.Forms.MaskedTextBox textBoxCVC;
    }
}