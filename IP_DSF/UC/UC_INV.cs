using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGauges.Core.Model;

namespace IP.UC
{
    public partial class UC_INV : UserControl
    {
        public UC_INV(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }

        public void BindingData(DataTable dt)
        {
            try
            {
                ascInv.EnableAnimation = false;
                ascInv.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseIn;
                ascInv.EasingFunction = new BackEase();
                ascInv.MinValue = 0;
                ascInv.Value = 0;
                labelComponent1.Text = "0 Prs";
                if (dt != null && dt.Rows.Count > 0)
                {
                    ascInv.MaxValue = Convert.ToInt32(dt.Rows[0]["TARGET"]);
                    lblPlanQty.Text = Convert.ToDouble(dt.Rows[0]["PLAN"]).ToString("#,#") + " Prs";
                    lblInvQty.Text = Convert.ToDouble(dt.Rows[0]["INV_QTY"]).ToString("#,#") + " Prs";

                    ascInv.EnableAnimation = true;
                    ascInv.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                    ascInv.EasingFunction = new BackEase();
                    double num;
                    double.TryParse(dt.Rows[0]["LT_DAYS"].ToString(), out num);
                    ascInv.Value = (float)num;
                    labelComponent1.Text = Convert.ToDouble(num).ToString("#,0.0") + " Days";
                }
            }
            catch { }
        }
    }
}
