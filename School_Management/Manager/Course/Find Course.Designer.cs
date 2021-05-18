
namespace School_Management.Manager.Course
{
    partial class Find_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Course));
            this.Keyword = new DevExpress.XtraEditors.LabelControl();
            this.Keyword_tb = new DevExpress.XtraEditors.TextEdit();
            this.Find = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Keyword_tb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Keyword
            // 
            this.Keyword.Location = new System.Drawing.Point(12, 27);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(94, 13);
            this.Keyword.TabIndex = 0;
            this.Keyword.Text = "Find with ID Course";
            // 
            // Keyword_tb
            // 
            this.Keyword_tb.Location = new System.Drawing.Point(125, 24);
            this.Keyword_tb.Name = "Keyword_tb";
            this.Keyword_tb.Size = new System.Drawing.Size(277, 20);
            this.Keyword_tb.TabIndex = 1;
            // 
            // Find
            // 
            this.Find.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Find.ImageOptions.SvgImage")));
            this.Find.Location = new System.Drawing.Point(427, 17);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 33);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Find_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 68);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Keyword_tb);
            this.Controls.Add(this.Keyword);
            this.Name = "Find_Course";
            this.Text = "Find Course";
            ((System.ComponentModel.ISupportInitialize)(this.Keyword_tb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Keyword;
        private DevExpress.XtraEditors.TextEdit Keyword_tb;
        private DevExpress.XtraEditors.SimpleButton Find;
    }
}