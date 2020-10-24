using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OracleClient;
//using MaterialSetRate;
using System.Data.SqlClient;
//using ChartDirector;
using System.Threading;
//using IPEX_Monitor.ClassLib;


namespace OS_DSF
{

    

    public partial class FORM_OS_MACHINE_LAYOUT : Form
    {
        public FORM_OS_MACHINE_LAYOUT()
        {
            InitializeComponent();
            addUC();
        }


        #region Init

        public int _Izone = 1;
        public int _time = 0;
        int _time_load = 40;
        Addons.Database db = new Addons.Database();
        DataTable _dtLayout = null;
        int iPlan = 0, iNoPlan = 0, iNoUse = 0, iMoldChange =0;
 
    

        
        //FORM_MOLD_PRODUCTION_POP _pop_change = new FORM_MOLD_PRODUCTION_POP();
        //FORM_MOLD_PRODUCTION_POP_PRE _pop_change_pre = new FORM_MOLD_PRODUCTION_POP_PRE();
      //  Thread th;
         
        

        #endregion Init

        #region Function

        private void addUC()
        {
            OS_DSF.UC.UC_DWMY ucMenu = new UC.UC_DWMY(5);
            pnMenu.Controls.Add(ucMenu);
            ucMenu.OnDWMYClick += mnBtnClick;

        }

        private void mnBtnClick(string ButtonCap, string ButtonCD)
        {
            switch (ButtonCap)
            {
                case "btnClose":
                    this.Hide();
                    break;
            }

        }
        
        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

    

        #region Binding Data Grid Top
        private void DisplayGridTop(DataTable arg_dt, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;

                // Set Default Grid
                arg_grid.Visible = false;   

                arg_grid.Reset();
                arg_grid.BorderStyle = FPUSpreadADO.BorderStyleConstants.BorderStyleNone;
                arg_grid.DisplayColHeaders = false;
                arg_grid.DisplayRowHeaders = false;
                arg_grid.ActiveCellHighlightStyle = FPUSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
                arg_grid.ColHeaderRows = 0;
                arg_grid.ScrollBars = FPUSpreadADO.ScrollBarsConstants.ScrollBarsNone;
                arg_grid.Font = new System.Drawing.Font("Calibri", 10);
                arg_grid.set_RowHeight(1, 0.5);
                arg_grid.set_ColWidth(1, 0.5);
                arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                arg_grid.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                arg_grid.TypeEditMultiLine = true;
                arg_grid.SetCellBorder(1, 1, 150, axGridTop.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                arg_grid.SetCellBorder(1, 1, 150, axGridTop.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                for (int ic = 2; ic <= 150; ic++)
                    arg_grid.set_ColWidth(ic, 4.0);

                int row_s = 2;
                int irow = row_s;
                int icol = 2;
               
                MachineHeadTop(icol, irow, 0, arg_dt, arg_grid);
                irow = row_s + 1;
                MachineBodyTop(icol, irow, 0, arg_dt, arg_grid);                
                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["LINE_ID"].ToString() == arg_dt.Rows[i - 1]["LINE_ID"].ToString())
                    {
                        if (arg_dt.Rows[i]["MINI_LINE_ID"].ToString() == arg_dt.Rows[i - 1]["MINI_LINE_ID"].ToString())
                        {
                            irow++;                           
                        }
                        else
                        {
                            irow = row_s + 1;
                            icol++;
                        }
                        MachineBodyTop(icol, irow, i, arg_dt, arg_grid);                       
                    }
                    else
                    {
                        axGridTop.set_ColWidth(icol +1, 0.5);
                        icol += 2;
                        irow = row_s;
                        MachineHeadTop(icol, irow, i, arg_dt, arg_grid);
                        irow = row_s + 1;                       
                        MachineBodyTop(icol, irow, i, arg_dt, arg_grid);                        
                    }
                }
            }
            catch
            { }
            finally
            {
                arg_grid.Visible = true;
            }
        }

        private void MachineHeadTop(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = "Line " + arg_dt.Rows[arg_idt]["LINE_NAME"].ToString();
                arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);
                axGridTop.set_RowHeight(arg_irow, 20);
                arg_grid.BackColor = Color.DodgerBlue;
                arg_grid.ForeColor = Color.White;
                arg_grid.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                arg_grid.AddCellSpan(arg_icol, arg_irow, Convert.ToInt32(arg_dt.Rows[arg_idt]["NUM_MINI_LINE"]), 1);

                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexOutline, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                // arg_grid.SetCellBorder(icol, irow, icol + 3, irow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow +1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //arg_grid.SetCellBorder(icol, irow, icol + 2, irow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);


