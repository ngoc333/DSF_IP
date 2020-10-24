using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Text.RegularExpressions;

//using COM.eBiz.Framework.Data;
//using COM.eBiz.Framework.Lib;
using FPSpreadADO;
using ChartDirector;
//using IPEX_Monitor;
using System.Threading;
using System.Collections;


namespace IP
{
    public partial class FORM_IP_CHAMBER_ZONE : Form
    {
        #region Declare
       // int iPercent = 5;
        bool _alarm = false;
        //public IPEX_Monitor.ClassLib.Class_Sound sound = new IPEX_Monitor.ClassLib.Class_Sound("critical.wav");
        double[] data0 = { 0, 0, 0 };
        double[] data1 = { 0, 0, 0 };
        double[] data2 = { 0, 0, 0 };
        double[] data = { 0, 0, 0 };
        double[] dataMax = { 0, 0, 0 };
        bool b1L = true;
        bool b2L = true;
        bool b3L = true;
        bool b4L = true;
        bool b5L = true;
        bool b6L = true;

        bool b1U = true;
        bool b2U = true;
        bool b3U = true;
        bool b4U = true;
        bool b5U = true;
        bool b6U = true;

        int _time = 0;
        DataTable _dtMinMax = null;
        DataTable _dtData = null;
        public static int iNumRow = 8;
        public static double _dNummax = 0;
        public static double _dNummin = 100;
        double[] _Min1 = new double[iNumRow];
        double[] _Min2 = new double[iNumRow];
        double[] _Min3 = new double[iNumRow];
        double[] _Min4 = new double[iNumRow];
        double[] _Min5 = new double[iNumRow];
        double[] _Min6 = new double[iNumRow];
        double[] _Min7 = new double[iNumRow];
        double[] _Min8 = new double[iNumRow];
        double[] _Min9 = new double[iNumRow];
        double[] _Min10 = new double[iNumRow];
        double[] _Min11 = new double[iNumRow];
        double[] _Min12 = new double[iNumRow];


        double[] _Min_show = new double[iNumRow];

        double[] _Max1_w = new double[iNumRow];
        double[] _Max2_w = new double[iNumRow];
        double[] _Max3_w = new double[iNumRow];
        double[] _Max4_w = new double[iNumRow];
        double[] _Max5_w = new double[iNumRow];
        double[] _Max6_w = new double[iNumRow];
        double[] _Max7_w = new double[iNumRow];
        double[] _Max8_w = new double[iNumRow];
        double[] _Max9_w = new double[iNumRow];
        double[] _Max10_w = new double[iNumRow];
        double[] _Max11_w = new double[iNumRow];
        double[] _Max12_w = new double[iNumRow];


        double[] _Min1_w = new double[iNumRow];
        double[] _Min2_w = new double[iNumRow];
        double[] _Min3_w = new double[iNumRow];
        double[] _Min4_w = new double[iNumRow];
        double[] _Min5_w = new double[iNumRow];
        double[] _Min6_w = new double[iNumRow];
        double[] _Min7_w = new double[iNumRow];
        double[] _Min8_w = new double[iNumRow];
        double[] _Min9_w = new double[iNumRow];
        double[] _Min10_w = new double[iNumRow];
        double[] _Min11_w = new double[iNumRow];
        double[] _Min12_w = new double[iNumRow];

        double[] _Max1 = new double[iNumRow];
        double[] _Max2 = new double[iNumRow];
        double[] _Max3 = new double[iNumRow];
        double[] _Max4 = new double[iNumRow];
        double[] _Max5 = new double[iNumRow];
        double[] _Max6 = new double[iNumRow];
        double[] _Max7 = new double[iNumRow];
        double[] _Max8 = new double[iNumRow];
        double[] _Max9 = new double[iNumRow];
        double[] _Max10 = new double[iNumRow];
        double[] _Max11 = new double[iNumRow];
        double[] _Max12 = new double[iNumRow];

        double[] _Value1 = new double[iNumRow];
        double[] _Value2 = new double[iNumRow];
        double[] _Value3 = new double[iNumRow];
        double[] _Value4 = new double[iNumRow];
        double[] _Value5 = new double[iNumRow];
        double[] _Value6 = new double[iNumRow];
        double[] _Value7 = new double[iNumRow];
        double[] _Value8 = new double[iNumRow];
        double[] _Value9 = new double[iNumRow];
        double[] _Value10 = new double[iNumRow];
        double[] _Value11 = new double[iNumRow];
        double[] _Value12 = new double[iNumRow];
        double[] _Max_show = new double[iNumRow];
        double[] _Value_show1 = new double[iNumRow];
        double[] _Value_show2 = new double[iNumRow];
        double[] _Value_show3 = new double[iNumRow];
        double[] _Value_show4 = new double[iNumRow];
        double[] _Value_show5 = new double[iNumRow];
        double[] _Value_show6 = new double[iNumRow];
        double[] _Value_show7 = new double[iNumRow];
        double[] _Value_show8 = new double[iNumRow];
        double[] _Value_show9 = new double[iNumRow];
        double[] _Value_show10 = new double[iNumRow];
        double[] _Value_show11 = new double[iNumRow];
        double[] _Value_show12 = new double[iNumRow];

        string[] _Lables = new string[iNumRow];
        double _ymax = _dNummax;
        double _ymin = _dNummin;
        bool _load = false;
        int _index1, _index2, _index3, _index4, _index5, _index6,
            _index7, _index8, _index9, _index10, _index11, _index12;
        int _current_chart = 1;
     //   DataTable dt_Data = null;
        string _txtTit1 = "1st ";
        string _txtTit2 = "2nd ";
        string _txtTit3 = "3rd ";
        string _txtTit4 = "4th ";

        private int idx_form;
        #endregion

        #region Creation
        public FORM_IP_CHAMBER_ZONE(int arg_idx = 0)
        {
            InitializeComponent();
            
            idx_form = arg_idx;
        }
        #endregion


