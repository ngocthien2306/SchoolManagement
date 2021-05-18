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
    public partial class Edit_Remove : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Edit_Remove()
        {
            InitializeComponent();
        }

        private void IdStudent_lb_Click(object sender, EventArgs e)
        {

        }

        public bool Find()
        {
            if (ID_student.Text.Trim() == "")
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            else
            {
                My_Database dataBase = new My_Database();
                SqlCommand command = new SqlCommand(
                    "SELECT id, firstname, lastname, birthday, gender, address, phone, picture FROM Add_Student WHERE id = @address or firstname = @address or lastname = @address", dataBase.GetConnection);
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = ID_student.Text;

                dataBase.Openconnection();
                Students student = new Students();
                DataTable table = student.GetStudents(command);
                if (table.Rows.Count > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Add_Student");
                    dataBase.Closeconnection();
                    ID_student.Text = table.Rows[0]["id"].ToString();
                    Firstname.Text = table.Rows[0]["firstname"].ToString();
                    Lastname.Text = table.Rows[0]["lastname"].ToString();
                    Birthday_picker.DateTime = (DateTime)table.Rows[0]["birthday"];
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        Check_female.Checked = true;
                    }
                    else if (table.Rows[0]["gender"].ToString() == "Male")
                    {
                        Check_male.Checked = true;
                    }
                    Address_student.Text = table.Rows[0]["address"].ToString();
                    Phone_student.Text = table.Rows[0]["phone"].ToString();
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    Picture_Student.Image = Image.FromStream(picture);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
        }

        private void Up_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Picture_Student.Image = Image.FromFile(open.FileName);
            }
        }

        private void Find_bt_Click(object sender, EventArgs e)
        {
            this.Find();
        }
        public void Remove()
        {
            try
            {
                DialogResult delete = MessageBox.Show("Are you sure delete student with id: " + ID_student.Text, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    My_Database dataBase = new My_Database();

                    SqlCommand command = new SqlCommand(
                        "DELETE FROM Add_Student" +
                        " WHERE ID = @id", dataBase.GetConnection);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID_student.Text;

                    dataBase.Openconnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Complete", "Delete complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ID_student.Text = "";
                        Firstname.Text = "";
                        Lastname.Text = "";
                        Phone_lb.Text = "";
                        Address_student.Text = "";
                        Picture_Student.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Delete fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataBase.Closeconnection();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }
        private void Delete_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Remove();
        }

        private void Save_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Edit();
        }

        private void Reset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ID_student.Text = "";
            Firstname.Text = "";
            Lastname.Text = "";
            Phone_lb.Text = "";
            Address_student.Text = "";
            Picture_Student.Image = null;
        }

        private void Close_bt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to Close?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {

            }
        }
        public void Edit()
        {
            try
            {
                My_Database data = new My_Database();

                SqlCommand command = new SqlCommand("UPDATE Add_Student SET firstname = @Fname, lastname = @Lname, birthday = @Bdate, gender = @Gender, address = @Address, phone = @Phone, picture = @Picture WHERE id = @ID", data.GetConnection);
                command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = Firstname.Text;
                command.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = Lastname.Text;
                command.Parameters.Add("@Bdate", SqlDbType.DateTime).Value = Birthday_picker.DateTime;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address_student.Text;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone_student.Text;
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(Picture_Student.Image, typeof(byte[]));
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = image;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID_student.Text;
                data.Openconnection();
                if (Check_male.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "Male";
                }
                else if (Check_female.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "Female";
                }

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Complete", "Edit completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR", "Edit failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                data.Closeconnection();
            }

            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }
        private void Save_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Edit();
            this.Hide();
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