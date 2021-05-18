
namespace School_Management.Manager.Login
{
    partial class Progress
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
            this.Progress_login = new DevExpress.XtraWaitForm.ProgressPanel();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Progress_login
            // 
            this.Progress_login.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Progress_login.Appearance.Options.UseBackColor = true;
            this.Progress_login.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Progress_login.AppearanceCaption.Options.UseFont = true;
            this.Progress_login.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Progress_login.AppearanceDescription.Options.UseFont = true;
            this.Progress_login.BarAnimationElementThickness = 2;
            this.Progress_login.Description = "Loading to School Management App";
            this.Progress_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress_login.ImageHorzOffset = 20;
            this.Progress_login.Location = new System.Drawing.Point(0, 17);
            this.Progress_login.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Progress_login.Name = "Progress_login";
            this.Progress_login.Size = new System.Drawing.Size(428, 223);
            this.Progress_login.TabIndex = 0;
            this.Progress_login.Text = "Progress";
            this.Progress_login.Click += new System.EventHandler(this.Progress_login_Click);
            // 
            // TableLayout
            // 
            this.TableLayout.AutoSize = true;
            this.TableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayout.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout.ColumnCount = 1;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Controls.Add(this.Progress_login, 0, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(428, 257);
            this.TableLayout.TabIndex = 1;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 257);
            this.Controls.Add(this.TableLayout);
            this.DoubleBuffered = true;
            this.Name = "Progress";
            this.TableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel Progress_login;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
    }
}
