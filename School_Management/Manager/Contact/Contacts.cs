using DevExpress.XtraBars;
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
using School_Management.Manager.Login;
using System.IO;

namespace School_Management.Manager.Contact
{
    public partial class Contacts : DevExpress.XtraEditors.XtraForm
    {
        public Contacts()
        {
            InitializeComponent();
        }
        DataTable table;
        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_Contacts add = new Add_Contacts();
            add.Show();
        }

        private void AddGroup_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Group group = new Group();
                int id = Convert.ToInt32(TextEdit_GroupID.Text);
                string nid = NameGroup_Textbox.Text;
                int uid = Convert.ToInt32(LabelControl_ID.Text);
                if (group.InsertGroup(id, nid, uid))
                {
                    XtraMessageBox.Show("Add a new group successful!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Add a new group failed!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                XtraMessageBox.Show("Please check the textbox!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ShowGroup()
        {
            Group group = new Group();
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT Group_id, Group_name FROM Group1", data.GetConnection);

            table = group.GetGroup(command);
            ComboBoxEdit_SelectGroup2.ValueMember = "Group_id";
            ComboBoxEdit_SelectGroup1.ValueMember = "Group_id";
            foreach(DataRow row in table.Rows)
            {
                ComboBoxEdit_SelectGroup1.Items.Add(row[1].ToString().Trim());
                ComboBoxEdit_SelectGroup2.Items.Add(row[1].ToString().Trim());
            }
        }
        private void Contacts_Load(object sender, EventArgs e)
        {
            this.ShowGroup();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Edit_Contact edit = new Edit_Contact();
            edit.ShowDialog();
            this.ShowGroup();
        }

        private void Edit_Group_Button_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            int id =(int)ComboBoxEdit_SelectGroup1.SelectedValue;
            string name = NewName_Textbox.Text;
            if(group.UpdateGroup(id, name))
            {
                XtraMessageBox.Show("Update Succussful!", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Update Failed!", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Remove_Group_Button_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            ComboBoxEdit_SelectGroup2.ValueMember = "Group_id";
            int id = Convert.ToInt32(table.Rows[ComboBoxEdit_SelectGroup2.SelectedIndex][0].ToString());
            if (group.DeleteGroup(id))
            {
                XtraMessageBox.Show("Delete Succussful!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Delete Failed!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.ShowGroup();
        }

        private void ShowList_Button_Click(object sender, EventArgs e)
        {
            ShowFullList list = new ShowFullList();
            list.ShowDialog();
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            DialogResult exit = XtraMessageBox.Show("Do you want logout account?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes)
            {
                this.Hide();
                Login_Account login = new Login_Account();
                login.Show();
            }
            else
            {

            }
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            Edit_Contact edit = new Edit_Contact();
            edit.TextEdit_ID.Text = ID_Textbox.Text;
            if(ID_Textbox.Text == "")
            {
                XtraMessageBox.Show("The textbox incorrect format", "Find contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                edit.Find();
                edit.ShowDialog();
            }
            
        }

        private void Remove_contact_Button_Click(object sender, EventArgs e)
        {
            Edit_Contact edit = new Edit_Contact();
            edit.TextEdit_ID.Text = ID_Textbox.Text;
            if(ID_Textbox.Text == "")
            {
                XtraMessageBox.Show("The textbox incorrect format", "Delete contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            PrintCo print = new PrintCo();
            print.ShowDialog();
        }

        private void HyperlinkLabelControl_Click(object sender, EventArgs e)
        {
            try
            {
                Create_Account login = new Create_Account();
                if (LabelControl_ID.Text.Trim() == "")
                {
                    XtraMessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    My_Database dataBase = new My_Database();
                    SqlCommand command = new SqlCommand(
                        "SELECT Id, firstname, lastname, username, password, picture, role FROM New_User WHERE Id = @ID", dataBase.GetConnection);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value =Convert.ToInt32(LabelControl_ID.Text);

                    dataBase.Openconnection();
                    Users user = new Users();
                    DataTable table = user.GetUser(command);
                    if (table.Rows.Count > 0)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "New_User");
                        dataBase.Closeconnection();
                        login.ID_tb.Text = table.Rows[0]["Id"].ToString().Trim();
                        login.First_tb.Text = table.Rows[0]["firstname"].ToString().Trim();
                        login.Last_tb.Text = table.Rows[0]["lastname"].ToString().Trim();
                        login.User_tb.Text = table.Rows[0]["username"].ToString().Trim();
                        login.Pass_tb.Text = table.Rows[0]["password"].ToString().Trim();
                        byte[] pic = (byte[])table.Rows[0]["picture"];
                        login.CheckedComboBox_Role.Text = table.Rows[0]["role"].ToString().Trim();
                        MemoryStream picture = new MemoryStream(pic);
                        login.PictureUser.Image = Image.FromStream(picture);
                        login.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Error format", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("The format incorrect", "User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}