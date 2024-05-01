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
namespace School_Management.Manager.Course
{
    public partial class AddCourse_FormStudent : DevExpress.XtraEditors.XtraForm
    {
        Courses course;
        Students student;
        Stack<int> selectedCourceAdded;
        public AddCourse_FormStudent()
        {
            InitializeComponent();
        }

        public void LoadListBox()
        {
            // Clear the registered courses list box
            ListBoxCourse.Items.Clear();

            // If no student is selected, exit the method
            if (string.IsNullOrEmpty(ComboBox_Student.Text))
                return;

            // Extract student ID from combo box text
            int studentId;
            if (!int.TryParse(ComboBox_Student.Text.Split('-')[0].Trim(), out studentId))
                return;

            // Retrieve registered courses for the selected student
            var registeredCourses = student.GetSelectedCourses(studentId)
                .AsEnumerable()
                .Select(row => row.Field<string>("label"))
                .ToList();

            // Add registered courses to the list box
            ListBoxCourse.Items.AddRange(registeredCourses.ToArray());

            // Clear the available courses list box
            Listbox_Available.Items.Clear();

            // Retrieve available courses for the selected semester
            var semester = ComboBox_Semester.Text.Trim();
            var availableCourses = course.GetCourseBySemester(semester)
                .AsEnumerable()
                .Select(row => row.Field<string>("label"));

            // Filter out registered courses from available courses
            var unregisteredCourses = availableCourses.Except(registeredCourses);

            // Add unregistered courses to the list box
            Listbox_Available.Items.AddRange(unregisteredCourses.ToArray());
        }


        private void ComboBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadListBox();
        }

        private void ComboBox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadListBox();
            //Listbox_Available.Items.Clear();
            //var source = course.GetCourseBySemester(ComboBox_Semester.Text.Trim());
            //foreach (DataRow row in source.Rows)
            //{
            //    Listbox_Available.Items.Add(row["label"]);
            //}

        }

        private void Add_Click(object sender, EventArgs e)
        {
            var course_selected = Listbox_Available.SelectedItem;
            if (course_selected != null)
            {
                var index = Listbox_Available.SelectedIndex;
                ListBoxCourse.Items.Add(course_selected);
                selectedCourceAdded.Push(index);
                Listbox_Available.Items.RemoveAt(index);
            }


            // Listbox_Available.Items.Clear();
        }

        private void Edit_andSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sid = ComboBox_Student.GetItemText(ComboBox_Student.SelectedItem).Split('-')[0].Trim();

                var success = course.RemoveStudentCourse(sid);
                if (!success)
                {
                    XtraMessageBox.Show("Failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var item in ListBoxCourse.Items)
                {
                    int cid = course.GetIdByLabel(item.ToString());

                    student.InsertSelectedCourse(sid, cid);
                }

                XtraMessageBox.Show("Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                XtraMessageBox.Show("Failed!", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_course_Click(object sender, EventArgs e)
        {
            // if (selectedCourceAdded.Count == 0) return;
            try
            {
                int index = 0;
                Listbox_Available.Items.Add(ListBoxCourse.Items[index]);
                ListBoxCourse.Items.RemoveAt(index);
            }
            catch (Exception)
            {

            }
        }

        private void AddCourse_FormStudent_Load(object sender, EventArgs e)
        {
            course = new Courses();
            student = new Students();
            selectedCourceAdded = new Stack<int>();

            var idTable = student.GetAllBriefInfo();
            for (int i = 0; i < idTable.Rows.Count; i++)
            {
                ComboBox_Student.Items.Add(idTable.Rows[i].ItemArray[0] + " - " + idTable.Rows[i].ItemArray[1] + " " + idTable.Rows[i].ItemArray[2]);
            }
            ComboBox_Student.SelectedIndex = 0;
            ComboBox_Student.Text = idTable.Rows[0].ItemArray[0] + " - " + idTable.Rows[0].ItemArray[1] + " " + idTable.Rows[0].ItemArray[2]; // default

            ComboBox_Semester.Items.Add("1");
            ComboBox_Semester.Items.Add("2");
            ComboBox_Semester.Items.Add("3");
            ComboBox_Semester.SelectedIndex = 0;

            LoadListBox();
            ComboBox_Semester.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Student_SelectedIndexChanged);

            ComboBox_Student.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Semester_SelectedIndexChanged);


        }
    }
}