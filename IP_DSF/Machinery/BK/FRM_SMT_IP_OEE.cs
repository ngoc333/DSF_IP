﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Data.OracleClient;

namespace OS_DSF
{
    public partial class FRM_SMT_IP_OEE : Form
    {
        public FRM_SMT_IP_OEE()
        {
            InitializeComponent();
           // tmrTime.Stop();
        }
        #region Variable
        int cCount = 0;
        string BtnClick = "PH";
        Color ColorRow = Color.White;
        Color ColorEven = Color.FromArgb(247, 247, 247);
        #endregion
        #region UC
       // UC.UC_PH_MACHINE_GRID UC = new UC.UC_PH_MACHINE_GRID();
        //UC.UC_PH_MACHINE_GRID UC23_44 = new UC.UC_PH_MACHINE_GRID();
        UC.UC_DWMY uc = new UC.UC_DWMY(7);
        #endregion
        #region Oracle
        private DataTable SELECT_DATA(string ARG_QTYPE)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "MES.PKG_SMT_B1_PHUOC.IP_OEE_MONTHLY_SELECT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_QTYPE";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = ARG_QTYPE;
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
        #endregion
        private void FRM_SMT_PH_OEE_Load(object sender, EventArgs e)
        {
            GoFullscreen();
            lblTitle.Text = "IP Machine OEE by Month";
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            pnYMD.Controls.Add(uc);
            uc.OnDWMYClick += DWMYClick;
        }

        private void GoFullscreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
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
               
                    this.Close();
                    Form fc = Application.OpenForms["FRM_SMT_IP_OEE"];
                    if (fc != null)
                        fc.Show();
                    else
                    {
                        FRM_SMT_IP_OEE f = new FRM_SMT_IP_OEE();
                        f.Show();
                    }
                    break;
                case "Y":
                   // ComVar.IP_OEE_YEAR.Show();
                    this.Close();
                    Form fc1 = Application.OpenForms["FRM_SMT_IP_OEE_YEAR"];
                    if (fc1 != null)
                        fc1.Show();
                    else
                    {
                        FRM_SMT_IP_OEE_YEAR f1 = new FRM_SMT_IP_OEE_YEAR();
                        f1.Show();
                    }
                    
                    break;
            }
        }
        static DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            Random r = new Random();
            table.Columns.Add("Range", typeof(string));
            table.Columns.Add("Dosage", typeof(int));

            // Here we add five DataRows.
            for (int i = 1;i<=44;i++)
                table.Rows.Add("CTM " + i.ToString(), r.Next(70,102));
            //table.Rows.Add("value1",25);
            //table.Rows.Add("value2", 50);
            //table.Rows.Add("value3",10);
            //table.Rows.Add("value4",21);
            //table.Rows.Add("value5",100);
            return table;
        }

        private void BindingOEEChart(string ARG_QTYPE)
        {
            try
            {
                ChartOEE.DataSource = SELECT_DATA(ARG_QTYPE);
                ChartOEE.Series[0].ArgumentDataMember = "MACHINE_CD";
                ChartOEE.Series[0].ValueDataMembers.AddRange(new string[] { "OEE" });
                ((XYDiagram)ChartOEE.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;
                 // ChartOEE.Series[0].ValueScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            }
            catch 
            { }
        }

        private void ClearGrid()
        {
            for (int iRow = 3; iRow <= axfpView.MaxRows; iRow++)
            {
                for (int iCol = 1; iCol <= axfpView.MaxCols; iCol++)
                {
                    axfpView.SetText(iCol, iRow, "");
                }
            }
        }

        private void BindingGrid(string ARG_QTYPE)
        {
            try
            {
                axfpView.Hide();
                ClearGrid();
              
                axfpView.ColsFrozen = 1;
                axfpView.RowsFrozen = 2;
                
                DataTable dt = SELECT_DATA(ARG_QTYPE);

                if (dt != null && dt.Rows.Count > 0)
                {
                    axfpView.Hide();
                    axfpView.MaxRows = dt.Rows.Count + 2;
                    axfpView.MaxCols = dt.Columns.Count;
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            //if (j == 0)
                            //{
                            //    axfpView.Row = 1;
                            //    axfpView.Col = i + 1;
                            //    axfpView.BackColor = Color.Gray;
                            //    axfpView.ForeColor = Color.White;
                            //    axfpView.SetText(i + 1, 1, dt.Columns[i].Caption.ToString());
                            //}
                            if (i > 0 && !dt.Rows[j][i].ToString().Equals(""))
                                axfpView.SetText(i + 1, j + 3, Convert.ToDouble(dt.Rows[j][i]).ToString("#.#"));
                            else
                                axfpView.SetText(i + 1, j + 3, dt.Rows[j][i].ToString());
                            axfpView.set_RowHeight(j + 3, 27);
                            axfpView.Row = j + 3;
                            axfpView.Col = i + 1;
                            axfpView.Font = new System.Drawing.Font("Calibri", 12, FontStyle.Bold);
                            if (axfpView.Row == axfpView.MaxRows)
                                axfpView.BackColor = Color.DarkOrange;
                            else
                            {

                                switch ((j + 3) % 2)
                                {
                                    case 0:
                                        axfpView.BackColor = ColorRow;
                                        break;
                                    case 1:
                                        axfpView.BackColor = ColorEven;
                                        break;
                                }
                            }
                        }
                        if (i > 0)
                            axfpView.set_ColWidth(i + 1, 7);


                    }

                    axfpView.TypeHAlign = FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
                    axfpView.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
                    // axfpView.CellType = FPUSpreadADO.CellTypeConstants.CellTypeEdit;
                    //axfpView.TypeNumberShowSep = false;
                    //axfpView.TypeNumberSeparator = ",";
                    axfpView.TypeNumberDecPlaces = 0;
                    if (dt.Rows.Count > 7)
                        axfpView.TopRow = axfpView.MaxRows - 6;




                    //axfpSpread.SetText(i_col + 1, i_row + 3, dtsource.Rows[i_row][i_col].ToString());
                    //axfpSpread.CellBorderStyle = FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleDot;
                    axfpView.SetCellBorder(0, 0, axfpView.MaxCols, axfpView.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexTop, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                    axfpView.SetCellBorder(0, 0, axfpView.MaxCols, axfpView.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexLeft, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                    axfpView.SetCellBorder(0, 0, axfpView.MaxCols, axfpView.MaxRows, FPUSpreadADO.CellBorderIndexConstants.CellBorderIndexRight, 0, FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleSolid);
                    axfpView.Show();
                }
            }
            catch { axfpView.Show(); }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            cCount++;
            if (cCount >= 40)
            {
                lblPhylon_Click(null, null);
                cCount = 0;
            }
        }

        private void FRM_SMT_PH_OEE_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                
                cCount = 39;
                tmrTime.Start();
            }
            else
                tmrTime.Stop();
        }

        private void lblPhylon_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BtnClick = "PH";
            lblTitle.Text = "IP Machine OEE by Month";
            BindingGrid("IP_G");
            BindingOEEChart("IP_C");
            this.Cursor = Cursors.Default;
            //Form_Home_Phylon._type = "PHP";
        }

        private void lblCMP_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //BtnClick = "CMP";
            //lblTitle.Text = "CMP Machine OEE by Month";
            //BindingGrid("CMP_G");
            //BindingOEEChart("CMP_C");
            //this.Cursor = Cursors.Default;
            //Form_Home_Phylon._type = "CMP";
        }

        private void splMain_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


    }
}
