using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using School_Management.Manager.Course;
using School_Management.Manager.Student;
namespace School_Management.Manager.Score
{
    public class Scores
    {
        My_Database data = new My_Database();
        public int Student_id { get; set; }
        public int Course_id { get; set; }
        public float Student_score { get; set; }
        public string Description { get; set; }
        public Scores(int student = 0, int course = 0, float score = 0, string description = "")
        {
            this.Student_id = student;
            this.Course_id = course;
            this.Student_score = score;
            this.Description = description;
        } 
        public DataTable GetStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = data.GetConnection;
            command.CommandText = ("SELECT Score.Student_id, Add_Student.firstname, Add_Student.Lastname, Score.Course_id, Course.label, Score." +
                "Student_score FROM Add_Student INNER JOIN Score on Add_student.id = Score.Student_id INNER JOIN Course on Score.Course_id = Course.Id");
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public bool Add_Score(int student, int course, float score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (Student_id, Course_id, Student_Score, Description) VALUES (@sid, @cid, @sc, @des)", data.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = course;
            command.Parameters.Add("@sc", SqlDbType.Float).Value = score;
            command.Parameters.Add("@des", SqlDbType.Text).Value = description;
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
        public bool Delete_Score(int student_id, int course_id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Score WHERE Student_id = @sid AND Course_id = @cid", data.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = course_id;
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
        public bool Student_Score_Exist(int student_id, int course_id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Score WHERE Student_id = @sid AND Course_id = @cid",data.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_id;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = course_id;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            if(table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable GetAvgScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = data.GetConnection;
            command.CommandText = "SELECT Course.label, AVG(Score.Student_core) As AverageGrade FROM Course, Score WHERE Course.Id =" + " Score.Course_id GROUP BY Course.label";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable GetAllScore()
        {
            My_Database dataBase = new My_Database();
            try
            {
                SqlCommand command = new SqlCommand("Select * From Score", dataBase.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.Openconnection();

                adapter.Fill(table);

                dataBase.Closeconnection();

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
        public DataTable GetScore(SqlCommand command)
        {
            command.Connection = data.GetConnection;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            sd.Fill(table);
            return table;
        }
        public DataTable GetALL_IdCourseOrder()
        {
            try
            {
                data.Openconnection();

                SqlCommand command = new SqlCommand("SELECT Student_id, Course_id, Student_score , Description FROM Score order BY Student_id, Course_id", data.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                data.Closeconnection();

                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                data.Closeconnection();
            }

        }
        public DataTable GetAvg_byStudent()
        {
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "SELECT Score.Student_id, AVG(Score.Student_score) " +
                                    "FROM Add_Student inner join Score on Add_Student.ID = Score.Student_id " +
                                    "Group by Score.Student_id " +
                                    "order by Score.Student_id "
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
        public DataTable MakeStudentScoreResultTable()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Score", data.GetConnection);
                Students student = new Students();
                Courses course = new Courses();
                Scores score = new Scores();

                //create column

                DataTable result = student.GetAllBriefInfo();
                result.Columns[0].ColumnName = "ID";
                result.Columns[1].ColumnName = "Firt Name";
                result.Columns[2].ColumnName = "Last Name";

                DataTable coursesLabel = course.AllLabel_IdOrder();
                DataTable scores = score.GetALL_IdCourseOrder();
                DataTable avgScore = score.GetAvg_byStudent();

                for (int i = 0; i < coursesLabel.Rows.Count; i++)
                {
                    result.Columns.Add(coursesLabel.Rows[i][1].ToString().Trim());
                }
                result.Columns.Add("Average");
                result.Columns.Add("Result");



                //test empty
                if (scores.Rows.Count < 1) return result;

                //fill score to table 
                int scoreRow = 0;
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        int courseIndex = 0;
                        while (result.Rows[row][0].ToString().Trim() == scores.Rows[scoreRow][0].ToString().Trim())
                        {
                            result.Rows[row][courseIndex + 3] = scores.Rows[scoreRow][2].ToString().Trim();
                            courseIndex++;
                            scoreRow++;
                            if (scoreRow > scores.Rows.Count - 1)
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                // fill avg score
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        result.Rows[row][result.Columns.Count - 2]
                            = avgScore.Rows[row][1].ToString().Trim();
                        int avg = Convert.ToInt32(avgScore.Rows[row][1].ToString().Trim());
                        if(avg < 5)
                        {
                            for(int count = 0; count < result.Rows.Count; count++)
                            {
                                try
                                {
                                    result.Rows[row][result.Columns.Count - 1] = "Fail";
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            for (int count = 0; count < result.Rows.Count; count++)
                            {
                                try
                                {
                                    result.Rows[count][result.Columns.Count - 1] = "Pass";
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                
                //DataTable table = score.GetScore(command);
                //for (int row = 0; row < result.Rows.Count; row++)
                //{
                //    try
                //    {
                //        result.Rows[row][result.Columns.Count - 1]
                //            = table.Rows[row][3].ToString().Trim();
                //    }
                //    catch (Exception)
                //    {
                //        continue;
                //    }
                //}
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int GetPassNumber()
        {
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "select count(A.Student_id) " +
                        "from (SELECT Score.Student_id, AVG(Score.Student_score) as AvgScore " +
                        "FROM Add_Student inner join Score on Add_Student.ID = Score.Student_id " +
                        "Group by Score.Student_id " +
                        "HAVING AVG(Score.Student_score) >= 5) as A"
                };
                int result;
                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    return 0;
                }
                db.Closeconnection();

                return result;
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
        public int GetFailNumber()
        {
            My_Database db = new My_Database();
            try
            {
                db.Openconnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.GetConnection,
                    CommandText = "select count(A.Student_id) " +
                        "from (SELECT Score.Student_id, AVG(Score.student_score) as AvgScore " +
                        "FROM Add_Student inner join Score on Add_Student.ID = Score.Student_id " +
                        "Group by Score.Student_id " +
                        "HAVING AVG(Score.Student_score) < 5 and AVG(Score.Student_score) >= 0) as A"
                };

                int result = 0;
                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    return 0;
                }

                db.Closeconnection();

                return result;
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
