using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Student
{
    class Students
    {
        public int ID { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public DateTime Bdate { get; set; }
        public char Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public MemoryStream Picture { get; set; }
        public Students(int id = 0, string firstname = "", string lastname = "",
            DateTime date = default, char gender = '\0', string phone = "", string address = "", MemoryStream picture = default)
        {
            ID = id;
            Fname = firstname;
            Lname = lastname;
            Bdate = date;
            Gender = gender;
            Phone = phone;
            Address = address;
            Picture = picture;
        }
        My_Database data = new My_Database();
        public bool EditStudent(int id, string firstname, string lastname, DateTime birthday, string gender,
    string address, string phone, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Add_Student" + " SET " +
                    "firstname = @Fname," +
                    "lastname = @Lname," +
                    "birthday = @Bdate," +
                    "gender = @Gender," +
                    "address = @Address," +
                    "phone = @Phone," +
                    "picture = @Picture" +
                    " WHERE id = @ID", data.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Fname", SqlDbType.NChar).Value = firstname;
            command.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = lastname;
            command.Parameters.Add("@Ddate", SqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@Picture", SqlDbType.Image).Value = picture.ToArray();
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
        public bool AddStudent(int id, string firstname, string lastname, DateTime birthday, string gender,
            string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Add_Student (id, firstname, lastname, birthday, gender, address, phone, picture)" +
                "VALUES (@id, @fn, @ln, @bday, @gen, @add, @ph, @pic)", data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NChar).Value = firstname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastname;
            command.Parameters.Add("@bday", SqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@gen", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@ph", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public object TotalStudent()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand(@"select count(*) from Add_Student", data.GetConnection);
            data.Openconnection();
            command.CommandText = @"select count(*) from Add_Student";
            return command.ExecuteScalar();
        }
        public object TotalMaleStudent()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand(@"select count(*) from Add_Student where gender = 'male'", data.GetConnection);
            data.Openconnection();
            command.CommandText = @"select count(*) from Add_Student where gender = 'male'";
            return command.ExecuteScalar();
        }
        public object TotalFemaleStudent()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand(@"select count(*) from Add_Student where gender = 'female'", data.GetConnection);
            data.Openconnection();
            command.CommandText = @"select count(*) from Add_Student where gender = 'female'";
            try
            {
                return command.ExecuteScalar();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                data.Closeconnection();
            }
            return command.ExecuteScalar();

        }
        public DataTable FindByHint(string hint)
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Add_Student WHERE CONCAT(firstname, lastname, address) LIKE '%" +
                    hint
                    + "%'", dataBase.GetConnection);

                dataBase.Openconnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                // table = StudentsTableNaming(table);

                dataBase.Closeconnection();

                return table;
            }
            catch (Exception)
            {
                dataBase.Closeconnection();
                throw;
            }
            finally
            {
                dataBase.Closeconnection();
            }
        }
        public DataTable StudentsTableNaming(DataTable table)
        {
            try
            {
                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "First Name";
                table.Columns[2].ColumnName = "Last Name";
                table.Columns[3].ColumnName = "Birthday";
                table.Columns[4].ColumnName = "Gender";
                table.Columns[5].ColumnName = "Phone";
                table.Columns[6].ColumnName = "Adress";
                table.Columns[7].ColumnName = "Picture";

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetStudents(SqlCommand command)
        {
            command.Connection = data.GetConnection;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sd.Fill(table);
            return table;
        }
        public DataTable GetAllBriefInfo()
        {
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT ID, firstname, lastname FROM Add_Student"
                };
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.Closeconnection();

                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Closeconnection();
            }

        }
        public DataTable GetSelectedCourses(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Student_Courses " +
                                                    "inner join Courses on Student_Courses.courseId = Courses.Id " +
                                                    "WHERE stdId=@id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                return this.GetStudents(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool CheckValidCourse(string selectedCourse, string currCourse)
        {
            if (selectedCourse.Contains(currCourse))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int IsExistId(int id)
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT id, firstname, lastname, birthday, gender, phone, address, picture FROM Add_Student WHERE id = @ID", dataBase.GetConnection);
                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
                dataBase.Openconnection();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter()
                {
                    SelectCommand = command
                };

                adapter.Fill(table);

                return table.Rows.Count;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            finally
            {
                dataBase.Closeconnection();
            }
        }
        public bool InsertSelectedCourse(string id, int course)
        {
            My_Database db = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("Insert into Course (Student_id, Course_id) " +
                                                     "values (@stdId, @courseId)", db.GetConnection);

                command.Parameters.Add("@stdId", SqlDbType.Int).Value = id;
                command.Parameters.Add("@courseId", SqlDbType.Int).Value = course;

                db.Openconnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    db.Closeconnection();
                    return true;
                }
                else
                {
                    db.Closeconnection();
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Closeconnection();
            }
        }
    }
}
