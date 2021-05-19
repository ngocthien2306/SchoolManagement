using DevExpress.XtraBars;
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
using DevExpress.XtraEditors;

namespace School_Management.Manager.Course
{
    public partial class Add_Course : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Add_Course()
        {
            InitializeComponent();
        }
        private bool Check()
        {
            if(ID_Course_tb.Text.Trim() == "" || NameCourse_tb.Text.Trim() == "" || Period_tb.Text.Trim() == "" || Description.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddCourse()
        {
            try
            {
                Courses course = new Courses();
                course.Id = Convert.ToInt32(ID_Course_tb.Text);
                course.Label = NameCourse_tb.Text;
                course.Period = Convert.ToInt32(Period_tb.Text);
                course.Description = Description.Text;
                course.Semester = Convert.ToInt32(ComboBox_Semester.Text);
                if (course.CheckCourseName(course.Label))
                {
                    if (this.Check())
                    {
                        XtraMessageBox.Show("The textbox control is blank! Please enter again", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (course.AddThisCourse())
                        {
                            XtraMessageBox.Show("Add a new course successful!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Add failed", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("This course already exist!. Please add a new course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                XtraMessageBox.Show("Error! Please check textbox", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Save_Course_Click(object sender, EventArgs e)
        {
            this.AddCourse();
            
        }

        private void Save_and_Close_Click(object sender, EventArgs e)
        {
            this.AddCourse();
            this.Hide();

        }
        public void ResetChange()
        {
            ID_Course_tb.Text = "";
            NameCourse_tb.Text = "";
            Description.Text = "";
            Period_tb.Text = "";
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            this.ResetChange();
        }

        private void Close_program_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}