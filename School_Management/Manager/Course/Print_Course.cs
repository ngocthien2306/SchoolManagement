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
using Microsoft.Office.Interop.Word;
using System.IO;
using DataTable = System.Data.DataTable;
using Application = Microsoft.Office.Interop.Word.Application;
namespace School_Management.Manager.Course
{
    public partial class Print_Course : DevExpress.XtraEditors.XtraForm
    {
        public Print_Course()
        {
            InitializeComponent();
        }

        private void Print_Course_Load(object sender, EventArgs e)
        {
            Courses course = new Courses();
            CourseDataGridView.DataSource = course.GetAllCourses();
        }


        private void Print_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report()
            {
                Title = "",
                Table = (System.Data.DataTable)CourseDataGridView.DataSource
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
        private void Save_Documment()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.DefaultExt = ".docx";
                save.Filter = "Word|*.docx";
                save.AddExtension = true;
                save.InitialDirectory = @"C:\Desktop.docx";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    object filename = save.FileName;
                    Application word = new Application();
                    word.ShowAnimation = false;
                    word.Visible = false;
                    object missing = System.Reflection.Missing.Value;
                    Document document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                    object styleHeading1 = "Heading 1";
                    para1.Range.set_Style(ref styleHeading1);
                    para1.Range.Text = "List of Course\nHCMUTE";
                    para1.Range.InsertParagraphAfter();
                    int rows = CourseDataGridView.Rows.Count + 1;
                    int cols = CourseDataGridView.Columns.Count + 1;
                    Table table = document.Tables.Add(para1.Range, rows, cols, ref missing, ref missing);
                    table.Borders.Enable = 1;
                    table.Rows[1].Cells[1].Range.Text = "STT";
                    for (int i = 1; i < table.Rows.Count; i++)
                    {
                        for (int j = 2; j < table.Columns.Count + 1; j++)
                        {

                            //Header 
                            table.Rows[i + 1].Cells[1].Range.Text = i.ToString();
                            table.Rows[1].Cells[j].Range.Text = CourseDataGridView.Columns[j - 2].HeaderText.ToString();
                            table.Rows[1].Cells[j].Range.Font.Bold = 1;
                            table.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            table.Rows[1].Cells[j].Range.Font.Size = 10;
                            table.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorAqua;
                            table.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            table.Rows[i + 1].Cells[j].Range.Text = CourseDataGridView.Rows[i - 1].Cells[j - 2].Value.ToString();
                        }
                    }
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    word.Quit(ref missing, ref missing, ref missing);
                    word = null;
                    XtraMessageBox.Show("Save data successful!");
                }
            }
            catch
            {
                XtraMessageBox.Show("Error", "Print Document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student);

        }

        private void courseBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.student);

        }
    }
}