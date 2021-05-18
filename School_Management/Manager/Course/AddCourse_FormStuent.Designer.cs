
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
            this.Edit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Edit_andSave = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ResetChange = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Delete_course = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Back = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Label_ID = new DevExpress.XtraEditors.LabelControl();
            this.Label_semester = new DevExpress.XtraEditors.LabelControl();
            this.Label_course = new DevExpress.XtraEditors.LabelControl();
            this.Label_Selected = new DevExpress.XtraEditors.LabelControl();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.Edit,
            this.Edit_andSave,
            this.ResetChange,
            this.Delete_course,
            this.Back});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(191, 534);
            this.accordionControl1.TabIndex = 13;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Task";
            // 
            // Edit
            // 
            this.Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit.ImageOptions.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Edit.Text = "Edit";
            // 
            // Edit_andSave
            // 
            this.Edit_andSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit_andSave.ImageOptions.Image")));
            this.Edit_andSave.Name = "Edit_andSave";
            this.Edit_andSave.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Edit_andSave.Text = "Edit and Close";
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
            this.Label_ID.Location = new System.Drawing.Point(213, 107);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(76, 19);
            this.Label_ID.TabIndex = 14;
            this.Label_ID.Text = "Student ID";
            // 
            // Label_semester
            // 
            this.Label_semester.Location = new System.Drawing.Point(555, 107);
            this.Label_semester.Name = "Label_semester";
            this.Label_semester.Size = new System.Drawing.Size(65, 19);
            this.Label_semester.TabIndex = 15;
            this.Label_semester.Text = "Semester";
            // 
            // Label_course
            // 
            this.Label_course.Location = new System.Drawing.Point(213, 219);
            this.Label_course.Name = "Label_course";
            this.Label_course.Size = new System.Drawing.Size(118, 19);
            this.Label_course.TabIndex = 16;
            this.Label_course.Text = "Available Course";
            // 
            // Label_Selected
            // 
            this.Label_Selected.Location = new System.Drawing.Point(555, 219);
            this.Label_Selected.Name = "Label_Selected";
            this.Label_Selected.Size = new System.Drawing.Size(112, 19);
            this.Label_Selected.TabIndex = 17;
            this.Label_Selected.Text = "Selected Course";
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(646, 103);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(150, 28);
            this.checkedComboBoxEdit1.TabIndex = 18;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(308, 103);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(150, 28);
            this.textEdit1.TabIndex = 19;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(555, 271);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(241, 182);
            this.listBoxControl1.TabIndex = 20;
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Location = new System.Drawing.Point(213, 271);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(245, 182);
            this.listBoxControl2.TabIndex = 21;
            // 
            // AddCourse_FormStuent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 534);
            this.Controls.Add(this.listBoxControl2);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.checkedComboBoxEdit1);
            this.Controls.Add(this.Label_Selected);
            this.Controls.Add(this.Label_course);
            this.Controls.Add(this.Label_semester);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.accordionControl1);
            this.Name = "AddCourse_FormStuent";
            this.Text = "Add Course";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Edit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Edit_andSave;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ResetChange;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Delete_course;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Back;
        private DevExpress.XtraEditors.LabelControl Label_ID;
        private DevExpress.XtraEditors.LabelControl Label_semester;
        private DevExpress.XtraEditors.LabelControl Label_course;
        private DevExpress.XtraEditors.LabelControl Label_Selected;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
    }
}