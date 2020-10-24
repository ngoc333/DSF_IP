namespace OS_DSF
{
    partial class FRM_SMT_OS_FSS_INVENTORY
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.splitmain = new System.Windows.Forms.SplitContainer();
            this.chartSlabtest = new DevExpress.XtraCharts.ChartControl();
            this.grdView = new DevExpress.XtraGrid.GridControl();
            this.gvwView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandDate = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandTot = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.MODEL_NM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandPlan = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.PLAN_QTY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandMon = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandFSINV = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.FS_INV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandFSLT = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.FS_LT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandOSINV = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.OS_INV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandOSLT = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.OS_LT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.timer2 = new System.Windows.Forms.Timer();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnYMD = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.Panel1.SuspendLayout();
            this.splitmain.Panel2.SuspendLayout();
            this.splitmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSlabtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwView)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitmain
            // 
            this.splitmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitmain.Location = new System.Drawing.Point(0, 100);
            this.splitmain.Name = "splitmain";
            this.splitmain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitmain.Panel1
            // 
            this.splitmain.Panel1.Controls.Add(this.chartSlabtest);
            // 
            // splitmain.Panel2
            // 
            this.splitmain.Panel2.Controls.Add(this.grdView);
            this.splitmain.Size = new System.Drawing.Size(1920, 980);
            this.splitmain.SplitterDistance = 592;
            this.splitmain.TabIndex = 16;
            // 
            // chartSlabtest
            // 
            this.chartSlabtest.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartSlabtest.DataBindings = null;
            xyDiagram1.AxisX.Label.Angle = -45;
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,#}";
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            xyDiagram1.AxisY.Title.Text = "Inventory (Prs)";
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.Title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondaryAxisY1.Title.Text = "Leadtime (Days)";
            secondaryAxisY1.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.chartSlabtest.Diagram = xyDiagram1;
            this.chartSlabtest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSlabtest.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartSlabtest.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartSlabtest.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartSlabtest.Legend.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.chartSlabtest.Legend.Name = "Default Legend";
            this.chartSlabtest.Legend.Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartSlabtest.Legend.Title.Text = "Slab Test";
            this.chartSlabtest.Legend.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chartSlabtest.Location = new System.Drawing.Point(0, 0);
            this.chartSlabtest.Name = "chartSlabtest";
            sideBySideBarSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            sideBySideBarSeriesLabel1.TextPattern = "{V:#,#}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Inventory";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            series1.View = sideBySideBarSeriesView1;
            pointSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel1.Shadow.Visible = true;
            pointSeriesLabel1.TextPattern = "{V:#,0.0}";
            series2.Label = pointSeriesLabel1;
            series2.Name = "Leadtime";
            lineSeriesView1.AxisYName = "Secondary AxisY 1";
            lineSeriesView1.Color = System.Drawing.Color.OrangeRed;
            lineSeriesView1.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(108)))), ((int)(((byte)(9)))));
            lineSeriesView1.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            lineSeriesView1.LineStyle.Thickness = 3;
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.View = lineSeriesView1;
            this.chartSlabtest.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartSlabtest.Size = new System.Drawing.Size(1920, 592);
            this.chartSlabtest.TabIndex = 7;
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            chartTitle1.Indent = 0;
            chartTitle1.Text = "Stitching 1";
            chartTitle1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartSlabtest.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartSlabtest.CustomDrawAxisLabel += new DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(this.chartSlabtest_CustomDrawAxisLabel);
            // 
            // grdView
            // 
            this.grdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdView.Location = new System.Drawing.Point(0, 0);
            this.grdView.MainView = this.gvwView;
            this.grdView.Name = "grdView";
            this.grdView.Size = new System.Drawing.Size(1920, 384);
            this.grdView.TabIndex = 0;
            this.grdView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwView});
            // 
            // gvwView
            // 
            this.gvwView.Appearance.BandPanel.BackColor = System.Drawing.Color.Gray;
            this.gvwView.Appearance.BandPanel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwView.Appearance.BandPanel.ForeColor = System.Drawing.Color.White;
            this.gvwView.Appearance.BandPanel.Options.UseBackColor = true;
            this.gvwView.Appearance.BandPanel.Options.UseFont = true;
            this.gvwView.Appearance.BandPanel.Options.UseForeColor = true;
            this.gvwView.Appearance.BandPanel.Options.UseTextOptions = true;
            this.gvwView.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwView.Appearance.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvwView.Appearance.Row.Font = new System.Drawing.Font("Calibri", 14F);
            this.gvwView.Appearance.Row.Options.UseFont = true;
            this.gvwView.Appearance.Row.Options.UseTextOptions = true;
            this.gvwView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvwView.BandPanelRowHeight = 35;
            this.gvwView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandDate,
            this.gridBand1,
            this.bandMon,
            this.gridBand2});
            this.gvwView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.MODEL_NM,
            this.PLAN_QTY,
            this.FS_INV,
            this.FS_LT,
            this.OS_INV,
            this.OS_LT});
            this.gvwView.GridControl = this.grdView;
            this.gvwView.Name = "gvwView";
            this.gvwView.OptionsCustomization.AllowBandMoving = false;
            this.gvwView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvwView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvwView.OptionsView.ShowColumnHeaders = false;
            this.gvwView.OptionsView.ShowGroupPanel = false;
            this.gvwView.OptionsView.ShowIndicator = false;
            this.gvwView.PaintStyleName = "UltraFlat";
            this.gvwView.RowHeight = 30;
            this.gvwView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvwView_RowCellStyle);
            // 
            // bandDate
            // 
            this.bandDate.Caption = "Model";
            this.bandDate.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandTot});
            this.bandDate.Name = "bandDate";
            this.bandDate.RowCount = 2;
            this.bandDate.VisibleIndex = 0;
            this.bandDate.Width = 420;
            // 
            // bandTot
            // 
            this.bandTot.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandTot.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandTot.AppearanceHeader.Options.UseBackColor = true;
            this.bandTot.AppearanceHeader.Options.UseForeColor = true;
            this.bandTot.Caption = "Total";
            this.bandTot.Columns.Add(this.MODEL_NM);
            this.bandTot.Name = "bandTot";
            this.bandTot.VisibleIndex = 0;
            this.bandTot.Width = 420;
            // 
            // MODEL_NM
            // 
            this.MODEL_NM.Caption = "MODEL_NM";
            this.MODEL_NM.FieldName = "MODEL_NM";
            this.MODEL_NM.Name = "MODEL_NM";
            this.MODEL_NM.Visible = true;
            this.MODEL_NM.Width = 420;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Plan";
            this.gridBand1.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandPlan});
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.RowCount = 2;
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 297;
            // 
            // bandPlan
            // 
            this.bandPlan.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandPlan.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandPlan.AppearanceHeader.Options.UseBackColor = true;
            this.bandPlan.AppearanceHeader.Options.UseForeColor = true;
            this.bandPlan.Caption = "0";
            this.bandPlan.Columns.Add(this.PLAN_QTY);
            this.bandPlan.Name = "bandPlan";
            this.bandPlan.VisibleIndex = 0;
            this.bandPlan.Width = 297;
            // 
            // PLAN_QTY
            // 
            this.PLAN_QTY.Caption = "PLAN_QTY";
            this.PLAN_QTY.FieldName = "PLAN_QTY";
            this.PLAN_QTY.Name = "PLAN_QTY";
            this.PLAN_QTY.Visible = true;
            this.PLAN_QTY.Width = 297;
            // 
            // bandMon
            // 
            this.bandMon.Caption = "Stockfit";
            this.bandMon.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand4});
            this.bandMon.Name = "bandMon";
            this.bandMon.VisibleIndex = 2;
            this.bandMon.Width = 598;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Inventory (Prs)";
            this.gridBand3.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandFSINV});
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 299;
            // 
            // bandFSINV
            // 
            this.bandFSINV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandFSINV.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandFSINV.AppearanceHeader.Options.UseBackColor = true;
            this.bandFSINV.AppearanceHeader.Options.UseForeColor = true;
            this.bandFSINV.Caption = "0";
            this.bandFSINV.Columns.Add(this.FS_INV);
            this.bandFSINV.Name = "bandFSINV";
            this.bandFSINV.VisibleIndex = 0;
            this.bandFSINV.Width = 299;
            // 
            // FS_INV
            // 
            this.FS_INV.Caption = "FS_INV";
            this.FS_INV.FieldName = "FS_INV";
            this.FS_INV.Name = "FS_INV";
            this.FS_INV.Visible = true;
            this.FS_INV.Width = 299;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Leadtime(Hours)";
            this.gridBand4.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandFSLT});
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 299;
            // 
            // bandFSLT
            // 
            this.bandFSLT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandFSLT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandFSLT.AppearanceHeader.Options.UseBackColor = true;
            this.bandFSLT.AppearanceHeader.Options.UseForeColor = true;
            this.bandFSLT.Caption = "0";
            this.bandFSLT.Columns.Add(this.FS_LT);
            this.bandFSLT.Name = "bandFSLT";
            this.bandFSLT.VisibleIndex = 0;
            this.bandFSLT.Width = 299;
            // 
            // FS_LT
            // 
            this.FS_LT.Caption = "FS_LT";
            this.FS_LT.FieldName = "FS_LT";
            this.FS_LT.Name = "FS_LT";
            this.FS_LT.Visible = true;
            this.FS_LT.Width = 299;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Outsole";
            this.gridBand2.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand5,
            this.gridBand6});
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 3;
            this.gridBand2.Width = 603;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Inventory (Prs)";
            this.gridBand5.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandOSINV});
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 0;
            this.gridBand5.Width = 301;
            // 
            // bandOSINV
            // 
            this.bandOSINV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandOSINV.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandOSINV.AppearanceHeader.Options.UseBackColor = true;
            this.bandOSINV.AppearanceHeader.Options.UseForeColor = true;
            this.bandOSINV.Caption = "0";
            this.bandOSINV.Columns.Add(this.OS_INV);
            this.bandOSINV.Name = "bandOSINV";
            this.bandOSINV.VisibleIndex = 0;
            this.bandOSINV.Width = 301;
            // 
            // OS_INV
            // 
            this.OS_INV.Caption = "OS_INV";
            this.OS_INV.FieldName = "OS_INV";
            this.OS_INV.Name = "OS_INV";
            this.OS_INV.Visible = true;
            this.OS_INV.Width = 301;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Leadtime(Hours)";
            this.gridBand6.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandOSLT});
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 1;
            this.gridBand6.Width = 302;
            // 
            // bandOSLT
            // 
            this.bandOSLT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandOSLT.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandOSLT.AppearanceHeader.Options.UseBackColor = true;
            this.bandOSLT.AppearanceHeader.Options.UseForeColor = true;
            this.bandOSLT.Caption = "0";
            this.bandOSLT.Columns.Add(this.OS_LT);
            this.bandOSLT.Name = "bandOSLT";
            this.bandOSLT.VisibleIndex = 0;
            this.bandOSLT.Width = 302;
            // 
            // OS_LT
            // 
            this.OS_LT.Caption = "OS_LT";
            this.OS_LT.FieldName = "OS_LT";
            this.OS_LT.Name = "OS_LT";
            this.OS_LT.Visible = true;
            this.OS_LT.Width = 302;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1679, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(225, 100);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "20-10-2018\r\n00:00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Turquoise;
            this.pnHeader.Controls.Add(this.pnYMD);
            this.pnHeader.Controls.Add(this.lblDateTime);
            this.pnHeader.Controls.Add(this.lblTitle2);
            this.pnHeader.Controls.Add(this.lblTitle1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1920, 100);
            this.pnHeader.TabIndex = 17;
            // 
            // pnYMD
            // 
            this.pnYMD.Location = new System.Drawing.Point(1176, 2);
            this.pnYMD.Name = "pnYMD";
            this.pnYMD.Size = new System.Drawing.Size(450, 96);
            this.pnYMD.TabIndex = 1;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(226, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(944, 100);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "- Inventory Tracking(OS-Stockfit)";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle1
            // 
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(0, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(240, 100);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Outsole";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRM_SMT_OS_FSS_INVENTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.splitmain);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SMT_OS_FSS_INVENTORY";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_ROLL_SLABTEST_MON_Load);
            this.VisibleChanged += new System.EventHandler(this.FRM_ROLL_SLABTEST_MON_VisibleChanged);
            this.splitmain.Panel1.ResumeLayout(false);
            this.splitmain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSlabtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwView)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitmain;
        private DevExpress.XtraGrid.GridControl grdView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvwView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MODEL_NM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PLAN_QTY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn OS_INV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn OS_LT;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraCharts.ChartControl chartSlabtest;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel pnYMD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn FS_INV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn FS_LT;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandDate;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandTot;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandPlan;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandMon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandFSINV;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandFSLT;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandOSINV;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandOSLT;
    }
}