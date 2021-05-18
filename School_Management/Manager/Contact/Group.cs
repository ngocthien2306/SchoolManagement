
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace School_Management.Manager.Contact
{
    class Group
    {
        My_Database data = new My_Database();
        public bool InsertGroup(int id, string nid, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Group1 (Group_id, Group_name, User_id) VALUES (@id, @name, @uid)", data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = nid;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            data.Openconnection();
            if (command.ExecuteNonQuery() == 1)
            {
                data.Closeconnection();
                return true;
            }
            else
            {
                data.Closeconnection();
                return false;
            }
        }
        public bool DeleteGroup(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Group1 WHERE Group_id = @id", data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            data.Openconnection();
            if (command.ExecuteNonQuery() == 1)
            {
                data.Closeconnection();
                return true;
            }
            else
            {
                data.Closeconnection();
                return false;
            }
        }
        public bool UpdateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE Group1 SET Group_name = @name WHERE Group_id = @id", data.GetConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = gname;
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
            data.Openconnection();
            if (command.ExecuteNonQuery() == 1)
            {
                data.Closeconnection();
                return true;
            }
            else
            {
                data.Closeconnection();
                return false;
            }

        }
        public DataTable GetAll_ID_label()
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("(Select Group_id, Group_name From Group1)", dataBase.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.Openconnection();

                adapter.Fill(table);

                return table;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dataBase.Closeconnection();
            }
        }
        public DataTable GetGroup(SqlCommand command)
        {
            command.Connection = data.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable GetIDGroup(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Group1 WHERE User_id = @uid", data.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = data.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public bool GroupExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM Group1 WHERE Group_name = @name AND User_id = @uid";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM Group1 WHERE Group_name = @name AND User_id = @uid AND Group_id <> @gid";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = data.GetConnection;
            command.CommandText = query;
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable table = new DataTable();
            SDA.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}