        #region No USE
        public void createChart(WinChartViewer viewer, string img, DataTable vDt)
        {
            try
            {
                Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

                double[] Mindata;
                double[] Maxdata;
                double[] Udata;
                double[] Ldata;
                string[] labels;
                //double Lower_limit, Upper_limit;
                //int Max_val, Min_val;


                //   DataTable vLt = SEL_LIMIT_CHART();
                //   Lower_limit = double.Parse(vLt.Rows[0].ItemArray[0].ToString());
                //  Upper_limit = double.Parse(vLt.Rows[0].ItemArray[1].ToString());

                if (vDt == null || vDt.Rows.Count == 0)
                    return;
                else
                {
                    Mindata = new double[vDt.Rows.Count];
                    Udata = new double[vDt.Rows.Count];
                    Ldata = new double[vDt.Rows.Count];
                    Maxdata = new double[vDt.Rows.Count];
                    labels = new string[vDt.Rows.Count];
                    // Min_val = int.Parse(vDt.Rows[0].ItemArray[5].ToString());
                    // Max_val = int.Parse(vDt.Rows[0].ItemArray[6].ToString());
                    //for (int i = 0; i < vDt.Rows.Count; i++)
                    //{
                    //    if (int.Parse(vDt.Rows[i].ItemArray[5].ToString()) < Min_val)
                    //        Min_val = int.Parse(vDt.Rows[i].ItemArray[5].ToString());

                    //    if (int.Parse(vDt.Rows[i].ItemArray[6].ToString()) > Max_val)
                    //        Max_val = int.Parse(vDt.Rows[i].ItemArray[6].ToString());
                    //}
                    //Maxdata[0] = Chart.NoValue;
                    //Udata[0] = Chart.NoValue;
                    //Ldata[0] = Chart.NoValue;
                    //Mindata[0] = Chart.NoValue;
                    //labels[0] = "";

                    for (int i = 0; i < vDt.Rows.Count; i++)
                    {

                        Udata[i] = Double.Parse(vDt.Rows[i].ItemArray[7].ToString());
                        Ldata[i] = Double.Parse(vDt.Rows[i].ItemArray[8].ToString());

                        if (img == "UP")
                        {
                            Maxdata[i] = Double.Parse(_dtMinMax.Rows[i]["MAX_TUNNEL1"].ToString());
                            Mindata[i] = Double.Parse(_dtMinMax.Rows[i]["MIN_TUNNEL1"].ToString());
                        }
                        else
                        {
                            Maxdata[i] = Double.Parse(_dtMinMax.Rows[i]["MAX_TUNNEL2"].ToString());
                            Mindata[i] = Double.Parse(_dtMinMax.Rows[i]["MIN_TUNNEL2"].ToString());
                        }

                        labels[i] = vDt.Rows[i].ItemArray[4].ToString();
                    }

                    //Maxdata[vDt.Rows.Count + 1] = Chart.NoValue;
                    //Udata[vDt.Rows.Count + 1] = Chart.NoValue;
                    //Ldata[vDt.Rows.Count + 1] = Chart.NoValue;
                    //Mindata[vDt.Rows.Count + 1] = Chart.NoValue;
                    //labels[vDt.Rows.Count + 1] = "";
                }
                vDt.Dispose();

                XYChart c = new XYChart(970, 790, 0xffffff, 0xffffff, 0);
                //  c.setRoundedFrame();
                // Set the plotarea at (55, 58) and of size 520 x 195 pixels, with white (ffffff) background. Set horizontal and vertical grid lines to grey (cccccc).
                c.setPlotArea(70, 90, 800, 550, Chart.Transparent, -1, 0xffffff, 0xffffff);

                // Add a legend box at (55, 32) (top of the chart) with horizontal layout. Use 9 pts Arial Bold font. Set the background and border color to Transparent.
                c.addLegend(800, 10, false, "Calibri Bold", 15).setBackground(Chart.Transparent);

                // Set the labels on the x axis
                c.xAxis().setLabels(labels);
                c.xAxis().setLabelStyle("Calibri Bold", 15);

                // Set the Limit on the x axis
                //      c.yAxis().setLinearScale(Lower_limit, Upper_limit);

                // Set the labels on the y axis
                c.yAxis().setLabelStyle("Calibri Bold", 15);

                // Set the axes width to 2 pixels
                c.xAxis().setWidth(2);
                c.yAxis().setWidth(2);


                // Set the default line width to 2 pixels
                /*LineLayer layer = c.addLineLayer2();
                layer.setLineWidth(10);
                layer.setDataLabelStyle("Calibri Bold", 15);*/

                // Add a data set to the spline layer, using blue (0000c0) as the line color, with yellow (ffff00) circle symbols.
                LineLayer layer = c.addLineLayer2();
                layer.setLineWidth(10);
                layer.addDataSet(Maxdata, 0xffcc00, "MAX").setDataSymbol(Chart.MonotonicNone, 18, 0xffcc00, -1);
                layer.setAggregateLabelStyle("Calibri Bold", 5);

                LineLayer layer3 = c.addLineLayer2();
                layer3.setLineWidth(10);
                layer3.addDataSet(Mindata, 0x9999ff, "MIN").setDataSymbol(Chart.MonotonicNone, 18, 0x9999ff);

                // Add a data set to the spline layer, using blue (0000c0) as the line color, with yellow (ffff00) circle symbols.
                if (img == "UP")
                {
                    LineLayer layer1 = c.addLineLayer2();
                    layer1.setLineWidth(10);
                    layer1.setDataLabelStyle("Calibri Bold", 15);
                    layer1.addDataSet(Udata, 0xff0000, "UPPER").setDataSymbol(Chart.GlassSphere2Shape, 18, -1);

                    ChartDirector.TextBox title1 = c.addTitle("Tunnel 1",
                     "Calibri Bold", 24);
                }
                else
                {
                    LineLayer layer2 = c.addLineLayer2();
                    layer2.setLineWidth(10);
                    layer2.setDataLabelStyle("Calibri Bold", 15);
                    layer2.addDataSet(Ldata, 0x00ff00, "LOWER").setDataSymbol(Chart.GlassSphere2Shape, 19);

                    ChartDirector.TextBox title2 = c.addTitle("Tunnel 2",
                     "Calibri Bold", 24);
                }
                //ArrayMath am = new ArrayMath(Udata);
                //c.yAxis().setLinearScale(0, am.max());
                //layer.addDataSet(am.mul(iPercent / 100.0).result(), 0x0000c0, "UPPER").setDataSymbol(Chart.CircleSymbol, 18, 0xffff00);

                // Add a data set to the spline layer, using brown (982810) as the line color, with pink (f040f0) diamond symbols.


                // Add a data set to the spline layer, using blue (0000c0) as the line color, with yellow (ffff00) circle symbols.




                //ArrayMath an = new ArrayMath(Ldata);
                //c.yAxis().setLinearScale(0, an.max());
                //layer.addDataSet(an.mul(iPercent / 100.0).result(), 0x982810, "LOWER").setDataSymbol(Chart.DiamondSymbol, 19, 0xf040f0);

                // Output the chart
                viewer.Chart = c;
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void create_grid(AxFPSpreadADO.AxfpSpread arg_grid)
        {
            arg_grid.Reset();

            arg_grid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
            arg_grid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            arg_grid.DisplayRowHeaders = false;
            arg_grid.DisplayColHeaders = false;
            arg_grid.set_RowHeight(1, 60);
            arg_grid.set_RowHeight(2, 30);
            arg_grid.Font = new Font("Calibri Bold", 15.25F, FontStyle.Bold);



            arg_grid.RowsFrozen = 1;
            arg_grid.Row = 1;
            arg_grid.BackColor = Color.DeepSkyBlue;
            arg_grid.ForeColor = Color.White;
            arg_grid.Font = new Font("Calibri", 20.25F, FontStyle.Bold);
            arg_grid.CellType = CellTypeConstants.CellTypeEdit;
            arg_grid.TypeEditMultiLine = true;
            arg_grid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            arg_grid.Row = 2;
            arg_grid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;



            arg_grid.SetCellBorder(1, 1, 6, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            arg_grid.SetCellBorder(1, 1, 6, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            arg_grid.SetCellBorder(1, 1, 6, 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

        }


        private void SearchData()
        {
            try
            {
                create_grid(axfChamber1);

                for (int i = 0; i < _dtMinMax.Rows.Count; i++)
                {

                    axfChamber1.SetText(i + 1, 1, _dtMinMax.Rows[i]["MC"] + "\n(" + _dtMinMax.Rows[i]["MAX_TUNNEL1"] + " ~ " + _dtMinMax.Rows[i]["MIN_TUNNEL1"] + ")");
                    axfChamber1.set_ColWidth(i + 1, 20);
                    //axfChamber2.SetText(i + 1, 0, _dtMinMax.Rows[i]["MC"] + "\n(" + _dtMinMax.Rows[i]["MAX_TUNNEL1"] + " ~ " + _dtMinMax.Rows[i]["MIN_TUNNEL1"] + ")");
                }

                //  axfChamber1.SetText(1, 0, "aaaa");

                //for (int i = 0; i < _dtData.Rows.Count; i++)
                //{
                //    axfChamber1.SetText(i + 1, 2, _dtData.Rows[i][""].ToString());
                //}

                //DataTable vDt = SEL_GRID_HEAD();
                //int tot_row = vDt.Rows.Count;
                //int col = 2;
                //if (vDt == null)
                //    return;
                //if (vDt.Rows.Count > 0)
                //{
                //    //axfp_view.MaxRows = vDt.Rows.Count + 1;
                //    for (int j = 1; j < 7; j++)
                //    {
                //        axfChamber1.SetText(col, 1, vDt.Rows[0].ItemArray[j - 1].ToString());
                //        if (col < axfChamber1.MaxCols - 1)
                //            col = col + 2;
                //    }
                //}


                //axfChamber1.Row = 2;
                //axfChamber1.BackColor = Color.DeepSkyBlue;

                //axfChamber1.Col = 1;
                //axfChamber1.set_ColWidth(1, 0);
                //for (int c = 2; c <= axfChamber1.MaxCols; c++)
                //    axfChamber1.set_ColWidth(c, 19.71);

                //vDt.Dispose();

                //DataTable vDt2 = SEL_GRID_DATA();
                //if (vDt2.Rows.Count > 0)
                //{
                //    for (int i = 1; i <= axfChamber1.MaxCols; i++)
                //    {
                //        axfChamber1.SetText(i, 3, vDt2.Rows[0].ItemArray[i - 1].ToString());
                //    }
                //}
                //vDt2.Dispose();
            }
            catch (Exception)
            {

                throw;
            }


        }
        #endregion NO USE

        #region Method
        //public void createChart(WinChartViewer viewer, string img, int iPercent)
       

        public void createChartChamper(WinChartViewer viewer, string img, double[] value, double[] max, double[] min, double[] max_w, double[] min_w)
        {

           // if (dataValueExtruder == null) return;
            //if (img !="")
            //    add_data(img);

            XYChart c = new XYChart(310, 345);
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

            //c.setPlotArea(30, 10, 260, 350, c.linearGradientColor(0, 55, 0,
            //    c.getHeight() - 35, 0xf0f6ff, 0xa0c0ff), -1, Chart.Transparent, 0xffffff, 0xffffff);

            c.setPlotArea(25, 10, 260, 315, Chart.Transparent, -1, Chart.Transparent, 0xffffff, 0xffffff);


            c.setBorder(10);
             c.addLegend(30, 2, false, "Calibri Bold", 8).setBackground(Chart.Transparent);
            

            c.xAxis().setLabels(_Lables);

            c.xAxis().setTickOffset(0.5);

            // Set axis label style to 8pts Arial Bold
         //   c.xAxis().setLabelStyle("Arial Bold", 8);
            c.yAxis().setLabelStyle("Arial Bold", 8);


            // Set axis line width to 2 pixels
            c.xAxis().setWidth(2);
            c.yAxis().setWidth(2);
            c.yAxis().setLinearScale(40, 95);
            //if (img != "")
            //{
            //    _ymin = _dNummin;
            //    _ymax = _dNummax;
            //}
            

            // Add a line layer for the pareto line
            LineLayer lineLayer = c.addLineLayer();
            lineLayer.addDataSet(value, 0x267f00, "Actual").setDataSymbol(
                                      Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

            //if (img == "")
            //    lineLayer.addDataSet(_Value_show, 0x267f00, "Actual").setDataSymbol(
            //                          Chart.NoShape, 9, 0xFF006E, 0x4CFF00);
            //else
            //    lineLayer.addDataSet(_Value, 0x267f00, "Actual").setDataSymbol(
            //                          Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

          //  c.setClipping();
            // Set the line width to 2 pixel
            lineLayer.setLineWidth(5);


            // Add a line layer for the pareto line
            LineLayer lineLayer1 = c.addLineLayer();
            lineLayer1.addDataSet(max, 0xff0000, "USL").setDataSymbol(Chart.NoShape, 18, 0xffcc00, -1);            
            //// Set the line width to 2 pixel
            lineLayer1.setLineWidth(5);


            LineLayer lineLayer2 = c.addLineLayer();
            lineLayer2.addDataSet(min, 0xff0000, "LSL").setDataSymbol(Chart.NoShape, 18, 0x9999ff);
            //// Set the line width to 2 pixel
            lineLayer2.setLineWidth(5);



            LineLayer lineLayer3 = c.addLineLayer();
            lineLayer3.addDataSet(max_w, 0xFFFF00, "UCL").setDataSymbol(Chart.NoShape, 18, 0x9999ff);
            //// Set the line width to 2 pixel
            lineLayer3.setLineWidth(5);

            LineLayer lineLayer4 = c.addLineLayer();
            lineLayer4.addDataSet(min_w, 0xFFFF00, "LCL").setDataSymbol(Chart.NoShape, 18, 0x9999ff);
            //// Set the line width to 2 pixel
            lineLayer4.setLineWidth(5);

            //SplineLayer lineLayer2Near = c.addSplineLayer();

            //lineLayer2Near.addDataSet(dataNearMaxExtruder, 0xFFFF00, "UWL").setDataSymbol(
            //    Chart.NoShape, 9, 0xFF006E, 0x4CFF00);

            //// Set the line width to 2 pixel
            //lineLayer2Near.setLineWidth(3);


            //c.addInterLineLayer(lineLayer1.getLine(0), lineLayer2.getLine(0), unchecked((int)0xFFFFFF), unchecked((int)0xFFFFFF));

            //c.addInterLineLayer(lineLayer.getLine(0), lineLayer1.getLine(0), 0xFF0000, Chart.Transparent);

            //c.addInterLineLayer(lineLayer.getLine(0), lineLayer2.getLine(0),
            //    Chart.Transparent, 0xFF0000);

            //trackLineLegend(c, viewer.IsMouseOnPlotArea ? viewer.PlotAreaMouseX :
            //    c.getPlotArea().getRightX());

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='{dataSetName} on {xLabel}: {value}'");
        }

        private void trackLineLegend(XYChart c, int mouseX)
        {
            // Clear the current dynamic layer and get the DrawArea object to draw on it.
            DrawArea d = c.initDynamicLayer();

            // The plot area object
            PlotArea plotArea = c.getPlotArea();

            // Get the data x-value that is nearest to the mouse, and find its pixel coordinate.
            double xValue = c.getNearestXValue(mouseX);
            int xCoor = c.getXCoor(xValue);

            // Draw a vertical track line at the x-position
            d.vline(plotArea.getTopY(), plotArea.getBottomY(), xCoor, d.dashLineColor(0x000000, 0x0101));

            // Container to hold the legend entries
            ArrayList legendEntries = new ArrayList();

            // Iterate through all layers to build the legend array
            for (int i = 0; i < c.getLayerCount(); ++i)
            {
                Layer layer = c.getLayerByZ(i);

                // The data array index of the x-value
                int xIndex = layer.getXIndexOf(xValue);

                // Iterate through all the data sets in the layer
                for (int j = 0; j < layer.getDataSetCount(); ++j)
                {
                    ChartDirector.DataSet dataSet = layer.getDataSetByZ(j);

                    // We are only interested in visible data sets with names
                    string dataName = dataSet.getDataName();
                    int color = dataSet.getDataColor();
                    if ((!string.IsNullOrEmpty(dataName)) && (color != Chart.Transparent))
                    {
                        // Build the legend entry, consist of the legend icon, name and data value.
                        double dataValue = dataSet.getValue(xIndex);
                        legendEntries.Add("<*block*>" + dataSet.getLegendIcon() + " " + dataName + ": " + ((
                            dataValue == Chart.NoValue) ? "N/A" : c.formatValue(dataValue, "{value|P4}")) +
                            "<*/*>");

                        // Draw a track dot for data points within the plot area
                        int yCoor = c.getYCoor(dataSet.getPosition(xIndex), dataSet.getUseYAxis());
                        if ((yCoor >= plotArea.getTopY()) && (yCoor <= plotArea.getBottomY()))
                        {
                            d.circle(xCoor, yCoor, 4, 4, color, color);
                        }
                    }
                }
            }

            // Create the legend by joining the legend entries
            legendEntries.Reverse();
            string legendText = "<*block,maxWidth=" + plotArea.getWidth() + "*><*block*><*font=Arial Bold*>["
                 + c.xAxis().getFormattedLabel(xValue, "hh:nn:ss.ff") + "]<*/*>        " + String.Join(
                "        ", (string[])legendEntries.ToArray(typeof(string))) + "<*/*>";

            // Display the legend on the top of the plot area
            TTFText t = d.text(legendText, "Arial", 8);
            t.draw(plotArea.getLeftX() + 5, plotArea.getTopY() - 3, 0x000000, Chart.BottomLeft);
        }

        #endregion

        #region Event
        private void FORM_IP_CHAMBER_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            try
            {
               
                

                
                //timer1.Interval = 45000;
               // timer1.Start();
                timer2.Interval = 1000;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));

               // axfChamber1.Size = new System.Drawing.Size(1922, 239);

                GoFullscreen(true);

                _dtMinMax = SEL_DATA_MIN_MAX(ucZone.GetValue());
                _dtData = SEL_DATA_CHAMPER(ucZone.GetValue());
                lblTitle.Text = "TEMPERATURE FOR IP AGING CHAMBER-ZONE " + Convert.ToInt32(ucZone.GetValue());

                Control_Show();

                timer1.Interval = 10;
                timer3.Interval = 10;
                timer4.Interval = 10;
                timer5.Interval = 10;
                timer6.Interval = 10;
                timer7.Interval = 10;
                timer8.Interval = 10;
                timer9.Interval = 10;
                timer10.Interval = 10;
                timer11.Interval = 10;
                timer12.Interval = 10;
                timer13.Interval = 10;
            }
            catch (System.Exception )
            {
                throw;
            }
        }


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

        public void Control_Show()
        {
            try
            {
                if (_dtMinMax == null) return;
                lbl_1L.Text = "(" + _dtMinMax.Rows[0]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[0]["MIN_TUNNEL"].ToString() + ")";
                lbl_1U.Text = "(" + _dtMinMax.Rows[1]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[1]["MIN_TUNNEL"].ToString() + ")";
                lbl_2L.Text = "(" + _dtMinMax.Rows[2]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[2]["MIN_TUNNEL"].ToString() + ")";
                lbl_2U.Text = "(" + _dtMinMax.Rows[3]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[3]["MIN_TUNNEL"].ToString() + ")";
                lbl_3L.Text = "(" + _dtMinMax.Rows[4]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[4]["MIN_TUNNEL"].ToString() + ")";
                lbl_3U.Text = "(" + _dtMinMax.Rows[5]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[5]["MIN_TUNNEL"].ToString() + ")";
                lbl_4L.Text = "(" + _dtMinMax.Rows[6]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[6]["MIN_TUNNEL"].ToString() + ")";
                lbl_4U.Text = "(" + _dtMinMax.Rows[7]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[7]["MIN_TUNNEL"].ToString() + ")";
                lbl_5L.Text = "(" + _dtMinMax.Rows[8]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[8]["MIN_TUNNEL"].ToString() + ")";
                lbl_5U.Text = "(" + _dtMinMax.Rows[9]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[9]["MIN_TUNNEL"].ToString() + ")";
                lbl_6L.Text = "(" + _dtMinMax.Rows[10]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[10]["MIN_TUNNEL"].ToString() + ")";
                lbl_6U.Text = "(" + _dtMinMax.Rows[11]["MAX_TUNNEL"].ToString() + " ~ " + _dtMinMax.Rows[11]["MIN_TUNNEL"].ToString() + ")";

                if (_dtData == null || _dtData.Rows.Count == 0) return;

                //chartViewerUpper1.Hide();
                //chartViewerUpper2.Hide();
                //chartViewerUpper3.Hide();
                //chartViewerUpper4.Hide();
                //chartViewerUpper5.Hide();
                //chartViewerUpper6.Hide();
                //chartViewerLower1.Hide();
                //chartViewerLower2.Hide();
                //chartViewerLower3.Hide();
                //chartViewerLower4.Hide();
                //chartViewerLower5.Hide();
                //chartViewerLower6.Hide();

                //createChartChamper(chartViewerUpper1, "1U");
                //createChartChamper(chartViewerUpper2, "2U");
                //createChartChamper(chartViewerUpper3, "3U");
                //createChartChamper(chartViewerUpper4, "4U");
                //createChartChamper(chartViewerUpper5, "5U");
                //createChartChamper(chartViewerUpper6, "6U");
                //createChartChamper(chartViewerLower1, "1L");
                //createChartChamper(chartViewerLower2, "2L");
                //createChartChamper(chartViewerLower3, "3L");
                //createChartChamper(chartViewerLower4, "4L");
                //createChartChamper(chartViewerLower5, "5L");
                //createChartChamper(chartViewerLower6, "6L");
                

                add_data("1U", ref _Value1, ref _Max1, ref _Min1, ref _Max1_w, ref _Min1_w);
                timer1.Start();
                add_data("2U", ref _Value2, ref _Max2, ref _Min2, ref _Max2_w, ref _Min2_w);
                timer3.Start();
                add_data("3U", ref _Value3, ref _Max3, ref _Min3, ref _Max3_w, ref _Min3_w);
                timer4.Start();
                add_data("4U", ref _Value4, ref _Max4, ref _Min4, ref _Max4_w, ref _Min4_w);
                timer5.Start();
                add_data("5U", ref _Value5, ref _Max5, ref _Min5, ref _Max5_w, ref _Min5_w);
                timer6.Start();
                add_data("6U", ref _Value6, ref _Max6, ref _Min6, ref _Max6_w, ref _Min6_w);
                timer7.Start();
                add_data("1L", ref _Value7, ref _Max7, ref _Min7, ref _Max7_w, ref _Min7_w);
                timer8.Start();
                add_data("2L", ref _Value8, ref _Max8, ref _Min8, ref _Max8_w, ref _Min8_w);
                timer9.Start();
                add_data("3L", ref _Value9, ref _Max9, ref _Min9, ref _Max9_w, ref _Min9_w);
                timer10.Start();
                add_data("4L", ref _Value10, ref _Max10, ref _Min10, ref _Max10_w, ref _Min10_w);
                timer11.Start();
                add_data("5L", ref _Value11, ref _Max11, ref _Min11, ref _Max11_w, ref _Min11_w);
                timer12.Start();
                add_data("6L", ref _Value12, ref _Max12, ref _Min12, ref _Max12_w, ref _Min12_w);
                timer13.Start();

                



                
                //showAnimation(this.chartViewerUpper2);
                //showAnimation(this.chartViewerUpper3);
                //showAnimation(this.chartViewerUpper4);
                //showAnimation(this.chartViewerUpper5);
                //showAnimation(this.chartViewerUpper6);
                //showAnimation(this.chartViewerLower1);
                //showAnimation(this.chartViewerLower2);
                //showAnimation(this.chartViewerLower3);
                //showAnimation(this.chartViewerLower4);
                //showAnimation(this.chartViewerLower5);
                //showAnimation(this.chartViewerLower6);

            }
            catch (Exception)
            {
                
                
            }
        }

        private void showAnimation(ChartDirector.WinChartViewer flg)
        {
            flg.Hide();
            //IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(flg.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("1"));
            flg.Show();
        }



        private void add_data(string arg_champer, ref double[] arg_value, ref double[] max, ref double[] min, ref double[] max_w, ref double[] min_w)
        {
            string strChamper = arg_champer;
            if (arg_champer == "")
            {
                switch (_current_chart)
                {
                    case 1:
                        arg_champer = "1U";
                        break;
                    case 2:
                        arg_champer = "2U";
                        break;
                    case 3:
                        arg_champer = "3U";
                        break;
                    case 4:
                        arg_champer = "4U";
                        break;
                    case 5:
                        arg_champer = "5U";
                        break;
                    case 6:
                        arg_champer = "6U";
                        break;
                    case 7:
                        arg_champer = "1L";
                        break;
                    case 8:
                        arg_champer = "2L";
                        break;
                    case 9:
                        arg_champer = "3L";
                        break;
                    case 10:
                        arg_champer = "4L";
                        break;
                    case 11:
                        arg_champer = "5L";
                        break;
                    case 12:
                        arg_champer = "6L";
                        break;
                }
            }

            int irow1 = 0;
            for (int i = 0; i < _dtData.Rows.Count; i++)
            {
                if (_dtData.Rows[i]["up_down"].ToString() == arg_champer)
                {
                    arg_value[irow1] = _dtData.Rows[i]["act_temp"].ToString() == null ? 0 : Convert.ToDouble(_dtData.Rows[i]["act_temp"].ToString());

                    if (_Value1[irow1] > _ymax) _ymax = _Value1[irow1];
                    if (_Value1[irow1] < _ymin) _ymin = _Value1[irow1];


                   // if (strChamper != "") _Value[irow1] = Chart.NoValue;

                    _Lables[irow1] = _dtData.Rows[i]["TI"].ToString() == null ? "" : _dtData.Rows[i]["TI"].ToString();

                    //if (irow1 % 3 == 1)
                    //{
                    //    _Lables[irow1] = _dtData.Rows[i]["TI"].ToString() == null ? "" : _dtData.Rows[i]["TI"].ToString();
                    //}
                    //else
                    //{
                    //    _Lables[irow1] = "";
                    //}
                    irow1++;
                }
            }

            for (int i = 0; i < _dtMinMax.Rows.Count; i++)
            {
                if (_dtMinMax.Rows[i]["MC"].ToString() == arg_champer)
                {
                    for (int j = 0; j < iNumRow; j++)
                    {
                        max[j] = _dtMinMax.Rows[i]["MAX_TUNNEL"].ToString() == null ? 0 : Convert.ToDouble(_dtMinMax.Rows[i]["MAX_TUNNEL"].ToString());
                        min[j] = _dtMinMax.Rows[i]["MIN_TUNNEL"].ToString() == null ? 0 : Convert.ToDouble(_dtMinMax.Rows[i]["MIN_TUNNEL"].ToString());
                        max_w[j] = max[j] - 1;
                        min_w[j] = min[j] + 1;
                    }

                    if (_Max1[0] > _ymax) _ymax = _Max1[0];
                    if (_Min1[0] < _ymin) _ymin = _Min1[0];
                }
            }
            
        }



        
        private DataTable SEL_LIMIT_CHART()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_ip_roll_chamber.sel_limit_chart";

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
        private DataTable SEL_DATA_CHART()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_ip_roll_chamber.sel_data_chamber_chart";

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

        private DataTable SEL_GRID_HEAD()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_ip_roll_chamber.sel_title_chamber_grid";

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

        private DataTable SEL_GRID_DATA()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_ip_roll_chamber.sel_data_chamber_grid";

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

        private DataTable SEL_DATA_MIN_MAX(string ARG_ZONE_CD)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_B2_IP.SEL_DATA_MIN_MAX";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_ZONE_CD";

            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = ARG_ZONE_CD;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable SEL_DATA_CHAMPER(string ARG_ZONE_CD)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_B2_IP.SEL_DATA_CHAMPER";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_ZONE_CD";

            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC
            MyOraDB.Parameter_Type[0] =  (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = ARG_ZONE_CD;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }
        /// <summary>
        /// 상세보기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// 최소화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /// <summary>
        /// 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private void MergeCol(AxFPSpreadADO.AxfpSpread gridObject, int iStartRow, int iCol)
        {
            try
            {
                string sTemp1 = "";
                string sTemp2 = "";
                int iRow = iStartRow;
                gridObject.Row = iStartRow;
                gridObject.Col = iCol;
                sTemp1 = gridObject.Value;
                for (int i = iStartRow; i < gridObject.MaxRows + 4; i++)
                {
                    gridObject.Row = i;
                    gridObject.Col = iCol;
                    sTemp2 = gridObject.Value;
                    if (sTemp1 != sTemp2)
                    {
                        gridObject.AddCellSpan(iCol, iRow, 1, i - iRow);
                        sTemp1 = sTemp2;
                        sTemp2 = "";
                        iRow = i;
                    }
                }
            }
            catch (Exception )
            {
              //  MessageBox.Show(ex.ToString());
            }
        }

        private void next_form()
        {
          //  Application.Run(new IPEX_Monitor.FORM_KNEADER_TEMPERATURE_STATUS());
        }
        private void pre_form()
        {
            //Com_Base.Variables.frm_show = 8;
            //Application.Run(new IPEX_Monitor.Frm_Mold_Show_TV());
        }

        private void blink(Button arg_cmd, bool arg_status)
        {
            if (arg_status == false)
            {
                if (arg_cmd.BackColor == Color.Red)
                {
                    arg_cmd.BackColor = Color.White;
                }
                else
                {
                    arg_cmd.BackColor = Color.Red;
                }
            }
        }

        public bool IsNumeric(string text)
        {
            return Regex.IsMatch(text, "^\\d+$");
        }

        private void check_button(bool status, int arg_chart)
        {
            if (status)
            {
                switch (arg_chart)
                {
                    case 1:
                        cmd_Alarm1U.BackColor = Color.Green;
                        b1U = true;
                        break;
                    case 2:
                        cmd_Alarm2U.BackColor = Color.Green;
                        b2U = true;
                        break;
                    case 3:
                        cmd_Alarm3U.BackColor = Color.Green;
                        b3U = true;
                        break;
                    case 4:
                        cmd_Alarm4U.BackColor = Color.Green;
                        b4U = true;
                        break;
                    case 5:
                        cmd_Alarm5U.BackColor = Color.Green;
                        b5U = true;
                        break;
                    case 6:
                        cmd_Alarm6U.BackColor = Color.Green;
                        b6U = true;
                        break;
                    case 7:
                        cmd_Alarm1L.BackColor = Color.Green;
                        b1L = true;
                        break;
                    case 8:
                        cmd_Alarm2L.BackColor = Color.Green;
                        b2L = true;
                        break;
                    case 9:
                        cmd_Alarm3L.BackColor = Color.Green;
                        b3L = true;
                        break;
                    case 10:
                        cmd_Alarm4L.BackColor = Color.Green;
                        b4L = true;
                        break;
                    case 11:
                        cmd_Alarm5L.BackColor = Color.Green;
                        b5L = true;
                        break;
                    case 12:
                        cmd_Alarm6L.BackColor = Color.Green;
                        b6L = true;
                        break;
                }
            }
            else
            {
                switch (arg_chart)
                {
                    case 1:
                        cmd_Alarm1U.BackColor = Color.Red;
                        b1U = false;
                        break;
                    case 2:
                        cmd_Alarm2U.BackColor = Color.Red;
                        b2U = false;
                        break;
                    case 3:
                        cmd_Alarm3U.BackColor = Color.Red;
                        b3U = false;
                        break;
                    case 4:
                        cmd_Alarm4U.BackColor = Color.Red;
                        b4U = false;
                        break;
                    case 5:
                        cmd_Alarm5U.BackColor = Color.Red;
                        b5U = false;
                        break;
                    case 6:
                        cmd_Alarm6U.BackColor = Color.Red;
                        b6U = false;
                        break;
                    case 7:
                        cmd_Alarm1L.BackColor = Color.Red;
                        b1L = false;
                        break;
                    case 8:
                        cmd_Alarm2L.BackColor = Color.Red;
                        b2L = false;
                        break;
                    case 9:
                        cmd_Alarm3L.BackColor = Color.Red;
                        b3L = false;
                        break;
                    case 10:
                        cmd_Alarm4L.BackColor = Color.Red;
                        b4L = false;
                        break;
                    case 11:
                        cmd_Alarm5L.BackColor = Color.Red;
                        b5L = false;
                        break;
                    case 12:
                        cmd_Alarm6L.BackColor = Color.Red;
                        b6L = false;
                        break;
                }
            }
        }

        private void check_chart(int arg_chart)
        {
            switch (arg_chart)
            {
                case 1:
                    chartViewerUpper1.updateViewPort(true, false);
                    break;
                case 2:
                    chartViewerUpper2.updateViewPort(true, false);
                    break;
                case 3:
                    chartViewerUpper3.updateViewPort(true, false);
                    break;
                case 4:
                    chartViewerUpper4.updateViewPort(true, false);
                    break;
                case 5:
                    chartViewerUpper5.updateViewPort(true, false);
                    break;
                case 6:
                    chartViewerUpper6.updateViewPort(true, false);
                    break;
                case 7:
                    chartViewerLower1.updateViewPort(true, false);
                    break;
                case 8:
                    chartViewerLower2.updateViewPort(true, false);
                    break;
                case 9:
                    chartViewerLower3.updateViewPort(true, false);
                    break;
                case 10:
                    chartViewerLower4.updateViewPort(true, false);
                    break;
                case 11:
                    chartViewerLower5.updateViewPort(true, false);
                    break;
                case 12:
                    chartViewerLower6.updateViewPort(true, false);
                    break;
            }
        }


        private void chart_data_load( ref int index, int arg_chart, double[] value, ref double[] value_show, double max, double min)
        {
            for (int i = 0; i < iNumRow; i++)
            {
                if (i == index)
                {
                    value_show[index] = value[index];
                    //_Min_show[_index] = _Min[_index];
                    //_Max_show[_index] = _Max[_index];
                }
                else if (i > index)
                {
                    value_show[i] = Chart.NoValue;
                }
            }

            if (index == iNumRow - 1)
            {
                //double sd = value[index];
                if (value[index] > max || value[index] < min)
                {
                    check_button(false, arg_chart);
                   // sound.PlaySeveral(1, 500);
                    _alarm = true;
                }
                else
                {
                    check_button(true, arg_chart);
                }
            }

            index++;



           
                //_index1 = 0;

                //_ymax = _dNummax;
                //_ymin = _dNummin;
                //if (_current_chart > 12)
                //    arg_timer.Stop();
                //add_data("");


            


        }

   



        private bool checkWindowOpen(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].Show();

                    return false;
                }
            }
            return true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
            blink(cmd_Alarm1L, b1L);
            blink(cmd_Alarm2L, b2L);
            blink(cmd_Alarm3L, b3L);
            blink(cmd_Alarm4L, b4L);
            blink(cmd_Alarm5L, b5L);
            blink(cmd_Alarm6L, b6L);
            blink(cmd_Alarm1U, b1U);
            blink(cmd_Alarm2U, b2U);
            blink(cmd_Alarm3U, b3U);
            blink(cmd_Alarm4U, b4U);
            blink(cmd_Alarm5U, b5U);
            blink(cmd_Alarm6U, b6U);
            _time++;
            if (_time == 25)
            {
                _dtMinMax = SEL_DATA_MIN_MAX(ucZone.GetValue());
                DataTable dt_data = SEL_DATA_CHAMPER(ucZone.GetValue());
                if (dt_data != null || dt_data.Rows.Count > 0)
                {
                    _dtData = dt_data;
                    _index1 = 0;
                    _index2 = 0;
                    _index3 = 0;
                    _index4 = 0;
                    _index5 = 0;
                    _index6 = 0;
                    _index7 = 0;
                    _index8 = 0;
                    _index9 = 0;
                    _index10 = 0;
                    _index11 = 0;
                    _index12 = 0;

                    Control_Show();
                    _time = 0;
                }
                
            }

        }

