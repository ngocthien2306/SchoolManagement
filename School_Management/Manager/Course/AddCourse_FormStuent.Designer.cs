
namespace School_Management.Manager.Course
{
    partial class AddCourse_FormStuent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse_FormStuent));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Add = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Edit_andSave = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ResetChange = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Delete_course = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Back = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Label_ID = new DevExpress.XtraEditors.LabelControl();
            this.Label_semester = new DevExpress.XtraEditors.LabelControl();
            this.Label_course = new DevExpress.XtraEditors.LabelControl();
            this.Label_Selected = new DevExpress.XtraEditors.LabelControl();
            this.ListBoxCourse = new DevExpress.XtraEditors.ListBoxControl();
            this.Listbox_Available = new DevExpress.XtraEditors.ListBoxControl();
            this.ComboBox_Student = new System.Windows.Forms.ComboBox();
            this.ComboBox_Semester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listbox_Available)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.Add,
            this.Edit_andSave,
            this.ResetChange,
            this.Delete_course,
            this.Back});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(191, 488);
            this.accordionControl1.TabIndex = 13;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Task";
            // 
            // Add
            // 
            this.Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Add.Name = "Add";
            this.Add.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit_andSave
            // 
            this.Edit_andSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit_andSave.ImageOptions.Image")));
            this.Edit_andSave.Name = "Edit_andSave";
            this.Edit_andSave.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Edit_andSave.Text = "Save and Close";
            this.Edit_andSave.Click += new System.EventHandler(this.Edit_andSave_Click);
            // 
            // ResetChange
            // 
            this.ResetChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ResetChange.ImageOptions.Image")));
            this.ResetChange.Name = "ResetChange";
            this.ResetChange.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ResetChange.Text = "Reset Change";
            // 
            // Delete_course
            // 
            this.Delete_course.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Delete_course.ImageOptions.Image")));
            this.Delete_course.Name = "Delete_course";
            this.Delete_course.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Delete_course.Text = "Delete";
            this.Delete_course.Click += new System.EventHandler(this.Delete_course_Click);
            // 
            // Back
            // 
            this.Back.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Back.ImageOptions.Image")));
            this.Back.Name = "Back";
            this.Back.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Back.Text = "Back";
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(230, 76);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(76, 19);
            this.Label_ID.TabIndex = 14;
            this.Label_ID.Text = "Student ID";
            // 
            // Label_semester
            // 
            this.Label_semester.Location = new System.Drawing.Point(631, 76);
            this.Label_semester.Name = "Label_semester";
            this.Label_semester.Size = new System.Drawing.Size(65, 19);
            this.Label_semester.TabIndex = 15;
            this.Label_semester.Text = "Semester";
            // 
            // Label_course
            // 
            this.Label_course.Location = new System.Drawing.Point(230, 174);
            this.Label_course.Name = "Label_course";
            this.Label_course.Size = new System.Drawing.Size(118, 19);
            this.Label_course.TabIndex = 16;
            this.Label_course.Text = "Available Course";
            // 
            // Label_Selected
            // 
            this.Label_Selected.Location = new System.Drawing.Point(631, 174);
            this.Label_Selected.Name = "Label_Selected";
            this.Label_Selected.Size = new System.Drawing.Size(112, 19);
            this.Label_Selected.TabIndex = 17;
            this.Label_Selected.Text = "Selected Course";
            // 
            // ListBoxCourse
            // 
            this.ListBoxCourse.Location = new System.Drawing.Point(631, 240);
            this.ListBoxCourse.Name = "ListBoxCourse";
            this.ListBoxCourse.Size = new System.Drawing.Size(306, 182);
            this.ListBoxCourse.TabIndex = 20;
            // 
            // Listbox_Available
            // 
            this.Listbox_Available.Location = new System.Drawing.Point(230, 240);
            this.Listbox_Available.Name = "Listbox_Available";
            this.Listbox_Available.Size = new System.Drawing.Size(310, 182);
            this.Listbox_Available.TabIndex = 21;
            // 
            // ComboBox_Student
            // 
            this.ComboBox_Student.FormattingEnabled = true;
            this.ComboBox_Student.Location = new System.Drawing.Point(346, 73);
            this.ComboBox_Student.Name = "ComboBox_Student";
            this.ComboBox_Student.Size = new System.Drawing.Size(194, 27);
            this.ComboBox_Student.TabIndex = 22;
            this.ComboBox_Student.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Student_SelectedIndexChanged);
            // 
            // ComboBox_Semester
            // 
            this.ComboBox_Semester.FormattingEnabled = true;
            this.ComboBox_Semester.Location = new System.Drawing.Point(743, 73);
            this.ComboBox_Semester.Name = "ComboBox_Semester";
            this.ComboBox_Semester.Size = new System.Drawing.Size(194, 27);
            this.ComboBox_Semester.TabIndex = 23;
            this.ComboBox_Semester.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Semester_SelectedIndexChanged);
            // 
            // AddCourse_FormStuent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 488);
            this.Controls.Add(this.ComboBox_Semester);
            this.Controls.Add(this.ComboBox_Student);
            this.Controls.Add(this.Listbox_Available);
            this.Controls.Add(this.ListBoxCourse);
            this.Controls.Add(this.Label_Selected);
            this.Controls.Add(this.Label_course);
            this.Controls.Add(this.Label_semester);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.accordionControl1);
            this.Name = "AddCourse_FormStuent";
            this.Text = "Add Course";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listbox_Available)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Add;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Edit_andSave;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ResetChange;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Delete_course;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Back;
        private DevExpress.XtraEditors.LabelControl Label_ID;
        private DevExpress.XtraEditors.LabelControl Label_semester;
        private DevExpress.XtraEditors.LabelControl Label_course;
        private DevExpress.XtraEditors.LabelControl Label_Selected;
        private DevExpress.XtraEditors.ListBoxControl ListBoxCourse;
        private DevExpress.XtraEditors.ListBoxControl Listbox_Available;
        private System.Windows.Forms.ComboBox ComboBox_Student;
        private System.Windows.Forms.ComboBox ComboBox_Semester;
    }
}