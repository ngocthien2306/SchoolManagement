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
    public partial class ShowFullList : DevExpress.XtraEditors.XtraForm
    {
        Contact_class contact = new Contact_class();
        Group group = new Group();
        public ShowFullList()
        {
            InitializeComponent();
        }
        public void ShowAll(DataTable table)
        {
            ListShowAll.DataSource = table;
            ListShowAll.RowTemplate.Height = 80;
            ListShowAll.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)ListShowAll.Columns[11];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ListShowAll.AllowUserToAddRows = false;

        }
        public void ShowGroup()
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("Select * from Contact", data.GetConnection);
            ListBox_Group.DataSource = contact.SelectContactList(command);
            ListBox_Group.ValueMember = "Group_id";
            ListBox_Group.DisplayMember = "Group_name";
            ListBox_Group.SelectedIndex = 0;
        }
        private void ShowFullList_Load(object sender, EventArgs e)
        {
            this.ShowGroup();
        }

        private void ListBox_Group_DoubleClick(object sender, EventArgs e)
        {
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("select * from group", data.GetConnection);
            int idx = ListBox_Group.SelectedIndex;
            if (idx < 0) return;
            DataTable allgroup = group.GetGroup(command);
            string _group = group.GetGroup(command).Rows[idx].ItemArray[1].ToString();
            DataTable table = contact.GetContactByGroup(_group);
            this.ShowAll(table);
        }

        private void ShowFull_Click(object sender, EventArgs e)
        {
            this.ShowAll(contact.SelectContactList());
        }

        private void Group_btn_Click(object sender, EventArgs e)
        {
            this.ShowGroup();
        }
    }
}