using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_CourseWork
{
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();
        }

        
        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                SqlConnection obj = connection.GetDatabaseConnection();

                string payments = "P101";
                textBoxPaymentID.Text=payments.ToString();

                if (textBoxPaymentID.Text != null && textBoxDate.Text != null && textBoxCardNumber.Text != null && textBoxAmount.Text != null )
                {
                    
                    string sql = "INSERT INTO Payment(Payment_ID,Card_Number,Payment_Date,Amount,Customer_NIC)" +
                               "VALUES('" + textBoxPaymentID.Text + "','"+textBoxCardNumber.Text+"','" + textBoxDate.Text + "','" + textBoxAmount.Text + "','" + textBoxNIC.Text + "')";
                    SqlCommand comnobj = new SqlCommand(sql, obj);
                    comnobj.ExecuteNonQuery();
                    MessageBox.Show("Payment Suessfull ");
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormBooking formBooking = new FormBooking();
            formBooking.Show();
            this.Hide();
        }
    }
}
