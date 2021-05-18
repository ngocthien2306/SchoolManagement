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
using System.Windows.Forms.DataVisualization.Charting;

namespace School_Management.Manager.Student
{
    public partial class Statics : DevExpress.XtraEditors.XtraForm
    {
        public object SeriesChartType { get; private set; }

        public Statics()
        {
            InitializeComponent();
        }

        private void Statics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'manager_StudentDataSet.Add_Student' table. You can move, or remove it, as needed.
            this.Static();
        }
        private void Static()
        {
            Students student = new Students();
            double male = Convert.ToDouble(student.TotalMaleStudent());
            double female = Convert.ToDouble(student.TotalFemaleStudent());
            double total = Convert.ToDouble(student.TotalStudent());
            Label_Male.Text = "Male: " + male.ToString();
            Label_Female.Text = "Female: " + female.ToString();
            Label_Total.Text = "Total: " + total.ToString();
            this.DrawPieChart(male, female);
        }
        private void DrawPieChart(double value1, double value2)
        {
            Chart.Series.Clear();
            Chart.Legends.Clear();
            Chart.Legends.Add("MyLegend");
            Chart.Legends[0].LegendStyle = LegendStyle.Table;
            Chart.Legends[0].Docking = Docking.Bottom;
            Chart.Legends[0].Alignment = StringAlignment.Center;
            Chart.Legends[0].Title = "Gender";
            Chart.Legends[0].BorderColor = Color.Black;
            string seriesname = "Gender";
            Chart.Series.Add(seriesname);
            double total = value1 + value2;
            Chart.Series[seriesname].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            Chart.Series[seriesname].Color = Color.Aqua;
            Chart.Series[seriesname].Points.AddXY("Male", value1);
            Chart.Series[seriesname].Points.AddXY("Female", value2);


        }
    }
}