        private Form frm_parrent = null;

        public void SetParrent(Form _frm)
        {
            frm_parrent = _frm;
        }
        private void lblDate_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            Application.Exit();
        }

        private void tmr_changForm_Tick(object sender, EventArgs e)
        {

            //if (checkWindowOpen("FORM_KNEADER_TEMPERATURE_STATUS"))
            //{
            //    FORM_KNEADER_TEMPERATURE_STATUS frm = new FORM_KNEADER_TEMPERATURE_STATUS();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    this.Hide();
            //}
            //Com_Base.Variables._iskeypress = false;
            //set_time_chage();
        }


        private void FORM_IP_CHAMBER_Activated(object sender, EventArgs e)
        {
            //GoFullscreen(true);
            //Control_Show();
            //set_time_chage();
        }

        private void FORM_IP_CHAMBER_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                _time = 0;
                timer2.Start();
                DataTable dt_minmax = SEL_DATA_MIN_MAX(ucZone.GetValue());
                
                if (dt_minmax != null || dt_minmax.Rows.Count > 0)
                {
                    _dtMinMax = dt_minmax;
                }

                Control_Show();
                if (_load == false)
                {
                    
                    //showAnimation(this.chartViewerUpper1);
                    //showAnimation(this.chartViewerUpper2);
                    //showAnimation(this.chartViewerUpper3);
                    //showAnimation(this.chartViewerUpper4);
                    //showAnimation(this.chartViewerUpper5);
                    //showAnimation(this.chartViewerUpper6);
                    //showAnimation(this.chartViewerLower1);
                    //showAnimation(this.chartViewerLower2);
                    //showAnimation(this.chartViewerLower3);
                    //showAnimation(this.chartViewerLower4);
                    //showAnimation(this.chartViewerLower5);
                    //showAnimation(this.chartViewerLower6);
                    _load = true;
                }
            }
            else
            {
                timer2.Stop();
                timer1.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
                timer9.Stop();
                timer10.Stop();
                timer11.Stop();
                timer12.Stop();
                timer13.Stop();
                _load = false;
                _index1 = 0;
                _index2 = 0;
                _index3 = 0;
                _index4 = 0;
                _index5 = 0;
                _index6 = 0;
                _index7 = 0;
                _index8 = 0;
                _index9 = 0;
                _index10 = 0;
                _index11 = 0;
                _index12 = 0;
                _alarm = false;
            }

        }

        

        private void chartViewerUpperLower_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            switch (_current_chart)
            {
                case 1:
                   // createChartChamper(chartViewerUpper1, "", _Value_show1, _Max1);
                    break;
                case 2:
                   
                    break;
                //case 3:
                //    createChartChamper(chartViewerUpper3, "");
                //    break;
                //case 4:
                //    createChartChamper(chartViewerUpper4, "");
                //    break;
                //case 5:
                //    //  if (chartViewerUpper5.Visible == false) chartViewerUpper5.Visible = true;
                //    createChartChamper(chartViewerUpper5, "");
                //    break;
                //case 6:
                //    createChartChamper(chartViewerUpper6, "");
                //    break;
                //case 7:
                //    createChartChamper(chartViewerLower1, "");
                //    break;
                //case 8:
                //    createChartChamper(chartViewerLower2, "");
                //    break;
                //case 9:
                //    createChartChamper(chartViewerLower3, "");
                //    break;
                //case 10:
                //    createChartChamper(chartViewerLower4, "");
                //    break;
                //case 11:
                //    createChartChamper(chartViewerLower5, "");
                //    break;
                //case 12:
                //    createChartChamper(chartViewerLower6, "");
                //    break;
            }
        }

        



        private void chartViewerUpper2_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerUpper2, "1", _Value_show2, _Max2, _Min2, _Max2_w, _Min2_w);
        }

        private void chartViewerUpper1_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerUpper1, "2", _Value_show1, _Max1, _Min1, _Max1_w, _Min1_w);
        }

        private void chartViewerUpper3_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerUpper3, "3", _Value_show3, _Max3, _Min3, _Max3_w, _Min3_w);
        }

        private void chartViewerUpper4_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerUpper4, "4", _Value_show4, _Max4, _Min4, _Max4_w, _Min4_w);
        }

        private void chartViewerUpper5_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerUpper5, "5", _Value_show5, _Max5, _Min5, _Max5_w, _Min5_w);
        }

        private void chartViewerUpper6_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerUpper6, "6", _Value_show6, _Max6, _Min6, _Max6_w, _Min6_w);
        }

        private void chartViewerLower1_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerLower1, "7", _Value_show7, _Max7, _Min7, _Max7_w, _Min7_w);
        }

        private void chartViewerLower2_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerLower2, "8", _Value_show8, _Max8, _Min8, _Max8_w, _Min8_w);
        }

        private void chartViewerLower3_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerLower3, "9", _Value_show9, _Max9, _Min9, _Max9_w, _Min9_w);
        }

        private void chartViewerLower4_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerLower4, "10", _Value_show10, _Max10, _Min10, _Max10_w, _Min10_w);
        }

        private void chartViewerLower5_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerLower5, "11", _Value_show11, _Max11, _Min11, _Max11_w, _Min11_w);
        }

        private void chartViewerLower6_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            createChartChamper(chartViewerLower6, "12", _Value_show12, _Max12, _Min12, _Max12_w, _Min12_w);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            chart_data_load(ref _index1, 1, _Value1, ref _Value_show1, _Max1[0], _Min1[0]);

            if (_index1 <= iNumRow)
            {

                chartViewerUpper1.updateViewPort(true, false);
            }
            else
            {
                timer1.Stop();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index2, 2, _Value2, ref _Value_show2, _Max2[0], _Min2[0]);

            if (_index2 <= iNumRow)
            {

                chartViewerUpper2.updateViewPort(true, false);
            }
            else
            {
                timer3.Stop();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index3, 3, _Value3, ref _Value_show3, _Max3[0], _Min3[0]);

            if (_index3 <= iNumRow)
            {

                chartViewerUpper3.updateViewPort(true, false);
            }
            else
            {
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index4, 4, _Value4, ref _Value_show4, _Max4[0], _Min4[0]);

            if (_index4 <= iNumRow)
            {

                chartViewerUpper4.updateViewPort(true, false);
            }
            else
            {
                timer5.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index5, 5, _Value5, ref _Value_show5, _Max5[0], _Min5[0]);

            if (_index5 <= iNumRow)
            {

                chartViewerUpper5.updateViewPort(true, false);
            }
            else
            {
                timer6.Stop();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index6, 6, _Value6, ref _Value_show6, _Max6[0], _Min6[0]);

            if (_index6 <= iNumRow)
            {

                chartViewerUpper6.updateViewPort(true, false);
            }
            else
            {
                timer7.Stop();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index7, 7, _Value7, ref _Value_show7, _Max7[0], _Min7[0]);

            if (_index7 <= iNumRow)
            {

                chartViewerLower1.updateViewPort(true, false);
            }
            else
            {
                timer8.Stop();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index8, 8, _Value8, ref _Value_show8, _Max8[0], _Min8[0]);

            if (_index8 <= iNumRow)
            {

                chartViewerLower2.updateViewPort(true, false);
            }
            else
            {
                timer9.Stop();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index9, 9, _Value9, ref _Value_show9, _Max9[0], _Min9[0]);

            if (_index9 <= iNumRow)
            {

                chartViewerLower3.updateViewPort(true, false);
            }
            else
            {
                timer10.Stop();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index10, 10, _Value10, ref _Value_show10, _Max10[0], _Min10[0]);

            if (_index10 <= iNumRow)
            {

                chartViewerLower4.updateViewPort(true, false);
            }
            else
            {
                timer11.Stop();
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index11, 11, _Value11, ref _Value_show11, _Max11[0], _Min11[0]);

            if (_index11 <= iNumRow)
            {

                chartViewerLower5.updateViewPort(true, false);
            }
            else
            {
                timer12.Stop();
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            chart_data_load(ref _index12, 12, _Value12, ref _Value_show12, _Max12[0], _Min12[0]);

            if (_index12 <= iNumRow)
            {

                chartViewerLower6.updateViewPort(true, false);
            }
            else
            {
                timer13.Stop();
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //FORM_POPUP_T frm = new FORM_POPUP_T();
            //frm.Show();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucZone_ValueChangeEvent(object sender, EventArgs e)
        {
            lblTitle.Text = "TEMPERATURE FOR IP AGING CHAMBER-ZONE " + Convert.ToInt32(ucZone.GetValue());
            _dtMinMax = SEL_DATA_MIN_MAX(ucZone.GetValue());
            DataTable dt_data = SEL_DATA_CHAMPER(ucZone.GetValue());
            if (dt_data != null || dt_data.Rows.Count > 0)
            {
                _dtData = dt_data;
                _index1 = 0;
                _index2 = 0;
                _index3 = 0;
                _index4 = 0;
                _index5 = 0;
                _index6 = 0;
                _index7 = 0;
                _index8 = 0;
                _index9 = 0;
                _index10 = 0;
                _index11 = 0;
                _index12 = 0;

                Control_Show();
                _time = 0;
            }
        }
    }
}
