using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Globalization;
using DevExpress.XtraCharts;

namespace OS_DSF
{
    public partial class FRM_SMT_OS_OSD_EXT : Form
    {
        public FRM_SMT_OS_OSD_EXT()
        {
            InitializeComponent();
        }

        int cnt = 0;
        string str_op = "";
        public delegate void MenuHandler();
        public MenuHandler OnClick = null;

        #region db
        Addons.Database db = new Addons.Database();
        #endregion
        #region UC
        UC.UC_DWMY uc = new UC.UC_DWMY(5);
        #endregion

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {            
            timer2.Enabled = true;
            timer2.Start();
            timer2.Interval = 1000;
            pnYMD.Controls.Add(uc);
            uc.OnDWMYClick += DWMYClick;
        }

        void DWMYClick(string ButtonCap, string ButtonCD)
        {
            //MessageBox.Show(ButtonCap + "    " + ButtonCD);
            switch (ButtonCD)
            {
                case "C":
                    this.Close();
                    break;
                case "M":
                    this.Hide();
                    Form fc = Application.OpenForms["FRM_SMT_OS_OSD_EXT"];
                    if (fc != null)
                        fc.ShowDialog();
                    else
                    {
                        FRM_SMT_OS_OSD_EXT f = new FRM_SMT_OS_OSD_EXT();
                        f.ShowDialog();
                    }
                    break;
                case "Y":
                    this.Hide();
                    Form fc1 = Application.OpenForms["FRM_SMT_IP_OSD_YEAR"];
                    if (fc1 != null)
                        fc1.ShowDialog();
                    else
                    {
                        FRM_SMT_IP_OSD_YEAR f1 = new FRM_SMT_IP_OSD_YEAR();
                        f1.ShowDialog();
                    }
                    break;
            }
        }

