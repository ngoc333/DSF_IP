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
using DevExpress.XtraEditors.Filtering.Templates;
//using WarehouseMaterialSystem.ClassLib;


namespace IP
{

    

    public partial class FORM_MOLD_ACTUAL_PLAN : Form
    {
        public FORM_MOLD_ACTUAL_PLAN()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        #region Init

        public int _time = 0;
        int _count = 0;
        int _countP = 0;
        int _countA = 0;
        DataTable _dt_layout = null;
        List<string> _Loc_yellow = new List<string>();

        List<string> _Loc_green = new List<string>();

        List<string> _Loc_Blink = new List<string>();

        int _row1, _row2, _row3;
        string _shift = "1";
        bool _isLoad = true;
        #endregion Init

        #region Function

        private void setDefaultGrid(AxFPSpreadADO.AxfpSpread arg_grid)
        {
            // Set Default Grid
            arg_grid.Visible = false;

            arg_grid.Reset();
            arg_grid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;
            arg_grid.DisplayColHeaders = false;
            arg_grid.DisplayRowHeaders = false;
            arg_grid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            arg_grid.GrayAreaBackColor = Color.White;
            // arg_grid.ScrollBarExtMode = true;
            arg_grid.ColHeaderRows = 0;
            arg_grid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsHorizontal;
            arg_grid.Font = new System.Drawing.Font("Calibri Bold", 11);
            arg_grid.set_RowHeight(1, 0.5);
            arg_grid.set_ColWidth(1, 0.5);
            arg_grid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            arg_grid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            arg_grid.TypeEditMultiLine = true;
            arg_grid.SetCellBorder(1, 1, 150, arg_grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            arg_grid.SetCellBorder(1, 1, 150, arg_grid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);

            for (int ic = 2; ic <= 150; ic++)
                arg_grid.set_ColWidth(ic, 4.2);
        }
    
        #region Binding Data Grid
        public void set_qty_actual()
        {
            lbl_Plan.Text ="Total Plan: " + _countP;
            lbl_Actual.Text = "Total Actual: " + _countA;


            double d;
            int x = _count;
            int y = _countP;
            d = (float)x / y * 100.0;
            lbl_change.Text = "Difference Plan: " + d.ToString("###,###") + "%";



        }       
        

        

        

        #endregion Binding Data Grid
        
        
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

      

        public void loaddata( bool arg_status)
        {
            try
            {
                DataTable dt = SEL_APS_PLAN_ACTUAL();
                if (dt != null && dt.Rows.Count > 0)
                    _dt_layout = dt;

                this.axGrid.Hide();
                DisplayGrid(_dt_layout);

                //autoClick();
         //       WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(this.axGrid.Handle, 400, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                this.axGrid.Show();
               
            }
            catch 
            { }
            finally
            {
               // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(axGrid.Handle, 500, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
                this.axGrid.Show(); 
            }
        }


        private void DisplayGrid(DataTable arg_dt)
        {
            try
            {
                _countP = 0;
                _countA = 0;
                _count = 0;
                if (arg_dt == null || arg_dt.Rows.Count == 0) return;
                // axGrid.ClearRange(0, 0, 50, 50, true);
                create_default();
                _Loc_yellow.Clear();
                _Loc_Blink.Clear();
                // _Loc_green.Clear();
                _row1 = Convert.ToInt32(arg_dt.Rows[0]["Row1"]);
                _row2 = Convert.ToInt32(arg_dt.Rows[0]["Row2"]);
                _row3 = Convert.ToInt32(arg_dt.Rows[0]["Row3"]);
                int irow = _row2;
                int icol = 2;


                MachineHead(icol, irow, 0);
                irow += 3;
                MachineBody(icol, irow, 0);
                irow++;

                for (int i = 1; i < arg_dt.Rows.Count; i++)
                {
                    if (arg_dt.Rows[i]["ZONE_CD"].ToString() == arg_dt.Rows[i - 1]["ZONE_CD"].ToString())
                    {
                        if (arg_dt.Rows[i]["LINE_ID"].ToString() == arg_dt.Rows[i - 1]["LINE_ID"].ToString())
                        {

                            if (arg_dt.Rows[i]["MACHINE_NAME"].ToString() == arg_dt.Rows[i - 1]["MACHINE_NAME"].ToString())
                            {
                                MachineBody(icol, irow, i);
                                irow++;
                            }
                            else
                            {
                                irow = RowMC(arg_dt.Rows[i]["MACHINE_SEQ"].ToString());
                                MachineHead(icol, irow, i + 1);
                                irow += 3;
                                MachineBody(icol, irow, i);
                                irow++;
                            }
                        }
                        else
                        {
                            icol += 6;
                            irow = RowMC(arg_dt.Rows[i]["MACHINE_SEQ"].ToString());
                            MachineHead(icol, irow, i + 1);
                            irow += 3;
                            MachineBody(icol, irow, i);
                            irow++;
                        }
                    }
                    else
                    {
                        icol += 7;
                        irow = RowMC(arg_dt.Rows[i]["MACHINE_SEQ"].ToString());
                        MachineHead(icol, irow, i + 1);
                        irow += 3;
                        MachineBody(icol, irow, i);
                        irow++;
                    }
                }

                if (_Loc_Blink.Count > 0) tmr_blind.Start();
                else tmr_blind.Stop();
                 set_qty_actual();
            }
               
            catch
            {
            }
        }

        private int RowMC(string arg_mc)
        {
            if (arg_mc == "1") return _row1;
            else if (arg_mc == "2") return _row2;
            else return _row3;
        }



        private void MachineHead(int icol, int irow, int idt)
        {
            try
            {
                axGrid.Row = 2;
                axGrid.Col = 2;
                axGrid.Text = "Zone 1";
                axGrid.AddCellSpan(2, 2, 11, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);


                axGrid.Row = 2;
                axGrid.Col = 15;
                axGrid.Text = "Zone 2";
                axGrid.AddCellSpan(15, 2, 11, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);

                axGrid.Row = 2;
                axGrid.Col = 28;
                axGrid.Text = "Zone 3";
                axGrid.AddCellSpan(28, 2, 11, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);

                axGrid.Row = 2;
                axGrid.Col = 41;
                axGrid.Text = "Zone 4";
                axGrid.AddCellSpan(41, 2, 11, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);

                axGrid.Row = 2;
                axGrid.Col = 54;
                axGrid.Text = "Zone 5";
                axGrid.AddCellSpan(54, 2, 11, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);

                axGrid.Row = 2;
                axGrid.Col = 67;
                axGrid.Text = "Zone 6";
                axGrid.AddCellSpan(67, 2, 11, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);

                axGrid.Row = 2;
                axGrid.Col = 80;
                axGrid.Text = "Zone 7";
                axGrid.AddCellSpan(80, 2, 5, 1);
                axGrid.BackColor = Color.Green;
                axGrid.Font = new System.Drawing.Font("Calibri", 20, FontStyle.Bold);



                axGrid.Col = icol;
                axGrid.Row = irow;
                axGrid.Text = _dt_layout.Rows[idt]["MACHINE_NAME"].ToString();
                axGrid.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
                axGrid.BackColor = Color.DodgerBlue;
                axGrid.ForeColor = Color.White;
                axGrid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignTop;
                axGrid.AddCellSpan(icol, irow, 5, 1);

                //axGrid.SetCellBorder(icol, irow, icol + 2, irow + 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexOutline, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                // axGrid.SetCellBorder(icol, irow, icol + 3, irow + 1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //axGrid.SetCellBorder(icol, irow, icol + 2, irow +1, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                //axGrid.SetCellBorder(icol, irow, icol + 2, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);



                irow++;
                axGrid.Row = irow;
                axGrid.Col = icol;
                axGrid.Text = "STA";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                axGrid.AddCellSpan(icol, irow, 1, 2);

                axGrid.Col = icol + 1;
                axGrid.Text = "L";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                axGrid.AddCellSpan(icol + 1, irow, 2, 1);

                axGrid.Col = icol + 3;
                axGrid.Text = "R";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                axGrid.AddCellSpan(icol + 3, irow, 2, 1);

                irow++;
                axGrid.Row = irow;
                axGrid.Col = icol + 1;
                axGrid.Text = "PLAN";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);

                axGrid.Col = icol + 2;
                axGrid.Text = "ACT";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);

                axGrid.Col = icol + 3;
                axGrid.Text = "PLAN";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);

