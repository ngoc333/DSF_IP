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
using ChartDirector;
using System.Threading;

namespace OS_DSF
{
    public partial class FORM_DEFFECTIVE_STATUS_V2: Form
    {
        #region Declare
        int iNumRow = 0;
        int iTime = 0;
        int iFirstTime = 0;


        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer2;     
        private AxFPSpreadADO.AxfpSpread axfpSpread;
        private ChartDirector.WinChartViewer chart1;
        private ChartDirector.WinChartViewer chart2;


        DataTable dt_Daily_Report = null;
       
        //Thread th;
       // int _time = 0;
        
        private int idx_form;
        #endregion

        #region Creation
        public FORM_DEFFECTIVE_STATUS_V2(int arg_idx = 0)
        {
            InitializeComponent();
            idx_form = arg_idx;
        }
        #endregion

     

        #region Event
        private void FORM_DEFFECTIVE_STATUS_Load(object sender, EventArgs e)
        {
            try{
               // this.button1.BackgroundImage = global::IPEX_Monitor.Properties.Resources.back7;
                iTime = 0;
                //Com_Base.Functions.Form_Maximized(this, int.Parse(Com_Base.Variables.Form[idx_form]["monitor"]));
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                GoFullscreen();
             //   panel1.BackColor = Color.FromArgb(255, 165, 0);
              //  this.lblDate.BackColor = Color.FromArgb(255, 165,0);

                timer2.Interval = 1000;
               //button1.Visible = false;
                GetData();
 
              
            }
            catch (System.Exception )
            {
               
            }

        }

        private void GoFullscreen()
        {
            //if (fullscreen)
            //{
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //}
        }

