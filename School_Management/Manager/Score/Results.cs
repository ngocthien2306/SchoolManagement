using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public void Print()
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            print.Document = printDoc;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if (print.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report()
            {
                Title = "Student Score Report",
                Table = (System.Data.DataTable)DataGridView_Score.DataSource
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

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}