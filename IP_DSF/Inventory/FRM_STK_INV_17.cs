using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using DevExpress.XtraCharts;

namespace IP
{
    public partial class FRM_STK_INV_17 : Form
    {
        public FRM_STK_INV_17()
        {
            InitializeComponent();
        }
        #region DB
        private DataTable Sel_Data(string Qtype,string ARG_DATE)
        {

            System.Data.DataSet retDS;
            COM.OraDB MyOraDB = new COM.OraDB();

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "MES.PKG_SMT_B2_IP.SEL_FS_IP_DATA";

            MyOraDB.Parameter_Name[0] = "ARG_QTYPE";
            MyOraDB.Parameter_Name[1] = "ARG_DATE";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = Qtype;
            MyOraDB.Parameter_Values[1] = ARG_DATE;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);

            retDS = MyOraDB.Exe_Select_Procedure();
            if (retDS == null) return null;
            return retDS.Tables[MyOraDB.Process_Name];


        }
        #endregion
        int cCount = 0;
        private void InitGrid()
        {
            for (int i = 4; i <= axfpSTK.MaxRows; i++)
            {
                for (int j = 1; j <= axfpSTK.MaxCols; j++)
                {
                    axfpSTK.Row = i;
                    axfpSTK.Col = j;
                    axfpSTK.SetText(j, i, "");
                    if (i == 4)
                        axfpSTK.BackColor = Color.YellowGreen;
                    else
                        axfpSTK.BackColor = Color.White;

                }
            }
            axfpSTK.RowsFrozen = 4;
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
        private string GetText(AxFPSpreadADO.AxfpSpread spread, int col, int row)
        {
            try
            {
                object data = null;
                spread.GetText(col, row, ref data);
                return data.ToString();
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        private void CreateGridSpan()
        {
            try
            {
                int startMline = 4;
                int startStyle = 4;
                int startFac = 4;
                for (int i = 4; i <= axfpSTK.MaxRows + 1; i++)
                {
                    if (GetText(axfpSTK, 1, i - 1) != " ")
                    {
                        if (GetText(axfpSTK, 1, i) != GetText(axfpSTK, 1, startFac))
                        {
                            axfpSTK.AddCellSpan(1, startFac, 1, i - startFac);
                            startFac = i;
                        }
                    }
                }


                for (int i = 4; i <= axfpSTK.MaxRows+1; i++)
                {
                    if (GetText(axfpSTK, 2, i - 1) + GetText(axfpSTK, 3, i) != " ")
                    {
                        if (GetText(axfpSTK, 2, i) != GetText(axfpSTK, 2, startMline))
                        {
                            axfpSTK.AddCellSpan(2, startMline, 1, i - startMline);
                            startMline = i;
                        }
                    }
                }


                for (int i = 4; i <= axfpSTK.MaxRows + 1; i++)
                {
                    if (GetText(axfpSTK, 3, i - 1) + GetText(axfpSTK, 4, i) != " ")
                    {
                        if (GetText(axfpSTK, 3, i) != GetText(axfpSTK, 3, startStyle))
                        {
                            axfpSTK.AddCellSpan(3, startStyle, 1, i - startStyle);
                            startStyle = i;
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void BindingData()
        {
            try
            {
                //InitGrid();
                DataTable dt = Sel_Data("G", null);

                if (dt != null && dt.Rows.Count > 0)
                {
                    axfpSTK.MaxRows = dt.Rows.Count + 3;
                    InitGrid();

                    for (int i = 0;i< dt.Rows.Count;i++)
                    {
                        for (int j  = 0;j < dt.Columns.Count;j++)
                        {
                            axfpSTK.Row = i + 4;
                            axfpSTK.Col = j + 1;
                            axfpSTK.SetText(j+1,i+4,dt.Rows[i][j].ToString());
                            if (dt.Rows[i][2].ToString().Equals("TOTAL"))
                            {
                                axfpSTK.BackColor = Color.FromArgb(250, 255, 186);
                            }
                            else
                               
                                if (dt.Rows[i][3].ToString().Equals("") && i != 0)
                                {
                                   // axfpSTK.SetText(3, i + 3,"Sub-TOT");
                                    axfpSTK.BackColor = Color.FromArgb(204, 231, 255); //Color.FromArgb(89, 238, 255);
                                }
                            switch(j+1)
                            {
                                case 3:
                                    axfpSTK.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignLeft;
                                    axfpSTK.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                                    break;
                                case 5:
                                case 6:
                                case 8:
                                case 10:
                                case 12:
                                    axfpSTK.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber;
                                    axfpSTK.TypeNumberDecPlaces = 0;
                                    axfpSTK.TypeNumberShowSep = true;
                                    break;
                                case 7:
                                case 9:
                                case 11:
                                case 13:
                                    axfpSTK.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber;
                                    axfpSTK.TypeNumberDecPlaces = 1;
                                    break;
                            }
                           // if (j+1 == 5 || j+1 = 6||)
                        }

                       
                    }
                    CreateGridSpan();
                   tmrScroll.Start();
                }
                else
                {
                    tmrScroll.Stop();
                }
            }
            catch (Exception ex)
            { }
        }

        private void CreateChart()
        {
            

            try
            {
                chartSTK.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
                chartSTK.DataSource = Sel_Data("C", null);
                chartSTK.Series[0].ArgumentDataMember = "MODEL_NM";
                chartSTK.Series[0].ValueDataMembers.AddRange(new string[] { "FS" });
                chartSTK.Series[1].ArgumentDataMember = "MODEL_NM";
                chartSTK.Series[1].ValueDataMembers.AddRange(new string[] { "IP" });
                ((XYDiagram)chartSTK.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
                
            }
            catch (Exception ex)
            { }
        }

        private void FRM_STK_INV_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            cCount = 60;
            //BindingData();
            //CreateChart();

        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            try
            {
                cCount++;
                lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                if (cCount >= 60)
                {
                    CreateChart();
                    BindingData();
                    axfpSTK.TopRow = cScroll;

                    cCount = 0;
                }
            }
            catch 
            {}
            
        }
        int cScroll = 4;
        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            try
            {
                axfpSTK.TopRow = cScroll;
                cScroll += 13;
                if (cScroll >= axfpSTK.MaxRows)
                    cScroll = 4;
            }
            catch 
            {}
            
           
        }

        private void FRM_STK_INV_17_VisibleChanged(object sender, EventArgs e)
        {
            cCount = 55;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
