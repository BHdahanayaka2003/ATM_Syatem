using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CourseWork
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void bookCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAvailableCars formAvailableCars = new FormAvailableCars();
            formAvailableCars.Show();
            this.Close();
        }

        private void addFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFeedback formFeedback = new FormFeedback();
            formFeedback.Show();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            this.Hide();
        }
    }
}
