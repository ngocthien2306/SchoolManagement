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

namespace School_Management.Manager.Contact
{
    public partial class PrintCo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrintCo()
        {
            InitializeComponent();
        }

        private void contactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student);

        }

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.student.Contact);

        }

        private void Print_Contact_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report report = new Report()
            {
                Title = "",
                Table = (System.Data.DataTable)ContactGridControl.DataSource
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
    }
}