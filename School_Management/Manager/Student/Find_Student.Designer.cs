
namespace School_Management.Manager.Student
{
    partial class Find_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Student));
            this.Find_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Keyword_text = new DevExpress.XtraEditors.TextEdit();
            this.Keyword_lb = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Keyword_text.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Find_bt
            // 
            this.Find_bt.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_bt.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Find_bt.Appearance.Options.UseFont = true;
            this.Find_bt.Appearance.Options.UseForeColor = true;
            this.Find_bt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Find_bt.ImageOptions.SvgImage")));
            this.Find_bt.Location = new System.Drawing.Point(422, 17);
            this.Find_bt.Name = "Find_bt";
            this.Find_bt.Size = new System.Drawing.Size(75, 39);
            this.Find_bt.TabIndex = 0;
            this.Find_bt.Text = "Find";
            this.Find_bt.Click += new System.EventHandler(this.Find_bt_Click);
            // 
            // Keyword_text
            // 
            this.Keyword_text.Location = new System.Drawing.Point(120, 22);
            this.Keyword_text.Name = "Keyword_text";
            this.Keyword_text.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyword_text.Properties.Appearance.Options.UseFont = true;
            this.Keyword_text.Size = new System.Drawing.Size(283, 26);
            this.Keyword_text.TabIndex = 1;
            // 
            // Keyword_lb
            // 
            this.Keyword_lb.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keyword_lb.Appearance.Options.UseFont = true;
            this.Keyword_lb.Location = new System.Drawing.Point(28, 25);
            this.Keyword_lb.Name = "Keyword_lb";
            this.Keyword_lb.Size = new System.Drawing.Size(61, 19);
            this.Keyword_lb.TabIndex = 2;
            this.Keyword_lb.Text = "Keyword";
            // 
            // Find_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 78);
            this.Controls.Add(this.Keyword_lb);
            this.Controls.Add(this.Keyword_text);
            this.Controls.Add(this.Find_bt);
            this.Name = "Find_Student";
            this.Text = "Find by ID";
            ((System.ComponentModel.ISupportInitialize)(this.Keyword_text.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Find_bt;
        private DevExpress.XtraEditors.TextEdit Keyword_text;
        private DevExpress.XtraEditors.LabelControl Keyword_lb;
    }
}