using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace School_Management.Manager.Login
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Users(string user = "", string pass = "")
        {
            this.Username = user;
            this.Password = pass;
        }
        public static int GlobleUserID { get; private set; }
        public static void SetGlobleUserID(int UserID)
        {
            GlobleUserID = UserID;
        }
        static My_Database connect = new My_Database();
        public bool GetUser(string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (Username, Password) + VALUES (@user, @pass)", connect.GetConnection);
            command.Parameters.Add(@"user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add(@"pass", SqlDbType.NVarChar).Value = pass;
            connect.Openconnection();
            if(command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                connect.Closeconnection();
                return false;
            }
        }
        public DataTable GetUser(SqlCommand command)
        {
            command.Connection = connect.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        My_Database data = new My_Database();
        public DataTable GetUserByID(Int32 userid)
        {
            
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM New_User WHERE Id = @id",data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            SDA.SelectCommand = command;
            SDA.Fill(table);
            return table;
        }
        public bool UserNameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM New_User WHERE username = @un";
            }
            else if(operation == "edit") {
                query = "SELECT * FROM New_User WHERE username = @un and Id <> @id";
            }
            SqlCommand command = new SqlCommand(query, data.GetConnection);
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable table = new DataTable();
            SDA.SelectCommand = command;
            SDA.Fill(table);
            data.Openconnection();
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Login(string user, string pass)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM New_User where username = @user AND password = @pass", connect.GetConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert_User(int id, string fname, string lname, string username, string pass, MemoryStream picture, string role)
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("INSERT INTO New_User (Id, firstname, lastname, username, password, picture, role)" +
                "VALUES (@ID, @fname, @lname, @uname, @pass, @picture, @ro)", data.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@ro", SqlDbType.NChar).Value = role;
            data.Openconnection();
            if(command.ExecuteNonQuery() == 1)
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
