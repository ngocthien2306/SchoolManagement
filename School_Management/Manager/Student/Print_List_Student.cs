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

namespace School_Management.Manager.Student
{
    public partial class Print_List_Student : DevExpress.XtraEditors.XtraForm
    {
        Students student = new Students();
        public Print_List_Student()
        {
            InitializeComponent();
        }
        private void Print_List_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet3.Add_Student' table. You can move, or remove it, as needed.
            this.add_StudentTableAdapter.Fill(this.manager_StudentDataSet3.Add_Student);
            Check_all.Checked = true;
            Yes_Check.Checked = true;
            Day1.Text = "1/1/1980";
            Day2.DateTime = DateTime.Now;
            this.ShowList();

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
                    para1.Range.Text = "List of Student\nClass: 19110CLA2\nObject Winform Programming";
                    para1.Range.InsertParagraphAfter();
                    int rows = DataSource_Student.Rows.Count + 1;
                    int cols = DataSource_Student.Columns.Count + 1;
                    Table table = document.Tables.Add(para1.Range, rows, cols, ref missing, ref missing);
                    table.Borders.Enable = 1;
                    table.Rows[1].Cells[1].Range.Text = "STT";
                    for (int i = 1; i < table.Rows.Count; i++)
                    {
                        for (int j = 2; j < table.Columns.Count + 1; j++)
                        {

                            //Header 
                            table.Rows[i + 1].Cells[1].Range.Text = i.ToString();
                            table.Rows[1].Cells[j].Range.Text = DataSource_Student.Columns[j - 2].HeaderText.ToString();
                            table.Rows[1].Cells[j].Range.Font.Bold = 1;
                            table.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            table.Rows[1].Cells[j].Range.Font.Size = 10;
                            table.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorAqua;
                            table.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            table.Rows[i + 1].Cells[j].Range.Text = DataSource_Student.Rows[i - 1].Cells[j - 2].Value.ToString();

                            if (j == 9)
                            {

                                Image sparePicture = ByteArrayToImage((byte[])DataSource_Student.Rows[i - 1].Cells[7].Value); //Change to your datagrid's name
                                Clipboard.SetDataObject(sparePicture);

                                table.Rows[i + 1].Cells[j].Range.Paste();
                                Clipboard.Clear();
                            }
                        }
                    }
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    word.Quit(ref missing, ref missing, ref missing);
                    word = null;
                    XtraMessageBox.Show("Save data successful!", "Print Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                XtraMessageBox.Show("Error", "Print Document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Image ByteArrayToImage(byte[] value)
        {
            using (MemoryStream ms = new MemoryStream(value))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        private bool ShowList()
        {
            try
            {
                My_Database dataBase = new My_Database();
                dataBase.Openconnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Add_Student", dataBase.GetConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Add_Student");
                dataBase.Closeconnection();
                DataSource_Student.RowTemplate.Height = 40;
                DataTable table = dataSet.Tables["Add_Student"];
                DataSource_Student.DataSource = table;
                DataSource_Student.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DataSource_Student.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataSource_Student.AllowUserToAddRows = false;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private void ButtonCheck()
        {
            if (Yes_Check.Checked)
            {
                DateTime start = Day1.DateTime;
                DateTime end = Day2.DateTime;
                if (start > end)
                {
                    DateTime temp = start;
                    start = end;
                    end = temp;
                }
                if (Check_male.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where birthday between @start and @end and gender = 'Male'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    DataSource_Student.DataSource = student.GetStudents(command);
                }
                else if (Check_female.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where birthday between @start and @end and gender = 'Female'");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    DataSource_Student.DataSource = student.GetStudents(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where birthday between @start and @end");
                    command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                    command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                    DataSource_Student.DataSource = student.GetStudents(command);
                }
            }
            else
            {
                if (Check_all.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student");
                    DataSource_Student.DataSource = student.GetStudents(command);
                }
                else if (Check_female.Checked)
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where gender = 'Female'");
                    DataSource_Student.DataSource = student.GetStudents(command);
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * from Add_Student where gender = 'Male'");
                    DataSource_Student.DataSource = student.GetStudents(command);
                }
            }
        }

        private void Check_Range_Click(object sender, EventArgs e)
        {
            this.ButtonCheck();
        }

        private void Check_all_CheckedChanged(object sender, EventArgs e)
        {
            Check_male.Checked = false;
            Check_female.Checked = false;
        }

        private void Check_male_CheckedChanged(object sender, EventArgs e)
        {
            Check_female.Checked = false;
            Check_all.Checked = false;
        }

        private void Check_female_CheckedChanged(object sender, EventArgs e)
        {
            Check_all.Checked = false;
            Check_male.Checked = false;
        }

        private void Yes_Check_CheckedChanged(object sender, EventArgs e)
        {
            No_Check.Checked = false;
        }

        private void No_Check_CheckedChanged(object sender, EventArgs e)
        {
            Yes_Check.Checked = false;
        }

        private void Print_bt_Click(object sender, EventArgs e)
        {
            this.Save_Documment();
        }

    }
}