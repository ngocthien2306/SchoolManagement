
namespace School_Management.Manager.Score
{
    partial class Static_Course
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Course_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Course_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.Course_Chart);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ResultChart);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1248, 677);
            this.splitContainerControl1.SplitterPosition = 607;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // Course_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Course_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Course_Chart.Legends.Add(legend1);
            this.Course_Chart.Location = new System.Drawing.Point(-17, 2);
            this.Course_Chart.Name = "Course_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Course_Chart.Series.Add(series1);
            this.Course_Chart.Size = new System.Drawing.Size(609, 663);
            this.Course_Chart.TabIndex = 1;
            this.Course_Chart.Text = "chart1";
            // 
            // ResultChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ResultChart.Legends.Add(legend2);
            this.ResultChart.Location = new System.Drawing.Point(4, 12);
            this.ResultChart.Name = "ResultChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ResultChart.Series.Add(series2);
            this.ResultChart.Size = new System.Drawing.Size(616, 662);
            this.ResultChart.TabIndex = 0;
            this.ResultChart.Text = "chart1";
            // 
            // Static_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 677);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Static_Course";
            this.Text = "Static Course";
            this.Load += new System.EventHandler(this.Static_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Course_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Course_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
    }
}