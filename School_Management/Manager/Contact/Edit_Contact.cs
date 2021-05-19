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
        DataTable table;
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
                   "SELECT ID, Firstname, Lastname, Group_id, Gender, Birthday, Phone, Email, Facebook, Address, City, Picture, User_id " +
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
                    TextEdit_ID.Text = table.Rows[0]["Id"].ToString().Trim();
                    TextEdit_Fname.Text = table.Rows[0]["Firstname"].ToString().Trim();
                    TextEdit_Lastname.Text = table.Rows[0]["Lastname"].ToString().Trim();
                    ComboBox_GroupId.Text = table.Rows[0]["Group_id"].ToString().Trim();
                    ComboBox_GroupId.SelectedValue = ComboBox_GroupId.DisplayMember;
                    ComboBoxEdit_Gender.Text = table.Rows[0]["Gender"].ToString().Trim();
                    DateEdit_Birthday.DateTime = (DateTime)table.Rows[0]["Birthday"];
                    TextEdit_Phone.Text = table.Rows[0]["Phone"].ToString().Trim();
                    TextEdit_Mail.Text = table.Rows[0]["Email"].ToString().Trim();
                    TextEdit_Fb.Text = table.Rows[0]["Facebook"].ToString().Trim();
                    TextEdit_Address.Text = table.Rows[0]["Address"].ToString().Trim();
                    TextEdit_City.Text = table.Rows[0]["City"].ToString().Trim();
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
                My_Database data = new My_Database();
                SqlCommand command = new SqlCommand("UPDATE Contact SET Firstname = @fn, Lastname = @ln, Group_id = @group, Gender = @gen, Birthday = @day, " +
                    "Phone = @phone, Email = @email, Facebook = @fb, Address = @add, City = @city, Picture = @pic WHERE ID = @id", data.GetConnection);
                command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = TextEdit_Fname.Text;
                command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = TextEdit_Lastname.Text;
                command.Parameters.Add("@group", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[ComboBox_GroupId.SelectedIndex][0].ToString());
                command.Parameters.Add("@gen", SqlDbType.NVarChar).Value = ComboBoxEdit_Gender.Text;
                command.Parameters.Add("@day", SqlDbType.DateTime).Value = DateEdit_Birthday.DateTime;
                command.Parameters.Add("@phone", SqlDbType.Int).Value = Convert.ToInt32(TextEdit_Phone.Text);
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
                    XtraMessageBox.Show("Edit Failed!", "Edit Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    data.Closeconnection();
                   
                }
                
            //}

            //catch 
            //{
            //    XtraMessageBox.Show("Edit Failed!", "Edit Contacts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
            XtraMessageBox.Show("Saved Data Succussful!", "Edit Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void GetIdGroup()
        {
            Group group = new Group();
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT * FROM [Group1]", data.GetConnection);

            table = group.GetAll_ID_label();
            ComboBox_GroupId.SelectedItem = 0;
            ComboBox_GroupId.ValueMember = "Group_id";
            ComboBox_GroupId.DisplayMember = "Group_name";  

            foreach (DataRow row in table.Rows)
            {
                ComboBox_GroupId.Items.Add(row[1].ToString().Trim());

            }
        }
        private void Edit_Contact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.manager_StudentDataSet3.Contact);
            Group group = new Group();
            this.GetIdGroup();

            DateEdit_Birthday.Text = "1/1/2000";
        }

        private void Find_Button_Click_1(object sender, EventArgs e)
        {
            this.Find();
        }

        private void PictureEdit_User_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureEdit_User.Image = Image.FromFile(open.FileName);
            }
        }

        private void M020201_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.contactTableAdapter.Fill(this.manager_StudentDataSet3.Contact);
        }
        public void ResetChange()
        {
            TextEdit_ID.Text = "";
            TextEdit_Fname.Text = "";
            TextEdit_Lastname.Text = "";
            DateEdit_Birthday.Text = "1/1/1973";
            ComboBoxEdit_Gender.Text = "";
            ComboBox_GroupId.Text = "";
            TextEdit_Address.Text = "";
            TextEdit_City.Text = "";
            TextEdit_Phone.Text = "";
            TextEdit_Mail.Text = "";
            TextEdit_Fb.Text = "";
            PictureEdit_User.Image = default;
        }
        private void contactBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void M010102_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.EditContact();
            this.Hide();
        }

        private void M010103_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.EditContact();
            this.ResetChange();
        }

        private void M010104_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contact_class contact = new Contact_class();
            if(TextEdit_ID.Text == "")
            {
                XtraMessageBox.Show("The textbox incorrect format! Please enter again.", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(TextEdit_ID.Text);
                if(contact.DeleteContacts(id))
                {
                    XtraMessageBox.Show("Delelte Completed", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Delete Failed", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
