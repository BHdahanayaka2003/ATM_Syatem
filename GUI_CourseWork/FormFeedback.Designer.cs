namespace GUI_CourseWork
{
    partial class FormFeedback
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
            this.labelFeedbackID = new System.Windows.Forms.Label();
            this.labelRideID = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxFeedbackID = new System.Windows.Forms.TextBox();
            this.textBoxRideID = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFeedbackID
            // 
            this.labelFeedbackID.AutoSize = true;
            this.labelFeedbackID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedbackID.Location = new System.Drawing.Point(167, 92);
            this.labelFeedbackID.Name = "labelFeedbackID";
            this.labelFeedbackID.Size = new System.Drawing.Size(89, 16);
            this.labelFeedbackID.TabIndex = 0;
            this.labelFeedbackID.Text = "Feedback ID";
            // 
            // labelRideID
            // 
            this.labelRideID.AutoSize = true;
            this.labelRideID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRideID.Location = new System.Drawing.Point(170, 140);
            this.labelRideID.Name = "labelRideID";
            this.labelRideID.Size = new System.Drawing.Size(53, 16);
            this.labelRideID.TabIndex = 1;
            this.labelRideID.Text = "Ride ID";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(170, 199);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(80, 16);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // textBoxFeedbackID
            // 
            this.textBoxFeedbackID.Location = new System.Drawing.Point(273, 92);
            this.textBoxFeedbackID.Name = "textBoxFeedbackID";
            this.textBoxFeedbackID.Size = new System.Drawing.Size(226, 20);
            this.textBoxFeedbackID.TabIndex = 3;
            // 
            // textBoxRideID
            // 
            this.textBoxRideID.Location = new System.Drawing.Point(273, 140);
            this.textBoxRideID.Name = "textBoxRideID";
            this.textBoxRideID.Size = new System.Drawing.Size(226, 20);
            this.textBoxRideID.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(273, 199);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(226, 58);
            this.textBoxDescription.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(338, 306);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(88, 33);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(180, 315);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(729, 388);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxRideID);
            this.Controls.Add(this.textBoxFeedbackID);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelRideID);
            this.Controls.Add(this.labelFeedbackID);
            this.Name = "FormFeedback";
            this.Text = "Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFeedbackID;
        private System.Windows.Forms.Label labelRideID;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxFeedbackID;
        private System.Windows.Forms.TextBox textBoxRideID;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
    }
}