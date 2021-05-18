
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Course_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_Total = new DevExpress.XtraEditors.LabelControl();
            this.Label_Pass = new DevExpress.XtraEditors.LabelControl();
            this.Label_fail = new DevExpress.XtraEditors.LabelControl();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.Label_fail);
            this.splitContainerControl1.Panel2.Controls.Add(this.Label_Pass);
            this.splitContainerControl1.Panel2.Controls.Add(this.Label_Total);
            this.splitContainerControl1.Panel2.Controls.Add(this.ResultChart);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1248, 677);
            this.splitContainerControl1.SplitterPosition = 607;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // Course_Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Course_Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Course_Chart.Legends.Add(legend3);
            this.Course_Chart.Location = new System.Drawing.Point(-17, 2);
            this.Course_Chart.Name = "Course_Chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Course_Chart.Series.Add(series3);
            this.Course_Chart.Size = new System.Drawing.Size(609, 663);
            this.Course_Chart.TabIndex = 1;
            this.Course_Chart.Text = "chart1";
            // 
            // ResultChart
            // 
            chartArea4.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ResultChart.Legends.Add(legend4);
            this.ResultChart.Location = new System.Drawing.Point(4, 2);
            this.ResultChart.Name = "ResultChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ResultChart.Series.Add(series4);
            this.ResultChart.Size = new System.Drawing.Size(616, 672);
            this.ResultChart.TabIndex = 0;
            this.ResultChart.Text = "chart1";
            // 
            // Label_Total
            // 
            this.Label_Total.Location = new System.Drawing.Point(485, 180);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(94, 19);
            this.Label_Total.TabIndex = 1;
            this.Label_Total.Text = "labelControl1";
            // 
            // Label_Pass
            // 
            this.Label_Pass.Location = new System.Drawing.Point(485, 257);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(94, 19);
            this.Label_Pass.TabIndex = 2;
            this.Label_Pass.Text = "labelControl2";
            // 
            // Label_fail
            // 
            this.Label_fail.Location = new System.Drawing.Point(485, 336);
            this.Label_fail.Name = "Label_fail";
            this.Label_fail.Size = new System.Drawing.Size(94, 19);
            this.Label_fail.TabIndex = 3;
            this.Label_fail.Text = "labelControl3";
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
        private DevExpress.XtraEditors.LabelControl Label_fail;
        private DevExpress.XtraEditors.LabelControl Label_Pass;
        private DevExpress.XtraEditors.LabelControl Label_Total;
    }
}