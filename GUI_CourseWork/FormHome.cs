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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
