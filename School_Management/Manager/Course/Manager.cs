using DevExpress.XtraBars.Docking2010;
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
namespace School_Management.Manager.Course
{
    public partial class Manager : DevExpress.XtraEditors.XtraForm
    {
        public Manager()
        {
            InitializeComponent();
            foreach (WindowsUIButton navButton in WindowsUIButtonPanel.Buttons)
            {
                navButton.Style = ButtonStyle.CheckButton;
                navButton.GroupIndex = 1;
                navButton.UseCaption = true;
                navButton.Checked = false;
                
            }
            foreach (WindowsUIButton navButton1 in WindowsUIButtonPanel1.Buttons)
            {
                navButton1.Style = ButtonStyle.CheckButton;
                navButton1.GroupIndex = 1;
                navButton1.UseCaption = true;
                navButton1.Checked = false;
            }
        }
        My_Database data = new My_Database();
        Courses course = new Courses();
        int pos;
        public void ReloadListData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course",data.GetConnection);
            ListBoxControl.DataSource = course.GetCourse(command);
            ListBoxControl.ValueMember = "Id";
            ListBoxControl.DisplayMember = "label";
            ListBoxControl.SelectedItem = null;
        }
        public void Showdata(int index)
        {
            DataRow dr = course.GetAllCourses().Rows[index];
            ListBoxControl.SelectedIndex = index;
            ID_Course.Text = dr.ItemArray[0].ToString();
            NameCourse.Text = dr.ItemArray[1].ToString();
            Period_updown.Value = Convert.ToInt32(dr.ItemArray[2].ToString());
            Rich_decs.Text = dr.ItemArray[3].ToString();
            ComboxBox_Semester.Text = dr.ItemArray[4].ToString();

        }

        private void ListBoxControl_Click(object sender, EventArgs e)
        {
            DataRowView drview = (DataRowView)ListBoxControl.SelectedItem;
            pos = ListBoxControl.SelectedIndex;
            this.Showdata(pos);
        }
        public void RefreshList()
        {
            this.ReloadListData();
        }
        private bool Check()
        {
            if (ID_Course.Text.Trim() == "" || NameCourse.Text.Trim() == "" || Period_updown.Value < 10 || Rich_decs.Text.Trim() == "")
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
            switch (tag)
            {
                case "A1":

                    course.Id = Convert.ToInt32(ID_Course.Text);
                    course.Label = NameCourse.Text;
                    course.Period = Convert.ToInt32(Period_updown.Value);
                    course.Description = Rich_decs.Text;
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
                    try
                    {
                        int id = Convert.ToInt32(ID_Course.Text);
                        string label = NameCourse.Text;
                        int period = Convert.ToInt32(Period_updown.Value);
                        string description = Rich_decs.Text;
                        int se = Convert.ToInt32(ComboxBox_Semester.Text);
                        if (course.UpdateCourse(id, label, period, description, se))
                        {
                            MessageBox.Show("Edit course successful!", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit course failed", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch
                    {

                    }
                    break;
                case "A3":
                    DialogResult delete = MessageBox.Show("Are you sure delete student with id: " + ID_Course.Text, "",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    int ids = Convert.ToInt32(ID_Course.Text);
                    if (delete == DialogResult.Yes)
                    {
                        if (course.RemoveCourse(ids) && ID_Course.Text.Trim() != "")
                        {
                            MessageBox.Show("Complete", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Delete course failed", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                case "A4":
                    this.RefreshList();
                    break;
            }
        }

        private void WindowsUIButtonPanel1_ButtonChecked(object sender, ButtonEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", data.GetConnection);
            Courses course = new Courses();
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "E1":
                    pos = 0;
                    this.Showdata(pos);
                    WindowsUIButton e1 = new WindowsUIButton(); ;
                    e1.Checked = false;
                    break;
                case "E2":
                   
                    if (pos > 0)
                    {
                        pos -= 1;
                        this.Showdata(pos);
                    }
                    break;
                case "E3":
                    if (pos < (course.GetCourse(command).Rows.Count - 1))
                    {
                        pos += 1;
                        this.Showdata(pos);
                    }
                    break;
                case "E4":
                    pos = course.GetCourse(command).Rows.Count - 1;
                    this.Showdata(pos);

                    break;
            }

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            this.ReloadListData();
        }

        private void XtraTabPage_Course_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}