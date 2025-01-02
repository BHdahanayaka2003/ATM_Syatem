namespace GUI_CourseWork
{
    partial class FormHome
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
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.Lime;
            this.buttonSignIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSignIn.Location = new System.Drawing.Point(566, 349);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(149, 37);
            this.buttonSignIn.TabIndex = 0;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Location = new System.Drawing.Point(2, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(310, 394);
            this.panelHome.TabIndex = 1;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.Blue;
            this.labelHome.Location = new System.Drawing.Point(88, 168);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(219, 32);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Welcome to the";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(56, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Rental System";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::GUI_CourseWork.Properties.Resources.car001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 388);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.buttonSignIn);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormHome";
            this.Text = "Home Page";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label label1;
    }
}

