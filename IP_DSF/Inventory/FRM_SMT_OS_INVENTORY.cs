using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace OS_DSF
{
    public partial class FRM_SMT_OS_INVENTORY : Form
    {
        public FRM_SMT_OS_INVENTORY()
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
            //uc.YMD_Change(6);
        }

        void DWMYClick(string ButtonCap, string ButtonCD)
        {
            //MessageBox.Show(ButtonCap + "    " + ButtonCD);
            switch (ButtonCD)
            {
                case "C":
                    timer2.Stop();
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
                    Form fc1 = Application.OpenForms["FRM_SMT_OS_INVENTORY"];
                    if (fc1 != null)
                        fc1.Show();
                    else
                    {
                        FRM_SMT_OS_INVENTORY f1 = new FRM_SMT_OS_INVENTORY();
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
                dtsource =  db.SEL_OS_PROD_MONTH("H", "");                
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
                    //bandDate.Width = 140;
                    //bandAVG.Width = 80;
                    //bandMon.Width = (grdView.Width - 220) / dtsource.Rows.Count;
                    //gvwView.OptionsView.ColumnAutoWidth = false;
                }
            }
            catch
            {
                return;
            }
        }

        private void BindingData(string arg_op)
        {
            try
            {
                grdView.Refresh();
                DataTable dtsource = null;
                dtsource = db.SEL_OS_INVENTORY("Q", arg_op);
                //formatband();

                bandPlan.Caption = "0";
                bandInv.Caption = "0";
                bandLT.Caption = "0";

                if (dtsource != null && dtsource.Rows.Count > 0)
                {
                    bandPlan.Caption = Convert.ToDouble(dtsource.Rows[0]["PLAN_QTY"].ToString()).ToString("#,0");
                    bandInv.Caption = Convert.ToDouble(dtsource.Rows[0]["INV"].ToString()).ToString("#,0");
                    bandLT.Caption = Convert.ToDouble(dtsource.Rows[0]["LT"].ToString()).ToString("#,0.0");
                    grdView.DataSource = dtsource.Select("MODEL_NM <> 'TOTAL'").CopyToDataTable();
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
                            gvwView.Columns[i].AppearanceCell.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Regular);
                            if (i > 0 && i < 3)
                            {
                                gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                gvwView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                gvwView.Columns[i].DisplayFormat.FormatString = "#,0";
                            }
                            else if (i == 3)
                            {
                                gvwView.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                                gvwView.Columns[i].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                                gvwView.Columns[i].DisplayFormat.FormatString = "#,0.0";
                            }
                        }

                    }
                    bindingdatachart(dtsource.Select("MODEL_NM <> 'TOTAL'").CopyToDataTable());
                }
                else
                {
                    grdView.DataSource = dtsource;
                    bindingdatachart(dtsource);
                }
            }
            catch { }
        }

        private void bindingdatachart(DataTable dt)
        {            
            chartSlabtest.DataSource = dt;
            chartSlabtest.Series[0].ArgumentDataMember = "MODEL_NM";
            chartSlabtest.Series[0].ValueDataMembers.AddRange(new string[] { "INV" });
            chartSlabtest.Series[1].ArgumentDataMember = "MODEL_NM";
            chartSlabtest.Series[1].ValueDataMembers.AddRange(new string[] { "LT" });
            //chartControl1.Series[1].ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }

        private void gvwView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.RowHandle == 0)
            //{
            //    e.Appearance.BackColor = Color.LightGray;//Color.FromArgb(80, 209, 244);
            //    e.Appearance.ForeColor = Color.Black;
            //    e.Appearance.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
            //}
            //else
            //{
                
            //}
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
                //bindingdatachart("OSP");
            }
        }

        private void FRM_ROLL_SLABTEST_MON_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    timer2.Start();
                    cnt = 40;
                }
                else
                    timer2.Stop();
            }
            catch
            {

            }
        }

        private void chartSlabtest_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e)
        {
            try
            {
                if (e.Item.Axis is AxisX)
                {
                    e.Item.Text = e.Item.Text.Replace("_", "\n");
                }
            }
            catch
            {

            }
        }
    }
}
