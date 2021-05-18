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

namespace School_Management.Manager.Student
{
    public partial class Find_Student : DevExpress.XtraEditors.XtraForm
    {
        public Find_Student()
        {
            InitializeComponent();
        }

        private void Find_bt_Click(object sender, EventArgs e)
        {
            Edit_Remove edit = new Edit_Remove();
            edit.ID_student.Text = Keyword_text.Text;
            if(edit.Check_male.Text == "Male")
            {
                edit.Check_male.Checked = true;
            }
            else
            {
                edit.Check_female.Checked = true;
            }
            if (edit.Find())
            {
                edit.Show();
            }
        }
    }
}