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

namespace School_Management.Manager.Contact
{
    public partial class Add_Contacts : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Add_Contacts()
        {
            InitializeComponent();

        }
        DataTable table;
        private void Add_Contacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet4.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter1.Fill(this.manager_StudentDataSet4.Contact);
            // TODO: This line of code loads data into the 'manager_StudentDataSet4.Group1' table. You can move, or remove it, as needed.
            this.group1TableAdapter1.Fill(this.manager_StudentDataSet4.Group1);
            // TODO: This line of code loads data into the 'manager_StudentDataSet31.Group' table. You can move, or remove it, as needed.
            Group group = new Group();
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT * FROM [Group1]", data.GetConnection);

            table = group.GetAll_ID_label();
            ComboBox_GroupID.ValueMember = "Group_id";
            foreach (DataRow row in table.Rows)
            {
                ComboBox_GroupID.Items.Add(row[1].ToString().Trim());

            }

            DateEdit_Birthday.Text = "1/1/2000";
        }

        private void BarButtonItem_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Contact_class contact = new Contact_class();
                int user_id = Convert.ToInt32(TextEdit_ID.Text);
                string firstname = TextEdit_Fname.Text;
                string lastname = TextEdit_Lastname.Text;
                DateTime bday = DateEdit_Birthday.DateTime;
                string gender = ComboBoxEdit_Gender.SelectedText.ToString();
                int groupid = Convert.ToInt32(table.Rows[ComboBox_GroupID.SelectedIndex][0].ToString());
                string address = TextEdit_Address.Text;
                string city = TextEdit_City.Text;
                int phone = Convert.ToInt32(TextEdit_Phone.Text);
                string email = TextEdit_Mail.Text;
                string fbook = TextEdit_Fb.Text;
                MemoryStream pic = new MemoryStream();
                PictureEdit_User.Image.Save(pic, PictureEdit_User.Image.RawFormat);
                if (contact.InsertContact(firstname, lastname, groupid, gender, bday, phone, email, fbook, address, city, pic, user_id))
                {
                    XtraMessageBox.Show("Add contact successful!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Add contact failed!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                XtraMessageBox.Show("Wrong! Please check the textbox maybe are blank or incorrect format", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private void PictureEdit_User_EditValueChanged(object sender, EventArgs e)
        {

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

        private void MethodX_Click(object sender, EventArgs e)
        {

        }

        private void M0501_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet4.Group1' table. You can move, or remove it, as needed.
            this.group1TableAdapter1.Fill(this.manager_StudentDataSet4.Group1);
            // TODO: This line of code loads data into the 'manager_StudentDataSet31.Group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.manager_StudentDataSet31.Group);
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.manager_StudentDataSet3.Contact);
        }
    }
}