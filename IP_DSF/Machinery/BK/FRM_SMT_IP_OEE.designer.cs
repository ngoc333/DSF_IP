namespace OS_DSF
{
    partial class FRM_SMT_IP_OEE
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SMT_IP_OEE));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnYMD = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.ChartOEE = new DevExpress.XtraCharts.ChartControl();
            this.axfpView = new AxFPUSpreadADO.AxfpSpread();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.pnYMD);
            this.pnHeader.Controls.Add(this.lblDateTime);
            this.pnHeader.Controls.Add(this.lblTitle);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1904, 110);
            this.pnHeader.TabIndex = 20;
            // 
            // pnYMD
            // 
            this.pnYMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnYMD.Location = new System.Drawing.Point(1052, 8);
            this.pnYMD.Name = "pnYMD";
            this.pnYMD.Size = new System.Drawing.Size(450, 96);
            this.pnYMD.TabIndex = 691;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateTime.Location = new System.Drawing.Point(1651, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(253, 110);
            this.lblDateTime.TabIndex = 52;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1029, 110);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(0, 110);
            this.splMain.Name = "splMain";
            this.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.ChartOEE);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.axfpView);
            this.splMain.Size = new System.Drawing.Size(1904, 931);
            this.splMain.SplitterDistance = 575;
            this.splMain.TabIndex = 21;
            // 
            // ChartOEE
            // 
            this.ChartOEE.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.ChartOEE.DataBindings = null;
            xyDiagram1.AxisX.Label.Angle = -35;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Title.Text = "Machine";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            constantLine1.AxisValueSerializable = "80";
            constantLine1.Color = System.Drawing.Color.DeepPink;
            constantLine1.LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            constantLine1.LineStyle.Thickness = 2;
            constantLine1.Name = "OEE Target";
            constantLine1.Title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            constantLine1.Title.ShowBelowLine = true;
            constantLine1.Title.Text = "Target: 80%";
            constantLine1.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(48)))), ((int)(((byte)(160)))));
            xyDiagram1.AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] {
            constantLine1});
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Title.Text = "Percent (%)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ChartOEE.Diagram = xyDiagram1;
            this.ChartOEE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartOEE.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.ChartOEE.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.ChartOEE.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.ChartOEE.Legend.Name = "Default Legend";
            this.ChartOEE.Location = new System.Drawing.Point(0, 0);
            this.ChartOEE.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.ChartOEE.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ChartOEE.Name = "ChartOEE";
            sideBySideBarSeriesLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            sideBySideBarSeriesLabel1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            sideBySideBarSeriesLabel1.Border.Thickness = 2;
            sideBySideBarSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            sideBySideBarSeriesLabel1.LineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash;
            sideBySideBarSeriesLabel1.LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            sideBySideBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            sideBySideBarSeriesLabel1.Shadow.Visible = true;
            sideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "OEE";
            sideBySideBarSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            sideBySideBarSeriesView1.Color = System.Drawing.Color.RoyalBlue;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            hatchFillOptions1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Percent05;
            sideBySideBarSeriesView1.FillStyle.Options = hatchFillOptions1;
            series1.View = sideBySideBarSeriesView1;
            this.ChartOEE.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ChartOEE.Size = new System.Drawing.Size(1904, 575);
            this.ChartOEE.TabIndex = 0;
            // 
            // axfpView
            // 
            this.axfpView.DataSource = null;
            this.axfpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axfpView.Location = new System.Drawing.Point(0, 0);
            this.axfpView.Name = "axfpView";
            this.axfpView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpView.OcxState")));
            this.axfpView.Size = new System.Drawing.Size(1904, 352);
            this.axfpView.TabIndex = 0;
            // 
            // FRM_SMT_IP_OEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splMain);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SMT_IP_OEE";
            this.Text = "FRM_SMT_IP_OEE";
            this.Load += new System.EventHandler(this.FRM_SMT_PH_OEE_Load);
            this.VisibleChanged += new System.EventHandler(this.FRM_SMT_PH_OEE_VisibleChanged);
            this.pnHeader.ResumeLayout(false);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblDateTime;
        private AxFPUSpreadADO.AxfpSpread axfpView;
        private System.Windows.Forms.SplitContainer splMain;
        private DevExpress.XtraCharts.ChartControl ChartOEE;
        private System.Windows.Forms.Panel pnYMD;

    }
}