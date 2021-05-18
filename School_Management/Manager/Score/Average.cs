using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management.Manager.Score
{
    public partial class Average : DevExpress.XtraEditors.XtraForm
    {
        public Average()
        {
            InitializeComponent();
        }

        private void Average_Load(object sender, EventArgs e)
        {
            Scores score = new Scores();
            score.GetAvg_byStudent();
            
        }
    }
}