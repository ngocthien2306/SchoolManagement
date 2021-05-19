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

namespace School_Management.Manager.Course
{
    public partial class ListCourse : DevExpress.XtraEditors.XtraForm
    {
        public ListCourse()
        {
            InitializeComponent();
        }



        private void ListCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.student.Course);
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Course' table. You can move, or remove it, as needed.

        }


        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student);
            XtraMessageBox.Show("Save Data Course Succussful!", "Edit Data Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}