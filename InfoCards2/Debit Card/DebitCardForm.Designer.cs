
namespace Assignment
{
    partial class DebitCardForm
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
            this.labelStartDay = new System.Windows.Forms.Label();
            this.labelExpiryDay = new System.Windows.Forms.Label();
            this.labelNameOnCard = new System.Windows.Forms.Label();
            this.labelSortCode = new System.Windows.Forms.Label();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelCVCNumber = new System.Windows.Forms.Label();
            this.textBoxNameOnCard = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStartDateDay = new System.Windows.Forms.TextBox();
            this.textBoxExpiryDateDay = new System.Windows.Forms.TextBox();
            this.textBoxStartDateYear = new System.Windows.Forms.TextBox();
            this.textBoxExpiryDateYear = new System.Windows.Forms.TextBox();
            this.labelStartDateSlash = new System.Windows.Forms.Label();
            this.labelExpiryDateSlash = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSortCode = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCVCNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(36, 65);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(72, 13);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number:";
            // 
            // labelStartDay
            // 
            this.labelStartDay.AutoSize = true;
            this.labelStartDay.Location = new System.Drawing.Point(37, 88);
            this.labelStartDay.Name = "labelStartDay";
            this.labelStartDay.Size = new System.Drawing.Size(58, 13);
            this.labelStartDay.TabIndex = 3;
            this.labelStartDay.Text = "Start Date:";
            // 
            // labelExpiryDay
            // 
            this.labelExpiryDay.AutoSize = true;
            this.labelExpiryDay.Location = new System.Drawing.Point(37, 112);
            this.labelExpiryDay.Name = "labelExpiryDay";
            this.labelExpiryDay.Size = new System.Drawing.Size(64, 13);
            this.labelExpiryDay.TabIndex = 4;
            this.labelExpiryDay.Text = "Expiry Date:";
            // 
            // labelNameOnCard
            // 
            this.labelNameOnCard.AutoSize = true;
            this.labelNameOnCard.Location = new System.Drawing.Point(36, 163);
            this.labelNameOnCard.Name = "labelNameOnCard";
            this.labelNameOnCard.Size = new System.Drawing.Size(80, 13);
            this.labelNameOnCard.TabIndex = 5;
            this.labelNameOnCard.Text = "Name On Card:";
            // 
            // labelSortCode
            // 
            this.labelSortCode.AutoSize = true;
            this.labelSortCode.Location = new System.Drawing.Point(36, 139);
            this.labelSortCode.Name = "labelSortCode";
            this.labelSortCode.Size = new System.Drawing.Size(57, 13);
            this.labelSortCode.TabIndex = 6;
            this.labelSortCode.Text = "Sort Code:";
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(36, 189);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.labelAccountNumber.TabIndex = 7;
            this.labelAccountNumber.Text = "Account Number:";
            // 
            // labelCVCNumber
            // 
            this.labelCVCNumber.AutoSize = true;
            this.labelCVCNumber.Location = new System.Drawing.Point(37, 213);
            this.labelCVCNumber.Name = "labelCVCNumber";
            this.labelCVCNumber.Size = new System.Drawing.Size(31, 13);
            this.labelCVCNumber.TabIndex = 8;
            this.labelCVCNumber.Text = "CVC:";
            // 
            // textBoxNameOnCard
            // 
            this.textBoxNameOnCard.Location = new System.Drawing.Point(132, 161);
            this.textBoxNameOnCard.Name = "textBoxNameOnCard";
            this.textBoxNameOnCard.Size = new System.Drawing.Size(217, 20);
            this.textBoxNameOnCard.TabIndex = 10;
            this.textBoxNameOnCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameOnCard_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(217, 20);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxStartDateDay
            // 
            this.textBoxStartDateDay.Location = new System.Drawing.Point(132, 83);
            this.textBoxStartDateDay.Name = "textBoxStartDateDay";
            this.textBoxStartDateDay.Size = new System.Drawing.Size(22, 20);
            this.textBoxStartDateDay.TabIndex = 14;
            this.textBoxStartDateDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartDateDay_KeyPress);
            // 
            // textBoxExpiryDateDay
            // 
            this.textBoxExpiryDateDay.Location = new System.Drawing.Point(132, 109);
            this.textBoxExpiryDateDay.Name = "textBoxExpiryDateDay";
            this.textBoxExpiryDateDay.Size = new System.Drawing.Size(22, 20);
            this.textBoxExpiryDateDay.TabIndex = 15;
            this.textBoxExpiryDateDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpiryDateDay_KeyPress);
            // 
            // textBoxStartDateYear
            // 
            this.textBoxStartDateYear.Location = new System.Drawing.Point(176, 83);
            this.textBoxStartDateYear.Name = "textBoxStartDateYear";
            this.textBoxStartDateYear.Size = new System.Drawing.Size(56, 20);
            this.textBoxStartDateYear.TabIndex = 16;
            this.textBoxStartDateYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartDateYear_KeyPress);
            // 
            // textBoxExpiryDateYear
            // 
            this.textBoxExpiryDateYear.Location = new System.Drawing.Point(176, 109);
            this.textBoxExpiryDateYear.Name = "textBoxExpiryDateYear";
            this.textBoxExpiryDateYear.Size = new System.Drawing.Size(56, 20);
            this.textBoxExpiryDateYear.TabIndex = 17;
            this.textBoxExpiryDateYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExpiryDateYear_KeyPress);
            // 
            // labelStartDateSlash
            // 
            this.labelStartDateSlash.AutoSize = true;
            this.labelStartDateSlash.Location = new System.Drawing.Point(160, 88);
            this.labelStartDateSlash.Name = "labelStartDateSlash";
            this.labelStartDateSlash.Size = new System.Drawing.Size(12, 13);
            this.labelStartDateSlash.TabIndex = 18;
            this.labelStartDateSlash.Text = "/";
            // 
            // labelExpiryDateSlash
            // 
            this.labelExpiryDateSlash.AutoSize = true;
            this.labelExpiryDateSlash.Location = new System.Drawing.Point(160, 112);
            this.labelExpiryDateSlash.Name = "labelExpiryDateSlash";
            this.labelExpiryDateSlash.Size = new System.Drawing.Size(12, 13);
            this.labelExpiryDateSlash.TabIndex = 19;
            this.labelExpiryDateSlash.Text = "/";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(132, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(249, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxCardNumber
            // 
            this.textboxCardNumber.Location = new System.Drawing.Point(132, 58);
            this.textboxCardNumber.Mask = "0000-0000-0000-0000";
            this.textboxCardNumber.Name = "textboxCardNumber";
            this.textboxCardNumber.Size = new System.Drawing.Size(217, 20);
            this.textboxCardNumber.TabIndex = 22;
            // 
            // textBoxSortCode
            // 
            this.textBoxSortCode.Location = new System.Drawing.Point(132, 135);
            this.textBoxSortCode.Mask = "000000";
            this.textBoxSortCode.Name = "textBoxSortCode";
            this.textBoxSortCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxSortCode.TabIndex = 23;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(132, 186);
            this.textBoxAccountNumber.Mask = "00000000";
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(217, 20);
            this.textBoxAccountNumber.TabIndex = 24;
            // 
            // textBoxCVCNumber
            // 
            this.textBoxCVCNumber.Location = new System.Drawing.Point(132, 212);
            this.textBoxCVCNumber.Mask = "000";
            this.textBoxCVCNumber.Name = "textBoxCVCNumber";
            this.textBoxCVCNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCVCNumber.TabIndex = 25;
            // 
            // DebitCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 291);
            this.Controls.Add(this.textBoxCVCNumber);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.textBoxSortCode);
            this.Controls.Add(this.textboxCardNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelExpiryDateSlash);
            this.Controls.Add(this.labelStartDateSlash);
            this.Controls.Add(this.textBoxExpiryDateYear);
            this.Controls.Add(this.textBoxStartDateYear);
            this.Controls.Add(this.textBoxExpiryDateDay);
            this.Controls.Add(this.textBoxStartDateDay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNameOnCard);
            this.Controls.Add(this.labelCVCNumber);
            this.Controls.Add(this.labelAccountNumber);
            this.Controls.Add(this.labelSortCode);
            this.Controls.Add(this.labelNameOnCard);
            this.Controls.Add(this.labelExpiryDay);
            this.Controls.Add(this.labelStartDay);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelName);
            this.Name = "DebitCardForm";
            this.Text = "Edit Debit Card Details";
            this.Load += new System.EventHandler(this.DebitCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelStartDay;
        private System.Windows.Forms.Label labelExpiryDay;
        private System.Windows.Forms.Label labelNameOnCard;
        private System.Windows.Forms.Label labelSortCode;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Label labelCVCNumber;
        private System.Windows.Forms.TextBox textBoxNameOnCard;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStartDateDay;
        private System.Windows.Forms.TextBox textBoxExpiryDateDay;
        private System.Windows.Forms.TextBox textBoxStartDateYear;
        private System.Windows.Forms.TextBox textBoxExpiryDateYear;
        private System.Windows.Forms.Label labelStartDateSlash;
        private System.Windows.Forms.Label labelExpiryDateSlash;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MaskedTextBox textboxCardNumber;
        private System.Windows.Forms.MaskedTextBox textBoxSortCode;
        private System.Windows.Forms.MaskedTextBox textBoxAccountNumber;
        private System.Windows.Forms.MaskedTextBox textBoxCVCNumber;
    }
}