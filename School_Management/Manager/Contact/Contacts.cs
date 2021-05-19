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
namespace School_Management.Manager.Contact
{
    public partial class Contacts : DevExpress.XtraEditors.XtraForm
    {
        public Contacts()
        {
            InitializeComponent();
        }


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
                int uid =Convert.ToInt32(LabelControl_ID.Text);
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
            DataTable table;
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
        }

        private void Edit_Group_Button_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            int id = ComboBoxEdit_SelectGroup1.SelectedIndex;
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
            int id = Convert.ToInt32(ComboBoxEdit_SelectGroup2.Text);
            if(group.DeleteGroup(id))
            {
                XtraMessageBox.Show("Delete Succussful!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Delete Failed!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}