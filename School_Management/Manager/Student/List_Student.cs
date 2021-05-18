using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Student
{
    public partial class List_Student : DevExpress.XtraEditors.XtraForm
    {
        public List_Student()
        {
            InitializeComponent();
        }
        public bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Add_Student", dataBase.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Add_Student");
                dataBase.Closeconnection();

                DataSource_Student.RowTemplate.Height = 40;
               
                DataTable table = dataSet.Tables["Add_Student"];
                DataSource_Student.DataSource = table;
                DataSource_Student.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DataSource_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataSource_Student.AllowUserToAddRows = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        public bool OpenEdit()
        {
            try
            {
                Edit_Remove editDelete = new Edit_Remove();
                editDelete.ID_student.Text = DataSource_Student.CurrentRow.Cells[0].Value.ToString().Trim();
                editDelete.Firstname.Text = DataSource_Student.CurrentRow.Cells[1].Value.ToString().Trim();
                editDelete.Lastname.Text = DataSource_Student.CurrentRow.Cells[2].Value.ToString().Trim();
                editDelete.Birthday_picker.DateTime = (DateTime)DataSource_Student.CurrentRow.Cells[3].Value;
                if (DataSource_Student.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
                {
                    editDelete.Check_male.Checked = true;
                }
                else if (DataSource_Student.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
                {
                    editDelete.Check_female.Checked = true;
                }
                editDelete.Address_student.Text = DataSource_Student.CurrentRow.Cells[5].Value.ToString().Trim();
                editDelete.Phone_student.Text = DataSource_Student.CurrentRow.Cells[6].Value.ToString().Trim();
                byte[] byteImage = (byte[])DataSource_Student.CurrentRow.Cells[7].Value;
                MemoryStream stream = new MemoryStream(byteImage);
                editDelete.Picture_Student.Image = Image.FromStream(stream);
                editDelete.Show();
                return true;
            }
            catch
            {
                XtraMessageBox.Show("Cannot open edit form");
                return false;
                throw;
            }
        }
        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter1.Fill(this.manager_StudentDataSet3.Add_Student);
            this.ShowList();
        }

        private void DataSource_Student_DoubleClick(object sender, EventArgs e)
        {
            this.OpenEdit();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            this.OpenEdit();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            this.ShowList();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DataSource_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}