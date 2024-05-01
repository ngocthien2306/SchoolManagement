using DevExpress.XtraEditors;
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
    public partial class StudentCourse : DevExpress.XtraEditors.XtraForm
    {
        public string cid;
        My_Database data = new My_Database();

        public StudentCourse()
        {
            InitializeComponent();
        }

        private void StudentCourse_Load(object sender, EventArgs e)
        {
            comboBoxSe.Items.Add("1");
            comboBoxSe.Items.Add("2");
            comboBoxSe.Items.Add("3");
            comboBoxSe.SelectedIndex = 0;
            comboBoxSe.SelectedValue = "1";
        }

        public void GetCourseByStudentID()
        {
            string semester = comboBoxSe.Items[comboBoxSe.SelectedIndex].ToString();
            string cname = txtCourseName.Text;
            string query = "SELECT s.id, s.firstname, s.lastname, s.birthday, c.semester, c.label " +
                           "FROM Student_Courses sc " +
                           "LEFT JOIN Add_Student s ON s.id = sc.stdId " +
                           "LEFT JOIN Course c ON c.Id = sc.courseId " +
                           "WHERE c.semester = @semester AND (c.label IS NULL OR c.label = '' OR c.label LIKE @label)";


            SqlCommand command = new SqlCommand(query, data.GetConnection);

            // Assuming 'semester' and 'label' are the parameters
            command.Parameters.AddWithValue("@semester", semester);
            command.Parameters.AddWithValue("@label", "%" + cname + "%"); // Add '%' wildcard characters

            DataTable table = new DataTable();

            data.Openconnection();

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(table);
            }

            data.Closeconnection();
            gridControlStudentCourse.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetCourseByStudentID();
        }
    }
}