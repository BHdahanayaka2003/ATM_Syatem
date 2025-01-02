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

namespace GUI_CourseWork
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            try
            {
                Connection connection = new Connection();
                SqlConnection obj = connection.GetDatabaseConnection();

                if (textBoxNIC.Text != null && textBoxName.Text != null && textBoxContactNumber.Text != null && textBoxEmail.Text != null && textBoxUsername.Text != null && textBoxPassword.Text != null)
                {
                    string sql = "INSERT INTO Customer(Customer_NIC,Customer_Name,Contact_No,Email,Username,C_Password)" +
                               "VALUES('" + textBoxNIC.Text + "','" + textBoxName.Text + "','" + textBoxContactNumber.Text + "','" + textBoxEmail.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')";
                    SqlCommand comnobj = new SqlCommand(sql, obj);
                    comnobj.ExecuteNonQuery();
                    MessageBox.Show("You are Sucessfully registered ");
                    obj.Close();

                    FormSignIn formSignIn = new FormSignIn();
                    formSignIn.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Please Enter Values");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed" + ex.Message);
            }

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                SqlConnection obj = connection.GetDatabaseConnection();

                if (textBoxNIC.Text != null && textBoxName.Text != null && textBoxContactNumber.Text != null && textBoxEmail.Text != null && textBoxUsername.Text != null && textBoxPassword.Text != null)
                {
                    string sql = "Update Customer set Customer_Name='"+textBoxName.Text+"',Contact_No='"+textBoxContactNumber.Text+"',Email='"+textBoxEmail.Text+"',Username='"+textBoxUsername.Text+"',C_Password='"+textBoxPassword.Text+"' where Customer_NIC='" + textBoxNIC.Text +"'";
                    SqlCommand comnobj = new SqlCommand(sql, obj);
                    comnobj.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated ");
                    obj.Close();

                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Enter Values");
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed"+ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn=new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
