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
//using WarehouseMaterialSystem.ClassLib;


namespace IP
{



    public partial class FORM_MOLD_PRODUCTION : Form
    {
        public FORM_MOLD_PRODUCTION()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        #region Init

        string _Zone = "Z001";
        public int _Izone = 1;
        string _lbl1, _lbl2, _lbl3;
        public int _time = 0;
        int _time_load = 20;
        int _time_auto = 0;
        int _countP = 0, _countN = 0, _countR = 0, _countNU = 0;
        DataTable _dt_layout = null;
        
        int _iColor = 0;
        bool _load_form = true;
        int _iCount = 0;
        int _bf_clickRow=0, _bf_clickCol=0;
        int _row1, _row2, _row3;

        
        //FORM_MOLD_PRODUCTION_POP _pop_change = new FORM_MOLD_PRODUCTION_POP();
        //FORM_MOLD_PRODUCTION_POP_PRE _pop_change_pre = new FORM_MOLD_PRODUCTION_POP_PRE();
      //  Thread th;
         
        List<string> _Loc_yellow = new List<string>();

        List<string> _Loc_green = new List<string>();

        List<string> _Loc_Blink = new List<string>();
        #endregion Init

        #region Function


        private void set_qty()
        {
            lblPlan.Text = "Plan: " + (_countP + _countR) + " set";
            lblNoPlan.Text = "No Plan: " + _countN + " set";
            lblMoldChange.Text = "Mold Change: " + _countR + " set";
            lblNoUse.Text = "No Use: " + _countNU + " set";
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

        private void create_default()
        {
            axGrid.Reset();
            axGrid.DisplayColHeaders = false;
            axGrid.DisplayRowHeaders = false;
            axGrid.ActiveCellHighlightStyle = FPSpreadADO.ActiveCellHighlightStyleConstants.ActiveCellHighlightStyleOff;
            axGrid.ColHeaderRows = 0;
            axGrid.ScrollBars = FPSpreadADO.ScrollBarsConstants.ScrollBarsNone;
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

            for (int icol = 2; icol <= 150; icol++)
            {
                axGrid.set_ColWidth(icol, 4.0);

            }
            
            
        }

        //private string GetShift(string arg_shift, string arg_date)
        //{
        //    string str_shift, str_date;
        //    if (arg_date == DateTime.Now.ToString("yyyyMMdd")) str_date = " (Today)";
        //    else str_date = " (Yesterday)";
        //    if (arg_shift == "10") str_shift = "Shift 1";
        //    else if (arg_shift == "20") str_shift = "Shift 2";
        //    else str_shift = "Shift 3";
        //    return str_shift + str_date;
        //}

        private void MachineHead(int icol, int irow, int idt)
        {
            try
            {
                axGrid.Col = icol;
                axGrid.Row = irow;
                axGrid.Text = _dt_layout.Rows[idt]["MACHINE_NAME"].ToString();
                axGrid.Font = new System.Drawing.Font("Calibri", 11, FontStyle.Bold);
                axGrid.BackColor = Color.DodgerBlue;
                axGrid.ForeColor = Color.White;
                axGrid.TypeVAlign = FPSpreadADO.TypeVAlignConstants.TypeVAlignTop;
                axGrid.AddCellSpan(icol, irow, 3, 1);

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

                axGrid.Col = icol + 1;
                axGrid.Text = "L";
                axGrid.BackColor = Color.LightSkyBlue;
              //  axGrid.ForeColor = Color.White;
                axGrid.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);

                axGrid.Col = icol + 2;
                axGrid.Text = "R";
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
                axGrid.SetCellBorder(icol, irow, icol, irow , FPSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                axGrid.SetCellBorder(icol, irow, icol, irow, FPSpreadADO.CellBorderIndexConstants.CellBorderIndexBottom, 0, FPSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
               
                axGrid.SetText(icol, irow, _dt_layout.Rows[idt]["STA"].ToString());

                axGrid.SetText(icol + 1, irow, _dt_layout.Rows[idt]["PLAN_L"].ToString());
                if (_dt_layout.Rows[idt]["USE_YN"].ToString() == "Y")
                {
                    color_grid(icol + 1, irow, _dt_layout.Rows[idt]["COLOR_L"].ToString(), _dt_layout.Rows[idt]["MACHINE_L"].ToString());
                }
                else
                {
                    color_grid(icol + 1, irow, "GRAY", _dt_layout.Rows[idt]["MACHINE_L"].ToString());
                }
                

                axGrid.SetText(icol + 2, irow, _dt_layout.Rows[idt]["PLAN_R"].ToString());
                if (_dt_layout.Rows[idt]["USE_YN"].ToString() == "Y")
                {
                    color_grid(icol + 2, irow, _dt_layout.Rows[idt]["COLOR_R"].ToString(), _dt_layout.Rows[idt]["MACHINE_R"].ToString());
                }
                else
                {
                    color_grid(icol + 1, irow, "GRAY", _dt_layout.Rows[idt]["MACHINE_R"].ToString());
                }

                if (_dt_layout.Rows[idt]["BLINK_L"].ToString() == "Y")
                {
                    _Loc_Blink.Add(icol + 1 + " " + irow + " " + _dt_layout.Rows[idt]["MACHINE_L"].ToString());
                }

                if (_dt_layout.Rows[idt]["BLINK_R"].ToString() == "Y")
                {
                    _Loc_Blink.Add(icol + 2 + " " + irow + " " + _dt_layout.Rows[idt]["MACHINE_R"].ToString());
                }
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
                    _Loc_yellow.Add(col  + " " + row + " " + machine);
                    _countR++;
                    break;

                // Change already
                case "BLUE":
                    axGrid.BackColor = Color.Lime;
                    axGrid.ForeColor = Color.Black;
                    _Loc_yellow.Add(col + " " + row + " " + machine);
                    _countP++;
                    break;
                //Cleaning
                case "ORANGE":
                    break;

                //No plan
                case "GRAY":
                    axGrid.BackColor = Color.LightGray;
                    _countNU++;
                    break;
        
                //Issues
                case "RED":
                    axGrid.BackColor = Color.Red;
                    _countN++;
                    break;

                //Plan
                case "GREEN":
                    axGrid.BackColor = Color.Lime;
                //    axGrid.ForeColor = Color.White;
                    _Loc_green.Add(col + " " + row + " " + machine);
                    _countP++;
                    break;
                    

           }
        }

        private int RowMC(string arg_mc)
        {
            if (arg_mc == "1") return _row1;
            else if (arg_mc == "2") return _row2;
            else return _row3;
        }




        private void DisplayGrid(DataTable arg_dt)
        {
           try
            {
                _countN = 0;
                _countP = 0;
                _countR = 0;
                _countNU = 0;
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
                irow+=2;
                MachineBody(icol, irow, 0);
                irow++;

                for (int i = 1; i<arg_dt.Rows.Count; i++)
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
                                irow+=2;
                                MachineBody(icol, irow, i);
                                irow++;                               
                            }
                        }
                        else
                        {
                            icol += 4;
                            irow = RowMC(arg_dt.Rows[i]["MACHINE_SEQ"].ToString());  
                            MachineHead(icol, irow, i + 1);
                            irow+=2;
                            MachineBody(icol, irow, i);
                            irow++;                 
                        }
                    }
                    else
                    {
                        icol += 5;
                        irow = RowMC(arg_dt.Rows[i]["MACHINE_SEQ"].ToString());  
                        MachineHead(icol, irow, i + 1);
                        irow+=2;
                        MachineBody(icol, irow, i);
                        irow++;
                    }
                }
                set_qty();
                if (_Loc_Blink.Count > 0) tmr_blind.Start();
                else tmr_blind.Stop();
            }
           catch
           {
           }
        }


        private void blind()
        {
            string[] str;

            for (int i = _iColor; i < _Loc_Blink.Count; i += 3)
            {
                str = _Loc_Blink[i].Split(' ');
                axGrid.Col = Convert.ToInt32(str[0].ToString());
                axGrid.Row = Convert.ToInt32(str[1].ToString());
                if (axGrid.BackColor == Color.Yellow)
                {
                    if (axGrid.Text == "")
                    {
                        axGrid.BackColor = Color.Red;
                    }
                    else
                    {
                        axGrid.BackColor = Color.Lime;
                    }
                    
                   // axGrid.ForeColor = Color.White;
                }
                else
                {
                    axGrid.BackColor = Color.Yellow;
                    axGrid.ForeColor = Color.Black;
                }
            }
            if (_iColor == 3) _iColor = 0;
            else _iColor ++;
        }

        public void loaddata()
        {
           // _dt = SEL_APS_PLAN_ACTUAL();

            //label1.Text = "";
            //label2.Text = "";
            //label3.Text = "";
           // lbl_zone.Text = "";
            
            //create_default();
            DataTable dt = SEL_APS_PLAN_ACTUAL();
            if (dt != null && dt.Rows.Count > 0) 
                _dt_layout = dt;

            this.axGrid.Hide();
            DisplayGrid(_dt_layout);

            //autoClick();
           // WarehouseMaterialSystem.ClassLib.WinAPI.AnimateWindow(this.axGrid.Handle, 400, WarehouseMaterialSystem.ClassLib.WinAPI.getSlidType("2"));
            this.axGrid.Show();

            //label1.Text = _lbl1;
            //label2.Text = _lbl2;
            //label3.Text = _lbl3;
        //    lbl_zone.Text = "Zone " + _Izone.ToString();
        }

        private void autoClick()
        {
            try
            {
                if (_Loc_Blink.Count > 0)
                {
                    string str = _Loc_Blink.ElementAt(_iCount).ToString();
                    string[] st = str.Split(' ');
                    AxFPSpreadADO._DSpreadEvents_ClickEvent ev = new AxFPSpreadADO._DSpreadEvents_ClickEvent(Convert.ToInt32(st[0]), Convert.ToInt32(st[1]));
                    axGrid_ClickEvent(axGrid, ev);
                    if (_iCount == _Loc_Blink.Count - 1) _iCount = 0;
                    else _iCount++;
                }
                else
                {
                  //  _pop_change.Hide();
                    _iCount = 0;
                }
            }
            catch (Exception)
            {

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
                string process_name = "PKG_SPB_MOLD_WMS.SEL_MOLD_PRODUCTION_LAYOUT_V2";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

 
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

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

    


        #endregion DB

        #region Event

        public void Frm_Mold_WS_Change_By_Shift_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            //lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
            //lblDate.Show();
          //  loaddata();
            
            
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


       

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
                //blind();
                _time++;
                //if (Com_Base.Variables.Form[0]["monitor"].ToLower() == "tv")
                //{
                //    _time_auto++;
                //    // if (_time_auto == 10) _pop_change.Hide();
                //    if (_time_auto >= 20)
                //    {

                //        autoClick();
                //        _time_auto = 0;
                //    }
                //}
                

                if (_time >= _time_load)
                {
                    loaddata();
                    _time = 0;
                //    _Izone++;
                //    if (_Izone <= 7)
                //    {
                //        _Zone = "Z00" + _Izone.ToString();
                //        loaddata();
                //        _time = 0;

                //    }
                //    else _Izone = 1;

                }

                if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 22)
                    lblShift.Text = "SHIFT 2";
                else if (Convert.ToInt16(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt16(DateTime.Now.ToString("HH")) < 14)
                    lblShift.Text = "SHIFT 1";
                else
                    lblShift.Text = "SHIFT 3";
            }
            catch
            {
            }
        }


        private void tmr_blind_Tick(object sender, EventArgs e)
        {
            blind();
        }



        private void Frm_Mold_WS_Change_By_Shift_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            this.Dispose();
            base.Dispose(true);
        }


        private void Frm_Mold_WS_Change_By_Shift_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    _time_auto = 10;
                    if (_load_form)
                    {
                        timer1.Start();

                        loaddata();
                        _load_form = false;
                    }
                  
                }
                else
                {
                    _load_form = true;
                    timer1.Stop();
                }
                
            }
            catch (Exception)
            {
                
                
            }
        }


        private void axGrid_BeforeEditMode(object sender, AxFPSpreadADO._DSpreadEvents_BeforeEditModeEvent e)
        {
            e.cancel = true;
        }
        
        private void axGrid_ClickEvent(object sender, AxFPSpreadADO._DSpreadEvents_ClickEvent e)
        {
            string str = _Loc_Blink.Find(x => x.StartsWith(e.col + " " + e.row));
            string str2 = _Loc_yellow.Find(x => x.StartsWith(e.col + " " + e.row));
            string str1 = _Loc_green.Find(x => x.StartsWith(e.col + " " + e.row));
            string[] st;
            string[] st2;
            //if (str != null && Com_Base.Variables.Form[0]["monitor"].ToLower() == "tv")
            //{
            //    st = str.Split(' ');
            //    _pop_change._machine = st[2];
            //    // _pop_change.Hide();
            //    _pop_change.Show();
            //}
            //else
            //{
            //    _pop_change.Hide();
            //}


            
            

            //if (str2 != null && (Com_Base.Variables.Form[0]["monitor"].ToLower() != "tv"))
            //{
            //    st2 = str2.Split(' ');
            //    _pop_change_pre._machine = st2[2];
            //    _pop_change_pre.Hide();
            //    _pop_change_pre.Show();

            //    if (_bf_clickCol == 0 && _bf_clickRow == 0)
            //    {
            //        _bf_clickCol = e.col;
            //        _bf_clickRow = e.row;
            //        axGrid.Col = e.col;
            //        axGrid.Row = e.row;
            //        axGrid.BackColor = Color.Blue;
            //    }
            //    else
            //    {
            //        axGrid.Col = _bf_clickCol;
            //        axGrid.Row = _bf_clickRow;
            //        axGrid.BackColor = Color.Yellow;
            //        axGrid.Col = e.col;
            //        axGrid.Row = e.row;
            //        axGrid.BackColor = Color.Blue;
            //        _bf_clickCol = e.col;
            //        _bf_clickRow = e.row;
            //    }
            //}
            //else
            //{
               
            //    _pop_change_pre.Hide();
            //}
            
        }
        #endregion Event

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }




    }
}
