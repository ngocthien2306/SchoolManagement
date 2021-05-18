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
    public partial class RemoveScore : DevExpress.XtraEditors.XtraForm
    {
        public RemoveScore()
        {
            InitializeComponent();
        }
        public void LoadScore()
        {
            Scores score = new Scores();
            DataGridView_Score.DataSource = score.GetStudentScore();
        }
        private void RemoveScore_Load(object sender, EventArgs e)
        {
            this.LoadScore();
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Scores score = new Scores();
                int sid = Convert.ToInt32(DataGridView_Score.CurrentRow.Cells[0].Value);
                int cid = Convert.ToInt32(DataGridView_Score.CurrentRow.Cells[3].Value);
                DialogResult delete = XtraMessageBox.Show("Are you sure remove score with Student ID: " + sid + " and Course ID " + cid + "?", "Remove Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    if (score.Delete_Score(sid, cid))
                    {
                        XtraMessageBox.Show("Remove succussful!", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadScore();
                    }
                    else
                    {
                        XtraMessageBox.Show("Remove failed!", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("ERROR!");
            }
        }
    }
}