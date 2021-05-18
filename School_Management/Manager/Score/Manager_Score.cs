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
using School_Management.Manager.Course;
using School_Management.Manager.Student;
using System.Data.SqlClient;
using DevExpress.XtraBars.Docking2010;
using Microsoft.Office.Interop.Word;
using System.IO;
using DataTable = System.Data.DataTable;
using Application = Microsoft.Office.Interop.Word.Application;
namespace School_Management.Manager.Score
{
    public partial class Manager_Score : DevExpress.XtraEditors.XtraForm
    {
        My_Database data = new My_Database();
        Courses course;
        Students student;
        Scores score;
        DataTable table;
        public Manager_Score()
        {
            InitializeComponent();
            course = new Courses();
            student = new Students();
            score = new Scores();
            foreach (WindowsUIButton navButton in windowsUIButtonPanel1.Buttons)
            {
                navButton.Style = ButtonStyle.CheckButton;
                navButton.GroupIndex = 1;
                navButton.UseCaption = true;
                navButton.Checked = false;

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
                    para1.Range.Text = "List of Student\nClass: 19110CLA2\nObject Winform Programming";
                    para1.Range.InsertParagraphAfter();
                    int rows = DataGridView.Rows.Count + 1;
                    int cols = DataGridView.Columns.Count + 1;
                    Table table = document.Tables.Add(para1.Range, rows, cols, ref missing, ref missing);
                    table.Borders.Enable = 1;
                    table.Rows[1].Cells[1].Range.Text = "STT";
                    for (int i = 1; i < table.Rows.Count; i++)
                    {
                        for (int j = 2; j < table.Columns.Count + 1; j++)
                        {

                            //Header 
                            table.Rows[i + 1].Cells[1].Range.Text = i.ToString();
                            table.Rows[1].Cells[j].Range.Text = DataGridView.Columns[j - 2].HeaderText.ToString();
                            table.Rows[1].Cells[j].Range.Font.Bold = 1;
                            table.Rows[1].Cells[j].Range.Font.Name = "verdana";
                            table.Rows[1].Cells[j].Range.Font.Size = 10;
                            table.Rows[1].Cells[j].Shading.BackgroundPatternColor = WdColor.wdColorAqua;
                            table.Rows[1].Cells[j].VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            table.Rows[1].Cells[j].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //Data
                            table.Rows[i + 1].Cells[j].Range.Text = DataGridView.Rows[i - 1].Cells[j - 2].Value.ToString();
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
        public Image ByteArrayToImage(byte[] value)
        {
            using (MemoryStream ms = new MemoryStream(value))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        public void LoadData()
        {
            My_Database data = new My_Database();
            Students student = new Students();
            SqlCommand commnand = new SqlCommand("SELECT id, firstname, lastname FROM Add_Student",data.GetConnection);
            DataGridView.DataSource = student.GetStudents(commnand);


        }
        private void Manager_Score_Load(object sender, EventArgs e)
        {
            ComboBox_Course.ValueMember = "Id";
            //this.scoreTableAdapter.Fill(this.dataSet_Student.Score);
            //getAllstudent = new SqlCommand()
            //{
            //    CommandText = "SELECT id, firstname, lastname FROM Add_Student"
            //};
            //GridControl.DataSource = student.GetStudents(getAllstudent);
            this.LoadData();
            table = course.GetAll_ID_label();
            foreach (DataRow row in table.Rows)
            {
                ComboBox_Course.Items.Add(row[1].ToString().Trim());
            }


        }
        public void RemoveScore()
        {
            try
            {
                DialogResult data = MessageBox.Show("Are you sure detele this record?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (data == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(IDStudent.Text);
                    int cid = Convert.ToInt32(table.Rows[ComboBox_Course.SelectedIndex][0].ToString());
                    if (score.Delete_Score(id, cid))
                    {
                        MessageBox.Show("Delete successful!", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed!", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Error!!! Tip: Check textbox or combobox", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void AddScore()
        {
            

            try
            {
                if (IDStudent.Text == ""
                            || ComboBox_Course.SelectedIndex == -1
                            || Rich_desc.Text == ""
                            || Score_tb.Text == "")
                {

                    MessageBox.Show("The textboxs are blank, please enter again!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int id = Convert.ToInt32(IDStudent.Text);
                    float sc = (float)Convert.ToDouble(Score_tb.Text);
                    string des = Rich_desc.Text;
                    int cid = Convert.ToInt32(table.Rows[ComboBox_Course.SelectedIndex][0].ToString());
                    if (score.Add_Score(id, cid, sc, des))
                    {
                        MessageBox.Show("Add score successful!!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, ButtonEventArgs e)
        {
            
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "A1":
                        this.AddScore();                    
                    break;
                case "A2":
                    this.RemoveScore();
                    break;
                case "A3":
                    this.LoadData();
                    break;
            }
        }

        private void Show_student_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = score.GetStudentScore();
        }

        private void ShowScore_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = score.GetAllScore();
        }
        private void scoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Save_Documment();
        }

        private void TabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}