        private void formatband()
        {
            try
            {
                int n;
                DataTable dtsource = null;
                dtsource = db.SEL_OS_OSD_EXT("H", "");
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    string name;
                    //bandMon.Caption = dtsource.Rows[0]["MON"].ToString();
                    if (dtsource.Rows.Count > 0)
                    {
                        gvwView.Bands.Clear();
                        gvwView.Columns.Clear();
                        DevExpress.XtraGrid.Views.BandedGrid.GridBand bMonth = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = "Month" };
                        DevExpress.XtraGrid.Views.BandedGrid.GridBand bDate = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = "Date" };
                        DevExpress.XtraGrid.Views.BandedGrid.GridBand bMon1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[0]["DATE_1"].ToString() };
                        DevExpress.XtraGrid.Views.BandedGrid.GridBand bAVG = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = "AVG" };
                        DevExpress.XtraGrid.Views.BandedGrid.GridBand bTotal = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = "Total" };
                        if (dtsource.Rows[0]["CNT"].ToString() == "1")
                        {
                            gvwView.Bands.Add(bMonth);
                            gvwView.Bands.Add(bMon1);
                            gvwView.Bands.Add(bAVG);
                            gvwView.Bands.Add(bTotal);
                            bMonth.Children.Add(bDate);
                            bDate.Columns.Add(new BandedGridColumn() { FieldName = "LINE_CD", Visible = true, Caption = "Date" });
                            bAVG.Columns.Add(new BandedGridColumn() { FieldName = "COLAVG", Visible = true, Caption = "AVG" });
                            bTotal.Columns.Add(new BandedGridColumn() { FieldName = "COLTOTAL", Visible = true, Caption = "Total" });
                            for (int i = 0; i < dtsource.Rows.Count; i++)
                            {
                                DevExpress.XtraGrid.Views.BandedGrid.GridBand bchild = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[i]["DD"].ToString() };
                                if (dtsource.Rows[i]["VAL_RANK"].ToString() == "1")
                                {
                                    bMon1.Children.Add(bchild);
                                    bchild.Columns.Add(new BandedGridColumn() { FieldName = dtsource.Rows[i]["COL"].ToString(), Visible = true, Caption = dtsource.Rows[i]["DD"].ToString() });
                                }
                            }
                            int i_width = 0;
                            i_width = (grdView.Width - 160) / dtsource.Rows.Count;
                            bMon1.Width = i_width * bMon1.Children.Count;
                            bMonth.Width = 65;
                            bAVG.Width = 50;
                            bAVG.AppearanceHeader.BackColor = Color.Orange;
                            bTotal.Width = 50;
                            bTotal.AppearanceHeader.BackColor = Color.DodgerBlue;
                            gvwView.OptionsView.ColumnAutoWidth = false;
                        }
                        else if (dtsource.Rows[0]["CNT"].ToString() == "2")
                        {   
                            DevExpress.XtraGrid.Views.BandedGrid.GridBand bMon2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[0]["DATE_2"].ToString() };
                            gvwView.Bands.Add(bMonth);
                            gvwView.Bands.Add(bMon1);
                            gvwView.Bands.Add(bMon2);
                            gvwView.Bands.Add(bAVG);
                            gvwView.Bands.Add(bTotal);
                            bMonth.Children.Add(bDate);
                            bDate.Columns.Add(new BandedGridColumn() { FieldName = "LINE_CD", Visible = true, Caption = "Date" });
                            bAVG.Columns.Add(new BandedGridColumn() { FieldName = "COLAVG", Visible = true, Caption = "AVG" });
                            bTotal.Columns.Add(new BandedGridColumn() { FieldName = "COLTOTAL", Visible = true, Caption = "Total" });
                            for (int i = 0; i < dtsource.Rows.Count; i++)
                            {
                                DevExpress.XtraGrid.Views.BandedGrid.GridBand bchild = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[i]["DD"].ToString() };
                                if (dtsource.Rows[i]["VAL_RANK"].ToString() == "1")
                                {
                                    bMon1.Children.Add(bchild);
                                    bchild.Columns.Add(new BandedGridColumn() { FieldName = dtsource.Rows[i]["COL"].ToString(), Visible = true, Caption = dtsource.Rows[i]["DD"].ToString() });
                                }
                                else if (dtsource.Rows[i]["VAL_RANK"].ToString() == "2")
                                {
                                    bMon2.Children.Add(bchild);
                                    bchild.Columns.Add(new BandedGridColumn() { FieldName = dtsource.Rows[i]["COL"].ToString(), Visible = true, Caption = dtsource.Rows[i]["DD"].ToString() });
                                }
                            }
                            int i_width = 0;
                            i_width = (grdView.Width - 160) / dtsource.Rows.Count;
                            bMon1.Width = i_width * bMon1.Children.Count;
                            bMon2.Width = i_width * bMon2.Children.Count;
                            bMonth.Width = 65;
                            bAVG.Width = 50;
                            bAVG.AppearanceHeader.BackColor = Color.Orange;
                            bTotal.Width = 50;
                            bTotal.AppearanceHeader.BackColor = Color.DodgerBlue;
                            gvwView.OptionsView.ColumnAutoWidth = false;
                        }
                        else
                        {                            
                            DevExpress.XtraGrid.Views.BandedGrid.GridBand bMon2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[0]["DATE_2"].ToString() };
                            DevExpress.XtraGrid.Views.BandedGrid.GridBand bMon3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[0]["DATE_3"].ToString() };
                            
                            gvwView.Bands.Add(bMonth);
                            gvwView.Bands.Add(bMon1);
                            gvwView.Bands.Add(bMon2);
                            gvwView.Bands.Add(bMon3);
                            gvwView.Bands.Add(bAVG);
                            gvwView.Bands.Add(bTotal);
                            bMonth.Children.Add(bDate);
                            bDate.Columns.Add(new BandedGridColumn() { FieldName = "LINE_CD", Visible = true, Caption = "Date" });
                            bAVG.Columns.Add(new BandedGridColumn() { FieldName = "COLAVG", Visible = true, Caption = "AVG" });
                            bTotal.Columns.Add(new BandedGridColumn() { FieldName = "COLTOTAL", Visible = true, Caption = "Total" });
                            for (int i = 0; i < dtsource.Rows.Count; i++)
                            {
                                DevExpress.XtraGrid.Views.BandedGrid.GridBand bchild = new DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Caption = dtsource.Rows[i]["DD"].ToString() };
                                if (dtsource.Rows[i]["VAL_RANK"].ToString() == "1")
                                {
                                    bMon1.Children.Add(bchild);
                                    bchild.Columns.Add(new BandedGridColumn() { FieldName = dtsource.Rows[i]["COL"].ToString(), Visible = true, Caption = dtsource.Rows[i]["DD"].ToString() });
                                }
                                else if (dtsource.Rows[i]["VAL_RANK"].ToString() == "2")
                                {
                                    bMon2.Children.Add(bchild);
                                    bchild.Columns.Add(new BandedGridColumn() { FieldName = dtsource.Rows[i]["COL"].ToString(), Visible = true, Caption = dtsource.Rows[i]["DD"].ToString() });
                                }
                                else
                                {
                                    bMon3.Children.Add(bchild);
                                    bchild.Columns.Add(new BandedGridColumn() { FieldName = dtsource.Rows[i]["COL"].ToString(), Visible = true, Caption = dtsource.Rows[i]["DD"].ToString() });                                
                                }

                            }                          
                            
                            int i_width = 0;
                            i_width = (grdView.Width - 160) / dtsource.Rows.Count;
                            bMon1.Width = i_width * bMon1.Children.Count;
                            bMon2.Width = i_width * bMon2.Children.Count;
                            bMon3.Width = i_width * bMon3.Children.Count;
                            bMonth.Width = 65;
                            bAVG.Width = 50;
                            bAVG.AppearanceHeader.BackColor = Color.Orange;
                            bTotal.Width = 50;
                            bTotal.AppearanceHeader.BackColor = Color.DodgerBlue;
                            gvwView.OptionsView.ColumnAutoWidth = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void BindingData(string arg_op)
        {
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = db.SEL_OS_OSD_EXT("Q", arg_op);
            formatband();
            grdView.DataSource = dtsource;
            if (dtsource != null && dtsource.Rows.Count > 0)
            {

                for (int i = 0; i < gvwView.Columns.Count; i++)
                {
                    gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    
                    if (i >= 0)
                    {
                        gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 10, FontStyle.Regular);                        
                    }
                }
                bindingdatachart(dtsource);
                bindingchart("FTY01", chart1, "1st");
                bindingchart("FTY02", chart2, "2nd");
                bindingchart("FTY03", chart3, "3rd");
                bindingchart("FTY04", chart4, "4th");
                //gvwView.Columns[0].OwnerBand.Width = 80;

            }
        }

        private void bindingchart(string arg_op, ChartControl chart, string stt)
        {
            DataTable dt = null;
            dt = db.SEL_OS_OSD_EXT_PARETO("Q", arg_op);
            chart.DataSource = dt;
            chart.Series[0].ArgumentDataMember = "MODEL_NAME";
            chart.Series[0].ValueDataMembers.AddRange(new string[] { "QTY" });
            chart.Series[1].ArgumentDataMember = "MODEL_NAME";
            chart.Series[1].ValueDataMembers.AddRange(new string[] { "PERC" });
            ((XYDiagram)chart.Diagram).AxisX.Label.Angle = 45;
            chart.Titles.Clear();
            chart.Titles.Add(new ChartTitle());
            chart.Titles[0].Text = stt + " (" + DateTime.ParseExact(dt.Rows[0]["DATE_FROM"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM dd") + " - " + DateTime.ParseExact(dt.Rows[0]["DATE_TO"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM dd") + ")";
            chart.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart.Titles[0].Font = new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            chart.Titles[0].Indent = 0;

            
        }

        private void bindingdatachart(DataTable dtsource)
        {
            try
            {
                DataTable dt = new DataTable();
                double d_max = 0;
                dt.Columns.Add("YMD", typeof(string));
                string col_name = "";
                for (int i_row = 0; i_row < gvwView.RowCount - 1; i_row++)
                {
                    col_name = dtsource.Rows[i_row]["LINE_CD"].ToString().Replace(" ", "");
                    dt.Columns.Add(col_name, typeof(double));
                    for (int i_col = 2; i_col < dtsource.Columns.Count - 2; i_col++)
                    {
                        if (i_row == 0)
                        {
                            dt.Rows.Add();
                            dt.Rows[dt.Rows.Count - 1]["YMD"] = DateTime.ParseExact(dtsource.Columns[i_col].ToString().Substring(3, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MMM\ndd");
                            dt.Rows[dt.Rows.Count - 1][col_name] = dtsource.Rows[i_row][i_col].ToString() == "" ? 0 : Convert.ToDouble(dtsource.Rows[i_row][i_col].ToString());
                        }
                        else
                        {                            
                            dt.Rows[i_col-2][col_name] = dtsource.Rows[i_row][i_col].ToString() == "" ? 0 : Convert.ToDouble(dtsource.Rows[i_row][i_col].ToString());
                        }
                        if (d_max < (dtsource.Rows[i_row][i_col].ToString() == "" ? 0 : Convert.ToDouble(dtsource.Rows[i_row][i_col].ToString())))
                            d_max = dtsource.Rows[i_row][i_col].ToString() == "" ? 0 : Convert.ToDouble(dtsource.Rows[i_row][i_col].ToString());
                    }
                }
                //dt = db.SEL_OS_OSD_MONTH("C", arg_op);
                chartOSD.DataSource = dt;
               
                chartOSD.Series.Clear();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                      
                    chartOSD.Series.Add(new DevExpress.XtraCharts.Series(dt.Columns[i].ColumnName.ToString(), DevExpress.XtraCharts.ViewType.Line));
                    chartOSD.Series[i - 1].ArgumentDataMember = "YMD";
                    chartOSD.Series[i - 1].ValueDataMembers.AddRange(new string[] { dt.Columns[i].ColumnName.ToString() });
                    DevExpress.XtraCharts.SplineSeriesView splineSeriesView = new DevExpress.XtraCharts.SplineSeriesView();
                    splineSeriesView.LineStyle.Thickness = 2;
                    splineSeriesView.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                    splineSeriesView.LineMarkerOptions.Size = 10;
                    splineSeriesView.LineMarkerOptions.Color = Color.DodgerBlue;
                    splineSeriesView.Color = getColor(chartOSD.Series[i - 1].Name.ToString());
                    chartOSD.Series[i - 1].Name = "Factory " + i;
                    chartOSD.Series[i - 1].View = splineSeriesView;
                }

                ((XYDiagram)chartOSD.Diagram).AxisY.WholeRange.Auto = true;
                ((XYDiagram)chartOSD.Diagram).AxisY.WholeRange.SetMinMaxValues(0, d_max + 10);
                //chartSlabtest.Series[0].ArgumentDataMember = "YMD";
                //chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "OSD" });
                //chartSlabtest.Series[1].ArgumentDataMember = "YMD";
                //chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "RATE" });
                //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        private Color getColor(string _sFactory)
        {

            if (_sFactory == "Factory1")
                return Color.LimeGreen;
            if (_sFactory == "Factory2")
                return Color.Black;
            if (_sFactory == "Factory3")
                return Color.Blue;
            if (_sFactory == "Factory4")
                return System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            return Color.White;
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.ColumnHandle == 1)
            {
                e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
            }
            else
            {
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            if (cnt < 40)
            {
                cnt++;                
            }
            else
            {
                cnt = 0;
                BindingData("OSP");
                
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    //BindingData("OSP");
                    cnt = 40;
                    timer2.Start();

                   
                }
                else
                    timer2.Stop();
            }
            catch
            {

            }
        }
    }
}
