using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Course
{
    public partial class Find_Course : DevExpress.XtraEditors.XtraForm
    {
        public Find_Course()
        {
            InitializeComponent();
        }

        public void Find_Click(object sender, EventArgs e)
        {
            Edit_Course edit = new Edit_Course();
            edit.ID_Course_tb.Text = Keyword_tb.Text;
            if(edit.Find())
            {
                edit.Show();
            }
            else
            {
                
            }
        }
    }
}