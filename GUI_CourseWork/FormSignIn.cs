using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CourseWork
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            this.Hide();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {

                Connection connection = new Connection();
                SqlConnection obj = connection.GetDatabaseConnection();

                string username=textBoxUserName.Text;
                string password=textBoxPassword.Text;

                String qry = "SELECT UserName,C_Password FROM Customer WHERE UserName = '" + textBoxUserName.Text + "' AND C_Password = '" + textBoxPassword.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(qry,obj);

                DataTable datatable=new DataTable();
                adapter.Fill(datatable);

                if(textBoxUserName.Text!=null && textBoxPassword.Text!=null)
                {
                    if (datatable.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful!");


                        FormDashboard dashboard = new FormDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                        textBoxUserName.Clear();
                        textBoxPassword.Clear();
                    }
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




    
    }
}
