using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management.Manager.Course;
namespace School_Management.Manager.Student
{
    public partial class Add_Students : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Add_Students()
        {
            InitializeComponent();
        }
        private void Add_Students_Load(object sender, EventArgs e)
        {

        }
        public bool Check()
        {
            if (ID_student.Text == "" || Firstname.Text == "" || Lastname.Text == "" ||
                Phone_student.Text == "" || Address_student.Text == ""
                    || Picture_Student.Image == null)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Picture_Student.Image = Image.FromFile(open.FileName);
            }
        }
        public void Add()
        {
            try
            {
                Students student = new Students();
                int Id = Convert.ToInt32(ID_student.Text);
                string firstname = this.Firstname.Text;
                string lastname = this.Lastname.Text;
                DateTime birthday = Birthday_Picker.Value;
                string phone = this.Phone_student.Text;
                string address = this.Address_student.Text;
                string gender = "Female";
                if (Check_male.Checked == true)
                {
                    Check_female.Checked = false;
                    gender = "Male";
                }

                MemoryStream pic = new MemoryStream();
                if (student.IsExistId(Id) >= 1)
                {

                }
                else
                {

                    Picture_Student.Image.Save(pic, Picture_Student.Image.RawFormat);
                    if (student.AddStudent(Id, firstname, lastname, birthday, gender, phone, address, pic))
                    {
                        XtraMessageBox.Show("New student added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        XtraMessageBox.Show("Error", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch
            {
                XtraMessageBox.Show("Error! Please check the Cotrol", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AddStudent()
        {
            this.Add();
        }
        private void Save_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.AddStudent();
        }

        private void Check_male_CheckedChanged(object sender, EventArgs e)
        {
            Check_female.Checked = false;           
        }

        private void Check_female_CheckedChanged(object sender, EventArgs e)
        {
            Check_male.Checked = false;
        }

        private void M0201_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_Course add = new Add_Course();
            add.ShowDialog();
        }

        private void Save_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Add();
            this.Hide();
        }
        public void ResetChange()
        {
            ID_student.Text = "";
            Firstname.Text = "";
            Lastname.Text = "";
            Check_male.Checked = true;
            Check_female.Checked = false;
            Phone_student.Text = "";
            Address_student.Text = "";
            Picture_Student.Image = null;

        }
        private void Save_new_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Add();
            this.ResetChange();
        }

        private void Reset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ResetChange();
        }
        private void Close_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }
    }
}