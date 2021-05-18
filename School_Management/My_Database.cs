using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace School_Management
{
    public class My_Database
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-NHHG86O;Initial Catalog=Manager_Student;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get { return this.connect; }
        }
        public void Openconnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void Closeconnection()
        {
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
