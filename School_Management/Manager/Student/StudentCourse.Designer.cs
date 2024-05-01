
namespace School_Management.Manager.Student
{
    partial class StudentCourse
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
            this.gridControlStudentCourse = new DevExpress.XtraGrid.GridControl();
            this.gridViewStudentCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCourseName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxSe = new System.Windows.Forms.ComboBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudentCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudentCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlStudentCourse
            // 
            this.gridControlStudentCourse.Location = new System.Drawing.Point(12, 80);
            this.gridControlStudentCourse.MainView = this.gridViewStudentCourse;
            this.gridControlStudentCourse.Name = "gridControlStudentCourse";
            this.gridControlStudentCourse.Size = new System.Drawing.Size(912, 467);
            this.gridControlStudentCourse.TabIndex = 0;
            this.gridControlStudentCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudentCourse});
            // 
            // gridViewStudentCourse
            // 
            this.gridViewStudentCourse.GridControl = this.gridControlStudentCourse;
            this.gridViewStudentCourse.Name = "gridViewStudentCourse";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Course name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(109, 22);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(202, 22);
            this.txtCourseName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(349, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Semester:";
            // 
            // comboBoxSe
            // 
            this.comboBoxSe.FormattingEnabled = true;
            this.comboBoxSe.Location = new System.Drawing.Point(428, 22);
            this.comboBoxSe.Name = "comboBoxSe";
            this.comboBoxSe.Size = new System.Drawing.Size(212, 24);
            this.comboBoxSe.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(798, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 39);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StudentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 549);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxSe);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlStudentCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentCourse";
            this.Text = "StudentCourse";
            this.Load += new System.EventHandler(this.StudentCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudentCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudentCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudentCourse;
        public DevExpress.XtraGrid.GridControl gridControlStudentCourse;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCourseName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox comboBoxSe;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
    }
}