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
using School_Management.Manager.Course;

namespace School_Management.Manager.Score
{
    public partial class Avg_Score : DevExpress.XtraEditors.XtraForm
    {
        public Avg_Score()
        {
            InitializeComponent();
            Courses course = new Courses();
            Chart_Avg.Series.RemoveAt(0);
            Chart_Avg.DataSource = course.GetAvgScoreByCourse();
            Chart_Avg.Series.Add("Average Score");
            Chart_Avg.Series["Average Score"].XValueMember = "lable";
            Chart_Avg.Series["Average Score"].YValueMembers = "AverageGrade";
            Chart_Avg.Titles.Add("Average Score per Course Chart");

        }

        private void Chart_Avg_Click(object sender, EventArgs e)
        {

        }
    }
}