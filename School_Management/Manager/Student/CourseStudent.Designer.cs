
namespace School_Management.Manager.Student
{
    partial class CourseStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseStudent));
            this.gridControlCourse = new DevExpress.XtraGrid.GridControl();
            this.gridViewCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbStudentId = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCourse
            // 
            this.gridControlCourse.Location = new System.Drawing.Point(12, 100);
            this.gridControlCourse.MainView = this.gridViewCourse;
            this.gridControlCourse.Name = "gridControlCourse";
            this.gridControlCourse.Size = new System.Drawing.Size(1063, 607);
            this.gridControlCourse.TabIndex = 0;
            this.gridControlCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCourse});
            // 
            // gridViewCourse
            // 
            this.gridViewCourse.GridControl = this.gridControlCourse;
            this.gridViewCourse.Name = "gridViewCourse";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnAddCourse.Location = new System.Drawing.Point(12, 26);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(130, 45);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(182, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 45);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(861, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Student ID:";
            // 
            // lbStudentId
            // 
            this.lbStudentId.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentId.Appearance.Options.UseFont = true;
            this.lbStudentId.Location = new System.Drawing.Point(959, 36);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(80, 22);
            this.lbStudentId.TabIndex = 4;
            this.lbStudentId.Text = "19110148";
            // 
            // CourseStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 719);
            this.Controls.Add(this.lbStudentId);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.gridControlCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseStudent";
            this.Text = "CourseStudent";
            this.Load += new System.EventHandler(this.CourseStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddCourse;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl gridControlCourse;
        public DevExpress.XtraEditors.LabelControl lbStudentId;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewCourse;
    }
}