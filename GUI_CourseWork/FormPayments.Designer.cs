namespace GUI_CourseWork
{
    partial class FormPayments
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
            this.labelPaymentID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxPaymentID = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelPaymentDetails = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNIC = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPaymentID
            // 
            this.labelPaymentID.AutoSize = true;
            this.labelPaymentID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentID.Location = new System.Drawing.Point(175, 76);
            this.labelPaymentID.Name = "labelPaymentID";
            this.labelPaymentID.Size = new System.Drawing.Size(80, 16);
            this.labelPaymentID.TabIndex = 0;
            this.labelPaymentID.Text = "Payment ID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(178, 116);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.Location = new System.Drawing.Point(178, 160);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(96, 16);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(178, 210);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(57, 16);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Amount";
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(290, 307);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(82, 29);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxPaymentID
            // 
            this.textBoxPaymentID.Location = new System.Drawing.Point(290, 76);
            this.textBoxPaymentID.Name = "textBoxPaymentID";
            this.textBoxPaymentID.Size = new System.Drawing.Size(160, 20);
            this.textBoxPaymentID.TabIndex = 5;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(290, 116);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(160, 20);
            this.textBoxDate.TabIndex = 6;
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(290, 160);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(160, 20);
            this.textBoxCardNumber.TabIndex = 7;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(290, 210);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(160, 20);
            this.textBoxAmount.TabIndex = 8;
            // 
            // labelPaymentDetails
            // 
            this.labelPaymentDetails.AutoSize = true;
            this.labelPaymentDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDetails.Location = new System.Drawing.Point(106, 29);
            this.labelPaymentDetails.Name = "labelPaymentDetails";
            this.labelPaymentDetails.Size = new System.Drawing.Size(132, 19);
            this.labelPaymentDetails.TabIndex = 9;
            this.labelPaymentDetails.Text = "Payment Details";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(416, 306);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIC.Location = new System.Drawing.Point(181, 246);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(32, 16);
            this.labelNIC.TabIndex = 11;
            this.labelNIC.Text = "NIC";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Location = new System.Drawing.Point(290, 251);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(160, 20);
            this.textBoxNIC.TabIndex = 12;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(184, 307);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 29);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(729, 388);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.labelNIC);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPaymentDetails);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxPaymentID);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPaymentID);
            this.Name = "FormPayments";
            this.Text = "Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaymentID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxPaymentID;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelPaymentDetails;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.Button buttonBack;
    }
}