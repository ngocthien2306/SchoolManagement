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

namespace School_Management.Manager.Score
{
    public partial class Results : DevExpress.XtraEditors.XtraForm
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            DataGridView_Score.DataSource = scores.MakeStudentScoreResultTable();
        }

        private void DataGridView_Score_DoubleClick(object sender, EventArgs e)
        {
            TextEdit_ID.Text = DataGridView_Score.CurrentRow.Cells[0].Value.ToString().Trim();
        }
    }
}