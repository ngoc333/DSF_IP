﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using JPlatform.Client.Controls;


namespace OS_DSF
{
    public partial class FRM_SMT_OS_PROD_DAILY : Form
    {
        public FRM_SMT_OS_PROD_DAILY()
        {
            InitializeComponent();
        }

        int cnt = 0, i_max = 0, i_min = 0;
        string str_op = "";    
        #region db
        Addons.Database db = new Addons.Database();
        #endregion
        #region UC
        UC.UC_DWMY uc = new UC.UC_DWMY(1);

        #endregion

        private void FRM_ROLL_SLABTEST_MON_Load(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            
            pnYMD.Controls.Add(uc);
            uc.OnDWMYClick += DWMYClick;
            uc.YMD_Change(6);
        }

        void DWMYClick(string ButtonCap, string ButtonCD)
        {
            //MessageBox.Show(ButtonCap + "    " + ButtonCD);
            switch (ButtonCD)
            {
                case "C":
                    this.Close();
                    break;
                case "D":
                    this.Close();
                    Form fc = Application.OpenForms["FRM_SMT_OS_PROD_DAILY"];
                    if (fc != null)
                        fc.Show();
                    else
                    {
                        FRM_SMT_OS_PROD_DAILY f = new FRM_SMT_OS_PROD_DAILY();
                        f.Show();
                    }
                    break;
                case "M":
                    this.Close();
                    Form fc1 = Application.OpenForms["FRM_SMT_OS_PROD_MONTH"];
                    if (fc1 != null)
                        fc1.Show();
                    else
                    {
                        FRM_SMT_OS_PROD_MONTH f1 = new FRM_SMT_OS_PROD_MONTH();
                        f1.Show();
                    }
                    break;
                case "Y":
                    this.Close();
                    Form fc2 = Application.OpenForms["FRM_SMT_OS_PROD_YEAR"];
                    if (fc2 != null)
                        fc2.Show();
                    else
                    {
                        FRM_SMT_OS_PROD_YEAR f2 = new FRM_SMT_OS_PROD_YEAR();
                        f2.Show();
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
                dtsource = db.SEL_OS_PROD_DAILY("H", "");
                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    string name;
                    bandMon.Caption = dtsource.Rows[0]["MON"].ToString();
                    if (dtsource.Rows.Count > 0)
                    {
                        foreach (DevExpress.XtraGrid.Views.BandedGrid.GridBand band in gvwView.Bands[1].Children)
                        {
                            double num;
                            if (double.TryParse(band.Caption, out num))
                            {
                                for (int i = 0; i < dtsource.Rows.Count; i++)
                                {
                                    if (band.Name.Contains(dtsource.Rows[i][0].ToString().Substring(dtsource.Rows[i][0].ToString().Length - 2)))
                                    {
                                        band.Visible = true;
                                        break;
                                    }
                                    if (i == dtsource.Rows.Count - 1)
                                    {
                                        band.Visible = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void BindingData(string arg_op)
        {
            grdView.Refresh();
            DataTable dtsource = null;
            dtsource = db.SEL_OS_PROD_DAILY("Q", arg_op);
            //formatband();
            DataTable dt = null;
            if (dtsource == null || dtsource.Rows.Count < 0) return;
            grdView.DataSource = dtsource.Rows.Count > 0 ? dtsource.Select("MC <> 'TOTAL'", "STT ASC").CopyToDataTable() : dtsource;
            lblTot_Plan.Text = "0";
            lblTot_RPlan.Text = "0";
            lblTot_Act.Text = "0";
            lblTot_Rate.Text = "0";
            for (int i = 0; i < gvwView.Columns.Count; i++)
            {
                gvwView.Columns[i].OwnerBand.Caption = "";
            }
            if (dtsource != null && dtsource.Rows.Count > 0)
            {
                lblTot_Plan.Text = dtsource.Rows[0]["TOT_PLAN"].ToString() + " Prs";
                lblTot_RPlan.Text = dtsource.Rows[0]["TOT_RPLAN"].ToString() + " Prs";
                lblTot_Act.Text = dtsource.Rows[0]["TOT_ACT"].ToString() + " Prs";
                lblTot_Rate.Text = dtsource.Rows[0]["TOT_RATE"].ToString();

                i_max = Convert.ToInt32(dtsource.Rows[0]["MAX"].ToString());
                i_min = Convert.ToInt32(dtsource.Rows[0]["MIN"].ToString());
                lbl1.Text = ">" + i_max + "%";
                lbl2.Text = i_min + "% ~ " + i_max + "%";
                lbl3.Text = "<" + i_min + "%";

                for (int i = 0; i < gvwView.Columns.Count; i++)
                {
                    gvwView.Columns[i].OptionsColumn.ReadOnly = true;
                    gvwView.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwView.Columns[i].OptionsFilter.AllowFilter = false;
                    gvwView.Columns[i].OwnerBand.Caption = dtsource.Rows[0][gvwView.Columns[i].FieldName].ToString();
                    gvwView.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Regular);
                    if (i>0)
                    {
                        //gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 13, FontStyle.Regular);
                        gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        gvwView.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    }
                }

            }
            //axfpSpread.MaxRows = 2;
            //if (dtsource != null && dtsource.Rows.Count > 0)
            //{
            //    for (int i_row = 0; i_row < dtsource.Rows.Count; i_row++)
            //    {
            //        for (int i_col = 0; i_col < dtsource.Columns.Count; i_col++)
            //        {
            //            axfpSpread.Col = i_col + 1;
            //            axfpSpread.Row = i_row + 3;
            //            axfpSpread.ForeColor = Color.Black;
            //            //axfpSpread.TypeHAlign= FPUSpreadADO.TypeHAlignConstants.TypeHAlignCenter;
            //            //axfpSpread.TypeVAlign = FPUSpreadADO.TypeVAlignConstants.TypeVAlignCenter;
            //            //axfpSpread.Font = new System.Drawing.Font("Calibri", 22, FontStyle.Regular);
            //            axfpSpread.set_RowHeight(i_row+3, 27);
            //            axfpSpread.SetText(i_col + 1, i_row + 3, dtsource.Rows[i_row][i_col].ToString());
            //            //axfpSpread.CellBorderStyle = FPUSpreadADO.CellBorderStyleConstants.CellBorderStyleDot;
            //        }
            //    }
            //}
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName.Contains("RATE"))
            {
                if (e.CellValue.ToString().Replace("%","") != "")
                {
                    if (Convert.ToDouble(e.CellValue.ToString().Replace("%", "").Trim()) > i_max)
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (Convert.ToDouble(e.CellValue.ToString().Replace("%", "").Trim()) >= i_min && Convert.ToDouble(e.CellValue.ToString().Replace("%", "").Trim()) <= i_max)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.ForeColor = Color.White;
                    }
                }
                //e.Appearance.BackColor = Color.FromArgb(255, 255, 192);
                //e.Appearance.ForeColor = Color.Black;
                //e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Regular);
            }
            else
            {
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd")) + "\n\r" + string.Format(DateTime.Now.ToString("HH:mm:ss"));
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
                    timer1.Start();
                    cnt = 40;
                }
                else
                    timer1.Stop();
            }
            catch
            {

            }
        }

        //private void lblRubber_Click(object sender, EventArgs e)
        //{
        //    //lblTitle.Text = "Rubber Slabtest Tracking by Month";
        //    BindingData("OS");
        //    bindingdatachart("OS");
        //    str_op = "OS";
        //    pnRubber.GradientEndColor = Color.White;//Color.FromArgb(255, 128, 128);
        //    pnEVA.GradientEndColor = Color.Gray;
        //}

        //private void lblEVA_Click(object sender, EventArgs e)
        //{
        //    //lblTitle.Text = "EVA Slabtest Tracking by Month";
        //    BindingData("PH");
        //    bindingdatachart("PH");
        //    str_op = "PH";
        //    pnEVA.GradientEndColor = Color.White; //Color.FromArgb(255, 128, 128);
        //    pnRubber.GradientEndColor = Color.Gray;
        //}

        //private void cmdYear_Click(object sender, EventArgs e)
        //{

        //}
    }
}
