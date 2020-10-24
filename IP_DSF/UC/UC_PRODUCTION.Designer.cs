namespace IP.UC
{
    partial class UC_PRODUCTION
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PRODUCTION));
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge14 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.imageIndicatorComponent1 = new DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.ascProd = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.gbbProduction = new System.Windows.Forms.GroupBox();
            this.flow_PnProduction = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDplan = new System.Windows.Forms.Label();
            this.lblDplanQty = new System.Windows.Forms.Label();
            this.lblRplan = new System.Windows.Forms.Label();
            this.lblRplanQty = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRatePercent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new IP.LabelGradient();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascProd)).BeginInit();
            this.gbbProduction.SuspendLayout();
            this.flow_PnProduction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl1.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)(((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge14});
            this.gaugeControl1.Location = new System.Drawing.Point(4, 38);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(399, 442);
            this.gaugeControl1.TabIndex = 6;
            // 
            // circularGauge14
            // 
            this.circularGauge14.Bounds = new System.Drawing.Rectangle(6, 6, 387, 430);
            this.circularGauge14.Images.AddRange(new DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent[] {
            this.imageIndicatorComponent1});
            this.circularGauge14.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge14.Name = "circularGauge14";
            this.circularGauge14.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge14.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.ascProd});
            // 
            // imageIndicatorComponent1
            // 
            this.imageIndicatorComponent1.Image = ((System.Drawing.Image)(resources.GetObject("imageIndicatorComponent1.Image")));
            this.imageIndicatorComponent1.Name = "circularGauge1_ImageIndicator1";
            this.imageIndicatorComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(123F, 125F);
            this.imageIndicatorComponent1.ZOrder = -1001;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Blue");
            this.labelComponent1.Name = "circularGauge3_Label1";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(180F, 80F);
            this.labelComponent1.Size = new System.Drawing.SizeF(100F, 40F);
            this.labelComponent1.Text = "95";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.ascProd;
            this.arcScaleRangeBarComponent1.EndOffset = 1F;
            this.arcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Green;Style2:]");
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 70F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // ascProd
            // 
            this.ascProd.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascProd.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascProd.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascProd.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascProd.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.ascProd.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.ascProd.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.ascProd.EndAngle = -45F;
            this.ascProd.MajorTickCount = 0;
            this.ascProd.MajorTickmark.FormatString = "{0:F0}";
            this.ascProd.MajorTickmark.ShapeOffset = -14F;
            this.ascProd.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.ascProd.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.ascProd.MaxValue = 100F;
            this.ascProd.MinorTickCount = 0;
            this.ascProd.MinorTickmark.ShapeOffset = -7F;
            this.ascProd.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.ascProd.Name = "scale1";
            this.ascProd.StartAngle = -270F;
            this.ascProd.Value = 40F;
            // 
            // gbbProduction
            // 
            this.gbbProduction.Controls.Add(this.flow_PnProduction);
            this.gbbProduction.Location = new System.Drawing.Point(408, 195);
            this.gbbProduction.Name = "gbbProduction";
            this.gbbProduction.Size = new System.Drawing.Size(219, 285);
            this.gbbProduction.TabIndex = 7;
            this.gbbProduction.TabStop = false;
            // 
            // flow_PnProduction
            // 
            this.flow_PnProduction.Controls.Add(this.lblDplan);
            this.flow_PnProduction.Controls.Add(this.lblDplanQty);
            this.flow_PnProduction.Controls.Add(this.lblRplan);
            this.flow_PnProduction.Controls.Add(this.lblRplanQty);
            this.flow_PnProduction.Controls.Add(this.lblProd);
            this.flow_PnProduction.Controls.Add(this.lblProdQty);
            this.flow_PnProduction.Controls.Add(this.lblRate);
            this.flow_PnProduction.Controls.Add(this.lblRatePercent);
            this.flow_PnProduction.Location = new System.Drawing.Point(6, 19);
            this.flow_PnProduction.Name = "flow_PnProduction";
            this.flow_PnProduction.Size = new System.Drawing.Size(207, 260);
            this.flow_PnProduction.TabIndex = 8;
            // 
            // lblDplan
            // 
            this.lblDplan.BackColor = System.Drawing.Color.Transparent;
            this.lblDplan.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDplan.ForeColor = System.Drawing.Color.Green;
            this.lblDplan.Location = new System.Drawing.Point(3, 0);
            this.lblDplan.Name = "lblDplan";
            this.lblDplan.Size = new System.Drawing.Size(86, 66);
            this.lblDplan.TabIndex = 0;
            this.lblDplan.Text = "D.Plan";
            this.lblDplan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDplanQty
            // 
            this.lblDplanQty.BackColor = System.Drawing.Color.Transparent;
            this.lblDplanQty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblDplanQty.ForeColor = System.Drawing.Color.Green;
            this.lblDplanQty.Location = new System.Drawing.Point(95, 0);
            this.lblDplanQty.Name = "lblDplanQty";
            this.lblDplanQty.Size = new System.Drawing.Size(94, 66);
            this.lblDplanQty.TabIndex = 1;
            this.lblDplanQty.Text = "2,018";
            this.lblDplanQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRplan
            // 
            this.lblRplan.BackColor = System.Drawing.Color.Transparent;
            this.lblRplan.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRplan.ForeColor = System.Drawing.Color.Green;
            this.lblRplan.Location = new System.Drawing.Point(3, 66);
            this.lblRplan.Name = "lblRplan";
            this.lblRplan.Size = new System.Drawing.Size(86, 66);
            this.lblRplan.TabIndex = 2;
            this.lblRplan.Text = "R.Plan";
            this.lblRplan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRplanQty
            // 
            this.lblRplanQty.BackColor = System.Drawing.Color.Transparent;
            this.lblRplanQty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRplanQty.ForeColor = System.Drawing.Color.Green;
            this.lblRplanQty.Location = new System.Drawing.Point(95, 66);
            this.lblRplanQty.Name = "lblRplanQty";
            this.lblRplanQty.Size = new System.Drawing.Size(86, 66);
            this.lblRplanQty.TabIndex = 3;
            this.lblRplanQty.Text = "1,000";
            this.lblRplanQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProd
            // 
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.Color.Blue;
            this.lblProd.Location = new System.Drawing.Point(3, 132);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(86, 66);
            this.lblProd.TabIndex = 4;
            this.lblProd.Text = "Prod";
            this.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProdQty
            // 
            this.lblProdQty.BackColor = System.Drawing.Color.Transparent;
            this.lblProdQty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblProdQty.ForeColor = System.Drawing.Color.Blue;
            this.lblProdQty.Location = new System.Drawing.Point(95, 132);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(86, 66);
            this.lblProdQty.TabIndex = 5;
            this.lblProdQty.Text = "2,000";
            this.lblProdQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRate.Location = new System.Drawing.Point(3, 198);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(86, 66);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Rate";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRatePercent
            // 
            this.lblRatePercent.BackColor = System.Drawing.Color.Transparent;
            this.lblRatePercent.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRatePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRatePercent.Location = new System.Drawing.Point(95, 198);
            this.lblRatePercent.Name = "lblRatePercent";
            this.lblRatePercent.Size = new System.Drawing.Size(86, 66);
            this.lblRatePercent.TabIndex = 7;
            this.lblRatePercent.Text = "100%";
            this.lblRatePercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.lblYellow);
            this.groupBox1.Controls.Add(this.lblGreen);
            this.groupBox1.Location = new System.Drawing.Point(408, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.White;
            this.lblRed.Location = new System.Drawing.Point(17, 99);
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
            this.lblYellow.Location = new System.Drawing.Point(17, 62);
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
            this.lblGreen.Location = new System.Drawing.Point(17, 27);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(183, 32);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Rate >90%";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrBlink
            // 
            this.tmrBlink.Interval = 500;
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
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
            // UC_PRODUCTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbbProduction);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_PRODUCTION";
            this.Size = new System.Drawing.Size(628, 483);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascProd)).EndInit();
            this.gbbProduction.ResumeLayout(false);
            this.flow_PnProduction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge14;
        private DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent imageIndicatorComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent ascProd;
        private System.Windows.Forms.GroupBox gbbProduction;
        private System.Windows.Forms.FlowLayoutPanel flow_PnProduction;
        private System.Windows.Forms.Label lblDplan;
        private System.Windows.Forms.Label lblDplanQty;
        private System.Windows.Forms.Label lblRplan;
        private System.Windows.Forms.Label lblRplanQty;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblRatePercent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Timer tmrBlink;
    }
}
