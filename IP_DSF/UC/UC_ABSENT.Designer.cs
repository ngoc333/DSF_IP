namespace IP.UC
{
    partial class UC_ABSENT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PiePopUpAnimation piePopUpAnimation1 = new DevExpress.XtraCharts.PiePopUpAnimation();
            this.lblTitle = new IP.LabelGradient();
            this.chartAbsent = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.GradientColorOne = System.Drawing.Color.DarkCyan;
            this.lblTitle.GradientColorTwo = System.Drawing.Color.White;
            this.lblTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 35);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Test";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartAbsent
            // 
            this.chartAbsent.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartAbsent.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartAbsent.DataBindings = null;
            this.chartAbsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartAbsent.Legend.Name = "Default Legend";
            this.chartAbsent.Location = new System.Drawing.Point(0, 35);
            this.chartAbsent.Name = "chartAbsent";
            this.chartAbsent.PaletteName = "Blue Warm";
            pieSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Radial;
            pieSeriesLabel1.TextPattern = "{A}: {V:#,#}";
            series1.Label = pieSeriesLabel1;
            series1.Name = "Series 1";
            pieSeriesView1.Animation = piePopUpAnimation1;
            series1.View = pieSeriesView1;
            this.chartAbsent.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartAbsent.Size = new System.Drawing.Size(628, 448);
            this.chartAbsent.TabIndex = 6;
            // 
            // UC_ABSENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartAbsent);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_ABSENT";
            this.Size = new System.Drawing.Size(628, 483);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAbsent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private DevExpress.XtraCharts.ChartControl chartAbsent;
    }
}
