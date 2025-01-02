using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI_CourseWork
{
    internal class Connection
    {
        string connstring = @"Data Source=LAPTOP-SBK6TAS8\SQLEXPRESS; Initial catalog=Car_Rental_System_DB; Integrated Security=True";

        public SqlConnection GetDatabaseConnection()
        { 
            SqlConnection conobj=new SqlConnection(connstring);
            conobj.Open();
            return conobj;
        }
    }
}
