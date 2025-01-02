namespace GUI_CourseWork
{
    partial class FormBooking
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
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelCarID = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.comboBoxCarID = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonPayNow = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPickUpLocation = new System.Windows.Forms.Label();
            this.textBoxPickUpLocation = new System.Windows.Forms.TextBox();
            this.labelReturnLocation = new System.Windows.Forms.Label();
            this.labelNumberOfDays = new System.Windows.Forms.Label();
            this.textBoxReturnLocation = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.labelBookingDetails = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelRideID = new System.Windows.Forms.Label();
            this.textBoxRideID = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIC.Location = new System.Drawing.Point(104, 57);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(32, 16);
            this.labelNIC.TabIndex = 0;
            this.labelNIC.Text = "NIC";
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarID.Location = new System.Drawing.Point(110, 134);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(56, 16);
            this.labelCarID.TabIndex = 1;
            this.labelCarID.Text = "Car ID";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(110, 178);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(48, 16);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Model";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Location = new System.Drawing.Point(226, 57);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(157, 20);
            this.textBoxNIC.TabIndex = 4;
            // 
            // comboBoxCarID
            // 
            this.comboBoxCarID.FormattingEnabled = true;
            this.comboBoxCarID.Items.AddRange(new object[] {
            "C010",
            "C011",
            "C012",
            "C014",
            "C015"});
            this.comboBoxCarID.Location = new System.Drawing.Point(226, 129);
            this.comboBoxCarID.Name = "comboBoxCarID";
            this.comboBoxCarID.Size = new System.Drawing.Size(157, 21);
            this.comboBoxCarID.TabIndex = 5;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Items.AddRange(new object[] {
            "Wagon r Stingray",
            "Wagon r FZ",
            "Premio 260 G Superior ",
            "Premio G",
            "Alto Lxi",
            "Aqua G",
            "Aqua X",
            "Vitz Safety"});
            this.comboBoxModel.Location = new System.Drawing.Point(226, 177);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(157, 21);
            this.comboBoxModel.TabIndex = 7;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // buttonPayNow
            // 
            this.buttonPayNow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayNow.Location = new System.Drawing.Point(526, 336);
            this.buttonPayNow.Name = "buttonPayNow";
            this.buttonPayNow.Size = new System.Drawing.Size(75, 23);
            this.buttonPayNow.TabIndex = 8;
            this.buttonPayNow.Text = "Pay Now";
            this.buttonPayNow.UseVisualStyleBackColor = true;
            this.buttonPayNow.Click += new System.EventHandler(this.buttonPayNow_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(473, 158);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(84, 19);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "Your Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(495, 188);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(157, 75);
            this.textBoxTotal.TabIndex = 10;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(620, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPickUpLocation
            // 
            this.labelPickUpLocation.AutoSize = true;
            this.labelPickUpLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickUpLocation.Location = new System.Drawing.Point(108, 223);
            this.labelPickUpLocation.Name = "labelPickUpLocation";
            this.labelPickUpLocation.Size = new System.Drawing.Size(110, 16);
            this.labelPickUpLocation.TabIndex = 12;
            this.labelPickUpLocation.Text = "PickUp Location";
            // 
            // textBoxPickUpLocation
            // 
            this.textBoxPickUpLocation.Location = new System.Drawing.Point(226, 223);
            this.textBoxPickUpLocation.Name = "textBoxPickUpLocation";
            this.textBoxPickUpLocation.Size = new System.Drawing.Size(157, 20);
            this.textBoxPickUpLocation.TabIndex = 13;
            // 
            // labelReturnLocation
            // 
            this.labelReturnLocation.AutoSize = true;
            this.labelReturnLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnLocation.Location = new System.Drawing.Point(110, 273);
            this.labelReturnLocation.Name = "labelReturnLocation";
            this.labelReturnLocation.Size = new System.Drawing.Size(107, 16);
            this.labelReturnLocation.TabIndex = 14;
            this.labelReturnLocation.Text = "Return Location";
            // 
            // labelNumberOfDays
            // 
            this.labelNumberOfDays.AutoSize = true;
            this.labelNumberOfDays.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfDays.Location = new System.Drawing.Point(104, 324);
            this.labelNumberOfDays.Name = "labelNumberOfDays";
            this.labelNumberOfDays.Size = new System.Drawing.Size(114, 16);
            this.labelNumberOfDays.TabIndex = 15;
            this.labelNumberOfDays.Text = "Number Of Days";
            // 
            // textBoxReturnLocation
            // 
            this.textBoxReturnLocation.Location = new System.Drawing.Point(226, 273);
            this.textBoxReturnLocation.Name = "textBoxReturnLocation";
            this.textBoxReturnLocation.Size = new System.Drawing.Size(157, 20);
            this.textBoxReturnLocation.TabIndex = 16;
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(226, 323);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(157, 20);
            this.textBoxNumberOfDays.TabIndex = 17;
            // 
            // labelBookingDetails
            // 
            this.labelBookingDetails.AutoSize = true;
            this.labelBookingDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingDetails.Location = new System.Drawing.Point(107, 13);
            this.labelBookingDetails.Name = "labelBookingDetails";
            this.labelBookingDetails.Size = new System.Drawing.Size(126, 19);
            this.labelBookingDetails.TabIndex = 18;
            this.labelBookingDetails.Text = "Booking Details";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(427, 335);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelRideID
            // 
            this.labelRideID.AutoSize = true;
            this.labelRideID.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRideID.Location = new System.Drawing.Point(107, 92);
            this.labelRideID.Name = "labelRideID";
            this.labelRideID.Size = new System.Drawing.Size(61, 16);
            this.labelRideID.TabIndex = 20;
            this.labelRideID.Text = "Ride ID";
            // 
            // textBoxRideID
            // 
            this.textBoxRideID.Location = new System.Drawing.Point(226, 92);
            this.textBoxRideID.Name = "textBoxRideID";
            this.textBoxRideID.Size = new System.Drawing.Size(157, 20);
            this.textBoxRideID.TabIndex = 21;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(437, 59);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 16);
            this.labelDate.TabIndex = 22;
            this.labelDate.Text = "Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(526, 57);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(141, 20);
            this.textBoxDate.TabIndex = 23;
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(729, 388);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxRideID);
            this.Controls.Add(this.labelRideID);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelBookingDetails);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.textBoxReturnLocation);
            this.Controls.Add(this.labelNumberOfDays);
            this.Controls.Add(this.labelReturnLocation);
            this.Controls.Add(this.textBoxPickUpLocation);
            this.Controls.Add(this.labelPickUpLocation);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonPayNow);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxCarID);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelCarID);
            this.Controls.Add(this.labelNIC);
            this.Name = "FormBooking";
            this.Text = "Ride Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelCarID;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.ComboBox comboBoxCarID;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonPayNow;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPickUpLocation;
        private System.Windows.Forms.TextBox textBoxPickUpLocation;
        private System.Windows.Forms.Label labelReturnLocation;
        private System.Windows.Forms.Label labelNumberOfDays;
        private System.Windows.Forms.TextBox textBoxReturnLocation;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
        private System.Windows.Forms.Label labelBookingDetails;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelRideID;
        private System.Windows.Forms.TextBox textBoxRideID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}