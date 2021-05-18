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
            add.ShowDialog();
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
            SqlCommand command = new SqlCommand("SELECT Group_id, Group_name FROM Group", data.GetConnection);
            DataTable table;
            table = group.GetGroup(command);
            foreach(DataRow row in table.Rows)
            {
                ComboBoxEdit_SelectGroup1.Items.Add(row[1].ToString().Trim());
                ComboBoxEdit_SelectGroup2.Items.Add(row[1].ToString().Trim());
            }
        }
        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Edit_Contact edit = new Edit_Contact();
            edit.ShowDialog();
        }

        private void Edit_Group_Button_Click(object sender, EventArgs e)
        {

        }
    }
}