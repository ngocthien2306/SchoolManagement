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
using System.Data.SqlClient;
using DevExpress.XtraBars.Docking2010;
using System.Data.Entity;

namespace School_Management.Manager.Course
{
    public partial class Manager_Course : DevExpress.XtraEditors.XtraForm
    {
        public Manager_Course()
        {
            InitializeComponent();
            //WindowsUIButtonPanel.AppearanceButton.Pressed.BackColor = Color.DarkGray;
            //WindowsUIButton navButton1 = new WindowsUIButton()
            //{
            //    Tag = "Ad1",
            //    Caption = "Add",
            //    Style = ButtonStyle.CheckButton,
            //    ImageUri = "Add;Size32x32;GrayScaled",

            //};
            //WindowsUIButton navButton2 = new WindowsUIButton()
            //{
            //    Tag = "Ad2",
            //    Caption = "Edit",
            //    Style = ButtonStyle.CheckButton,
            //    ImageUri = "Edit;Size32x32;GrayScaled",

            //};
            //WindowsUIButton navButton3 = new WindowsUIButton()
            //{
            //    Tag = "Ad3",
            //    Caption = "Remove",
            //    Style = ButtonStyle.CheckButton,
            //    ImageUri = "Delete;Size32x32;GrayScaled"
            //};
            //WindowsUIButton navButton4 = new WindowsUIButton()
            //{
            //    Tag = "Ad4",
            //    Caption = "Reset",
            //    Style = ButtonStyle.CheckButton,
            //    ImageUri = "Reset;Size32x32;GrayScaled"
            //};
            //WindowsUIButtonPanel.Buttons.AddRange(new WindowsUIButton[] { navButton1, navButton2, navButton3, navButton4 });
            foreach (WindowsUIButton navButton in WindowsUIButtonPanel.Buttons)
            {
                navButton.Style = ButtonStyle.CheckButton;
                navButton.GroupIndex = 1;
                navButton.UseCaption = true;

            }
            
        }
        Courses course = new Courses();
        private void Manager_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.manager_StudentDataSet.Course);

        }
        public void Showlist()
        {
            My_Database dataBase = new My_Database();
            SqlCommand command = new SqlCommand(
                "SELECT FROM Course", dataBase.GetConnection);
            dataBase.Openconnection();
            DataTable table = course.GetCourse(command);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Course");
            ID_Course.Text = table.Rows[0]["Id"].ToString();
            Name_Course.Text = table.Rows[0]["lable"].ToString();
            Period.Text = table.Rows[0]["period"].ToString();
            Rich_Description.Text = table.Rows[0]["description"].ToString();

        }
        public void Display(int index)
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT * FROM Course", data.GetConnection);
            DataRow dr = course.GetCourse(command).Rows[index];
            ID_Course.Text = dr.ItemArray[0].ToString();
            Name_Course.Text = dr.ItemArray[1].ToString();
            Period.Value = int.Parse(dr.ItemArray[2].ToString());
            Rich_Description.Text = dr.ItemArray[3].ToString();
            
        }
        public void OpenEdit()
        {
            
        }
        public void RefreshList()
        {
            this.courseTableAdapter.Fill(this.manager_StudentDataSet.Course);
        }
        private void WindowsUIButtonPanel_Click(object sender, EventArgs e)
        {
            
        }
        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Save record", "",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (save == DialogResult.Yes)
            {
                this.Validate();
                this.courseBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet);
            }
        }
        private bool Check()
        {
            if (ID_Course.Text.Trim() == "" || Name_Course.Text.Trim() == "" || Period.Value < 10 || Rich_Description.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void WindowsUIButtonPanel_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            Courses course = new Courses();
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch(tag)
            {
                case "A1":
 
                    course.Id = Convert.ToInt32(ID_Course.Text);
                    course.Label = Name_Course.Text;
                    course.Period = Convert.ToInt32(Period.Value);
                    course.Description = Rich_Description.Text;
                    if (course.CheckCourseName(course.Label))
                    {
                        if (this.Check())
                        {
                            MessageBox.Show("The textbox control is blank! Please enter again", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (course.AddThisCourse())
                            {
                                MessageBox.Show("Add a new course successful!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Add failed", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("This course already!. Please add a new course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "A2":
                    int id = Convert.ToInt32(ID_Course.Text);
                    string label = Name_Course.Text;
                    int period = Convert.ToInt32(Period.Value);
                    string description = Rich_Description.Text;
                    if (course.UpdateCourse(id, label, period, description))
                    {
                        MessageBox.Show("Edit course successful!", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Edit course failed", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    break;
                case "A3":
                    DialogResult delete = XtraMessageBox.Show("Are you sure delete student with id: " + ID_Course.Text, "",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    int ids = Convert.ToInt32(ID_Course.Text);
                    if (delete == DialogResult.Yes)
                    {
                        if (course.RemoveCourse(ids) && ID_Course.Text.Trim() != "")
                        {
                            XtraMessageBox.Show("Complete", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Delete course failed", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                case "A4":
                    this.RefreshList();
                    break;
            }
        }

        private void CourseGridControl_DoubleClick(object sender, EventArgs e)
        {
            this.Showlist();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet);

        }
    }
}