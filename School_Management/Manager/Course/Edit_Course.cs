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

namespace School_Management.Manager.Course
{
    public partial class Edit_Course : DevExpress.XtraEditors.XtraForm
    {
        public Edit_Course()
        {
            InitializeComponent();
        }
        public void Reset_Change()
        {
            ID_Course_tb.Text = "";
            NameCourse_tb.Text = "";
            Period_tb.Text = "";
            Description.Text = "";
        }
        public void Edit_Information()
        {
            Courses course = new Courses();
            int id = Convert.ToInt32(ID_Course_tb.Text);
            string label = NameCourse_tb.Text;
            int period = Convert.ToInt32(Period_tb.Text);
            string description = Description.Text;
            if(course.UpdateCourse(id, label, period, description)) {
                MessageBox.Show("Edit course successful!", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Edit course failed", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }
        public void Remove()
        {
            DialogResult delete = MessageBox.Show("Are you sure delete student with id: " + ID_Course_tb.Text, "",
    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int id = Convert.ToInt32(ID_Course_tb.Text);
            if (delete == DialogResult.Yes) { 
                Courses course = new Courses();
                if (course.RemoveCourse(id) && ID_Course_tb.Text.Trim()!= "")
                {
                    MessageBox.Show("Complete", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Reset_Change();
                }
                else
                {
                    MessageBox.Show("Delete course failed", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public bool Find()
        {
            try
            {
                if (ID_Course_tb.Text.Trim() == "")
                {
                    XtraMessageBox.Show("The textbox is blank, please enter ID you want to find", "Find Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    Courses course = new Courses();
                    My_Database dataBase = new My_Database();
                    SqlCommand command = new SqlCommand(
                        "SELECT Id, label, period, description FROM Course WHERE id = @ID", dataBase.GetConnection);
                    command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID_Course_tb.Text;

                    dataBase.Openconnection();
                    DataTable table = course.GetCourse(command);
                    if (table.Rows.Count > 0)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Course");
                        this.Show();
                        ID_Course_tb.Text = table.Rows[0]["Id"].ToString();
                        NameCourse_tb.Text = table.Rows[0]["label"].ToString();
                        Period_tb.Text = table.Rows[0]["period"].ToString();
                        Description.Text = table.Rows[0]["description"].ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Not found this course", "Find Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        
        private void Find_bt_Click(object sender, EventArgs e)
        {
            this.Find();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Edit_Information();
        }

        private void Edit_andSave_Click(object sender, EventArgs e)
        {
            this.Edit_Information();
            this.Hide();
        }

        private void Delete_course_Click(object sender, EventArgs e)
        {
            this.Remove();
        }

        private void ResetChange_Click(object sender, EventArgs e)
        {
            this.Reset_Change();
        }
    }
}