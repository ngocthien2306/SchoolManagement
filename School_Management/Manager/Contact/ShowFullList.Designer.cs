
namespace School_Management.Manager.Contact
{
    partial class ShowFullList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFullList));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Group_Show = new System.Windows.Forms.GroupBox();
            this.ShowFull = new DevExpress.XtraEditors.SimpleButton();
            this.Group_btn = new DevExpress.XtraEditors.SimpleButton();
            this.ListShowAll = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ListBox_Group = new System.Windows.Forms.ListBox();
            this.Print_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Group_Show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListShowAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1553, 710);
            this.splitContainerControl1.SplitterPosition = 362;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainer2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(362, 710);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Group_Show);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListShowAll);
            this.splitContainer1.Size = new System.Drawing.Size(1173, 710);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 1;
            // 
            // Group_Show
            // 
            this.Group_Show.Controls.Add(this.Print_btn);
            this.Group_Show.Controls.Add(this.ShowFull);
            this.Group_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Show.Location = new System.Drawing.Point(0, 0);
            this.Group_Show.Name = "Group_Show";
            this.Group_Show.Size = new System.Drawing.Size(1173, 125);
            this.Group_Show.TabIndex = 0;
            this.Group_Show.TabStop = false;
            // 
            // ShowFull
            // 
            this.ShowFull.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ShowFull.ImageOptions.SvgImage")));
            this.ShowFull.Location = new System.Drawing.Point(65, 40);
            this.ShowFull.Name = "ShowFull";
            this.ShowFull.Size = new System.Drawing.Size(144, 49);
            this.ShowFull.TabIndex = 1;
            this.ShowFull.Text = "Show All";
            this.ShowFull.Click += new System.EventHandler(this.ShowFull_Click);
            // 
            // Group_btn
            // 
            this.Group_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Group_btn.ImageOptions.SvgImage")));
            this.Group_btn.Location = new System.Drawing.Point(87, 38);
            this.Group_btn.Name = "Group_btn";
            this.Group_btn.Size = new System.Drawing.Size(144, 49);
            this.Group_btn.TabIndex = 0;
            this.Group_btn.Text = "Group";
            this.Group_btn.Click += new System.EventHandler(this.Group_btn_Click);
            // 
            // ListShowAll
            // 
            this.ListShowAll.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListShowAll.Location = new System.Drawing.Point(0, 0);
            this.ListShowAll.Name = "ListShowAll";
            this.ListShowAll.RowHeadersWidth = 62;
            this.ListShowAll.RowTemplate.Height = 28;
            this.ListShowAll.Size = new System.Drawing.Size(1173, 581);
            this.ListShowAll.TabIndex = 1;
            this.ListShowAll.DoubleClick += new System.EventHandler(this.ListShowAll_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Group_btn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ListBox_Group);
            this.splitContainer2.Size = new System.Drawing.Size(358, 706);
            this.splitContainer2.SplitterDistance = 119;
            this.splitContainer2.TabIndex = 0;
            // 
            // ListBox_Group
            // 
            this.ListBox_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Group.FormattingEnabled = true;
            this.ListBox_Group.ItemHeight = 19;
            this.ListBox_Group.Location = new System.Drawing.Point(0, 0);
            this.ListBox_Group.Name = "ListBox_Group";
            this.ListBox_Group.Size = new System.Drawing.Size(358, 583);
            this.ListBox_Group.TabIndex = 1;
            // 
            // Print_btn
            // 
            this.Print_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.Print_btn.Location = new System.Drawing.Point(372, 40);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(144, 49);
            this.Print_btn.TabIndex = 2;
            this.Print_btn.Text = "Print";
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // ShowFullList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 710);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ShowFullList";
            this.Text = "ShowFullList";
            this.Load += new System.EventHandler(this.ShowFullList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Group_Show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListShowAll)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Group_Show;
        private System.Windows.Forms.DataGridView ListShowAll;
        private DevExpress.XtraEditors.SimpleButton Group_btn;
        private DevExpress.XtraEditors.SimpleButton ShowFull;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox ListBox_Group;
        private DevExpress.XtraEditors.SimpleButton Print_btn;
    }
}