
namespace School_Management.Manager.Login
{
    partial class Login_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Account));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.Pass_tb = new DevExpress.XtraEditors.TextEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.Login_bt = new DevExpress.XtraEditors.SimpleButton();
            this.TipController = new DevExpress.Utils.ToolTipController(this.components);
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController(this.components);
            this.Radio_Student = new System.Windows.Forms.RadioButton();
            this.Radio_human = new System.Windows.Forms.RadioButton();
            this.RadioButton_Teacher = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.User_tb = new DevExpress.XtraEditors.TextEdit();
            this.ToolTip_new = new System.Windows.Forms.ToolTip(this.components);
            this.Link_account = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.Exit_bt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_tb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Pass_tb
            // 
            this.Pass_tb.EditValue = "";
            this.Pass_tb.Location = new System.Drawing.Point(187, 149);
            this.Pass_tb.Name = "Pass_tb";
            this.Pass_tb.Properties.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Pass_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_tb.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Pass_tb.Properties.Appearance.Options.UseBackColor = true;
            this.Pass_tb.Properties.Appearance.Options.UseFont = true;
            this.Pass_tb.Properties.Appearance.Options.UseForeColor = true;
            this.Pass_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.Pass_tb.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Pass_tb.Properties.ContextImageOptions.SvgImage")));
            this.Pass_tb.Size = new System.Drawing.Size(250, 36);
            this.Pass_tb.TabIndex = 1;
            this.Pass_tb.ToolTip = "Password";
            this.Pass_tb.ToolTipController = this.toolTipController1;
            this.Pass_tb.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Pass_tb.EditValueChanged += new System.EventHandler(this.Pass_tb_EditValueChanged);
            // 
            // Login_bt
            // 
            this.Login_bt.Appearance.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_bt.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Login_bt.Appearance.Options.UseFont = true;
            this.Login_bt.Appearance.Options.UseForeColor = true;
            this.Login_bt.Location = new System.Drawing.Point(187, 299);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(250, 38);
            this.Login_bt.TabIndex = 3;
            this.Login_bt.Text = "Login";
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click_1);
            // 
            // defaultToolTipController1
            // 
            // 
            // 
            // 
            this.defaultToolTipController1.DefaultController.AutoPopDelay = 10000;
            // 
            // Radio_Student
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.Radio_Student, DevExpress.Utils.DefaultBoolean.Default);
            this.Radio_Student.AutoSize = true;
            this.Radio_Student.BackColor = System.Drawing.Color.Azure;
            this.Radio_Student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Radio_Student.BackgroundImage")));
            this.Radio_Student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Radio_Student.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Radio_Student.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Radio_Student.Location = new System.Drawing.Point(142, 253);
            this.Radio_Student.Name = "Radio_Student";
            this.Radio_Student.Size = new System.Drawing.Size(71, 20);
            this.Radio_Student.TabIndex = 7;
            this.Radio_Student.TabStop = true;
            this.Radio_Student.Text = "Student";
            this.Radio_Student.UseVisualStyleBackColor = false;
            this.Radio_Student.CheckedChanged += new System.EventHandler(this.Radio_Student_CheckedChanged);
            // 
            // Radio_human
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.Radio_human, DevExpress.Utils.DefaultBoolean.Default);
            this.Radio_human.AutoSize = true;
            this.Radio_human.BackColor = System.Drawing.Color.Azure;
            this.Radio_human.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Radio_human.BackgroundImage")));
            this.Radio_human.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Radio_human.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Radio_human.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_human.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Radio_human.Location = new System.Drawing.Point(356, 253);
            this.Radio_human.Name = "Radio_human";
            this.Radio_human.Size = new System.Drawing.Size(121, 20);
            this.Radio_human.TabIndex = 8;
            this.Radio_human.TabStop = true;
            this.Radio_human.Text = "Human Resourse";
            this.Radio_human.UseVisualStyleBackColor = false;
            this.Radio_human.CheckedChanged += new System.EventHandler(this.Radio_human_CheckedChanged);
            // 
            // RadioButton_Teacher
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.RadioButton_Teacher, DevExpress.Utils.DefaultBoolean.Default);
            this.RadioButton_Teacher.AutoSize = true;
            this.RadioButton_Teacher.BackColor = System.Drawing.Color.Azure;
            this.RadioButton_Teacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RadioButton_Teacher.BackgroundImage")));
            this.RadioButton_Teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RadioButton_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButton_Teacher.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_Teacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RadioButton_Teacher.Location = new System.Drawing.Point(253, 253);
            this.RadioButton_Teacher.Name = "RadioButton_Teacher";
            this.RadioButton_Teacher.Size = new System.Drawing.Size(75, 20);
            this.RadioButton_Teacher.TabIndex = 10;
            this.RadioButton_Teacher.TabStop = true;
            this.RadioButton_Teacher.Text = "Teacher";
            this.RadioButton_Teacher.UseVisualStyleBackColor = false;
            this.RadioButton_Teacher.CheckedChanged += new System.EventHandler(this.RadioButton_Teacher_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SeaShell;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(277, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Login";
            // 
            // User_tb
            // 
            this.User_tb.EditValue = "";
            this.User_tb.Location = new System.Drawing.Point(187, 90);
            this.User_tb.Name = "User_tb";
            this.User_tb.Properties.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.User_tb.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_tb.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.User_tb.Properties.Appearance.Options.UseBackColor = true;
            this.User_tb.Properties.Appearance.Options.UseFont = true;
            this.User_tb.Properties.Appearance.Options.UseForeColor = true;
            this.User_tb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.User_tb.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("User_tb.Properties.ContextImageOptions.SvgImage")));
            this.User_tb.Size = new System.Drawing.Size(250, 36);
            this.User_tb.TabIndex = 0;
            this.ToolTip_new.SetToolTip(this.User_tb, "Username");
            this.User_tb.ToolTip = "Username";
            this.User_tb.ToolTipController = this.TipController;
            this.User_tb.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.User_tb.ToolTipTitle = "Username";
            this.User_tb.EditValueChanged += new System.EventHandler(this.User_tb_EditValueChanged);
            // 
            // Link_account
            // 
            this.Link_account.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_account.Appearance.Options.UseFont = true;
            this.Link_account.Location = new System.Drawing.Point(247, 214);
            this.Link_account.Name = "Link_account";
            this.Link_account.Size = new System.Drawing.Size(131, 16);
            this.Link_account.TabIndex = 6;
            this.Link_account.Text = "Create a new account?";
            this.Link_account.Click += new System.EventHandler(this.Link_account_Click);
            // 
            // Exit_bt
            // 
            this.Exit_bt.Appearance.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_bt.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Exit_bt.Appearance.Options.UseFont = true;
            this.Exit_bt.Appearance.Options.UseForeColor = true;
            this.Exit_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_bt.ImageOptions.Image")));
            this.Exit_bt.Location = new System.Drawing.Point(12, 309);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Exit_bt.Size = new System.Drawing.Size(89, 71);
            this.Exit_bt.TabIndex = 9;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // Login_Account
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(629, 392);
            this.Controls.Add(this.RadioButton_Teacher);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Radio_human);
            this.Controls.Add(this.Radio_Student);
            this.Controls.Add(this.Link_account);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.User_tb);
            this.Controls.Add(this.Pass_tb);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Account";
            this.Text = "Login Account";
            this.Load += new System.EventHandler(this.Login_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_tb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton Login_bt;
        private DevExpress.XtraEditors.TextEdit Pass_tb;
        private DevExpress.Utils.ToolTipController TipController;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit User_tb;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.ToolTip ToolTip_new;
        private DevExpress.XtraEditors.HyperlinkLabelControl Link_account;
        private System.Windows.Forms.RadioButton Radio_Student;
        private System.Windows.Forms.RadioButton Radio_human;
        private DevExpress.XtraEditors.SimpleButton Exit_bt;
        private System.Windows.Forms.RadioButton RadioButton_Teacher;
    }
}