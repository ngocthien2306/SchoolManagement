
namespace School_Management.Manager.Score
{
    partial class Manager_Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Score));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.IDStudent = new DevExpress.XtraEditors.TextEdit();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.Rich_desc = new System.Windows.Forms.RichTextBox();
            this.Score_tb = new DevExpress.XtraEditors.TextEdit();
            this.ComboBox_Course = new System.Windows.Forms.ComboBox();
            this.Des_course = new DevExpress.XtraEditors.LabelControl();
            this.Score_lb = new DevExpress.XtraEditors.LabelControl();
            this.Course_list = new DevExpress.XtraEditors.LabelControl();
            this.Id_list = new DevExpress.XtraEditors.LabelControl();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.XtraTabPage_Show = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ShowScore = new DevExpress.XtraEditors.SimpleButton();
            this.Show_student = new DevExpress.XtraEditors.SimpleButton();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Student = new School_Management.DataSet_Student();
            this.add_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_StudentTableAdapter = new School_Management.DataSet_StudentTableAdapters.Add_StudentTableAdapter();
            this.tableAdapterManager = new School_Management.DataSet_StudentTableAdapters.TableAdapterManager();
            this.courseTableAdapter = new School_Management.DataSet_StudentTableAdapters.CourseTableAdapter();
            this.scoreTableAdapter = new School_Management.DataSet_StudentTableAdapters.ScoreTableAdapter();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.XtraTabPage_Show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Appearance.BackColor = System.Drawing.Color.Snow;
            this.splitContainerControl1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGridView);
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(942, 480);
            this.splitContainerControl1.SplitterPosition = 401;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(401, 480);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPage1});
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.Controls.Add(this.IDStudent);
            this.TabPage1.Controls.Add(this.windowsUIButtonPanel1);
            this.TabPage1.Controls.Add(this.Rich_desc);
            this.TabPage1.Controls.Add(this.Score_tb);
            this.TabPage1.Controls.Add(this.ComboBox_Course);
            this.TabPage1.Controls.Add(this.Des_course);
            this.TabPage1.Controls.Add(this.Score_lb);
            this.TabPage1.Controls.Add(this.Course_list);
            this.TabPage1.Controls.Add(this.Id_list);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(399, 455);
            this.TabPage1.Text = "Home";
            this.TabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.TabPage1_Paint);
            // 
            // IDStudent
            // 
            this.IDStudent.Location = new System.Drawing.Point(148, 41);
            this.IDStudent.Name = "IDStudent";
            this.IDStudent.Size = new System.Drawing.Size(219, 20);
            this.IDStudent.TabIndex = 18;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions2.Image")));
            windowsUIButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions3.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("     Add     ", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Add a new score", -1, true, null, true, false, true, "A1", 1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("     Delete     ", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "You want to delete the score, click here", -1, true, null, true, false, true, "A2", 1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("     Refresh     ", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "A3", 1, false)});
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(3, 374);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(383, 67);
            this.windowsUIButtonPanel1.TabIndex = 17;
            this.windowsUIButtonPanel1.Text = "WindowsUIButtonPanel";
            this.windowsUIButtonPanel1.ButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonChecked);
            // 
            // Rich_desc
            // 
            this.Rich_desc.Location = new System.Drawing.Point(148, 225);
            this.Rich_desc.Name = "Rich_desc";
            this.Rich_desc.Size = new System.Drawing.Size(219, 96);
            this.Rich_desc.TabIndex = 16;
            this.Rich_desc.Text = "";
            // 
            // Score_tb
            // 
            this.Score_tb.Location = new System.Drawing.Point(148, 164);
            this.Score_tb.Name = "Score_tb";
            this.Score_tb.Size = new System.Drawing.Size(219, 20);
            this.Score_tb.TabIndex = 15;
            // 
            // ComboBox_Course
            // 
            this.ComboBox_Course.FormattingEnabled = true;
            this.ComboBox_Course.Location = new System.Drawing.Point(148, 99);
            this.ComboBox_Course.Name = "ComboBox_Course";
            this.ComboBox_Course.Size = new System.Drawing.Size(219, 21);
            this.ComboBox_Course.TabIndex = 13;
            // 
            // Des_course
            // 
            this.Des_course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Des_course.Location = new System.Drawing.Point(25, 243);
            this.Des_course.Name = "Des_course";
            this.Des_course.Size = new System.Drawing.Size(53, 13);
            this.Des_course.TabIndex = 12;
            this.Des_course.Text = "Description";
            // 
            // Score_lb
            // 
            this.Score_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Score_lb.Location = new System.Drawing.Point(26, 170);
            this.Score_lb.Name = "Score_lb";
            this.Score_lb.Size = new System.Drawing.Size(27, 13);
            this.Score_lb.TabIndex = 11;
            this.Score_lb.Text = "Score";
            // 
            // Course_list
            // 
            this.Course_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Course_list.Location = new System.Drawing.Point(26, 107);
            this.Course_list.Name = "Course_list";
            this.Course_list.Size = new System.Drawing.Size(34, 13);
            this.Course_list.TabIndex = 10;
            this.Course_list.Text = "Course";
            // 
            // Id_list
            // 
            this.Id_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Id_list.Location = new System.Drawing.Point(26, 44);
            this.Id_list.Name = "Id_list";
            this.Id_list.Size = new System.Drawing.Size(52, 13);
            this.Id_list.TabIndex = 9;
            this.Id_list.Text = "ID Student";
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(2, 105);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.Size = new System.Drawing.Size(534, 370);
            this.DataGridView.TabIndex = 3;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(1, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.XtraTabPage_Show;
            this.xtraTabControl2.Size = new System.Drawing.Size(597, 99);
            this.xtraTabControl2.TabIndex = 2;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XtraTabPage_Show});
            // 
            // XtraTabPage_Show
            // 
            this.XtraTabPage_Show.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.XtraTabPage_Show.Appearance.PageClient.Options.UseBackColor = true;
            this.XtraTabPage_Show.Controls.Add(this.simpleButton1);
            this.XtraTabPage_Show.Controls.Add(this.ShowScore);
            this.XtraTabPage_Show.Controls.Add(this.Show_student);
            this.XtraTabPage_Show.Name = "XtraTabPage_Show";
            this.XtraTabPage_Show.Size = new System.Drawing.Size(595, 74);
            this.XtraTabPage_Show.Text = "Show Data";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(217, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(75, 35);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Print";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ShowScore
            // 
            this.ShowScore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ShowScore.ImageOptions.Image")));
            this.ShowScore.Location = new System.Drawing.Point(337, 18);
            this.ShowScore.Name = "ShowScore";
            this.ShowScore.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ShowScore.Size = new System.Drawing.Size(132, 36);
            this.ShowScore.TabIndex = 1;
            this.ShowScore.Text = "Show Score";
            this.ShowScore.Click += new System.EventHandler(this.ShowScore_Click);
            // 
            // Show_student
            // 
            this.Show_student.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Show_student.ImageOptions.Image")));
            this.Show_student.Location = new System.Drawing.Point(45, 15);
            this.Show_student.Name = "Show_student";
            this.Show_student.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Show_student.Size = new System.Drawing.Size(127, 42);
            this.Show_student.TabIndex = 0;
            this.Show_student.Text = "Show Student";
            this.Show_student.Click += new System.EventHandler(this.Show_student_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dataSet_Student;
            // 
            // dataSet_Student
            // 
            this.dataSet_Student.DataSetName = "DataSet_Student";
            this.dataSet_Student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_StudentBindingSource
            // 
            this.add_StudentBindingSource.DataMember = "Add_Student";
            this.add_StudentBindingSource.DataSource = this.dataSet_Student;
            // 
            // add_StudentTableAdapter
            // 
            this.add_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Add_StudentTableAdapter = this.add_StudentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.NameTableAdapter = null;
            this.tableAdapterManager.New_UserTableAdapter = null;
            this.tableAdapterManager.ScoreTableAdapter = this.scoreTableAdapter;
            this.tableAdapterManager.UpdateOrder = School_Management.DataSet_StudentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.dataSet_Student;
            // 
            // Manager_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 480);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Manager_Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager Score";
            this.Load += new System.EventHandler(this.Manager_Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.XtraTabPage_Show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPage1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.RichTextBox Rich_desc;
        private DevExpress.XtraEditors.TextEdit Score_tb;
        private System.Windows.Forms.ComboBox ComboBox_Course;
        private DevExpress.XtraEditors.LabelControl Des_course;
        private DevExpress.XtraEditors.LabelControl Score_lb;
        private DevExpress.XtraEditors.LabelControl Course_list;
        private DevExpress.XtraEditors.LabelControl Id_list;
        private DevExpress.XtraEditors.SimpleButton ShowScore;
        private DevExpress.XtraEditors.SimpleButton Show_student;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage XtraTabPage_Show;
        private DataSet_Student dataSet_Student;
        private System.Windows.Forms.BindingSource add_StudentBindingSource;
        private DataSet_StudentTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private DataSet_StudentTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet_StudentTableAdapters.ScoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private DataSet_StudentTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView DataGridView;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit IDStudent;
    }
}