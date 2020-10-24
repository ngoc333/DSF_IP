namespace IP.UC
{
    partial class UC_ABSENT_V2
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieBurstAnimation pieBurstAnimation1 = new DevExpress.XtraCharts.PieBurstAnimation();
            this.groupBoxEx1 = new IP.Addons.GroupBoxEx();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartAbsent = new DevExpress.XtraCharts.ChartControl();
            this.lblTitle = new IP.LabelGradient();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackgroundPanelImage = null;
            this.groupBoxEx1.Controls.Add(this.lblAbsent);
            this.groupBoxEx1.Controls.Add(this.label2);
            this.groupBoxEx1.Controls.Add(this.label3);
            this.groupBoxEx1.Controls.Add(this.label1);
            this.groupBoxEx1.Controls.Add(this.chartAbsent);
            this.groupBoxEx1.DrawGroupBorder = true;
            this.groupBoxEx1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.groupBoxEx1.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx1.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx1.GroupPanelColor = System.Drawing.Color.LightGray;
            this.groupBoxEx1.GroupPanelShape = IP.Addons.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx1.GroupPanelWith = 1F;
            this.groupBoxEx1.Location = new System.Drawing.Point(5, 38);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(620, 434);
            this.groupBoxEx1.TabIndex = 11;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.TextBackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBoxEx1.TextBorderColor = System.Drawing.Color.DarkTurquoise;
            this.groupBoxEx1.TextBorderWith = 1F;
            // 
            // lblAbsent
            // 
            this.lblAbsent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsent.ForeColor = System.Drawing.Color.Black;
            this.lblAbsent.Location = new System.Drawing.Point(406, 48);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(206, 82);
            this.lblAbsent.TabIndex = 14;
            this.lblAbsent.Text = "Total Absent";
            this.lblAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(175, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Attended";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(268, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Plan Absenteeism";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(430, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unplan Absenteeism";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartAbsent
            // 
            this.chartAbsent.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartAbsent.AppearanceNameSerializable = "Nature Colors";
            this.chartAbsent.BackColor = System.Drawing.Color.LightGray;
            this.chartAbsent.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartAbsent.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.Default;
            this.chartAbsent.DataBindings = null;
            simpleDiagram1.LabelsResolveOverlappingMinIndent = 2;
            this.chartAbsent.Diagram = simpleDiagram1;
            this.chartAbsent.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartAbsent.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartAbsent.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartAbsent.Legend.Name = "Default Legend";
            this.chartAbsent.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartAbsent.Location = new System.Drawing.Point(6, 48);
            this.chartAbsent.Name = "chartAbsent";
            this.chartAbsent.PaletteName = "Palette 3";
            this.chartAbsent.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(40))))), System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(40))))))}));
            this.chartAbsent.PaletteRepository.Add("Palette 2", new DevExpress.XtraCharts.Palette("Palette 2", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Green, System.Drawing.Color.Green)}));
            this.chartAbsent.PaletteRepository.Add("Palette 3", new DevExpress.XtraCharts.Palette("Palette 3", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Yellow, System.Drawing.Color.Yellow),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Green, System.Drawing.Color.Green)}));
            pieSeriesLabel1.Border.Color = System.Drawing.Color.Black;
            pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient;
            pieSeriesLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pieSeriesLabel1.LineColor = System.Drawing.Color.Blue;
            pieSeriesLabel1.LineStyle.Thickness = 2;
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pieSeriesLabel1.TextColor = System.Drawing.Color.Black;
            pieSeriesLabel1.TextPattern = "{V:#,0} Person(s)\n{VP:0.0%}\n";
            series1.Label = pieSeriesLabel1;
            series1.Name = "Series 1";
            pieSeriesView1.Animation = pieBurstAnimation1;
            pieSeriesView1.Rotation = 90;
            series1.View = pieSeriesView1;
            this.chartAbsent.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartAbsent.Size = new System.Drawing.Size(608, 380);
            this.chartAbsent.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.GradientColorTwo = System.Drawing.Color.White;
            this.lblTitle.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 35);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Test";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_ABSENT_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxEx1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_ABSENT_V2";
            this.Size = new System.Drawing.Size(628, 483);
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAbsent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private Addons.GroupBoxEx groupBoxEx1;
        private DevExpress.XtraCharts.ChartControl chartAbsent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAbsent;
    }
}
