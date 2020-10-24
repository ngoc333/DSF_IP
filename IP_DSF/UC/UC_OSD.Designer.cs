namespace IP.UC
{
    partial class UC_OSD
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram4 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel4 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView4 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.PieBurstAnimation pieBurstAnimation4 = new DevExpress.XtraCharts.PieBurstAnimation();
            this.lblTitle = new IP.LabelGradient();
            this.chartOSD = new DevExpress.XtraCharts.ChartControl();
            this.gbbOSD = new System.Windows.Forms.GroupBox();
            this.lblProduction = new System.Windows.Forms.Label();
            this.lblProductionQty = new System.Windows.Forms.Label();
            this.lblOSD = new System.Windows.Forms.Label();
            this.lblOSDQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRatePercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartOSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView4)).BeginInit();
            this.gbbOSD.SuspendLayout();
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
            // chartOSD
            // 
            this.chartOSD.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartOSD.AppearanceNameSerializable = "Nature Colors";
            this.chartOSD.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartOSD.DataBindings = null;
            simpleDiagram4.LabelsResolveOverlappingMinIndent = 10;
            this.chartOSD.Diagram = simpleDiagram4;
            this.chartOSD.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartOSD.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartOSD.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartOSD.Legend.Name = "Default Legend";
            this.chartOSD.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartOSD.Location = new System.Drawing.Point(0, 38);
            this.chartOSD.Name = "chartOSD";
            this.chartOSD.PaletteName = "Nature Colors";
            doughnutSeriesLabel4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesLabel4.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            doughnutSeriesLabel4.TextPattern = "{A}";
            series4.Label = doughnutSeriesLabel4;
            series4.Name = "Series 1";
            doughnutSeriesView4.Animation = pieBurstAnimation4;
            series4.View = doughnutSeriesView4;
            this.chartOSD.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartOSD.Size = new System.Drawing.Size(625, 380);
            this.chartOSD.TabIndex = 7;
            // 
            // gbbOSD
            // 
            this.gbbOSD.Controls.Add(this.lblRatePercent);
            this.gbbOSD.Controls.Add(this.lblRate);
            this.gbbOSD.Controls.Add(this.lblOSDQty);
            this.gbbOSD.Controls.Add(this.lblOSD);
            this.gbbOSD.Controls.Add(this.lblProductionQty);
            this.gbbOSD.Controls.Add(this.lblProduction);
            this.gbbOSD.Location = new System.Drawing.Point(5, 424);
            this.gbbOSD.Name = "gbbOSD";
            this.gbbOSD.Size = new System.Drawing.Size(620, 48);
            this.gbbOSD.TabIndex = 8;
            this.gbbOSD.TabStop = false;
            // 
            // lblProduction
            // 
            this.lblProduction.AutoSize = true;
            this.lblProduction.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblProduction.Location = new System.Drawing.Point(6, 16);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(101, 23);
            this.lblProduction.TabIndex = 9;
            this.lblProduction.Text = "Production:";
            // 
            // lblProductionQty
            // 
            this.lblProductionQty.AutoSize = true;
            this.lblProductionQty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblProductionQty.Location = new System.Drawing.Point(113, 16);
            this.lblProductionQty.Name = "lblProductionQty";
            this.lblProductionQty.Size = new System.Drawing.Size(70, 23);
            this.lblProductionQty.TabIndex = 9;
            this.lblProductionQty.Text = "123456";
            // 
            // lblOSD
            // 
            this.lblOSD.AutoSize = true;
            this.lblOSD.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSD.Location = new System.Drawing.Point(249, 16);
            this.lblOSD.Name = "lblOSD";
            this.lblOSD.Size = new System.Drawing.Size(62, 23);
            this.lblOSD.TabIndex = 9;
            this.lblOSD.Text = "OS&&D:";
            // 
            // lblOSDQty
            // 
            this.lblOSDQty.AutoSize = true;
            this.lblOSDQty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSDQty.Location = new System.Drawing.Point(317, 16);
            this.lblOSDQty.Name = "lblOSDQty";
            this.lblOSDQty.Size = new System.Drawing.Size(70, 23);
            this.lblOSDQty.TabIndex = 9;
            this.lblOSDQty.Text = "123456";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRate.Location = new System.Drawing.Point(476, 16);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(52, 23);
            this.lblRate.TabIndex = 9;
            this.lblRate.Text = "Rate:";
            // 
            // lblRatePercent
            // 
            this.lblRatePercent.AutoSize = true;
            this.lblRatePercent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRatePercent.Location = new System.Drawing.Point(544, 16);
            this.lblRatePercent.Name = "lblRatePercent";
            this.lblRatePercent.Size = new System.Drawing.Size(54, 23);
            this.lblRatePercent.TabIndex = 9;
            this.lblRatePercent.Text = "100%";
            // 
            // UC_OSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartOSD);
            this.Controls.Add(this.gbbOSD);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_OSD";
            this.Size = new System.Drawing.Size(628, 483);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOSD)).EndInit();
            this.gbbOSD.ResumeLayout(false);
            this.gbbOSD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private DevExpress.XtraCharts.ChartControl chartOSD;
        private System.Windows.Forms.GroupBox gbbOSD;
        private System.Windows.Forms.Label lblProductionQty;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.Label lblRatePercent;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblOSDQty;
        private System.Windows.Forms.Label lblOSD;
    }
}
