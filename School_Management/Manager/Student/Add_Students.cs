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
        public void AddStudent()
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
                //int born_year = Convert.ToInt32(Birthday_Picker.ToString());
                //int this_year = Convert.ToInt32(DateTime.Now.Year);
                //if (this_year - born_year < 10 || this_year - born_year > 100)
                //{
                //    XtraMessageBox.Show("The student age must be 10 to 100 year", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                if (!Check())
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
                else
                {
                    XtraMessageBox.Show("Empty fields", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                XtraMessageBox.Show("Error! Please check the Cotrol", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}