                axGrid.Col = icol + 4;
                axGrid.Text = "ACT";
                axGrid.BackColor = Color.LightSkyBlue;
                //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                




            }
            catch
            {
            }
        }

        public void MachineBody(int icol, int irow, int idt)
        {
            try
            {
                axGrid.SetCellBorder(icol, irow, icol+5, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                axGrid.SetCellBorder(icol, irow, icol+4, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);

                axGrid.Col = icol;
                axGrid.Row = irow;
                axGrid.SetText(icol, irow, _dt_layout.Rows[idt]["STA"].ToString());
                axGrid.BackColor = Color.LightGreen;

                axGrid.SetText(icol + 1, irow, _dt_layout.Rows[idt]["PLAN_L"].ToString());
                if (_dt_layout.Rows[idt]["PLAN_L"].ToString() != "")
                {
                    _countP++;
                }
             //   color_grid(icol + 1, irow, _dt_layout.Rows[idt]["COLOR_L"].ToString(), _dt_layout.Rows[idt]["MACHINE_L"].ToString());

                axGrid.SetText(icol + 2, irow, _dt_layout.Rows[idt]["ACT_L"].ToString());
                if (_dt_layout.Rows[idt]["ACT_L"].ToString() != "")
                {
                    _countA++;
                }
                if (_dt_layout.Rows[idt]["STATUS_L"].ToString() == "1")
                {
                    axGrid.Col = icol + 2;
                    axGrid.BackColor = Color.Yellow;
                    _count++;
                }
                else
                {
                    axGrid.Col = icol + 2;
                    axGrid.BackColor = Color.White;
                }


                axGrid.SetText(icol + 3, irow, _dt_layout.Rows[idt]["PLAN_R"].ToString());
                if (_dt_layout.Rows[idt]["PLAN_R"].ToString() != "")
                {
                    _countP++;
                }
               // color_grid(icol + 2, irow, _dt_layout.Rows[idt]["COLOR_R"].ToString(), _dt_layout.Rows[idt]["MACHINE_R"].ToString());

                axGrid.SetText(icol + 4, irow, _dt_layout.Rows[idt]["ACT_R"].ToString());
                if (_dt_layout.Rows[idt]["ACT_R"].ToString() != "")
                {
                    _countA++;
                }
                if (_dt_layout.Rows[idt]["STATUS_R"].ToString() == "1")
                {
                    axGrid.Col = icol + 4;
                    axGrid.BackColor = Color.Yellow;
                    _count++;
                }
                else
                {
                    axGrid.Col = icol + 4;
                    axGrid.BackColor = Color.White;
                }

                //if (_dt_layout.Rows[idt]["BLINK_L"].ToString() == "Y")
                //{
                //    _Loc_Blink.Add(icol + 1 + " " + irow + " " + _dt_layout.Rows[idt]["MACHINE_L"].ToString());
                //}

                //if (_dt_layout.Rows[idt]["BLINK_R"].ToString() == "Y")
                //{
                //    _Loc_Blink.Add(icol + 2 + " " + irow + " " + _dt_layout.Rows[idt]["MACHINE_R"].ToString());
                //}
                //_Loc_Color.Add(new Loc_Gid(icol + 2, irow, _dt_layout.Rows[idt]["COLOR_R"].ToString()));


            }
            catch (Exception)
            {
            }

        }

        private void color_grid(int col, int row, string color, string machine)
        {
            axGrid.Col = col;
            axGrid.Row = row;
            if (machine == "IPP_MC012_02_L")
            {
            }
            switch (color)
            {
                // Change
                case "YELLOW":
                    axGrid.BackColor = Color.Yellow;
                    axGrid.ForeColor = Color.Black;
                    _Loc_yellow.Add(col + " " + row + " " + machine);
                    break;

                //Cleaning
                case "ORANGE":
                    break;

                //No plan
                case "GRAY":
                    axGrid.BackColor = Color.Gray;
                    break;

                //Issues
                case "RED":
                    break;

                //Plan
                case "GREEN":
                    axGrid.BackColor = Color.Lime;
                  //  axGrid.ForeColor = Color.White;
                    _Loc_green.Add(col + " " + row + " " + machine);
                    break;


            }
        }

        private void create_default()
        {
            axGrid.Reset();
            axGrid.DisplayColHeaders = false;
            axGrid.DisplayRowHeaders = false;
            axGrid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            axGrid.ColHeaderRows = 0;
            axGrid.MaxCols = 85;
            axGrid.MaxRows = 42;
            axGrid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsHorizontal;
            axGrid.Font = new System.Drawing.Font("Calibri", 12);
            axGrid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;

            // axGrid.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleNone;
            axGrid.set_RowHeight(1, 0.5);
            //axGrid.set_RowHeight(20, 9);
            //axGrid.set_ColWidth((int)G.S1_Blank, 5.37);
            axGrid.set_ColWidth(1, 0.5);
            //axGrid.set_ColWidth((int)G.S3_Blank, 5.37);
            //axGrid.set_ColWidth((int)G.Blank1, 13.62);
            //axGrid.set_ColWidth((int)G.Blank2, 13.62);
            axGrid.TypeHAlign = FPSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            axGrid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            axGrid.SetCellBorder(1, 1, 150, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            axGrid.SetCellBorder(1, 1, 150, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            //  axGrid.SetCellBorder((int)G.S1_M1_L_Plan, 1, (int)G.S3_M2_R_Act, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);


            //  axGrid.SetCellBorder((int)G.S1_M1_L_Tar, 1, (int)G.S3_M2_R_Cur, axGrid.MaxRows, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexOutline, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleBlank);
            for (int irow = 2; irow <= 50; irow++)
            {
                axGrid.set_RowHeight(irow, 16);

            }

            for (int icol = 0; icol <= 150; icol++)
            {
                axGrid.set_ColWidth(icol, 4.5);

            }


        }
     


                

        #endregion Fuction

        #region DB
        public DataTable SEL_APS_PLAN_ACTUAL()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

            try
            {
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_MOLD_APS_ACTUAL_V2";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_WH_CD";
                MyOraDB.Parameter_Name[1] = "ARG_DATE";
                MyOraDB.Parameter_Name[2] = "ARG_SHIFT";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "30";
                MyOraDB.Parameter_Values[1] = dtpDate.DateTime.ToString("yyyyMMdd");
                MyOraDB.Parameter_Values[2] = _shift;
                MyOraDB.Parameter_Values[3] = "";

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
        public DataTable SEL_TOTAL_PLAN_ACTUAL()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;

           
                string process_name = "PKG_SPB_MOLD_WMS_V2.SEL_QTY_ACTUAL";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Name[1] = "ARG_WH_CD";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Parameter_Values[1] = "30";

                MyOraDB.Add_Select_Parameter(true);

                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            
        }

    


        #endregion DB

        #region Event

        public void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
            _isLoad = true;
            GoFullscreen();
            //timer2.Start();
            //lblDmc_Click(lblDmc, null);
            setDefaultGrid(axGrid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _time++;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                if (_time == 60)
                {
                   // _dt_layout = SEL_APS_PLAN_ACTUAL();
                    loaddata(true);
                    _time = 0;
                }

                //if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                //    lbl_Shift1.Text = "SHIFT 2";
                //else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                //    lbl_Shift1.Text = "SHIFT 1";
                //else
                //    lbl_Shift1.Text = "SHIFT 3";
            }
            catch
            {
            }
        }

        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    _isLoad = true;

                    dtpDate.EditValue = DateTime.Now;

                    if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                    {
                        lbl_Shift_Click(lbl_Shift2, null);
                    }
                    else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                    {
                        lbl_Shift_Click(lbl_Shift1, null);
                    }
                    else
                    {
                        lbl_Shift_Click(lbl_Shift3, null);
                    }
                    _time = 59;
                    timer1.Start();          
                }
                else
                {
                    timer1.Stop();
                }
                
            }
            catch (Exception)
            {}
            finally
            {
                _isLoad = false;
            }
        }

        private void axGrid_BeforeEditMode(object sender, AxFPSpreadADO._DSpreadEvents_BeforeEditModeEvent e)
        {
            e.cancel = true;
        }

        
        #endregion Event

        private void lbl_Plan_Click(object sender, EventArgs e)
        {

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_Shift_Click(object sender, EventArgs e)
        {
            Control cmd = (Control)sender;
            foreach (Control ctr in pnShift.Controls)
            {
                if (ctr.Name == cmd.Name)
                {
                    cmd.BackColor = Color.DodgerBlue;
                    cmd.ForeColor = Color.White;
                    _shift = cmd.Tag.ToString();
                    if (!_isLoad) loaddata(true);
                    _time = 0;
                }
                else
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                }
            }
        }

        private void dtpDate_EditValueChanged(object sender, EventArgs e)
        {
            if (_isLoad) return;
            loaddata(true);
            _time = 0;
        }


    }
}
