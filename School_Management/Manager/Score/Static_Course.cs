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
using School_Management.Manager.Student;
namespace School_Management.Manager.Score
{
    public partial class Static_Course : DevExpress.XtraEditors.XtraForm
    {
        public Static_Course()
        {
            InitializeComponent();
        }

        private void Static_Course_Load(object sender, EventArgs e)
        {
            Courses course = new Courses();

            // Course_Chart
            Course_Chart.Series.RemoveAt(0);
            var data = course.GetAvgScoreByCourse();
            if (data.Rows.Count < 1)
            {
                XtraMessageBox.Show("No score infomation!");
                return;
            }
            Course_Chart.DataSource = data;
            var seri = Course_Chart.Series.Add("Average Score");
            seri.XValueMember = "label";
            seri.YValueMembers = "AverageGrade";
            seri.IsValueShownAsLabel = true;
            Course_Chart.Titles.Add("Average Score");

            //passFail_chart
            Scores score = new Scores();

            Students student = new Students();
            double total = Convert.ToDouble(student.TotalStudent());
            int pass = score.GetPassNumber();
            int fail = score.GetFailNumber();
            int Total = pass + fail;
            Label_Total.Text = "Total: " + Total;
            Label_Pass.Text = "Pass: " + pass + " (" + (pass*100/Total) + ")%";
            Label_fail.Text = "Fail: " + fail + " ("  + (pass*100/Total) + ")%";
            ResultChart.Series.RemoveAt(0);
            seri = ResultChart.Series.Add("Average Score");
            seri.Points.AddXY("Pass", (Math.Truncate(pass * 100.0) / total));
            seri.Points.AddXY("Fail", (Math.Truncate(fail * 100.0) / total));
            seri.IsValueShownAsLabel = true;
            seri.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            ResultChart.Titles.Add("Academic Statistics");
        }
    }
}