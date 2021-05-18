
namespace School_Management.Manager.Student
{
    partial class List_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Student));
            this.DataSource_Student = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.addStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet3 = new School_Management.Manager_StudentDataSet3();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_StudentDataSet = new School_Management.Manager_StudentDataSet();
            this.add_StudentTableAdapter = new School_Management.Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter();
            this.Edit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Refresh_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Exit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.add_StudentTableAdapter1 = new School_Management.Manager_StudentDataSet3TableAdapters.Add_StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSource_Student
            // 
            this.DataSource_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSource_Student.AutoGenerateColumns = false;
            this.DataSource_Student.BackgroundColor = System.Drawing.Color.LightBlue;
            this.DataSource_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSource_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.DataSource_Student.DataSource = this.addStudentBindingSource1;
            this.DataSource_Student.Location = new System.Drawing.Point(3, -3);
            this.DataSource_Student.Margin = new System.Windows.Forms.Padding(4);
            this.DataSource_Student.Name = "DataSource_Student";
            this.DataSource_Student.RowHeadersWidth = 62;
            this.DataSource_Student.Size = new System.Drawing.Size(1308, 681);
            this.DataSource_Student.TabIndex = 0;
            this.DataSource_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSource_Student_CellContentClick);
            this.DataSource_Student.DoubleClick += new System.EventHandler(this.DataSource_Student_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 8;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 150;
            // 
            // addStudentBindingSource1
            // 
            this.addStudentBindingSource1.DataMember = "Add_Student";
            this.addStudentBindingSource1.DataSource = this.manager_StudentDataSet3;
            // 
            // manager_StudentDataSet3
            // 
            this.manager_StudentDataSet3.DataSetName = "Manager_StudentDataSet3";
            this.manager_StudentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataMember = "Add_Student";
            this.addStudentBindingSource.DataSource = this.manager_StudentDataSet;
            // 
            // manager_StudentDataSet
            // 
            this.manager_StudentDataSet.DataSetName = "Manager_StudentDataSet";
            this.manager_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_StudentTableAdapter
            // 
            this.add_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // Edit_btn
            // 
            this.Edit_btn.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Edit_btn.Appearance.Options.UseFont = true;
            this.Edit_btn.Appearance.Options.UseForeColor = true;
            this.Edit_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edit_btn.ImageOptions.Image")));
            this.Edit_btn.Location = new System.Drawing.Point(45, 709);
            this.Edit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Edit_btn.Size = new System.Drawing.Size(138, 57);
            this.Edit_btn.TabIndex = 1;
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.Refresh_btn.Appearance.Options.UseFont = true;
            this.Refresh_btn.Appearance.Options.UseForeColor = true;
            this.Refresh_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_btn.ImageOptions.Image")));
            this.Refresh_btn.Location = new System.Drawing.Point(588, 709);
            this.Refresh_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Refresh_btn.Size = new System.Drawing.Size(138, 57);
            this.Refresh_btn.TabIndex = 2;
            this.Refresh_btn.Text = "Refresh";
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.Exit_btn.Appearance.Options.UseFont = true;
            this.Exit_btn.Appearance.Options.UseForeColor = true;
            this.Exit_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.ImageOptions.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(1140, 709);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Exit_btn.Size = new System.Drawing.Size(138, 57);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // add_StudentTableAdapter1
            // 
            this.add_StudentTableAdapter1.ClearBeforeFill = true;
            // 
            // List_Student
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 783);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.DataSource_Student);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "List_Student";
            this.Text = "List of Student";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSource_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_StudentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataSource_Student;
        private Manager_StudentDataSet manager_StudentDataSet;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private Manager_StudentDataSetTableAdapters.Add_StudentTableAdapter add_StudentTableAdapter;
        private DevExpress.XtraEditors.SimpleButton Edit_btn;
        private DevExpress.XtraEditors.SimpleButton Refresh_btn;
        private DevExpress.XtraEditors.SimpleButton Exit_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private Manager_StudentDataSet3 manager_StudentDataSet3;
        private System.Windows.Forms.BindingSource addStudentBindingSource1;
        private Manager_StudentDataSet3TableAdapters.Add_StudentTableAdapter add_StudentTableAdapter1;
    }
}