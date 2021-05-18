using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace School_Management.Manager.Contact
{
    class Contact_class
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Group_id { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public MemoryStream Picture { get; set; }
        public int User_id { get; set; }
        public bool InsertContact(string fname, string lname, string group, string gender, DateTime bday, int phone, 
            string email, string fbook, string address, string city, MemoryStream picture, int userid) {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("INSERT INTO Contact (ID, Firstname, Fastname, Group_id, Gender, Birthday, Phone, Email, Facebook, Address, City, Picture)" +
                "VALUES (@fn, @lname, @group, @gen, @day, @phone, @email, @fb, @add, @city, @pic, @id)", data.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;
            command.Parameters.Add("@gen", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = bday;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@fb", SqlDbType.NVarChar).Value = fbook;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            data.Openconnection();
            if(command.ExecuteNonQuery() == 1)
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
        public bool UpdateContact(string fname, string lname, string group, string gender, DateTime bday, int phone,
            string email, string fbook, string address, string city, MemoryStream picture, int userid)
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("UPDATE Contact SET Firstname = @fn, Fastname = @ln, Group_id = @group, Gender = @gen, Birthday = @day, " +
                "Phone = @phone, Email = @email, Facebook = @fb, Address = @add, City = @city, Picture = @pic, User_id = @id", data.GetConnection);
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;
            command.Parameters.Add("@gen", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@day", SqlDbType.DateTime).Value = bday;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@fb", SqlDbType.NVarChar).Value = fbook;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
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
        public bool DeleteContacts(int uid)
        {
            My_Database data = new My_Database();
            SqlCommand commnad = new SqlCommand("DELETE FROM Contact WHERE ID = @id", data.GetConnection);
            commnad.Parameters.Add("@id", SqlDbType.Int).Value = uid;
            data.Openconnection();
            if(commnad.ExecuteNonQuery() == 1)
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
        public DataTable SelectContactList(SqlCommand commnand)
        {
            My_Database data = new My_Database();
            commnand.Connection = data.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(commnand);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable GetContactsByID(int ID)
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT ID, Firstname, Fastname, Group_id, Gender, Birthday, Phone, Email, Facebook, Address, City, Picture, User_id " +
                "FROM Contact WHERE ID = @id", data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
    }
}
