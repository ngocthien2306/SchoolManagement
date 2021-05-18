
namespace School_Management.Manager.Score
{
    partial class Add_Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Score));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet3 = new School_Management.Manager_StudentDataSet3();
            this.XtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPage = new DevExpress.XtraTab.XtraTabPage();
            this.LoadScore = new DevExpress.XtraEditors.SimpleButton();
            this.Load_Student = new DevExpress.XtraEditors.SimpleButton();
            this.Avg_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Des_tb = new DevExpress.XtraEditors.TextEdit();
            this.Score_tb = new DevExpress.XtraEditors.TextEdit();
            this.Id_tb = new DevExpress.XtraEditors.TextEdit();
            this.Add_bt = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBox_Course = new System.Windows.Forms.ComboBox();
            this.Des_course = new DevExpress.XtraEditors.LabelControl();
            this.Score_lb = new DevExpress.XtraEditors.LabelControl();
            this.Course_list = new DevExpress.XtraEditors.LabelControl();
            this.Id_list = new DevExpress.XtraEditors.LabelControl();
            this.scoreTableAdapter = new School_Management.Manager_StudentDataSet3TableAdapters.ScoreTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSet3TableAdapters.TableAdapterManager();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).BeginInit();
            this.XtraTabControl1.SuspendLayout();
            this.TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Des_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Id_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.DataGridView);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.XtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(880, 456);
            this.splitContainerControl1.SplitterPosition = 446;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.manager_StudentDataSet3;
            // 
            // manager_StudentDataSet3
            // 
            this.manager_StudentDataSet3.DataSetName = "Manager_StudentDataSet3";
            this.manager_StudentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XtraTabControl1
            // 
            this.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.XtraTabControl1.Name = "XtraTabControl1";
            this.XtraTabControl1.SelectedTabPage = this.TabPage;
            this.XtraTabControl1.Size = new System.Drawing.Size(422, 456);
            this.XtraTabControl1.TabIndex = 0;
            this.XtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPage});
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.LoadScore);
            this.TabPage.Controls.Add(this.Load_Student);
            this.TabPage.Controls.Add(this.Avg_bt);
            this.TabPage.Controls.Add(this.Des_tb);
            this.TabPage.Controls.Add(this.Score_tb);
            this.TabPage.Controls.Add(this.Id_tb);
            this.TabPage.Controls.Add(this.Add_bt);
            this.TabPage.Controls.Add(this.ComboBox_Course);
            this.TabPage.Controls.Add(this.Des_course);
            this.TabPage.Controls.Add(this.Score_lb);
            this.TabPage.Controls.Add(this.Course_list);
            this.TabPage.Controls.Add(this.Id_list);
            this.TabPage.Name = "TabPage";
            this.TabPage.Size = new System.Drawing.Size(420, 431);
            this.TabPage.Text = "Course";
            // 
            // LoadScore
            // 
            this.LoadScore.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadScore.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoadScore.Appearance.Options.UseFont = true;
            this.LoadScore.Appearance.Options.UseForeColor = true;
            this.LoadScore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoadScore.ImageOptions.Image")));
            this.LoadScore.Location = new System.Drawing.Point(276, 376);
            this.LoadScore.Name = "LoadScore";
            this.LoadScore.Size = new System.Drawing.Size(119, 35);
            this.LoadScore.TabIndex = 11;
            this.LoadScore.Text = "Load Score";
            this.LoadScore.Click += new System.EventHandler(this.LoadScore_Click);
            // 
            // Load_Student
            // 
            this.Load_Student.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Student.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Load_Student.Appearance.Options.UseFont = true;
            this.Load_Student.Appearance.Options.UseForeColor = true;
            this.Load_Student.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Load_Student.ImageOptions.Image")));
            this.Load_Student.Location = new System.Drawing.Point(39, 376);
            this.Load_Student.Name = "Load_Student";
            this.Load_Student.Size = new System.Drawing.Size(119, 35);
            this.Load_Student.TabIndex = 10;
            this.Load_Student.Text = "Load Student";
            this.Load_Student.Click += new System.EventHandler(this.Load_Student_Click);
            // 
            // Avg_bt
            // 
            this.Avg_bt.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avg_bt.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Avg_bt.Appearance.Options.UseFont = true;
            this.Avg_bt.Appearance.Options.UseForeColor = true;
            this.Avg_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Avg_bt.ImageOptions.Image")));
            this.Avg_bt.Location = new System.Drawing.Point(276, 324);
            this.Avg_bt.Name = "Avg_bt";
            this.Avg_bt.Size = new System.Drawing.Size(119, 35);
            this.Avg_bt.TabIndex = 9;
            this.Avg_bt.Text = "Average";
            this.Avg_bt.Click += new System.EventHandler(this.Avg_bt_Click);
            // 
            // Des_tb
            // 
            this.Des_tb.Location = new System.Drawing.Point(176, 256);
            this.Des_tb.Name = "Des_tb";
            this.Des_tb.Size = new System.Drawing.Size(219, 20);
            this.Des_tb.TabIndex = 8;
            // 
            // Score_tb
            // 
            this.Score_tb.Location = new System.Drawing.Point(176, 183);
            this.Score_tb.Name = "Score_tb";
            this.Score_tb.Size = new System.Drawing.Size(219, 20);
            this.Score_tb.TabIndex = 7;
            // 
            // Id_tb
            // 
            this.Id_tb.Location = new System.Drawing.Point(176, 60);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(219, 20);
            this.Id_tb.TabIndex = 6;
            // 
            // Add_bt
            // 
            this.Add_bt.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_bt.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Add_bt.Appearance.Options.UseFont = true;
            this.Add_bt.Appearance.Options.UseForeColor = true;
            this.Add_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Add_bt.ImageOptions.Image")));
            this.Add_bt.Location = new System.Drawing.Point(39, 324);
            this.Add_bt.Name = "Add_bt";
            this.Add_bt.Size = new System.Drawing.Size(119, 36);
            this.Add_bt.TabIndex = 5;
            this.Add_bt.Text = "Add Score";
            this.Add_bt.Click += new System.EventHandler(this.Add_bt_Click);
            // 
            // ComboBox_Course
            // 
            this.ComboBox_Course.FormattingEnabled = true;
            this.ComboBox_Course.Location = new System.Drawing.Point(176, 115);
            this.ComboBox_Course.Name = "ComboBox_Course";
            this.ComboBox_Course.Size = new System.Drawing.Size(219, 21);
            this.ComboBox_Course.TabIndex = 4;
            // 
            // Des_course
            // 
            this.Des_course.Location = new System.Drawing.Point(39, 259);
            this.Des_course.Name = "Des_course";
            this.Des_course.Size = new System.Drawing.Size(53, 13);
            this.Des_course.TabIndex = 3;
            this.Des_course.Text = "Description";
            // 
            // Score_lb
            // 
            this.Score_lb.Location = new System.Drawing.Point(39, 186);
            this.Score_lb.Name = "Score_lb";
            this.Score_lb.Size = new System.Drawing.Size(27, 13);
            this.Score_lb.TabIndex = 2;
            this.Score_lb.Text = "Score";
            // 
            // Course_list
            // 
            this.Course_list.Location = new System.Drawing.Point(39, 123);
            this.Course_list.Name = "Course_list";
            this.Course_list.Size = new System.Drawing.Size(34, 13);
            this.Course_list.TabIndex = 1;
            this.Course_list.Text = "Course";
            // 
            // Id_list
            // 
            this.Id_list.Location = new System.Drawing.Point(39, 60);
            this.Id_list.Name = "Id_list";
            this.Id_list.Size = new System.Drawing.Size(52, 13);
            this.Id_list.TabIndex = 0;
            this.Id_list.Text = "ID Student";
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Add_StudentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.New_UserTableAdapter = null;
            this.tableAdapterManager.ScoreTableAdapter = this.scoreTableAdapter;
            this.tableAdapterManager.UpdateOrder = School_Management.Manager_StudentDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(446, 456);
            this.DataGridView.TabIndex = 3;
            // 
            // Add_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 456);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Add_Score";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.Add_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabControl1)).EndInit();
            this.XtraTabControl1.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Des_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Id_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Manager_StudentDataSet3 manager_StudentDataSet3;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private Manager_StudentDataSet3TableAdapters.ScoreTableAdapter scoreTableAdapter;
        private Manager_StudentDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTab.XtraTabControl XtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPage;
        private DevExpress.XtraEditors.SimpleButton LoadScore;
        private DevExpress.XtraEditors.SimpleButton Load_Student;
        private DevExpress.XtraEditors.SimpleButton Avg_bt;
        private DevExpress.XtraEditors.TextEdit Des_tb;
        private DevExpress.XtraEditors.TextEdit Score_tb;
        private DevExpress.XtraEditors.TextEdit Id_tb;
        private DevExpress.XtraEditors.SimpleButton Add_bt;
        private System.Windows.Forms.ComboBox ComboBox_Course;
        private DevExpress.XtraEditors.LabelControl Des_course;
        private DevExpress.XtraEditors.LabelControl Score_lb;
        private DevExpress.XtraEditors.LabelControl Course_list;
        private DevExpress.XtraEditors.LabelControl Id_list;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}