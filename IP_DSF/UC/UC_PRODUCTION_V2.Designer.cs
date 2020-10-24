namespace IP.UC
{
    partial class UC_PRODUCTION_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PRODUCTION_V2));
            this.lblDplan = new System.Windows.Forms.Label();
            this.lblDplanQty = new System.Windows.Forms.Label();
            this.lblRplan = new System.Windows.Forms.Label();
            this.lblRplanQty = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRatePercent = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new IP.LabelGradient();
            this.circularGauge14 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.imageIndicatorComponent1 = new DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent();
            this.groupBoxEx1 = new IP.Addons.GroupBoxEx();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.ascProd = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDplan
            // 
            this.lblDplan.BackColor = System.Drawing.Color.Transparent;
            this.lblDplan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblDplan.ForeColor = System.Drawing.Color.Green;
            this.lblDplan.Location = new System.Drawing.Point(4, 45);
            this.lblDplan.Name = "lblDplan";
            this.lblDplan.Size = new System.Drawing.Size(107, 40);
            this.lblDplan.TabIndex = 0;
            this.lblDplan.Text = "S.Plan";
            this.lblDplan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDplanQty
            // 
            this.lblDplanQty.BackColor = System.Drawing.Color.Transparent;
            this.lblDplanQty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblDplanQty.ForeColor = System.Drawing.Color.Green;
            this.lblDplanQty.Location = new System.Drawing.Point(113, 46);
            this.lblDplanQty.Name = "lblDplanQty";
            this.lblDplanQty.Size = new System.Drawing.Size(138, 40);
            this.lblDplanQty.TabIndex = 1;
            this.lblDplanQty.Text = "0";
            this.lblDplanQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRplan
            // 
            this.lblRplan.BackColor = System.Drawing.Color.Transparent;
            this.lblRplan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRplan.ForeColor = System.Drawing.Color.Indigo;
            this.lblRplan.Location = new System.Drawing.Point(4, 84);
            this.lblRplan.Name = "lblRplan";
            this.lblRplan.Size = new System.Drawing.Size(107, 42);
            this.lblRplan.TabIndex = 2;
            this.lblRplan.Text = "R.Plan";
            this.lblRplan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRplanQty
            // 
            this.lblRplanQty.BackColor = System.Drawing.Color.Transparent;
            this.lblRplanQty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRplanQty.ForeColor = System.Drawing.Color.Indigo;
            this.lblRplanQty.Location = new System.Drawing.Point(113, 85);
            this.lblRplanQty.Name = "lblRplanQty";
            this.lblRplanQty.Size = new System.Drawing.Size(138, 42);
            this.lblRplanQty.TabIndex = 3;
            this.lblRplanQty.Text = "0";
            this.lblRplanQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProd
            // 
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblProd.ForeColor = System.Drawing.Color.Blue;
            this.lblProd.Location = new System.Drawing.Point(4, 126);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(107, 39);
            this.lblProd.TabIndex = 4;
            this.lblProd.Text = "Actual";
            this.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProdQty
            // 
            this.lblProdQty.BackColor = System.Drawing.Color.Transparent;
            this.lblProdQty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblProdQty.ForeColor = System.Drawing.Color.Blue;
            this.lblProdQty.Location = new System.Drawing.Point(113, 127);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(138, 39);
            this.lblProdQty.TabIndex = 5;
            this.lblProdQty.Text = "0";
            this.lblProdQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Transparent;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRate.Location = new System.Drawing.Point(22, 30);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(86, 41);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Rate";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRate.Visible = false;
            // 
            // lblRatePercent
            // 
            this.lblRatePercent.BackColor = System.Drawing.Color.Transparent;
            this.lblRatePercent.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRatePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRatePercent.Location = new System.Drawing.Point(92, 30);
            this.lblRatePercent.Name = "lblRatePercent";
            this.lblRatePercent.Size = new System.Drawing.Size(86, 41);
            this.lblRatePercent.TabIndex = 7;
            this.lblRatePercent.Text = "100%";
            this.lblRatePercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRatePercent.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Red;
            this.lbl3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(475, 6);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(137, 32);
            this.lbl3.TabIndex = 11;
            this.lbl3.Text = "Rate <94%";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Yellow;
            this.lbl2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(332, 6);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(137, 32);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Rate 94% ~ 97%";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Green;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(189, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(137, 32);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Rate >97%";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // circularGauge14
            // 
            this.circularGauge14.Bounds = new System.Drawing.Rectangle(6, 6, 387, 430);
            this.circularGauge14.Name = "circularGauge14";
            // 
            // imageIndicatorComponent1
            // 
            this.imageIndicatorComponent1.Image = ((System.Drawing.Image)(resources.GetObject("imageIndicatorComponent1.Image")));
            this.imageIndicatorComponent1.Name = "circularGauge1_ImageIndicator1";
            this.imageIndicatorComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(123F, 125F);
            this.imageIndicatorComponent1.ZOrder = -1001;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackgroundPanelImage = null;
            this.groupBoxEx1.Controls.Add(this.lblProdQty);
            this.groupBoxEx1.Controls.Add(this.lblRplanQty);
            this.groupBoxEx1.Controls.Add(this.lblDplanQty);
            this.groupBoxEx1.Controls.Add(this.lbl3);
            this.groupBoxEx1.Controls.Add(this.gaugeControl1);
            this.groupBoxEx1.Controls.Add(this.lbl2);
            this.groupBoxEx1.Controls.Add(this.lblProd);
            this.groupBoxEx1.Controls.Add(this.lbl1);
            this.groupBoxEx1.Controls.Add(this.lblRplan);
            this.groupBoxEx1.Controls.Add(this.lblDplan);
            this.groupBoxEx1.DrawGroupBorder = true;
            this.groupBoxEx1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEx1.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx1.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx1.GroupPanelColor = System.Drawing.Color.LightGray;
            this.groupBoxEx1.GroupPanelShape = IP.Addons.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx1.GroupPanelWith = 1F;
            this.groupBoxEx1.Location = new System.Drawing.Point(7, 38);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(618, 442);
            this.groupBoxEx1.TabIndex = 9;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.TextBackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBoxEx1.TextBorderColor = System.Drawing.Color.DarkTurquoise;
            this.groupBoxEx1.TextBorderWith = 1F;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BackColor = System.Drawing.Color.LightGray;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(234, 45);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(378, 365);
            this.gaugeControl1.TabIndex = 9;
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 366, 353);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.ascProd});
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Digital-7", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DarkOrange");
            this.labelComponent1.Name = "circularGauge1_Label1";
            this.labelComponent1.Size = new System.Drawing.SizeF(180F, 60F);
            this.labelComponent1.Text = "910";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.ascProd;
            this.arcScaleRangeBarComponent1.EndOffset = 4F;
            this.arcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 80F;
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
            this.ascProd.EndAngle = 90F;
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
            // 
            // UC_PRODUCTION_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblRatePercent);
            this.Controls.Add(this.groupBoxEx1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_PRODUCTION_V2";
            this.Size = new System.Drawing.Size(628, 483);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private System.Windows.Forms.Label lblDplan;
        private System.Windows.Forms.Label lblDplanQty;
        private System.Windows.Forms.Label lblRplan;
        private System.Windows.Forms.Label lblRplanQty;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblRatePercent;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer tmrBlink;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge14;
        private DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent imageIndicatorComponent1;
        private Addons.GroupBoxEx groupBoxEx1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent ascProd;
    }
}
