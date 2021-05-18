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
using System.IO;
using System.Data.SqlClient;
using School_Management.Manager.Student;
namespace School_Management.Manager.Contact
{
    public partial class Edit_Contact : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Edit_Contact()
        {
            InitializeComponent();
        }
        public void Find()
        {
            if (TextEdit_ID.Text.Trim() == "")
            {
                XtraMessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                My_Database dataBase = new My_Database();
                SqlCommand command = new SqlCommand(
                   "SELECT ID, Firstname, Fastname, Group_id, Gender, Birthday, Phone, Email, Facebook, Address, City, Picture, User_id " +
                "FROM Contact WHERE ID = @id", dataBase.GetConnection);
                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = TextEdit_ID.Text;

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
                    TextEdit_ID.Text = table.Rows[0]["Id"].ToString();
                    TextEdit_Fname.Text = table.Rows[0]["Firstname"].ToString();
                    TextEdit_Lastname.Text = table.Rows[0]["Fastname"].ToString();
                    TextEdit_GroupID.Text = table.Rows[0]["Group_id"].ToString();
                    ComboBoxEdit_Gender.SelectedItem = table.Rows[0]["Gender"].ToString();
                    DateEdit_Birthday.DateTime = (DateTime)table.Rows[0]["Birthday"];
                    TextEdit_Phone.Text = table.Rows[0]["Phone"].ToString();
                    TextEdit_Mail.Text = table.Rows[0]["Email"].ToString();
                    TextEdit_Fb.Text = table.Rows[0]["Facebook"].ToString();
                    TextEdit_Address.Text = table.Rows[0]["Address"].ToString();
                    TextEdit_City.Text = table.Rows[0]["City"].ToString();
                    byte[] pic = (byte[])table.Rows[0]["Picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureEdit_User.Image = Image.FromStream(picture);
                    
                }
                else
                {
                    XtraMessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
            }
        }
        public void OpenEdit()
        {

        }
        public void EditContact()
        {
            try
            {
                My_Database data = new My_Database();
                SqlCommand command = new SqlCommand("UPDATE Contact SET Firstname = @fn, Fastname = @ln, Group_id = @group, Gender = @gen, Birthday = @day, " +
                    "Phone = @phone, Email = @email, Facebook = @fb, Address = @add, City = @city, Picture = @pic, User_id = @id", data.GetConnection);
                command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = TextEdit_Fname.Text;
                command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = TextEdit_Lastname.Text;
                command.Parameters.Add("@group", SqlDbType.NVarChar).Value = TextEdit_GroupID.Text;
                command.Parameters.Add("@gen", SqlDbType.NVarChar).Value = ComboBoxEdit_Gender.SelectedItem.ToString();
                command.Parameters.Add("@day", SqlDbType.DateTime).Value = DateEdit_Birthday.DateTime;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = TextEdit_Phone.Text;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = TextEdit_Mail.Text;
                command.Parameters.Add("@fb", SqlDbType.NVarChar).Value = TextEdit_Fb.Text;
                command.Parameters.Add("@add", SqlDbType.NVarChar).Value = TextEdit_Address.Text;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = TextEdit_City.Text;
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(PictureEdit_User.Image, typeof(byte[]));
                command.Parameters.Add("@pic", SqlDbType.Image).Value = image;
                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(TextEdit_ID.Text);
                data.Openconnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    XtraMessageBox.Show("Edit Successful!", "Edit Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Closeconnection();
                    
                }
                else
                {
                    XtraMessageBox.Show("Edit Failed!", "Edit Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Closeconnection();
                   
                }
                
            }

            catch 
            {
                XtraMessageBox.Show("");
            }
        }
        private void M010101_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.EditContact();
        }

        private void Find_Button_Click(object sender, EventArgs e)
        {
            this.Find();
        }

        private void PictureEdit_User_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureEdit_User.Image = Image.FromFile(open.FileName);
            }
        }

        private void contactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manager_StudentDataSet3);

        }

        private void Edit_Contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.manager_StudentDataSet3.Contact);

        }
    }
}
//int user_id = Convert.ToInt32(TextEdit_ID.Text);
//string firstname = TextEdit_Fname.Text;
//string lastname = TextEdit_Lastname.Text;
//DateTime bday = DateEdit_Birthday.DateTime;
//string gender = ComboBoxEdit_Gender.SelectedIndex.ToString();
//string groupid = TextEdit_GroupID.Text;
//string address = TextEdit_Address.Text;
//string city = TextEdit_City.Text;
//int phone = Convert.ToInt32(TextEdit_Phone.Text);
//string email = TextEdit_Mail.Text;
//string fbook = TextEdit_Fb.Text;
//ImageConverter converter = new ImageConverter();
//byte[] image = (byte[])converter.ConvertTo(PictureEdit_User.Image, typeof(byte[]));
//MemoryStream pic = image;
