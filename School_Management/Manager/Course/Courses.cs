using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.Manager.Course
{
    class Courses
    {
        private int period;

        public int Id { get; set; }
        public string Label { get; set; }
        public int Period
        {
            get { return period; }
            set
            {
                if (period < 10)
                {
                    this.period = 10;
                }
                else
                {
                    this.period = value;
                }
            }
        }
        public string Description { get; set; }
        public bool AddThisCourse()
        {
            My_Database mydb = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Course (Id, label, period, description)" +
                    "VALUES (@Id, @lable, @period, @desciption)", mydb.GetConnection);

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@lable", SqlDbType.NVarChar).Value = Label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = Period;
                command.Parameters.Add("@desciption", SqlDbType.Text).Value = Description;

                mydb.Openconnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.Closeconnection();
                    return true;
                }
                else
                {
                    mydb.Closeconnection();
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                mydb.Closeconnection();
            }
        }
        public bool UpdateThisCourse()
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Courses" +
                    " SET " +
                    "label = @label," +
                    "period = @period," +
                    "description = @description" +
                    " WHERE id = @ID"
                    , dataBase.GetConnection);
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = Label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = Period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = Description;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                dataBase.Openconnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    dataBase.Closeconnection();
                    return true;
                }
                else
                {
                    dataBase.Closeconnection();
                    return false;
                }
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
        public bool RemoveThisCourse()
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Courses" +
                    " WHERE Id = @id", dataBase.GetConnection);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                dataBase.Openconnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    dataBase.Closeconnection();
                    return true;
                }
                else
                {
                    dataBase.Closeconnection();
                    return false;
                }
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
        public DataTable GetCourse(SqlCommand command)
        {
            My_Database data = new My_Database();
            command.Connection = data.GetConnection;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sd.Fill(table);
            return table;
        }
        public List<int> GetAllId()
        {
            List<int> result = new List<int>();
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("Select id From Courses", dataBase.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.Openconnection();

                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    result.Add(Convert.ToInt32(row[0].ToString()));
                }

                return result;
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
        public Courses GetByID(int Id)
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("Select * From Course Where Id = @id", dataBase.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.Openconnection();

                adapter.Fill(table);

                dataBase.Closeconnection();

                Courses course = new Courses()
                {
                    Id = Convert.ToInt32(table.Rows[0][0].ToString()),
                    Label = table.Rows[0][1].ToString(),
                    Period = Convert.ToInt32(table.Rows[0][2].ToString()),
                    Description = table.Rows[0][3].ToString()
                };

                this.Id = Convert.ToInt32(table.Rows[0][0].ToString());
                this.Label = table.Rows[0][1].ToString();
                this.Period = Convert.ToInt32(table.Rows[0][2].ToString());
                this.Description = table.Rows[0][3].ToString();

                return course;
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
        public DataTable GetAll_ID_label()
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("Select id, label From Course", dataBase.GetConnection);
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
        public bool InsertCourse(int id, string label, int period, string description)
        {
            My_Database db = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, period, description) "
                                  + "VALUES (@id, @label, @period, @description)", db.GetConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;

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
                return false;
                throw;
            }
            finally
            {
                db.Closeconnection();
            }
        }
        public bool CheckCourseName(string courseName, int courseID = 0)
        {
            My_Database db = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cName and Id<>@cID", db.GetConnection);

                command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
                command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                db.Closeconnection();
            }
        }
        public bool RemoveCourse(int id)
        {
            My_Database db = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", db.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                return false;
                throw;
            }
            finally
            {
                db.Closeconnection();
            }
        }
        public bool UpdateCourse(int id, string label, int period, string description)
        {
            My_Database db = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Course" +
                    " SET " +
                    "label = @label," +
                    "period = @period," +
                    "description = @description" +
                    " WHERE Id = @ID"
                    , db.GetConnection);

                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

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
                return false;
                throw;
            }
            finally
            {
                db.Closeconnection();
            }
        }
        public bool DeleteCourse(int id)
        {
            My_Database db = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Course " +
                                    "where id=@id",
                                    db.GetConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
                return false;
                throw;
            }
            finally
            {
                db.Closeconnection();
            }
        }
        public DataTable GetTable(string query)
        {
            My_Database db = new My_Database();
            try
            {

                db.Openconnection();
                SqlCommand command = new SqlCommand(query, db.GetConnection);
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
        public DataTable GetAllCourses()
        {
            My_Database db = new My_Database();
            try
            {
                string query = "SELECT * FROM Course";
                return this.GetTable(query);
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
        public DataTable GetCourseByID(int id)
        {
            My_Database db = new My_Database();
            try
            {
                string query = $"SELECT * FROM Courses WHERE id = {id}";
                return this.GetTable(query);
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
        public int TotalCourse()
        {
            My_Database db = new My_Database();
            try
            {
                DataTable table = this.GetAllCourses();
                return table.Rows.Count;

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
        public DataTable GetAvgScoreByCourse()
        {
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT Course.label, AVG(score.student_score) As AverageGrade " +
                    "FROM Course, Score " +
                    "WHERE Course.Id = Score.Course_id " +
                    "GROUP BY Course.label"
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
        public int GetIdByLabel(string label)
        {
            My_Database dataBase = new My_Database();
            try
            {
                label = label.Trim();
                SqlCommand command = new SqlCommand("SELECT Id From Course Where label = @label", dataBase.GetConnection);
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                dataBase.Openconnection();
                int result = Convert.ToInt32(command.ExecuteScalar());
                dataBase.Closeconnection();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable AllLabel_IdOrder()
        {
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "select Course.Id, Course.label " +
                                    "from Course " +
                                    "order by Course.Id"
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
        public DataTable GetCourseBySemester(string semester)
        {
            semester = semester.Trim();
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT * FROM Courses WHERE semester = @semester"
                };
                command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = semester;
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
    }
}
