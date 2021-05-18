using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Management.Manager.Login
{
    public partial class Progress : WaitForm
    {
        public Progress()
        {
            InitializeComponent();
            this.Progress_login.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.Progress_login.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.Progress_login.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void Progress_login_Click(object sender, EventArgs e)
        {

        }
    }
}