
namespace School_Management.Manager.Score
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.GroupBox_Control = new System.Windows.Forms.GroupBox();
            this.Save_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Exit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Find_btn = new DevExpress.XtraEditors.SimpleButton();
            this.TextEdit_find = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_lname = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_fname = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_ID = new DevExpress.XtraEditors.TextEdit();
            this.Label_search = new DevExpress.XtraEditors.LabelControl();
            this.Label_lname = new DevExpress.XtraEditors.LabelControl();
            this.Label_fname = new DevExpress.XtraEditors.LabelControl();
            this.Label_ID = new DevExpress.XtraEditors.LabelControl();
            this.DataGridView_Score = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.GroupBox_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_find.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_lname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_fname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.GroupBox_Control);
            this.splitContainerControl1.Panel1.Controls.Add(this.Find_btn);
            this.splitContainerControl1.Panel1.Controls.Add(this.TextEdit_find);
            this.splitContainerControl1.Panel1.Controls.Add(this.TextEdit_lname);
            this.splitContainerControl1.Panel1.Controls.Add(this.TextEdit_fname);
            this.splitContainerControl1.Panel1.Controls.Add(this.TextEdit_ID);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_search);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_lname);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_fname);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_ID);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGridView_Score);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1210, 476);
            this.splitContainerControl1.SplitterPosition = 384;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // GroupBox_Control
            // 
            this.GroupBox_Control.Controls.Add(this.Save_btn);
            this.GroupBox_Control.Controls.Add(this.Exit_btn);
            this.GroupBox_Control.Location = new System.Drawing.Point(12, 335);
            this.GroupBox_Control.Name = "GroupBox_Control";
            this.GroupBox_Control.Size = new System.Drawing.Size(376, 138);
            this.GroupBox_Control.TabIndex = 12;
            this.GroupBox_Control.TabStop = false;
            // 
            // Save_btn
            // 
            this.Save_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.ImageOptions.Image")));
            this.Save_btn.Location = new System.Drawing.Point(6, 40);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(141, 43);
            this.Save_btn.TabIndex = 14;
            this.Save_btn.Text = "Save to File";
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.ImageOptions.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(225, 40);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(142, 43);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.Text = "Cancel";
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Find_btn
            // 
            this.Find_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Find_btn.ImageOptions.Image")));
            this.Find_btn.Location = new System.Drawing.Point(12, 285);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(112, 47);
            this.Find_btn.TabIndex = 10;
            this.Find_btn.Text = "Find";
            // 
            // TextEdit_find
            // 
            this.TextEdit_find.Location = new System.Drawing.Point(145, 295);
            this.TextEdit_find.Name = "TextEdit_find";
            this.TextEdit_find.Size = new System.Drawing.Size(234, 28);
            this.TextEdit_find.TabIndex = 7;
            // 
            // TextEdit_lname
            // 
            this.TextEdit_lname.Location = new System.Drawing.Point(145, 180);
            this.TextEdit_lname.Name = "TextEdit_lname";
            this.TextEdit_lname.Size = new System.Drawing.Size(234, 28);
            this.TextEdit_lname.TabIndex = 6;
            // 
            // TextEdit_fname
            // 
            this.TextEdit_fname.Location = new System.Drawing.Point(145, 105);
            this.TextEdit_fname.Name = "TextEdit_fname";
            this.TextEdit_fname.Size = new System.Drawing.Size(234, 28);
            this.TextEdit_fname.TabIndex = 5;
            // 
            // TextEdit_ID
            // 
            this.TextEdit_ID.Location = new System.Drawing.Point(145, 28);
            this.TextEdit_ID.Name = "TextEdit_ID";
            this.TextEdit_ID.Size = new System.Drawing.Size(234, 28);
            this.TextEdit_ID.TabIndex = 4;
            // 
            // Label_search
            // 
            this.Label_search.Location = new System.Drawing.Point(12, 253);
            this.Label_search.Name = "Label_search";
            this.Label_search.Size = new System.Drawing.Size(175, 19);
            this.Label_search.TabIndex = 3;
            this.Label_search.Text = "Find By ID or First Name";
            // 
            // Label_lname
            // 
            this.Label_lname.Location = new System.Drawing.Point(12, 184);
            this.Label_lname.Name = "Label_lname";
            this.Label_lname.Size = new System.Drawing.Size(74, 19);
            this.Label_lname.TabIndex = 2;
            this.Label_lname.Text = "Last Name";
            // 
            // Label_fname
            // 
            this.Label_fname.Location = new System.Drawing.Point(12, 109);
            this.Label_fname.Name = "Label_fname";
            this.Label_fname.Size = new System.Drawing.Size(76, 19);
            this.Label_fname.TabIndex = 1;
            this.Label_fname.Text = "First Name";
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(12, 28);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(76, 19);
            this.Label_ID.TabIndex = 0;
            this.Label_ID.Text = "ID Student";
            // 
            // DataGridView_Score
            // 
            this.DataGridView_Score.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView_Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Score.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Score.Name = "DataGridView_Score";
            this.DataGridView_Score.RowHeadersWidth = 62;
            this.DataGridView_Score.RowTemplate.Height = 28;
            this.DataGridView_Score.Size = new System.Drawing.Size(808, 476);
            this.DataGridView_Score.TabIndex = 0;
            this.DataGridView_Score.DoubleClick += new System.EventHandler(this.DataGridView_Score_DoubleClick);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 476);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.GroupBox_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_find.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_lname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_fname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton Find_btn;
        private DevExpress.XtraEditors.TextEdit TextEdit_find;
        private DevExpress.XtraEditors.TextEdit TextEdit_lname;
        private DevExpress.XtraEditors.TextEdit TextEdit_fname;
        private DevExpress.XtraEditors.TextEdit TextEdit_ID;
        private DevExpress.XtraEditors.LabelControl Label_search;
        private DevExpress.XtraEditors.LabelControl Label_lname;
        private DevExpress.XtraEditors.LabelControl Label_fname;
        private DevExpress.XtraEditors.LabelControl Label_ID;
        private System.Windows.Forms.DataGridView DataGridView_Score;
        private System.Windows.Forms.GroupBox GroupBox_Control;
        private DevExpress.XtraEditors.SimpleButton Save_btn;
        private DevExpress.XtraEditors.SimpleButton Exit_btn;
    }
}