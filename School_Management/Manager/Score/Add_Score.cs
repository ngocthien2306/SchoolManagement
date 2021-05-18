using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management.Manager.Course;
using School_Management.Manager.Student;
using System.Data.SqlClient;

namespace School_Management.Manager.Score
{
    public partial class Add_Score : DevExpress.XtraEditors.XtraForm
    {
        public Add_Score()
        {
            InitializeComponent();
        }
        Students student = new Students();
        Courses course = new Courses();
        Scores score = new Scores();

        private void Add_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this.manager_StudentDataSet3.Score);
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Score' table. You can move, or remove it, as needed.
            this.scoreTableAdapter.Fill(this.manager_StudentDataSet3.Score);

            //StudentGridControl.DataSource = score.GetStudentScore();
            ComboBox_Course.DataSource = course.GetAllCourses();
            ComboBox_Course.DisplayMember = "label";
            ComboBox_Course.ValueMember = "id";

        }
        public void ReloadCourse()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("select Student_id as ID, Course_id as Course, Student_score as Score, Description from Score",data.GetConnection);
            DataGridView_Sourse.Width = 60;
            DataGridView_Sourse.DataSource = score.GetScore(command);
        }
        public void ReloadStudent()
        {

            My_Database data = new My_Database();
            DataGridView_Sourse.Width = 60;
            SqlCommand command = new SqlCommand("select id as ID, firstname as Firstname, lastname as Lastname from Add_Student", data.GetConnection);
            DataGridView_Sourse.DataSource = student.GetStudents(command);
        }
        private void Add_bt_Click(object sender, EventArgs e)
        {
            try
            {
                
                Scores score = new Scores();
                int sid = Convert.ToInt32(Id_tb.Text);
                int cid = Convert.ToInt32(ComboBox_Course.SelectedValue);
                float score_stu = (float)Convert.ToDouble(Score_tb.Text);
                string des = Des_tb.Text;
                if(score_stu > 10 || score_stu < 0)
                {
                    XtraMessageBox.Show("Score can not over 10. Please anter again!", "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else {
                    if (!score.Student_Score_Exist(sid, cid))
                    {
                        if (score.Add_Score(sid, cid, score_stu, des))
                        {
                            XtraMessageBox.Show("Add score successful!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Add score failed !", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("The Student ID and Course ID already", "All Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            
            }
            catch
            {
                XtraMessageBox.Show("The textbox is blank. Please enter again", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Avg_bt_Click(object sender, EventArgs e)
        {
            Average avg = new Average();
            avg.Show();
        }



        private void Load_Student_Click(object sender, EventArgs e)
        {
            this.ReloadStudent();
        }

        private void scoreBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.scoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet3);
            XtraMessageBox.Show("Edit Data Succussful!");
        }

        private void LoadScore_Click(object sender, EventArgs e)
        {
            this.ReloadCourse();
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            Id_tb.Text = DataGridView_Sourse.CurrentRow.Cells[0].Value.ToString().Trim();
        }
    }
}