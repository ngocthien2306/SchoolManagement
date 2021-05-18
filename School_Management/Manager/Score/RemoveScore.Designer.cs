
namespace School_Management.Manager.Score
{
    partial class RemoveScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveScore));
            this.DataGridView_Score = new System.Windows.Forms.DataGridView();
            this.Remove_btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Score
            // 
            this.DataGridView_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Score.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.DataGridView_Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Score.Location = new System.Drawing.Point(-1, -2);
            this.DataGridView_Score.Name = "DataGridView_Score";
            this.DataGridView_Score.RowHeadersWidth = 62;
            this.DataGridView_Score.RowTemplate.Height = 28;
            this.DataGridView_Score.Size = new System.Drawing.Size(1051, 560);
            this.DataGridView_Score.TabIndex = 0;
            // 
            // Remove_btn
            // 
            this.Remove_btn.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.Remove_btn.Appearance.Options.UseFont = true;
            this.Remove_btn.Appearance.Options.UseForeColor = true;
            this.Remove_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Remove_btn.Location = new System.Drawing.Point(-1, 564);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(201, 55);
            this.Remove_btn.TabIndex = 1;
            this.Remove_btn.Text = "Remove Score";
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 624);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.DataGridView_Score);
            this.Name = "RemoveScore";
            this.Text = "RemoveScore";
            this.Load += new System.EventHandler(this.RemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Score;
        private DevExpress.XtraEditors.SimpleButton Remove_btn;
    }
}