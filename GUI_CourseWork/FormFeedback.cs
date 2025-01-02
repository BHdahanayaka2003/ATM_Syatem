using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_CourseWork
{
    public partial class FormFeedback : Form
    {
        public FormFeedback()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                SqlConnection obj = connection.GetDatabaseConnection();

                if (textBoxFeedbackID.Text != null && textBoxRideID.Text != null )
                {
                    string sql = "INSERT INTO Feedback(Feedback_ID,Ride_ID,F_Description)" +
                               "VALUES('" + textBoxFeedbackID.Text + "','" + textBoxRideID.Text + "','" + textBoxDescription.Text + "')";
                    SqlCommand comnobj = new SqlCommand(sql, obj);
                    comnobj.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added Feedback ");
                    obj.Close();

                }
                else
                {
                    MessageBox.Show("Please Enter Correct Values");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed" + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
            this.Hide();
        }
    }
}
