using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.PowerPacks;
using ChartDirector;

namespace IP
{
    public partial class FORM_INVENTORY_UV_SP : Form
    {
        System.Drawing.Color _lineColor = System.Drawing.Color.Blue;
        System.Drawing.Pen _myPen = new System.Drawing.Pen(System.Drawing.Color.Blue);
        int _wlr = 6;
        int _wn = 3, top_r = 0;
        int iPercent = 0;
        DataTable dt;
        public static int iColNum = 0;
        public static int _indexK = 0;
        double[] dataValueINV = new double[iColNum];
        double[] dataValueINV1 = new double[iColNum];

        public FORM_INVENTORY_UV_SP()
        {
            InitializeComponent();
        }

        #region Func

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }


        #endregion Func


        #region DB


        private DataTable sel_data_by_daily()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_IPEX3_AND_OSD.SEL_DAILY_INV_V2";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        #endregion DB

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
        }

        private void FORM_OSD_OEE_ZONE_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    timer1.Interval = 1000;
                    timer1.Start();
                    //iPercent = 0;
                    dt = sel_data_by_daily();
                    showData(dt);
                    GridControl(dt);

                    timer_reload.Interval = 60 * 1000;
                    timer_reload.Start();

                    timer2.Interval = 20 * 1000;
                    timer2.Start();

                    iPercent = 0;
                    _indexK = 0;
                    timerDrawChart.Start();
                    timerdRawLine.Start();
                }
                else
                {
                    timer1.Stop();
                }
            }
            catch (Exception)
            {

            }
                
        }

        private void FORM_OSD_OEE_ZONE_Load(object sender, EventArgs e)
        {
            try
            {
                GoFullscreen(true);
                _myPen.Width = _wlr;

                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                lbl_Zone.Text = "LEAD TIME/INVENTORY TRACKING ";
            }
            catch (Exception)
            {
            }
            
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }

        }

        #region Lable Paint

        private void lblNomal_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
          //  DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 0);

            ControlPaint.DrawBorder(e.Graphics, lbl.DisplayRectangle, Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid);
        }

        #endregion Lable Paint

        //private void showTempByGauseL(DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleComp, int iValue, int iMinValue, int iMaxValue, int iTickCount)
        //{
        //    lnScaleComp.Value = iValue;
        //    lnScaleComp.MinValue = iMinValue;
        //    lnScaleComp.MaxValue = iMaxValue;
        //    lnScaleComp.MajorTickCount = iTickCount;
        //}
        //private void showTempByGause(DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComp, int iValue, int iMinValue, int iMaxValue)
        //{
        //    arcScaleComp.Value = iValue;
        //    arcScaleComp.MinValue = iMinValue;
        //    arcScaleComp.MaxValue = iMaxValue;
        //}

        private void showData(DataTable dt)
        {
            try
            {
                int limit_row = dt.Rows.Count + 2, idx = 0;
                double uv, uv_hk, uv_hk_sp;

                iColNum = dt.Rows.Count - 1;
                dataValueINV1 = new double[iColNum];
                dataValueINV = new double[iColNum];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    axfGrid_Main.SetText(1, i + 3, dt.Rows[i]["MODEL_NM"].ToString());
                    axfGrid_Main.SetText(2, i + 3, dt.Rows[i]["TOT_PL"].ToString());
                    axfGrid_Main.SetText(3, i + 3, dt.Rows[i]["TOT_INV"].ToString());
                    axfGrid_Main.SetText(4, i + 3, dt.Rows[i]["TOT_LT"].ToString());
                    axfGrid_Main.SetText(5, i + 3, dt.Rows[i]["UV_INV"].ToString());
                    axfGrid_Main.SetText(6, i + 3, dt.Rows[i]["UV_LT"].ToString());
                    axfGrid_Main.SetText(7, i + 3, dt.Rows[i]["HK_INV"].ToString());
                    axfGrid_Main.SetText(8, i + 3, dt.Rows[i]["HK_LT"].ToString());
                    axfGrid_Main.SetText(9, i + 3, dt.Rows[i]["SP_INV"].ToString());
                    axfGrid_Main.SetText(10, i + 3, dt.Rows[i]["SP_LT"].ToString());

                    if (i % 2 == 1)
                    {
                        axfGrid_Main.Row = i + 3;
                        axfGrid_Main.BackColor = Color.Gainsboro;
                    }

                    if (i > 0)
                    {
                        if (dt.Rows[i]["TOT_INV"].ToString() == "0" || dt.Rows[i]["TOT_INV"].ToString() == "")
                            dataValueINV1[idx] = 0;
                        else
                            dataValueINV1[idx] = Convert.ToDouble(dt.Rows[i]["TOT_INV"].ToString());
                        idx = idx + 1;
                    }
                }
                uv = double.Parse(dt.Rows[0]["UV_LT"].ToString());
                uv_hk = double.Parse(dt.Rows[0]["UV_LT"].ToString()) + double.Parse(dt.Rows[0]["HK_LT"].ToString());
                uv_hk_sp = double.Parse(dt.Rows[0]["UV_LT"].ToString()) + double.Parse(dt.Rows[0]["HK_LT"].ToString()) + double.Parse(dt.Rows[0]["SP_LT"].ToString());

                lbl_UV.Text = uv.ToString() + " Days";
                lbl_UV_HK.Text = uv_hk.ToString() + " Days";
                lbl_UV_HK_SP.Text = uv_hk_sp.ToString() + " Days";
            }
            catch
            {}

        }

        private void GridControl(DataTable dt)
        {
            try
            {
                int limit_row = dt.Rows.Count + 3;
                for (int j = limit_row; j <= 500; j++)
                {
                    axfGrid_Main.Row = j;
                    axfGrid_Main.RowHidden = true;
                }
                axfGrid_Main.RowsFrozen = 3;

                axfGrid_Main.Row = 3;
                axfGrid_Main.BackColor = Color.LightGray;
                axfGrid_Main.FontName = "Calibri";
                axfGrid_Main.FontSize = 22;
                axfGrid_Main.FontBold = true;
            }
            catch 
            {}
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                top_r = top_r + 7;
                if (top_r > dt.Rows.Count - 1)
                    top_r = 0;
                axfGrid_Main.TopRow = top_r;
            }
            catch 
            {}
            //GridControl(dt);
           
        }

        private void timer_reload_Tick(object sender, EventArgs e)
        {
            try
            {
                iPercent = 0;
                _indexK = 0;
                dt = sel_data_by_daily();
                showData(dt);
                GridControl(dt);

                timerDrawChart.Start();
                timerdRawLine.Start();
                //INV_Chart(iPercent);

                //this.Chart_INV.Hide();
                //ClassLib.WinAPI.AnimateWindow(this.Chart_INV.Handle, 1000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("1"));
                //this.Chart_INV.Show();

                this.axfGrid_Main.Hide();
                //ClassLib.WinAPI.AnimateWindow(this.axfGrid_Main.Handle, 1000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("1"));
                this.axfGrid_Main.Show();
            }
            catch (Exception)
            {
            }
            

        }
        private bool checkWindowOpen(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].Show();
                    //showAnimation(Application.OpenForms[i]);
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            if (checkWindowOpen("FORM_TOUCH_SCREEN_MAIN_CONTROL") == true)
            {
                FORM_TOUCH_SCREEN_MAIN_CONTROL frm = new FORM_TOUCH_SCREEN_MAIN_CONTROL();
                frm.Show();
            }

            this.Hide();*/
        }

        private void INV_Chart(int percentage)
        {
            try
            {
                string[] labels = new string[dt.Rows.Count - 1];
                double[] data_inv = new double[dt.Rows.Count - 1];
                double[] data_lt = new double[dt.Rows.Count - 1];

                for (int x = 1; x < dt.Rows.Count; x++)
                {
                    labels[x - 1] = dt.Rows[x]["MODEL_NM"].ToString();
                    data_inv[x - 1] = double.Parse(dt.Rows[x]["TOT_INV"].ToString());
                    data_lt[x - 1] = double.Parse(dt.Rows[x]["TOT_LT"].ToString());
                }
                dt.Dispose();

                // Show ChartDirector
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

                // Create a XYChart object of size 400 x 240 pixels.
                XYChart c = new XYChart(1900, 500);

                c.setBackground(0xFFFFFF);

                c.setPlotArea(50, 50, 1790, 250, c.linearGradientColor(0, 0, 0, 280, 0xffffff, 0xffffff), -1, 0xffffff, 0xffffff);
                c.xAxis().setLabels(labels).setFontAngle(45);

                c.addLegend(50, 5, false, "Calibri Bold", 15).setBackground(Chart.Transparent);

                ArrayMath am1 = new ArrayMath(data_lt);
                c.yAxis2().setLinearScale(am1.min(), am1.max(), 5000);

                LineLayer layer0 = c.addLineLayer2();

                layer0.setUseYAxis2();
                layer0.setDataLabelFormat("{value|,}");

                //dataValueINV
                layer0.addDataSet(data_lt, 0xff6347, "LeadTime (Days)").setDataSymbol(Chart.GlassSphere2Shape, 11);
                layer0.setLineWidth(3);

                BarLayer layer = c.addBarLayer(Chart.CircleShape);

                // Set the labels on the x axis.
                c.xAxis().setLabels(labels);
                c.yAxis().setLabelStyle("Calibri Bold", 10);
                c.yAxis2().setLabelStyle("Calibri Bold", 10);

                // Add a bar chart layer using the given data
                //data_lt
                ArrayMath am = new ArrayMath(dataValueINV);
                //ArrayMath am = new ArrayMath(data_inv);
                c.yAxis().setLinearScale(0, am.max() +2);

                layer.addDataSet(am.mul(percentage / 100.0).result(), 0x00bfff, "Inventory (Prs)");
                layer.setDataLabelFormat("{value|,}");
                //layer.set3D(1);
                c.setNumberFormat(',');

                // Output the chart
                Chart_INV.Chart = c;

                //include tool tip for the chart
                Chart_INV.ImageMap = c.getHTMLImageMap("clickable", "",
                    "title='{xLabel}: {value} '");
            }
            catch
            {}
            

        }

        int iPer;
        private void timerDrawChart_Tick(object sender, EventArgs e)
        {
            try
            {
                iPer = _indexK / iColNum * 100;
                INV_Chart(iPercent += 2);
                if (iPer >= 100)
                    timerDrawChart.Stop();
            }
            catch
            {}
            
        }

        private void timerdRawLine_Tick(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < iColNum; i++)
                {
                    if (i == _indexK)
                    {
                        dataValueINV[_indexK] = dataValueINV1[_indexK];
                    }
                    else if (i > _indexK)
                    {
                        dataValueINV[i] = Chart.NoValue;
                    }
                }

                _indexK++;
                if (_indexK >= iColNum)
                {
                    timerdRawLine.Stop();
                }
                Chart_INV.updateViewPort(true, false);
            }
            catch (Exception)
            {

            }
            
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
    }
}
