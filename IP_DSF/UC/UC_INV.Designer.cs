namespace IP.UC
{
    partial class UC_INV
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
            this.lblTitle = new IP.LabelGradient();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge14 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.imageIndicatorComponent1 = new DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            this.ascInv = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.gbbOSD = new System.Windows.Forms.GroupBox();
            this.lblInvQty = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.lblPlanQty = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascInv)).BeginInit();
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
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.ColorScheme.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gaugeControl1.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)(((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.ImageIndicator) 
            | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge14});
            this.gaugeControl1.Location = new System.Drawing.Point(6, 38);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(613, 384);
            this.gaugeControl1.TabIndex = 8;
            // 
            // circularGauge14
            // 
            this.circularGauge14.Bounds = new System.Drawing.Rectangle(6, 6, 602, 376);
            this.circularGauge14.Images.AddRange(new DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent[] {
            this.imageIndicatorComponent1});
            this.circularGauge14.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge14.Name = "circularGauge14";
            this.circularGauge14.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge14.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.ascInv});
            // 
            // imageIndicatorComponent1
            // 
           // this.imageIndicatorComponent1.Image = global::OS_DSF.Properties.Resources.mas_inventory_system;
            this.imageIndicatorComponent1.Name = "circularGauge1_ImageIndicator1";
            this.imageIndicatorComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(123F, 125F);
            this.imageIndicatorComponent1.ZOrder = -1001;
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelComponent1.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Blue");
            this.labelComponent1.Name = "circularGauge3_Label1";
            this.labelComponent1.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(205F, 100F);
            this.labelComponent1.Size = new System.Drawing.SizeF(100F, 40F);
            this.labelComponent1.Text = "12";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.ascInv;
            this.arcScaleRangeBarComponent1.EndOffset = 50F;
            this.arcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Teal;Style2:Blue]");
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 79F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // ascInv
            // 
            this.ascInv.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascInv.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascInv.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascInv.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.ascInv.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.ascInv.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.ascInv.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.ascInv.EndAngle = -45F;
            this.ascInv.MajorTickCount = 0;
            this.ascInv.MajorTickmark.FormatString = "{0:F0}";
            this.ascInv.MajorTickmark.ShapeOffset = -14F;
            this.ascInv.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.ascInv.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.ascInv.MaxValue = 100F;
            this.ascInv.MinorTickCount = 0;
            this.ascInv.MinorTickmark.ShapeOffset = -7F;
            this.ascInv.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.ascInv.Name = "scale1";
            this.ascInv.StartAngle = -270F;
            this.ascInv.Value = 40F;
            // 
            // gbbOSD
            // 
            this.gbbOSD.Controls.Add(this.lblInvQty);
            this.gbbOSD.Controls.Add(this.lblInv);
            this.gbbOSD.Controls.Add(this.lblPlanQty);
            this.gbbOSD.Controls.Add(this.lblPlan);
            this.gbbOSD.Location = new System.Drawing.Point(8, 424);
            this.gbbOSD.Name = "gbbOSD";
            this.gbbOSD.Size = new System.Drawing.Size(620, 48);
            this.gbbOSD.TabIndex = 9;
            this.gbbOSD.TabStop = false;
            // 
            // lblInvQty
            // 
            this.lblInvQty.AutoSize = true;
            this.lblInvQty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInvQty.Location = new System.Drawing.Point(301, 16);
            this.lblInvQty.Name = "lblInvQty";
            this.lblInvQty.Size = new System.Drawing.Size(55, 23);
            this.lblInvQty.TabIndex = 9;
            this.lblInvQty.Text = "3,000";
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblInv.Location = new System.Drawing.Point(192, 16);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(92, 23);
            this.lblInv.TabIndex = 9;
            this.lblInv.Text = "Inventory:";
            // 
            // lblPlanQty
            // 
            this.lblPlanQty.AutoSize = true;
            this.lblPlanQty.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlanQty.Location = new System.Drawing.Point(61, 16);
            this.lblPlanQty.Name = "lblPlanQty";
            this.lblPlanQty.Size = new System.Drawing.Size(70, 23);
            this.lblPlanQty.TabIndex = 9;
            this.lblPlanQty.Text = "123456";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlan.Location = new System.Drawing.Point(6, 16);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(49, 23);
            this.lblPlan.TabIndex = 9;
            this.lblPlan.Text = "Plan:";
            // 
            // UC_INV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbbOSD);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_INV";
            this.Size = new System.Drawing.Size(628, 483);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIndicatorComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascInv)).EndInit();
            this.gbbOSD.ResumeLayout(false);
            this.gbbOSD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LabelGradient lblTitle;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge14;
        private DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent imageIndicatorComponent1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent ascInv;
        private System.Windows.Forms.GroupBox gbbOSD;
        private System.Windows.Forms.Label lblInvQty;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.Label lblPlanQty;
        private System.Windows.Forms.Label lblPlan;
    }
}
