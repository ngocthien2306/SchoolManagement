
namespace School_Management.Manager.Student
{
    partial class Print_List_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_List_Student));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.managerStudentDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet3 = new School_Management.Manager_StudentDataSet3();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.Print_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Check_Range = new DevExpress.XtraEditors.SimpleButton();
            this.Check_female = new DevExpress.XtraEditors.CheckEdit();
            this.Check_male = new DevExpress.XtraEditors.CheckEdit();
            this.Check_all = new DevExpress.XtraEditors.CheckEdit();
            this.TabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.Print_Excel = new DevExpress.XtraEditors.SimpleButton();
            this.Print_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.TabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.And_lb = new DevExpress.XtraEditors.LabelControl();
            this.Day2 = new DevExpress.XtraEditors.DateEdit();
            this.Day1 = new DevExpress.XtraEditors.DateEdit();
            this.Between_lb = new DevExpress.XtraEditors.LabelControl();
            this.Range_Day = new DevExpress.XtraEditors.LabelControl();
            this.No_Check = new DevExpress.XtraEditors.CheckEdit();
            this.Yes_Check = new DevExpress.XtraEditors.CheckEdit();
            this.add_StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_StudentTableAdapter = new School_Management.Manager_StudentDataSet3TableAdapters.Add_StudentTableAdapter();
            this.tableAdapterManager = new School_Management.Manager_StudentDataSet3TableAdapters.TableAdapterManager();
            this.DataSource_Student = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerStudentDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_female.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_male.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_all.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.No_Check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yes_Check.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // managerStudentDataSet3BindingSource
            // 
            this.managerStudentDataSet3BindingSource.DataSource = this.manager_StudentDataSet3;
            this.managerStudentDataSet3BindingSource.Position = 0;
            // 
            // manager_StudentDataSet3
            // 
            this.manager_StudentDataSet3.DataSetName = "Manager_StudentDataSet3";
            this.manager_StudentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem2";
            this.barEditItem3.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem3.Id = 3;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "barEditItem2";
            this.barEditItem4.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem4.Id = 3;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // Print_bt
            // 
            this.Print_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print_bt.ImageOptions.Image")));
            this.Print_bt.Location = new System.Drawing.Point(103, 16);
            this.Print_bt.Margin = new System.Windows.Forms.Padding(4);
            this.Print_bt.Name = "Print_bt";
            this.Print_bt.Size = new System.Drawing.Size(69, 76);
            this.Print_bt.TabIndex = 5;
            this.Print_bt.Click += new System.EventHandler(this.Print_bt_Click);
            // 
            // Check_Range
            // 
            this.Check_Range.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Check_Range.ImageOptions.Image")));
            this.Check_Range.Location = new System.Drawing.Point(1053, 15);
            this.Check_Range.Margin = new System.Windows.Forms.Padding(4);
            this.Check_Range.Name = "Check_Range";
            this.Check_Range.Size = new System.Drawing.Size(112, 70);
            this.Check_Range.TabIndex = 4;
            this.Check_Range.Text = "Filter";
            this.Check_Range.Click += new System.EventHandler(this.Check_Range_Click);
            // 
            // Check_female
            // 
            this.Check_female.Location = new System.Drawing.Point(244, 35);
            this.Check_female.Margin = new System.Windows.Forms.Padding(4);
            this.Check_female.Name = "Check_female";
            this.Check_female.Properties.Caption = "Female";
            this.Check_female.Size = new System.Drawing.Size(112, 25);
            this.Check_female.TabIndex = 2;
            this.Check_female.CheckedChanged += new System.EventHandler(this.Check_female_CheckedChanged);
            // 
            // Check_male
            // 
            this.Check_male.Location = new System.Drawing.Point(123, 35);
            this.Check_male.Margin = new System.Windows.Forms.Padding(4);
            this.Check_male.Name = "Check_male";
            this.Check_male.Properties.Caption = "Male";
            this.Check_male.Size = new System.Drawing.Size(112, 25);
            this.Check_male.TabIndex = 1;
            this.Check_male.CheckedChanged += new System.EventHandler(this.Check_male_CheckedChanged);
            // 
            // Check_all
            // 
            this.Check_all.Location = new System.Drawing.Point(22, 35);
            this.Check_all.Margin = new System.Windows.Forms.Padding(4);
            this.Check_all.Name = "Check_all";
            this.Check_all.Properties.Caption = "All";
            this.Check_all.Size = new System.Drawing.Size(92, 25);
            this.Check_all.TabIndex = 0;
            this.Check_all.CheckedChanged += new System.EventHandler(this.Check_all_CheckedChanged);
            // 
            // TabControl1
            // 
            this.TabControl1.Location = new System.Drawing.Point(2, 3);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedTabPage = this.TabPage2;
            this.TabControl1.Size = new System.Drawing.Size(1291, 142);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPage1,
            this.TabPage2});
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Print_Excel);
            this.TabPage2.Controls.Add(this.Print_pdf);
            this.TabPage2.Controls.Add(this.Print_bt);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(1289, 107);
            this.TabPage2.Text = "Printer";
            // 
            // Print_Excel
            // 
            this.Print_Excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print_Excel.ImageOptions.Image")));
            this.Print_Excel.Location = new System.Drawing.Point(441, 16);
            this.Print_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.Print_Excel.Name = "Print_Excel";
            this.Print_Excel.Size = new System.Drawing.Size(64, 76);
            this.Print_Excel.TabIndex = 7;
            // 
            // Print_pdf
            // 
            this.Print_pdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Print_pdf.ImageOptions.Image")));
            this.Print_pdf.Location = new System.Drawing.Point(276, 16);
            this.Print_pdf.Margin = new System.Windows.Forms.Padding(4);
            this.Print_pdf.Name = "Print_pdf";
            this.Print_pdf.Size = new System.Drawing.Size(68, 76);
            this.Print_pdf.TabIndex = 6;
            // 
            // TabPage1
            // 
            this.TabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Turquoise;
            this.TabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.TabPage1.Controls.Add(this.And_lb);
            this.TabPage1.Controls.Add(this.Check_Range);
            this.TabPage1.Controls.Add(this.Day2);
            this.TabPage1.Controls.Add(this.Day1);
            this.TabPage1.Controls.Add(this.Between_lb);
            this.TabPage1.Controls.Add(this.Range_Day);
            this.TabPage1.Controls.Add(this.No_Check);
            this.TabPage1.Controls.Add(this.Yes_Check);
            this.TabPage1.Controls.Add(this.Check_all);
            this.TabPage1.Controls.Add(this.Check_male);
            this.TabPage1.Controls.Add(this.Check_female);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1289, 107);
            this.TabPage1.Text = "Filter";
            // 
            // And_lb
            // 
            this.And_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.And_lb.Appearance.Options.UseFont = true;
            this.And_lb.Location = new System.Drawing.Point(729, 66);
            this.And_lb.Margin = new System.Windows.Forms.Padding(4);
            this.And_lb.Name = "And_lb";
            this.And_lb.Size = new System.Drawing.Size(39, 24);
            this.And_lb.TabIndex = 14;
            this.And_lb.Text = "AND";
            // 
            // Day2
            // 
            this.Day2.EditValue = null;
            this.Day2.Location = new System.Drawing.Point(774, 64);
            this.Day2.Margin = new System.Windows.Forms.Padding(4);
            this.Day2.Name = "Day2";
            this.Day2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day2.Properties.MaxValue = new System.DateTime(2020, 12, 31, 23, 59, 0, 0);
            this.Day2.Properties.MinValue = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Day2.Size = new System.Drawing.Size(168, 28);
            this.Day2.TabIndex = 13;
            // 
            // Day1
            // 
            this.Day1.EditValue = null;
            this.Day1.Location = new System.Drawing.Point(549, 64);
            this.Day1.Margin = new System.Windows.Forms.Padding(4);
            this.Day1.Name = "Day1";
            this.Day1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Day1.Properties.MaxValue = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.Day1.Properties.MinValue = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.Day1.Size = new System.Drawing.Size(171, 28);
            this.Day1.TabIndex = 12;
            // 
            // Between_lb
            // 
            this.Between_lb.Location = new System.Drawing.Point(404, 69);
            this.Between_lb.Margin = new System.Windows.Forms.Padding(4);
            this.Between_lb.Name = "Between_lb";
            this.Between_lb.Size = new System.Drawing.Size(132, 19);
            this.Between_lb.TabIndex = 11;
            this.Between_lb.Text = "Birthday between  ";
            // 
            // Range_Day
            // 
            this.Range_Day.Location = new System.Drawing.Point(404, 12);
            this.Range_Day.Margin = new System.Windows.Forms.Padding(4);
            this.Range_Day.Name = "Range_Day";
            this.Range_Day.Size = new System.Drawing.Size(107, 19);
            this.Range_Day.TabIndex = 10;
            this.Range_Day.Text = "Use Range Day";
            // 
            // No_Check
            // 
            this.No_Check.Location = new System.Drawing.Point(774, 12);
            this.No_Check.Margin = new System.Windows.Forms.Padding(4);
            this.No_Check.Name = "No_Check";
            this.No_Check.Properties.Caption = "No";
            this.No_Check.Size = new System.Drawing.Size(112, 25);
            this.No_Check.TabIndex = 9;
            // 
            // Yes_Check
            // 
            this.Yes_Check.Location = new System.Drawing.Point(549, 12);
            this.Yes_Check.Margin = new System.Windows.Forms.Padding(4);
            this.Yes_Check.Name = "Yes_Check";
            this.Yes_Check.Properties.Caption = "Yes";
            this.Yes_Check.Size = new System.Drawing.Size(112, 25);
            this.Yes_Check.TabIndex = 8;
            // 
            // add_StudentBindingSource
            // 
            this.add_StudentBindingSource.DataMember = "Add_Student";
            this.add_StudentBindingSource.DataSource = this.manager_StudentDataSet3;
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
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.New_UserTableAdapter = null;
            this.tableAdapterManager.ScoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = School_Management.Manager_StudentDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataSource_Student
            // 
            this.DataSource_Student.AutoGenerateColumns = false;
            this.DataSource_Student.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataSource_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSource_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.DataSource_Student.DataSource = this.add_StudentBindingSource;
            this.DataSource_Student.Location = new System.Drawing.Point(3, 151);
            this.DataSource_Student.Name = "DataSource_Student";
            this.DataSource_Student.RowHeadersWidth = 62;
            this.DataSource_Student.RowTemplate.Height = 28;
            this.DataSource_Student.Size = new System.Drawing.Size(1290, 627);
            this.DataSource_Student.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Student";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birth Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // Print_List_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 779);
            this.Controls.Add(this.DataSource_Student);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Print_List_Student";
            this.Text = "Printer";
            this.Load += new System.EventHandler(this.Print_List_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerStudentDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_female.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_male.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check_all.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.No_Check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yes_Check.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraEditors.CheckEdit Check_female;
        private DevExpress.XtraEditors.CheckEdit Check_male;
        private DevExpress.XtraEditors.CheckEdit Check_all;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton Check_Range;
        private DevExpress.XtraEditors.SimpleButton Print_bt;
        private DevExpress.XtraTab.XtraTabControl TabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPage2;
        private DevExpress.XtraEditors.SimpleButton Print_Excel;
        private DevExpress.XtraEditors.SimpleButton Print_pdf;
        private DevExpress.XtraTab.XtraTabPage TabPage1;
        private DevExpress.XtraEditors.LabelControl And_lb;
        private DevExpress.XtraEditors.DateEdit Day2;
        private DevExpress.XtraEditors.DateEdit Day1;
        private DevExpress.XtraEditors.LabelControl Between_lb;
        private DevExpress.XtraEditors.LabelControl Range_Day;
        private DevExpress.XtraEditors.CheckEdit No_Check;
        private DevExpress.XtraEditors.CheckEdit Yes_Check;
        private System.Windows.Forms.BindingSource managerStudentDataSet3BindingSource;
        private Manager_StudentDataSet3 manager_StudentDataSet3;
        private System.Windows.Forms.BindingSource add_StudentBindingSource;
        private Manager_StudentDataSet3TableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private Manager_StudentDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataSource_Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}