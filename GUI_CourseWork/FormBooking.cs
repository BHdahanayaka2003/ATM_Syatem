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
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }

        

        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            

            try
            {
                Connection connection = new Connection();
                SqlConnection obj = connection.GetDatabaseConnection();

                string rideId = "R010";
                textBoxRideID.Text= rideId.ToString();
                
                if (textBoxNIC.Text != null && textBoxRideID.Text!=null && comboBoxCarID.Text != null &&   comboBoxModel.Text != null && textBoxPickUpLocation.Text != null && textBoxReturnLocation.Text != null && textBoxNumberOfDays.Text !=null)
                {
                    
                    int days = Convert.ToInt32(textBoxNumberOfDays.Text);
                    int index = Convert.ToInt32(comboBoxCarID.SelectedIndex);
                    int modelIndex = Convert.ToInt32(comboBoxModel.SelectedIndex);
                    double amount = 0;


                    if (index == 0)
                    {
                        if (modelIndex == 0)
                        {
                            amount = 5000 * days;
                        }
                        else if (modelIndex == 1)
                        {
                            amount = 4500 * days;
                        }
                        else
                        {
                            MessageBox.Show("Please Select Correct Model");

                        }
                    }

                    if (index == 1)
                    {
                        if (modelIndex == 2)
                        {
                            amount = 10000 * days;
                        }
                        else if (modelIndex == 3)
                        {
                            amount = 8000 * days;
                        }
                        else
                        {
                            MessageBox.Show("Please Select Correct Model");

                        }

                    }
                    if (index == 2)
                    {
                        amount = 5000 * days;
                    }
                    if (index == 3)
                    {
                        if (modelIndex == 6)
                        {
                            amount = 7500 * days;
                        }
                        else if (modelIndex == 7)
                        {
                            amount = 7000 * days;
                        }
                        else
                        {
                            MessageBox.Show("Please Select Correct Model");

                        }

                    }
                    if (index == 4)
                    {
                        amount = 6000 * days;
                    }

                    textBoxTotal.Text = amount.ToString();

                    string sql = "INSERT INTO Ride(Ride_ID,Ride_Date,PickUp_Location,Drop_Location,Price,No_Of_days,Customer_NIC)" +
                               "VALUES('" + textBoxRideID.Text + "','" + textBoxDate.Text + "','" + textBoxPickUpLocation.Text + "','" + textBoxReturnLocation.Text + "','" + textBoxTotal.Text + "','" + textBoxNumberOfDays.Text + "','" + textBoxNIC.Text + "')";

                    /*string sql1 = "INSERT INTO Car(Car_ID,Model,Customer_NIC)" +
                                "VALUES('" + comboBoxCarID + "','" + comboBoxModel + "','"+textBoxNIC+"')";*/

                    SqlCommand comnobj = new SqlCommand(sql, obj);
                    //SqlCommand comnobj1 = new SqlCommand(sql1, obj);
                    comnobj.ExecuteNonQuery();
                    //comnobj1.ExecuteNonQuery();





                    MessageBox.Show("Suceesfully book a car ");
                    obj.Close();

                }
                else
                {
                    MessageBox.Show("Please enter all values");
                }

                

                FormPayments formPayments = new FormPayments();
                formPayments.Show();
                this.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed" + ex.Message);
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAvailableCars formAvailable=new FormAvailableCars();
            formAvailable.Show();
            this.Hide();
        }

       
        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
