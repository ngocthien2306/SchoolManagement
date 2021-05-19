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
            int idx;
            try
            {
                idx = (int)ListBox_Group.SelectedValue;
            }
            catch (Exception)
            {
                return;
            }
            if (idx < 0) return;
            DataTable allcontact = group.GetAllContactInGroup(idx);

            this.ShowAll(allcontact);
        }

        private void ShowFull_Click(object sender, EventArgs e)
        {
            this.ShowAll(contact.SelectContactList());
        }

        private void Group_btn_Click(object sender, EventArgs e)
        {
            this.ShowGroup();
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report()
            {
                Title = "",
                Table = (System.Data.DataTable)ListShowAll.DataSource
            };

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Report";
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx|Excel files(.xlsx) |*.xlsx";


            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                if (savefile.FileName.EndsWith("docx") == true)
                {
                    report.toWordReport(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("xlsx") == true)
                {
                    report.ToExcelReport(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ListShowAll_DoubleClick(object sender, EventArgs e)
        {
            Edit_Contact edit = new Edit_Contact();
            edit.TextEdit_ID.Text = ListShowAll.CurrentRow.Cells[0].Value.ToString().Trim();
            edit.Find();
            edit.ShowDialog();
        }
    }
}