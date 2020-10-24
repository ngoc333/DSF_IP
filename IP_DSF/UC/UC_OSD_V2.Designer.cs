namespace IP.UC
{
    partial class UC_OSD_V2
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
            this.gbbOSD = new System.Windows.Forms.GroupBox();
            this.lblValue = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.groupBoxEx1 = new IP.Addons.GroupBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScale_VAL = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.lbl_Scale = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblOSD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new IP.LabelGradient();
            ((System.ComponentModel.ISupportInitialize)(this.lblValue)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScale_VAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbbOSD
            // 
            this.gbbOSD.Location = new System.Drawing.Point(5, 424);
            this.gbbOSD.Name = "gbbOSD";
            this.gbbOSD.Size = new System.Drawing.Size(620, 48);
            this.gbbOSD.TabIndex = 8;
            this.gbbOSD.TabStop = false;
            this.gbbOSD.Visible = false;
            // 
            // lblValue
            // 
            this.lblValue.Name = null;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackgroundPanelImage = null;
            this.groupBoxEx1.Controls.Add(this.label2);
            this.groupBoxEx1.Controls.Add(this.label1);
            this.groupBoxEx1.Controls.Add(this.gaugeControl1);
            this.groupBoxEx1.Controls.Add(this.lblProd);
            this.groupBoxEx1.Controls.Add(this.lblOSD);
            this.groupBoxEx1.Controls.Add(this.label4);
            this.groupBoxEx1.Controls.Add(this.label3);
            this.groupBoxEx1.DrawGroupBorder = true;
            this.groupBoxEx1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.groupBoxEx1.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx1.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx1.GroupPanelColor = System.Drawing.Color.LightGray;
            this.groupBoxEx1.GroupPanelShape = IP.Addons.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx1.GroupPanelWith = 1F;
            this.groupBoxEx1.Location = new System.Drawing.Point(5, 38);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(620, 442);
            this.groupBoxEx1.TabIndex = 10;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.TextBackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBoxEx1.TextBorderColor = System.Drawing.Color.DarkTurquoise;
            this.groupBoxEx1.TextBorderWith = 1F;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(397, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS&&D ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(397, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prod ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.BackColor = System.Drawing.Color.LightGray;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(6, 47);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(432, 367);
            this.gaugeControl1.TabIndex = 2;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 418, 355);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.lbl_Scale});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScale_VAL});
            this.circularGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScale_VAL;
            this.arcScaleBackgroundLayerComponent1.Name = "bg1";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.56F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style22;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 224F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScale_VAL
            // 
            this.arcScale_VAL.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale_VAL.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale_VAL.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale_VAL.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScale_VAL.AppearanceTickmarkText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arcScale_VAL.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#393939");
            this.arcScale_VAL.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 140F);
            this.arcScale_VAL.EndAngle = 45F;
            this.arcScale_VAL.MajorTickCount = 9;
            this.arcScale_VAL.MajorTickmark.FormatString = "{0:F1}";
            this.arcScale_VAL.MajorTickmark.ShapeOffset = -8F;
            this.arcScale_VAL.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_1;
            this.arcScale_VAL.MajorTickmark.TextOffset = 10F;
            this.arcScale_VAL.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScale_VAL.MaxValue = 10F;
            this.arcScale_VAL.MinorTickCount = 4;
            this.arcScale_VAL.MinorTickmark.ShapeOffset = -8F;
            this.arcScale_VAL.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2;
            this.arcScale_VAL.Name = "scale1";
            this.arcScale_VAL.RadiusX = 75F;
            this.arcScale_VAL.RadiusY = 75F;
            this.arcScale_VAL.StartAngle = -225F;
            // 
            // lbl_Scale
            // 
            this.lbl_Scale.AppearanceText.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Scale.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
            this.lbl_Scale.Name = "circularGauge1_Label1";
            this.lbl_Scale.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 220F);
            this.lbl_Scale.Size = new System.Drawing.SizeF(70F, 25F);
            this.lbl_Scale.Text = "0";
            this.lbl_Scale.ZOrder = -1001;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScale_VAL;
            this.arcScaleNeedleComponent1.EndOffset = 2F;
            this.arcScaleNeedleComponent1.Name = "needle1";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style22;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScale_VAL;
            this.arcScaleSpindleCapComponent1.Name = "cap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style22;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(29F, 29F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // lblProd
            // 
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblProd.ForeColor = System.Drawing.Color.Blue;
            this.lblProd.Location = new System.Drawing.Point(476, 47);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(134, 40);
            this.lblProd.TabIndex = 1;
            this.lblProd.Text = "999,999 Prs";
            this.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOSD
            // 
            this.lblOSD.BackColor = System.Drawing.Color.Transparent;
            this.lblOSD.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblOSD.ForeColor = System.Drawing.Color.Purple;
            this.lblOSD.Location = new System.Drawing.Point(476, 84);
            this.lblOSD.Name = "lblOSD";
            this.lblOSD.Size = new System.Drawing.Size(134, 40);
            this.lblOSD.TabIndex = 1;
            this.lblOSD.Text = "0 Prs";
            this.lblOSD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(466, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "OS&&D >= 3.6%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "OS&&D < 3.6%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // UC_OSD_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxEx1);
            this.Controls.Add(this.gbbOSD);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_OSD_V2";
            this.Size = new System.Drawing.Size(628, 483);
            ((System.ComponentModel.ISupportInitialize)(this.lblValue)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScale_VAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private System.Windows.Forms.GroupBox gbbOSD;
        private Addons.GroupBoxEx groupBoxEx1;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblOSD;
        private DevExpress.XtraGauges.Win.Base.LabelComponent lblValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScale_VAL;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent lbl_Scale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
