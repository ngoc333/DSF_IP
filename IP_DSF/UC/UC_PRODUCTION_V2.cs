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
    public partial class UC_PRODUCTION_V2 : UserControl
    {
        public UC_PRODUCTION_V2(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }

        double i_max = 0, i_min = 0;
        public void BindingData(DataTable dt)
        {
            try
            {
                ascProd.EnableAnimation = false;
                ascProd.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseIn;
                ascProd.EasingFunction = new BackEase();
                ascProd.MinValue = 0;
                ascProd.Value = 0;
                labelComponent1.Text = "0 %";
                if (dt != null && dt.Rows.Count > 0)
                {
                    ascProd.MaxValue = 100;
                    lblDplanQty.Text = Convert.ToDouble(dt.Rows[0]["PLAN"]).ToString("#,#") + " Prs";
                    lblRplanQty.Text = Convert.ToDouble(dt.Rows[0]["RPLAN"]).ToString("#,#") + " Prs";
                    lblProdQty.Text = Convert.ToDouble(dt.Rows[0]["PROD_QTY"]).ToString("#,#") + " Prs";
                    lblRatePercent.Text = Convert.ToDouble(dt.Rows[0]["RATE"]).ToString("#,0") + "%";

                    i_max = Convert.ToDouble(dt.Rows[0]["MAX"].ToString());
                    i_min = Convert.ToDouble(dt.Rows[0]["MIN"].ToString());
                    lbl1.Text = "Rate >" + i_max + "%";
                    lbl2.Text = "Rate " +i_min + "% ~ " + i_max + "%";
                    lbl3.Text = "Rate <" + i_min + "%";

                    ascProd.EnableAnimation = true;
                    ascProd.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                    ascProd.EasingFunction = new BackEase();
                    double num;
                    double.TryParse(dt.Rows[0]["RATE"].ToString(), out num);
                    ascProd.Value = (float)num;
                    labelComponent1.Text = Convert.ToDouble(num).ToString("#,0") + "%";

                    if (Convert.ToInt32(dt.Rows[0]["RATE"]) > 98)
                    {
                        lbl = lbl1;
                        LastColor = lbl1.BackColor;
                        arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Green;Style2:Green]");

                    }
                    else if (Convert.ToInt32(dt.Rows[0]["RATE"]) >= 95 && Convert.ToInt32(dt.Rows[0]["RATE"]) <= 98)
                    {
                        lbl = lbl2;
                        LastColor = lbl2.BackColor;
                        arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Yellow;Style2:Yellow]");
                    }
                    else
                    {
                        lbl = lbl3;
                        LastColor = lbl3.BackColor;
                        arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Red;Style2:Red]");
                    }
                }




            }
            catch { }
        }
        int flag = 1;
        Control lbl = null;
        Color LastColor;
        private void tmrBlink_Tick(object sender, EventArgs e)
        {

            if (lbl.BackColor == LastColor)
            {
                if (LastColor == Color.Yellow)
                    lbl.BackColor = Color.Black;
                else
                lbl.BackColor = Color.White;
                lbl.ForeColor = LastColor;
            }
            else if (lbl.BackColor == Color.White || lbl.BackColor == Color.Black)
            {
                lbl.BackColor = LastColor;
                if (LastColor == Color.Yellow)
                    lbl.ForeColor = Color.Black;
                else
                    lbl.ForeColor = Color.White;
            }
        }
    }
}