        public void createChart(WinChartViewer viewer, DataTable dt_chart, string title)
        {
            // The data for the pie chart
            //dt_chart = this.select_chart_1();
            Chart.setLicenseCode("DEVP-2LSU-B4LX-YCTY-2DF2-77EE");

            double[] data = new double [dt_chart.Rows.Count];
            string[] labels = new string[dt_chart.Rows.Count];

            for (int i = 0; i < dt_chart.Rows.Count ; i++)
            {
                data[i] = Convert.ToDouble(dt_chart.Rows[i]["RATE"].ToString());
                labels[i] = dt_chart.Rows[i]["reason_tail_nm"].ToString();
            }

    

            // The colors to use for the sectors
            int[] colors = {0x66aaee, 0xeebb22, 0xbbbbbb, 0x8844ff, 0xdd2222,
                0x009900, 0xff8040, 0xaa0023};

            // Create a PieChart object of size 600 x 320 pixels. Use a vertical
            // gradient color from light blue (99ccff) to white (ffffff) spanning the
            // top 100 pixels as background. Set border to grey (888888). Use rounded
            // corners. Enable soft drop shadow.
            PieChart c = new PieChart(670, 430);
            c.setBackground(c.linearGradientColor(0, 0, 0, 100, 0x99ccff, 0xffffff),
                0x888888);
            c.setRoundedFrame();
            c.setDropShadow();

            // Add a title using 18 pts Times New Roman Bold Italic font. Add 16
            // pixels top margin to the title.
            c.addTitle(title,
                "Malgun Gothic Bold Italic", 18).setMargin2(0, 0, 16, 0);

            // Set the center of the pie at (160, 165) and the radius to 110 pixels
            c.setPieSize(230, 200, 150);

            // Draw the pie in 3D with a pie thickness of 25 pixels
            c.set3D(25);

            // Set the pie data and the pie labels
            c.setData(data, labels);

            // Set the sector colors
            c.setColors2(Chart.DataColor, colors);

            // Use local gradient shading for the sectors
            c.setSectorStyle(Chart.LocalGradientShading);

            // Use the side label layout method, with the labels positioned 16 pixels
            // from the pie bounding box
            c.setLabelLayout(Chart.Transparent, 16);

            // Show only the sector number as the sector label
            c.setLabelFormat("{percent} % ");

            // Set the sector label style to Arial Bold 10pt, with a dark grey
            // (444444) border
            c.setLabelStyle("Malgun Gothic", 10).setBackground(Chart.Transparent,
                0x444444);

            // Add a legend box, with the center of the left side anchored at (330,
            // 175), and using 10 pts Arial Bold Italic font
            LegendBox b = new LegendBox();
            b = c.addLegend(450, 195, true, "Malgun Gothic Bold Italic", 12);
            b.setAlignment(Chart.Left);

            // Set the legend box border to dark grey (444444), and with rounded
            // conerns
            b.setBackground(Chart.Transparent, 0x444444);
            b.setRoundedCorners();

            // Set the legend box margin to 16 pixels, and the extra line spacing
            // between the legend entries as 5 pixels
            b.setMargin(16);
            b.setKeySpacing(0, 5);

            // Set the legend box icon to have no border (border color same as fill
            // color)
            b.setKeyBorder(Chart.SameAsMainColor);

            // Set the legend text to show the sector number, followed by a 120
            // pixels wide block showing the sector label, and a 40 pixels wide block
            // showing the percentage
            b.setText(
                "<*block,valign=top*> <*advanceTo=22*>" +
                "<*block,width=140*>{label}<*/*>");

            // Output the chart
            viewer.Chart = c;

            //include tool tip for the chart
            viewer.ImageMap = c.getHTMLImageMap("clickable", "",
                "title='{label}: {percent} % '");
        }
       
      
        private Color SetColorGrid(string strValue)
        {           
            try
            {         
                switch (strValue)
                {
                    case "RED" :
                        return Color.Red;
                   
                    case "WHITE":
                        return Color.White;
                       
                    case "YELLOW":
                        return Color.Yellow;
                       
                    case "GREEN":
                        return Color.Green;
                       
                    case "BLUE":
                        return Color.Blue;
                       
                    case  "DodgerBlue":
                        return Color.DodgerBlue;
                       

                    case "BLACK":
                        return Color.Black;
                       
                    case "TOTAL_COL":
                        return Color.FromArgb(255,255,196) ;
                       
                }
                return Color.White;
                 
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.ToString());
                return Color.Red;
            }
        }
        private Color getColor(string strValue)
        {

            try
            {
                if (strValue.Trim().Equals(""))
                    return Color.Red;

                string[] s = strValue.Split('/');

                if (s[0].ToString().Trim() == s[1].ToString().Trim())
                {
                    return Color.SeaGreen;
                }
                return Color.SkyBlue;
            }
            catch (Exception )
            {
                
                //MessageBox.Show(ex.ToString());
                return Color.Red;
            }
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void menu1_buttonClicked()
        {

        }

        private void InitGridHeader()
        {

            for (int i = 5; i <= 31; i++)
            {
                this.axfpSpread.SetText(i, 1, "DATE_" + (i - 4).ToString());
            }
            DataTable dt = null;
            dt = select_work_date(UC_MONTH.GetValue());
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.axfpSpread.SetText(i + 5, 1, dt.Rows[i]["THEDATE"].ToString());
                }

                axfpSpread.LeftCol = dt.Rows.Count - 1;
                

            }
            for (int i = 5; i <= 31; i++)
            {
                string sHeader = "";
                axfpSpread.Col = i;
                axfpSpread.Row = 1;
                sHeader = axfpSpread.Value.ToString();
                if (sHeader.Contains("DATE_"))
                {
                    axfpSpread.set_ColWidth(i, 0);

                }
                else
                {
                    axfpSpread.set_ColWidth(i, 10.37);
                }
            }


           
        }


        private DataTable select_work_date(string arg_month)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_DMP_DMC.SELECT_WORK_DATE";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MONTH";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }

        private DataTable select_deffect_monitor(string arg_month)
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_B2_IP.SELECT_DEFFECT_MONITOR_V2";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MONTH";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }


        private string FormatData(object arg_obj)
        {
            try
            {
                if (arg_obj != null && arg_obj.ToString() != "0")
                {
                    return Convert.ToDouble(arg_obj).ToString("#,###,##0.##");
                }
                else
                {
                    return "";
                }

            }
            catch (Exception)
            {
                return "";
            }

        }

        private void Search_Daily_Report()
        {
            try
            {

                double[] total = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                //  DataTable dt = null;

                // dt = null;

                InitGridHeader();

                DataTable dt = select_deffect_monitor(UC_MONTH.GetValue());

                if (dt != null && dt.Rows.Count > 1)
                {
                    iNumRow = dt.Rows.Count;
                    dt_Daily_Report = dt;
                    axfpSpread.ClearRange(1, 2, axfpSpread.MaxCols, axfpSpread.MaxRows, true);
                    //   axfDailyReport_Header.Visible = false;
                    axfpSpread.Row = dt.Rows.Count + 2;
                    axfpSpread.BackColor = Color.Lime;

                    if (dt_Daily_Report != null && dt_Daily_Report.Rows.Count > 1)
                    {
                        for (int i = 0; i < dt_Daily_Report.Rows.Count; i++)
                        {
                            //  string sFormat = "#,###,##0.##";
                            //if (dt_Daily_Report.Rows[i]["remark"].ToString() == "10"
                            //    || dt_Daily_Report.Rows[i]["remark"].ToString() == "20"
                            //    || dt_Daily_Report.Rows[i]["remark"].ToString() == "30")
                            //{
                            //    axfpSpread.Row = i + 2;
                            //    axfpSpread.Col = 4;
                            //    axfpSpread.TypeHAlign = TypeHAlignConstants.TypeHAlignLeft;
                            //}
                            axfpSpread.set_RowHeight(i + 2, 20.5);

                            this.axfpSpread.SetText(1, i + 2, dt_Daily_Report.Rows[i]["LEV"].ToString());
                            this.axfpSpread.SetText(2, i + 2, dt_Daily_Report.Rows[i]["PROCESS_NM"].ToString().Replace(" ", "\n"));
                            this.axfpSpread.SetText(3, i + 2, dt_Daily_Report.Rows[i]["REASON_HEAD_NM"].ToString());
                            this.axfpSpread.SetText(4, i + 2, dt_Daily_Report.Rows[i]["REASON_TAIL_NM"].ToString());
                            this.axfpSpread.SetText(5, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_1"]));
                            this.axfpSpread.SetText(6, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_2"]));
                            this.axfpSpread.SetText(7, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_3"]));
                            this.axfpSpread.SetText(8, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_4"]));
                            this.axfpSpread.SetText(9, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_5"]));
                            this.axfpSpread.SetText(10, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_6"]));
                            this.axfpSpread.SetText(11, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_7"]));
                            this.axfpSpread.SetText(12, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_8"]));
                            this.axfpSpread.SetText(13, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_9"]));
                            this.axfpSpread.SetText(14, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_10"]));
                            this.axfpSpread.SetText(15, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_11"]));
                            this.axfpSpread.SetText(16, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_12"]));
                            this.axfpSpread.SetText(17, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_13"]));
                            this.axfpSpread.SetText(18, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_14"]));
                            this.axfpSpread.SetText(19, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_15"]));
                            this.axfpSpread.SetText(20, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_16"]));
                            this.axfpSpread.SetText(21, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_17"]));
                            this.axfpSpread.SetText(22, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_18"]));
                            this.axfpSpread.SetText(23, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_19"]));
                            this.axfpSpread.SetText(24, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_20"]));
                            this.axfpSpread.SetText(25, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_21"]));
                            this.axfpSpread.SetText(26, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_22"]));
                            this.axfpSpread.SetText(27, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_23"]));
                            this.axfpSpread.SetText(28, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_24"]));
                            this.axfpSpread.SetText(29, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_25"]));
                            this.axfpSpread.SetText(30, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_26"]));
                            this.axfpSpread.SetText(31, i + 2, FormatData(dt_Daily_Report.Rows[i]["DATE_27"]));
                            this.axfpSpread.SetText(32, i + 2, FormatData(dt_Daily_Report.Rows[i]["TOT"]));


                            if (dt_Daily_Report.Rows[i]["REASON_TAIL_CD"].ToString().Substring(0, 3) == "RAT")
                            {
                                for (int j = 3; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.DodgerBlue;

                                }

                            }
                            else if (dt_Daily_Report.Rows[i]["REASON_TAIL_CD"].ToString().Substring(0, 3) == "TOT")
                            {
                                for (int j = 4; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.Yellow;
                                    if (j >= 5 && j <= 35)
                                    {
                                        total[j - 5] += axfpSpread.Text == "" ? 0 : Convert.ToDouble(axfpSpread.Text);
                                    }

                                }

                            }
                            else
                            {
                                for (int j = 1; j < dt_Daily_Report.Columns.Count; j++)
                                {
                                    axfpSpread.Col = j;
                                    axfpSpread.Row = i + 2;
                                    axfpSpread.BackColor = Color.White;

                                }
                            }



                        }
                        //   axfpSpread.AddCellSpan(1, dt.Rows.Count + 2, 4, 1);

                        axfpSpread.SetText(2, dt.Rows.Count + 2, "Total");
                        axfpSpread.SetText(4, dt.Rows.Count + 2, "%");
                        axfpSpread.SetText(5, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_1"].ToString()) == 0 ? "0" : (total[0] / Convert.ToDouble(dt.Rows[0]["DATE_1"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(6, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_2"].ToString()) == 0 ? "0" : (total[1] / Convert.ToDouble(dt.Rows[0]["DATE_2"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(7, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_3"].ToString()) == 0 ? "0" : (total[2] / Convert.ToDouble(dt.Rows[0]["DATE_3"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(8, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_4"].ToString()) == 0 ? "0" : (total[3] / Convert.ToDouble(dt.Rows[0]["DATE_4"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(9, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_5"].ToString()) == 0 ? "0" : (total[4] / Convert.ToDouble(dt.Rows[0]["DATE_5"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(10, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_6"].ToString()) == 0 ? "0" : (total[5] / Convert.ToDouble(dt.Rows[0]["DATE_6"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(11, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_7"].ToString()) == 0 ? "0" : (total[6] / Convert.ToDouble(dt.Rows[0]["DATE_7"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(12, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_8"].ToString()) == 0 ? "0" : (total[7] / Convert.ToDouble(dt.Rows[0]["DATE_8"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(13, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_9"].ToString()) == 0 ? "0" : (total[8] / Convert.ToDouble(dt.Rows[0]["DATE_9"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(14, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_10"].ToString()) == 0 ? "0" : (total[9] / Convert.ToDouble(dt.Rows[0]["DATE_10"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(15, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_11"].ToString()) == 0 ? "0" : (total[10] / Convert.ToDouble(dt.Rows[0]["DATE_11"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(16, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_12"].ToString()) == 0 ? "0" : (total[11] / Convert.ToDouble(dt.Rows[0]["DATE_12"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(17, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_13"].ToString()) == 0 ? "0" : (total[12] / Convert.ToDouble(dt.Rows[0]["DATE_13"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(18, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_14"].ToString()) == 0 ? "0" : (total[13] / Convert.ToDouble(dt.Rows[0]["DATE_14"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(19, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_15"].ToString()) == 0 ? "0" : (total[14] / Convert.ToDouble(dt.Rows[0]["DATE_15"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(20, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_16"].ToString()) == 0 ? "0" : (total[15] / Convert.ToDouble(dt.Rows[0]["DATE_16"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(21, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_17"].ToString()) == 0 ? "0" : (total[16] / Convert.ToDouble(dt.Rows[0]["DATE_17"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(22, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_18"].ToString()) == 0 ? "0" : (total[17] / Convert.ToDouble(dt.Rows[0]["DATE_18"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(23, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_19"].ToString()) == 0 ? "0" : (total[18] / Convert.ToDouble(dt.Rows[0]["DATE_19"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(24, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_20"].ToString()) == 0 ? "0" : (total[19] / Convert.ToDouble(dt.Rows[0]["DATE_20"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(25, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_21"].ToString()) == 0 ? "0" : (total[20] / Convert.ToDouble(dt.Rows[0]["DATE_21"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(26, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_22"].ToString()) == 0 ? "0" : (total[21] / Convert.ToDouble(dt.Rows[0]["DATE_22"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(27, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_23"].ToString()) == 0 ? "0" : (total[22] / Convert.ToDouble(dt.Rows[0]["DATE_23"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(28, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_24"].ToString()) == 0 ? "0" : (total[23] / Convert.ToDouble(dt.Rows[0]["DATE_24"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(29, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_25"].ToString()) == 0 ? "0" : (total[24] / Convert.ToDouble(dt.Rows[0]["DATE_25"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(30, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_26"].ToString()) == 0 ? "0" : (total[25] / Convert.ToDouble(dt.Rows[0]["DATE_26"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(31, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["DATE_27"].ToString()) == 0 ? "0" : (total[26] / Convert.ToDouble(dt.Rows[0]["DATE_27"].ToString()) * 100).ToString("###,##0.00"));
                        axfpSpread.SetText(32, dt.Rows.Count + 2, Convert.ToDouble(dt.Rows[0]["TOT"].ToString()) == 0 ? "0" : (total[27] / Convert.ToDouble(dt.Rows[0]["TOT"].ToString()) * 100).ToString("###,##0.00"));



                        for (int j = 1; j < dt_Daily_Report.Columns.Count; j++)
                        {
                            axfpSpread.Col = j;
                            axfpSpread.Row = dt.Rows.Count + 2;
                            axfpSpread.BackColor = Color.Lime;


                        }

                        int iTmp = dt.Rows.Count + 3;
                        for (int i = 2; i < iTmp; i++)
                        {
                            axfpSpread.set_RowHeight(i, 20.5);
                        }

                        for (int i = dt.Rows.Count + 3; i < axfpSpread.MaxRows + 1; i++)
                        {
                            axfpSpread.set_RowHeight(i, 0);
                        }
                        MergeCol(axfpSpread, 2, 1);
                        MergeCol(axfpSpread, 2, 2);
                        MergeCol(axfpSpread, 2, 3);

                        //  axfpSpread.TopRow = dt.Rows.Count - 15;



                        dt = null;

                        dt = select_chart_1(UC_MONTH.GetValue());
                        if (dt != null & dt.Rows.Count > 0)
                        {
                            createChart(chart1, dt, dt.Rows[0]["title"].ToString());
                        }

                        //dt = null;

                        //dt = select_chart_2(UC_MONTH.GetValue());
                        //if (dt != null & dt.Rows.Count > 0)
                        //{

                        //    createChart(chart2, dt, dt.Rows[0]["title"].ToString());
                        //}

                        //dt = select_chart_3();
                        //if (dt != null & dt.Rows.Count > 0)
                        //{

                        //    createChart(chart3, dt, dt.Rows[0]["title"].ToString());
                        //}

                        //  showAnimation(axfpSpread);
                    }

                    else
                    {

                    }
                }
                else
                {

                    //  axfDailyReport_Header.Visible = true;
                    iNumRow = 0;
                }
            }
            catch (Exception)
            {

            }

            axfpSpread.Focus();
            SendKeys.Send("^{END}");
            axfpSpread.LeftCol = 14;


        }

        private DataTable select_chart_1(string arg_month)
        {


            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "MES.PKG_SMT_OS_DEFECTIVE.SEL_CHART_1_V2";

            //02.ARGURMENT ¢¬i
            MyOraDB.Parameter_Name[0] = "ARG_MONTH";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE A¢´AC

            MyOraDB.Parameter_Type[0] = (int)OracleType.NVarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_month;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();

            if (retDS == null) return null;

            return retDS.Tables[MyOraDB.Process_Name];
        }
        

        private DataTable select_deffect_monitor()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "MES.PKG_SMT_B2_IP.SELECT_DEFFECT_MONITOR";

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


        private DataTable select_work_date()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_deffect_status.select_work_date";

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

        private DataTable select_chart_1()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_deffect_status.select_chart_1";

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

        private DataTable select_chart_2()
        {
            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_deffect_status.select_chart_2";

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

        private void axfpSpread2_Advance(object sender, AxFPSpreadADO._DSpreadEvents_AdvanceEvent e)
        {

        }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        public bool IsNumeric(string text)
        {
            return Regex.IsMatch(text,"^\\d+$");
        }

        private void showAnimation(ChartDirector.WinChartViewer flg)
        {
            //flg.Hide();
            //IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(flg.Handle, 2000, IPEX_Monitor.ClassLib.WinAPI.getSlidType("2"));
            //flg.Show();
        }

        private void showAnimation(AxFPSpreadADO.AxfpSpread flg)
        {
           // flg.Hide();
            //IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(flg.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("2"));
            //flg.Show();
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
            iTime++;
            if (iFirstTime == 0 && iTime >= 3)
            {
                iTime = 0;
                GetData();
                iFirstTime = 1;

            }
            if (iTime >= 120)
            {
                iTime = 0;
                GetData();
            }
           
           
        }

        private void FORM_DEFFECTIVE_STATUS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
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

        private void FORM_DEFFECTIVE_STATUS_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.PageDown )
            //{
            //    Com_Base.Variables._iskeypress = true;
            //    previousForm();
            //} 
            //else if (e.KeyCode == Keys.PageUp)
            // {                
            //     Com_Base.Variables._iskeypress = true;
            //     nextForm();
            // }
           
            

        }
                
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

         
               Size size = new Size(58, iNumRow*57 + 49);

              // Size size = new Size(58, 5 * 57 + 49);
                System.Drawing.Point location = new System.Drawing.Point(10, 20 + 50 * 0);
               
                Pen pen = new Pen(Color.Blue, 5);
                e.Graphics.DrawRectangle(pen, new System.Drawing.Rectangle(location, size));
        }

       

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            //Com_Base.Variables._iskeypress = false;
            //nextForm();
            
        }

        private void FORM_DEFFECTIVE_STATUS_Activated(object sender, EventArgs e)
        {
           
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_DEFFECTIVE_STATUS_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    timer2.Start();
                    iTime = 0;

                   // set_time_chage();
                }
                catch (Exception)
                {
                    
                    
                }
            }
            else
            {
                timer2.Stop();
                iFirstTime = 0;
            }
        }

        private void GetData()
        {
            
            DataTable dt = null;
            dt = select_work_date();
            axfpSpread.Hide();
            chart1.Hide();
            chart2.Hide();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    this.axfpSpread.SetText(5, 1, dt.Rows[0]["THEDATE"].ToString());
                    this.axfpSpread.SetText(6, 1, dt.Rows[1]["THEDATE"].ToString());
                    this.axfpSpread.SetText(7, 1, dt.Rows[2]["THEDATE"].ToString());
                    this.axfpSpread.SetText(8, 1, dt.Rows[3]["THEDATE"].ToString());
                    this.axfpSpread.SetText(9, 1, dt.Rows[4]["THEDATE"].ToString());
                    this.axfpSpread.SetText(10, 1, dt.Rows[5]["THEDATE"].ToString());
                }
            }

            //axfDailyReport_Header.Visible = false;
            Search_Daily_Report();
            axfpSpread.Show();
            chart1.Show();
            chart2.Show();
            axfpSpread.RowsFrozen = 50;
            
        }
      

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_DEFFECTIVE_STATUS_V2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdMonth = new DevExpress.XtraEditors.SimpleButton();
            this.cmdYear = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new ChartDirector.WinChartViewer();
            this.chart2 = new ChartDirector.WinChartViewer();
            this.axfpSpread = new AxFPSpreadADO.AxfpSpread();
            this.UC_MONTH = new OS_DSF.UC.UC_MONTH_SELECTION();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.cmdMonth);
            this.panel1.Controls.Add(this.cmdYear);
            this.panel1.Controls.Add(this.cmdBack);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(1920, 109);
            this.panel1.MinimumSize = new System.Drawing.Size(1920, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 109);
            this.panel1.TabIndex = 0;
            // 
            // cmdMonth
            // 
            this.cmdMonth.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdMonth.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdMonth.Appearance.Options.UseBackColor = true;
            this.cmdMonth.Appearance.Options.UseFont = true;
            this.cmdMonth.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdMonth.Enabled = false;
            this.cmdMonth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdMonth.ImageOptions.Image")));
            this.cmdMonth.Location = new System.Drawing.Point(1512, 5);
            this.cmdMonth.Name = "cmdMonth";
            this.cmdMonth.Size = new System.Drawing.Size(175, 48);
            this.cmdMonth.TabIndex = 68;
            this.cmdMonth.Text = "Day";
            // 
            // cmdYear
            // 
            this.cmdYear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdYear.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdYear.Appearance.Options.UseBackColor = true;
            this.cmdYear.Appearance.Options.UseFont = true;
            this.cmdYear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cmdYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdYear.ImageOptions.Image")));
            this.cmdYear.Location = new System.Drawing.Point(1512, 56);
            this.cmdYear.Name = "cmdYear";
            this.cmdYear.Size = new System.Drawing.Size(175, 48);
            this.cmdYear.TabIndex = 69;
            this.cmdYear.Text = "Month";
            this.cmdYear.Click += new System.EventHandler(this.cmdYear_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Turquoise;
            this.cmdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBack.BackgroundImage")));
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1314, 5);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 67;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Turquoise;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1676, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(244, 109);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1108, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defective Status by Process && Reason";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.Location = new System.Drawing.Point(1221, 116);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(683, 448);
            this.chart1.TabIndex = 64;
            this.chart1.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.Location = new System.Drawing.Point(1221, 575);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(683, 451);
            this.chart2.TabIndex = 65;
            this.chart2.TabStop = false;
            // 
            // axfpSpread
            // 
            this.axfpSpread.DataSource = null;
            this.axfpSpread.Location = new System.Drawing.Point(5, 158);
            this.axfpSpread.Name = "axfpSpread";
            this.axfpSpread.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpSpread.OcxState")));
            this.axfpSpread.Size = new System.Drawing.Size(1207, 884);
            this.axfpSpread.TabIndex = 63;
            // 
            // UC_MONTH
            // 
            this.UC_MONTH.AutoSize = true;
            this.UC_MONTH.Location = new System.Drawing.Point(5, 111);
            this.UC_MONTH.Name = "UC_MONTH";
            this.UC_MONTH.Size = new System.Drawing.Size(472, 46);
            this.UC_MONTH.TabIndex = 66;
            // 
            // FORM_DEFFECTIVE_STATUS_V2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1916, 1054);
            this.Controls.Add(this.UC_MONTH);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axfpSpread);
            this.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FORM_DEFFECTIVE_STATUS_V2";
            this.Text = "FORM_DEFFECTIVE_STATUS";
            this.Activated += new System.EventHandler(this.FORM_DEFFECTIVE_STATUS_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_DEFFECTIVE_STATUS_FormClosing);
            this.Load += new System.EventHandler(this.FORM_DEFFECTIVE_STATUS_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_DEFFECTIVE_STATUS_VisibleChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            
            
            OS_DSF.ComVar.DEFECTIVE_YEAR.Show();
            this.Hide();
        }
        

    }
    

}
