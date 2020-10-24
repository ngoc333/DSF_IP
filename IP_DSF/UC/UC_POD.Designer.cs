namespace IP.UC
{
    partial class UC_POD
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
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange1 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange2 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange3 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.lblTitle = new IP.LabelGradient();
            this.gcPOD = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge7 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.ascPOD = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.gcPOD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascPOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // gcPOD
            // 
            this.gcPOD.AutoLayout = false;
            this.gcPOD.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcPOD.Controls.Add(this.groupBox1);
            this.gcPOD.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge7});
            this.gcPOD.Location = new System.Drawing.Point(5, 38);
            this.gcPOD.Name = "gcPOD";
            this.gcPOD.Size = new System.Drawing.Size(621, 442);
            this.gcPOD.TabIndex = 9;
            // 
            // circularGauge7
            // 
            this.circularGauge7.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge7.Bounds = new System.Drawing.Rectangle(6, 6, 609, 427);
            this.circularGauge7.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge7.Name = "circularGauge7";
            this.circularGauge7.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge7.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.ascPOD});
            this.circularGauge7.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.ascPOD;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.695F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_CarPanelBack;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 179F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // ascPOD
            // 
            this.ascPOD.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascPOD.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:LightYellow");
            this.ascPOD.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascPOD.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8080");
            this.ascPOD.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8080");
            this.ascPOD.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 170F);
            this.ascPOD.EndAngle = 0F;
            this.ascPOD.MajorTickCount = 6;
            this.ascPOD.MajorTickmark.FormatString = "{0:F0}";
            this.ascPOD.MajorTickmark.ShapeOffset = -6F;
            this.ascPOD.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_1;
            this.ascPOD.MajorTickmark.TextOffset = 13F;
            this.ascPOD.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.ascPOD.MaxValue = 100F;
            this.ascPOD.MinorTickCount = 4;
            this.ascPOD.MinorTickmark.ShapeOffset = -6F;
            this.ascPOD.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2;
            this.ascPOD.Name = "scale1";
            this.ascPOD.RadiusX = 72F;
            this.ascPOD.RadiusY = 72F;
            arcScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange1.EndThickness = 6F;
            arcScaleRange1.EndValue = 33F;
            arcScaleRange1.Name = "Range0";
            arcScaleRange1.ShapeOffset = 29F;
            arcScaleRange1.StartThickness = 6F;
            arcScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Yellow");
            arcScaleRange2.EndThickness = 6F;
            arcScaleRange2.EndValue = 66F;
            arcScaleRange2.Name = "Range1";
            arcScaleRange2.ShapeOffset = 29F;
            arcScaleRange2.StartThickness = 6F;
            arcScaleRange2.StartValue = 33F;
            arcScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            arcScaleRange3.EndThickness = 6F;
            arcScaleRange3.EndValue = 100F;
            arcScaleRange3.Name = "Range2";
            arcScaleRange3.ShapeOffset = 29F;
            arcScaleRange3.StartThickness = 6F;
            arcScaleRange3.StartValue = 66F;
            this.ascPOD.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange1,
            arcScaleRange2,
            arcScaleRange3});
            this.ascPOD.StartAngle = -180F;
            this.ascPOD.Value = 22F;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.labelComponent1.Name = "circularGauge7_Label1";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 200F);
            this.labelComponent1.Text = "00";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.ascPOD;
            this.arcScaleNeedleComponent1.EndOffset = 3F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style5;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.ascPOD;
            this.arcScaleSpindleCapComponent1.Name = "circularGauge7_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style26;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(28F, 28F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.lblYellow);
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 57);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.White;
            this.lblRed.Location = new System.Drawing.Point(413, 16);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(183, 32);
            this.lblRed.TabIndex = 11;
            this.lblRed.Text = "Rate <80%";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYellow
            // 
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellow.ForeColor = System.Drawing.Color.Black;
            this.lblYellow.Location = new System.Drawing.Point(224, 16);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(183, 32);
            this.lblYellow.TabIndex = 10;
            this.lblYellow.Text = "Rate 85% ~ 90%";
            this.lblYellow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.White;
            this.lblGreen.Location = new System.Drawing.Point(35, 16);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(183, 32);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Rate >90%";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_POD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gcPOD);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_POD";
            this.Size = new System.Drawing.Size(628, 483);
            this.gcPOD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascPOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private DevExpress.XtraGauges.Win.GaugeControl gcPOD;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge7;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent ascPOD;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
    }
}