                //arg_irow++;
                //arg_grid.Row = arg_irow;
                //arg_grid.Col = arg_icol;
                //arg_grid.Text = "STA";
                //arg_grid.BackColor = Color.LightSkyBlue;
                ////  arg_grid.ForeColor = Color.White;
                //arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                //arg_grid.Col = arg_icol + 1;
                //arg_grid.Text = "L";
                //arg_grid.BackColor = Color.LightSkyBlue;
                ////  arg_grid.ForeColor = Color.White;
                //arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);

                //arg_grid.Col = arg_icol + 2;
                //arg_grid.Text = "R";
                //arg_grid.BackColor = Color.LightSkyBlue;
                ////  arg_grid.ForeColor = Color.White;
                //arg_grid.Font = new System.Drawing.Font("Calibri", 15, FontStyle.Bold);


            }
            catch
            { }
           
        }

        public void MachineBodyTop(int arg_icol, int arg_irow, int arg_idt, DataTable arg_dt, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            try
            {
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol, arg_irow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
              //  arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol + 1, arg_irow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                arg_grid.SetCellBorder(arg_icol, arg_irow, arg_icol, arg_irow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

                arg_grid.set_RowHeight(arg_irow, 41);


                arg_grid.Col = arg_icol;
                arg_grid.Row = arg_irow;
                arg_grid.Text = arg_dt.Rows[arg_idt]["MOLD_SIZE_CD"].ToString().Replace("/","/\n");

                if (arg_dt.Rows[arg_idt]["USE_YN"].ToString() == "N")
                {
                    arg_grid.BackColor = Color.FromArgb(191, 191, 191);
                    iNoUse++;
                    //_dtColor.Rows[row_index][column_index] = "5";
                }
                else if (arg_dt.Rows[arg_idt]["MOLD_SIZE_CD"].ToString() == "")
                {
                    if (arg_dt.Rows[arg_idt]["PLAN_FIX_YN"].ToString() == "Y")
                    {
                        arg_grid.BackColor = Color.LightCyan;

                       // _dtColor.Rows[row_index][column_index] = "8";
                    }
                    else
                    {
                        arg_grid.BackColor = Color.Red;
                        iNoPlan++;
                        //_dtColor.Rows[row_index][column_index] = "4";
                    }
                }
                else if (arg_dt.Rows[arg_idt]["MOLD_SIZE_CD"].ToString().Split('/').Length > 1)
                {
                    arg_grid.BackColor = Color.Orange;
                    iMoldChange++;
                    iPlan++;
                    //_dtColor.Rows[row_index][column_index] = "6";
                }
                else
                {
                    arg_grid.BackColor = Color.FromArgb(0, 255, 0);
                    iPlan++;
                    //_dtColor.Rows[row_index][column_index] = "3";
                }

            }
            catch (Exception)
            {}

        }

        #endregion Binding Data Grid Top

        #region Binding Data Grid Left
        private void DisplayGridLeft(DataTable arg_dt, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            int irow = 1, icol = 0,divRow;
            int iTotMachine = 0, iTotInput = 0, iTotBal = 0;
            arg_grid.Reset();
           // arg_grid.BorderStyle = FPUSpreadADO.BorderStyleConstants.BorderStyleNone;
            arg_grid.GrayAreaBackColor = Color.White;
            arg_grid.DisplayColHeaders = false;
            arg_grid.DisplayRowHeaders = false;
            arg_grid.ActiveCellHighlightStyle = FPUSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            arg_grid.ColHeaderRows = 0;
            arg_grid.ScrollBars = FPUSpreadADO.ScrollBarsConstants.ScrollBarsNone;
            arg_grid.Font = new System.Drawing.Font("Calibri", 11);
            //arg_grid.set_RowHeight(1, 0.5);
            //arg_grid.set_ColWidth(1, 0.5);
            arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            arg_grid.TypeEditMultiLine = true;

            arg_grid.Row = 1;
            arg_grid.FontBold = true;
            
            
            //for (int ic = 1; ic <= 50; ic++)
            //    arg_grid.set_ColWidth(ic, 12);

            
            
            var query = from DataRow dRow in arg_dt.AsEnumerable()
                        //  where p.Used = "N"
                        group dRow by dRow["LINE_NAME"] into gp
                        select new
                        {
                            Line = gp.Key,
                            Machine = gp.Count(),
                            Input = gp.Count(dRow => dRow.Field<string>("USE_YN") == "Y")
                        };

            divRow = (query.Count() / 2) + 2;
            for (int ir = 1; ir <= divRow; ir++)
                arg_grid.set_RowHeight(ir, 15);

            arg_grid.set_RowHeight(divRow + 1, 18);
            arg_grid.MaxCols = 9;
            arg_grid.MaxRows = divRow +1;
            GridLeftHead(1, arg_grid);

            arg_grid.SetCellBorder(1, 1, arg_grid.MaxCols, divRow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0x4286f4, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            arg_grid.SetCellBorder(1, 1, arg_grid.MaxCols, divRow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0x4286f4, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            

            foreach (var element in query)
            {                
                if (irow == divRow)
                {
                    icol += 5;
                    irow = 2;
                    GridLeftHead(icol + 1, arg_grid);
                    arg_grid.set_ColWidth(icol, 2);
                    arg_grid.SetCellBorder(icol, 1, icol, divRow-1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                    //arg_grid.SetCellBorder(irow , icol , 4, divRow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                   // arg_grid.SetCellBorder(irow , icol, 4, divRow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                }
                else irow++;

                arg_grid.SetText(icol + 1, irow, element.Line);
                arg_grid.SetText(icol + 2, irow, element.Machine);
                arg_grid.SetText(icol + 3, irow, element.Input);
                arg_grid.SetText(icol + 4, irow, element.Machine - element.Input);

                iTotMachine += element.Machine;
                iTotInput += element.Input;
                iTotBal += (element.Machine - element.Input);
            }

            arg_grid.AddCellSpan(1, divRow + 1, 6, 1);

            arg_grid.SetText(1, divRow + 1, "Total");
            arg_grid.SetText(icol + 2, divRow + 1, iTotMachine.ToString());
            arg_grid.SetText(icol + 3, divRow + 1, iTotInput.ToString());
            arg_grid.SetText(icol + 4, divRow + 1, iTotBal.ToString());
            arg_grid.Col = -1;
            arg_grid.Row = divRow + 1;
            arg_grid.BackColor = Color.FromArgb(232, 232, 127);
            arg_grid.FontBold = true;
            arg_grid.FontSize = 14;
            
        }

        private void GridLeftHead(int arg_col, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            string[] str = { "Line", "Machine", "Input", "Bal" };
            int[] w = { 6, 12, 6, 6 };
            for (int i = 0; i < 4; i++)
            {
                arg_grid.Col = arg_col + i;
                arg_grid.Row = 1;
                arg_grid.Text = str[i];
                arg_grid.BackColor = Color.Yellow;
                arg_grid.FontSize = 14;
                arg_grid.set_ColWidth(arg_col + i, w[i]);
            }
        }
        #endregion Binding Data Grid Left

        #region Binding Data Grid Right
        private void DisplayGridRight(DataTable arg_dt, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            int irow = 1, icol = 0;
            int iTotInput = 0, iTotMold = 0, iInput = 0, iMold = 0;
            int divRow = 11;

            arg_grid.Reset();
            //arg_grid.BorderStyle = FPUSpreadADO.BorderStyleConstants.BorderStyleNone;
            arg_grid.GrayAreaBackColor = Color.White;
            arg_grid.DisplayColHeaders = false;
            arg_grid.DisplayRowHeaders = false;
            arg_grid.ActiveCellHighlightStyle = FPUSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            arg_grid.ColHeaderRows = 0;
            arg_grid.ScrollBars = FPUSpreadADO.ScrollBarsConstants.ScrollBarsNone;
            arg_grid.Font = new System.Drawing.Font("Calibri", 11);
            //arg_grid.set_RowHeight(1, 0.5);
            //arg_grid.set_ColWidth(1, 0.5);
            arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            arg_grid.TypeEditMultiLine = true;

            arg_grid.Row = 1;
            arg_grid.FontBold = true;

            

            //for (int ic = 1; ic <= 50; ic++)
            //    arg_grid.set_ColWidth(ic, 12);

            for (int ir = 1; ir <= divRow; ir++)
                arg_grid.set_RowHeight(ir, 15);

           // arg_grid.set_RowHeight(1, 22);
            arg_grid.set_RowHeight(divRow + 1, 18);

            GridRightHead(1, arg_grid);
            arg_grid.SetCellBorder(1, 1, arg_grid.MaxCols, divRow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0x4286f4, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            arg_grid.SetCellBorder(1, 1, arg_grid.MaxCols, divRow + 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0x4286f4, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                if (irow == divRow)
                {
                    icol += 4;
                    irow = 2;
                    GridRightHead(icol + 1, arg_grid);
                    arg_grid.set_ColWidth(icol, 2);
                    arg_grid.SetCellBorder(icol, 1, icol, divRow - 1, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
                    //arg_grid.SetCellBorder(irow , icol , 4, divRow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                    // arg_grid.SetCellBorder(irow , icol, 4, divRow, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                }
                else irow++;

                iInput = Convert.ToInt32(arg_dt.Rows[i]["MOLD_INPUT"]);
                iMold = Convert.ToInt32(arg_dt.Rows[i]["QTY"]);

                arg_grid.SetText(icol + 1, irow, arg_dt.Rows[i]["SHORT_NAME"].ToString());
                arg_grid.SetText(icol + 2, irow, iMold.ToString("###,###,###"));
                arg_grid.SetText(icol + 3, irow, iInput.ToString("###,###,###"));

                iTotInput += Convert.ToInt32(arg_dt.Rows[i]["MOLD_INPUT"]);
                iTotMold += Convert.ToInt32(arg_dt.Rows[i]["QTY"]);
            }

            arg_grid.AddCellSpan(1, divRow + 1, 13, 1);

            arg_grid.SetText(1, divRow + 1, "Total");
            arg_grid.SetText(icol + 3, divRow + 1, iTotInput.ToString("###,###,###"));
            arg_grid.SetText(icol + 2, divRow + 1, iTotMold.ToString("###,###,###"));
            arg_grid.Col = -1;
            arg_grid.Row = divRow + 1;           
            arg_grid.BackColor = Color.FromArgb(232, 232, 127);
            arg_grid.FontBold = true;
            arg_grid.FontSize = 14;
            arg_grid.Col = 1;
            arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.MaxRows = divRow + 1;
            arg_grid.MaxCols = 15;
        }

        private void GridRightHead(int arg_col, AxFPUSpreadADO.AxfpSpread arg_grid)
        {
            string[] str = { "Model", "Plan", "Input" };
            double[] w = {21.5, 10, 10 };
            arg_grid.Col = arg_col;
            arg_grid.Row = -1;
            arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignLeft;
            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0)
                {
                    arg_grid.Col = arg_col + i;
                    arg_grid.Row = -1;
                    arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignRight;
                }

                arg_grid.Col = arg_col + i;
                arg_grid.Row = 1;
                arg_grid.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                arg_grid.Text = str[i];
                arg_grid.BackColor = Color.Yellow;
                arg_grid.FontSize = 14;
                arg_grid.set_ColWidth(arg_col + i, w[i]);
            }
        }

        #endregion Binding Data Grid Right


        public void loaddata()
        {
            try
            {
                DataTable dtLayout = db.GetMainData("Q");
                DataTable dtModel = db.GetMainData("Q1");
                iPlan = 0; iNoPlan = 0; iNoUse = 0; iMoldChange = 0;

                axGridTop.Visible = false;
                DisplayGridTop(dtLayout, axGridTop);
                axGridTop.Visible = true;
                axGridLeft.Visible = false;
                DisplayGridLeft(dtLayout, axGridLeft);
                axGridLeft.Visible = true;
                axGridRight.Visible = false;
                lblPlan.Text = "Plan: " + iPlan.ToString() + " Set";
                lblNoPlan.Text = "No Plan: " + iNoPlan.ToString() + " Set";
                lblNoUse.Text = "No Use: " + iNoUse.ToString() + " Set";
                lblMoldChange.Text = "Mold Change: " + iMoldChange.ToString() + " Set";
                //DisplayGridRight(dtModel, axGridRight);
                //axGridRight.Visible = true;
                //_dtLayout = GetMainData("Q1");

            }
            catch (Exception)
            { }
            finally
            {
                axGridTop.Visible = true;
                axGridLeft.Visible = true;
                //axGridRight.Visible = true;
            }
        }
    

        #endregion Fuction

        #region DB
        /*
        public DataTable SEL_APS_PLAN_ACTUAL(string arg_wh)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_DMC.SEL_MOLD_PRODUCTION_LAYOUT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

 
                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_wh;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private DataTable GetMainData(string workType)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "P_OS_MACHINE_LAYOUT_Q";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "V_P_WORKTYPE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (char)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = workType;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
         */
        #endregion DB

        #region Event

        public void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
            GoFullscreen();
           // timer1.Start();
            //lblDmc_Click(lblDmc, null);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                //blind();
                _time++;
                //_time_auto++;
               // if (_time_auto == 10) _pop_change.Hide();
                //if (_time_auto >= 40)
                //{
                //    if (_status == "DMC") autoClick(_Loc_change_DMC);
                //    else autoClick(_Loc_change_DMP);
                //    _time_auto = 0;
                //}
                

                if (_time >= _time_load)
                {
                    loaddata();
                    
                    _time = 0;
                }

                //if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                //    lblShift.Text = "SHIFT 2";
                //else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                //    lblShift.Text = "SHIFT 1";
                //else
                //    lblShift.Text = "SHIFT 3";
            }
            catch
            {
            }
        }

        private void tmr_blind_Tick(object sender, EventArgs e)
        {
            
        }


        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    //_time_auto = 10;
                    //if (_load_form)
                    //{
                        timer1.Start();

                        loaddata();
                      
                       // _load_form = false;
                    //}                 
                }
                else
                {
                   // _load_form = true;
                    timer1.Stop();
                }
                
            }
            catch (Exception)
            {}
        }


        private void axGrid_BeforeEditMode(object sender, AxFPUSpreadADO._DSpreadEvents_BeforeEditModeEvent e)
        {
            e.cancel = true;
        }
        
        
        #endregion Event

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }





    }
}
