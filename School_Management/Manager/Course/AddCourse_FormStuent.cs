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
    public partial class AddCourse_FormStuent : DevExpress.XtraEditors.XtraForm
    {
        public string currId;
        Courses course;
        Students student;
        Stack<int> selectedCourceAdded;
        public AddCourse_FormStuent()
        {
            InitializeComponent();
        }
        public void LoadComboBox()
        {
            ComboBox_Student.DataSource = student.GetAllBriefInfo();
            ComboBox_Student.DisplayMember = "id";
            ComboBox_Student.ValueMember = "id";
        }
        public void LoadListBox()
        {
            ListBoxCourse.Items.Clear();
            if (ComboBox_Student.Text.Length == 0) return;
            var source = student.GetSelectedCourses(Convert.ToInt32(ComboBox_Student.Text.Trim()));
            foreach (DataRow row in source.Rows)
            {
                ListBoxCourse.Items.Add(row["label"]);
            }

            Listbox_Available.Items.Clear();
            source = course.GetCourseBySemester(ComboBox_Student.Text.Trim());
            foreach (DataRow row in source.Rows)
            {
                Listbox_Available.Items.Add(row["label"]);
            }
            for (int i = 0; i < Listbox_Available.Items.Count; i++)
            {
                for (int j = 0; j < ListBoxCourse.Items.Count; j++)
                {
                    try
                    {
                        if (Listbox_Available.GetItemText((int)Listbox_Available.Items[i]) == ListBoxCourse.GetItemText((int)ListBoxCourse.Items[j]))
                    
                        {
                            Listbox_Available.Items.Remove(ListBoxCourse.Items[j]);
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }
        private void AddCourse_FormStuent_Load(object sender, EventArgs e)
        {

            course = new Courses();
            student = new Students();
            selectedCourceAdded = new Stack<int>();
            
            var idTable = student.GetAllBriefInfo();
            for (int i = 0; i < idTable.Rows.Count; i++)
            {
                ComboBox_Student.Items.Add(idTable.Rows[i].ItemArray[0]);
            }


            LoadComboBox();

            ComboBox_Student.Text = currId;

            ComboBox_Semester.Items.Add("1");
            ComboBox_Semester.Items.Add("2");
            ComboBox_Semester.Items.Add("3");
            ComboBox_Semester.SelectedIndex = 0;

            LoadListBox();
            ComboBox_Semester.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Student_SelectedIndexChanged);

            ComboBox_Student.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Semester_SelectedIndexChanged);
        }

        private void ComboBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadListBox();
        }

        private void ComboBox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listbox_Available.Items.Clear();
            var source = course.GetCourseBySemester(ComboBox_Semester.Text.Trim());
            foreach (DataRow row in source.Rows)
            {
                Listbox_Available.Items.Add(row["label"]);
            }
            for (int i = 0; i < Listbox_Available.Items.Count; i++)
            {
                for (int j = 0; j < ListBoxCourse.Items.Count; j++)
                {
                    if (
                        Listbox_Available.GetItemText((int)ListBoxCourse.Items[i]) ==
                        ListBoxCourse.GetItemText((int)ListBoxCourse.Items[j])
                    )
                    {
                        Listbox_Available.Items.Remove(ListBoxCourse.Items[j]);
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            foreach (var item in Listbox_Available.Items)
            {
                int index = Listbox_Available.Items.Add(item);
                selectedCourceAdded.Push(index);
            }
            Listbox_Available.Items.Clear();
        }

        private void Edit_andSave_Click(object sender, EventArgs e)
        {
            try
            {
                while (selectedCourceAdded.Count > 0)
                {
                    string label = Listbox_Available.GetItemText((int)Listbox_Available.Items[selectedCourceAdded.Pop()]);
                    int id = course.GetIdByLabel(label);
                    student.InsertSelectedCourse(ComboBox_Student.GetItemText(ComboBox_Student.SelectedItem), id);
                }
                XtraMessageBox.Show("Complete!");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Failed!", "",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_course_Click(object sender, EventArgs e)
        {
            if (selectedCourceAdded.Count == 0) return;
            try
            {
                int index = selectedCourceAdded.Pop();
                Listbox_Available.Items.Add(ListBoxCourse.Items[index]);
                ListBoxCourse.Items.RemoveAt(index);
            }
            catch (Exception)
            {

            }
        }
    }
}