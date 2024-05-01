using DevExpress.XtraEditors;
using School_Management.Manager.Course;
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

namespace School_Management.Manager.Student
{
    public partial class CourseStudent : DevExpress.XtraEditors.XtraForm
    {
        public CourseStudent()
        {
            InitializeComponent();
        }
        My_Database data = new My_Database();


        private void CourseStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT c.semester, c.label, score.Student_score, score.Description " +
               "FROM Student_Courses sc " +
               "LEFT JOIN Add_Student s ON s.id = sc.stdId " +
               "LEFT JOIN Course c ON c.Id = sc.courseId " +
               "LEFT JOIN Score score on score.Student_id = s.id and score.Course_id = c.Id " +
                "WHERE s.id = @sid";

            SqlCommand command = new SqlCommand(query, data.GetConnection);
            int id = Convert.ToInt32(lbStudentId.Text);
            // Assuming 'courseId' is a parameter to filter the data based on the selected item
            command.Parameters.AddWithValue("@sid", id);
            DataTable table = new DataTable();

            data.Openconnection();

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(table);
            }

            data.Closeconnection();

            gridControlCourse.DataSource = table;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse_FormStudent add = new AddCourse_FormStudent();
            add.lbStudentId.Text = lbStudentId.Text;
            add.ShowDialog();
        }
    }
}