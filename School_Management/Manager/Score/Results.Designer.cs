
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
            this.DataGridView_Score = new System.Windows.Forms.DataGridView();
            this.Label_ID = new DevExpress.XtraEditors.LabelControl();
            this.Label_fname = new DevExpress.XtraEditors.LabelControl();
            this.Label_lname = new DevExpress.XtraEditors.LabelControl();
            this.Label_search = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.Print_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Exit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Find_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.Find_btn);
            this.splitContainerControl1.Panel1.Controls.Add(this.Exit_btn);
            this.splitContainerControl1.Panel1.Controls.Add(this.Print_btn);
            this.splitContainerControl1.Panel1.Controls.Add(this.textEdit4);
            this.splitContainerControl1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainerControl1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainerControl1.Panel1.Controls.Add(this.textEdit1);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_search);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_lname);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_fname);
            this.splitContainerControl1.Panel1.Controls.Add(this.Label_ID);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.DataGridView_Score);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1211, 439);
            this.splitContainerControl1.SplitterPosition = 348;
            this.splitContainerControl1.TabIndex = 0;
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
            this.DataGridView_Score.Size = new System.Drawing.Size(845, 439);
            this.DataGridView_Score.TabIndex = 0;
            // 
            // Label_ID
            // 
            this.Label_ID.Location = new System.Drawing.Point(12, 28);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(76, 19);
            this.Label_ID.TabIndex = 0;
            this.Label_ID.Text = "ID Student";
            // 
            // Label_fname
            // 
            this.Label_fname.Location = new System.Drawing.Point(12, 109);
            this.Label_fname.Name = "Label_fname";
            this.Label_fname.Size = new System.Drawing.Size(76, 19);
            this.Label_fname.TabIndex = 1;
            this.Label_fname.Text = "First Name";
            // 
            // Label_lname
            // 
            this.Label_lname.Location = new System.Drawing.Point(12, 184);
            this.Label_lname.Name = "Label_lname";
            this.Label_lname.Size = new System.Drawing.Size(74, 19);
            this.Label_lname.TabIndex = 2;
            this.Label_lname.Text = "Last Name";
            // 
            // Label_search
            // 
            this.Label_search.Location = new System.Drawing.Point(12, 253);
            this.Label_search.Name = "Label_search";
            this.Label_search.Size = new System.Drawing.Size(175, 19);
            this.Label_search.TabIndex = 3;
            this.Label_search.Text = "Find By ID or First Name";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(145, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(190, 28);
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(145, 105);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(190, 28);
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(145, 180);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(190, 28);
            this.textEdit3.TabIndex = 6;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(145, 295);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(190, 28);
            this.textEdit4.TabIndex = 7;
            // 
            // Print_btn
            // 
            this.Print_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Print_btn.Location = new System.Drawing.Point(12, 362);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(112, 43);
            this.Print_btn.TabIndex = 8;
            this.Print_btn.Text = "Print";
            // 
            // Exit_btn
            // 
            this.Exit_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(223, 362);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(112, 43);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Text = "Cancel";
            // 
            // Find_btn
            // 
            this.Find_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.Find_btn.Location = new System.Drawing.Point(12, 285);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(112, 47);
            this.Find_btn.TabIndex = 10;
            this.Find_btn.Text = "Find";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 439);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton Find_btn;
        private DevExpress.XtraEditors.SimpleButton Exit_btn;
        private DevExpress.XtraEditors.SimpleButton Print_btn;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl Label_search;
        private DevExpress.XtraEditors.LabelControl Label_lname;
        private DevExpress.XtraEditors.LabelControl Label_fname;
        private DevExpress.XtraEditors.LabelControl Label_ID;
        private System.Windows.Forms.DataGridView DataGridView_Score;
    }
}