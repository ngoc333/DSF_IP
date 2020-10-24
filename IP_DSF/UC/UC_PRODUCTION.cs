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
    public partial class UC_PRODUCTION : UserControl
    {
        public UC_PRODUCTION(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }


        public void BindingData(DataTable dt)
        {
            try
            {
                ascProd.EnableAnimation = false;
                ascProd.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseIn;
                ascProd.EasingFunction = new BackEase();
                ascProd.MinValue = 0;
                ascProd.Value = 0;
                labelComponent1.Text = "0 Prs";
                if (dt != null && dt.Rows.Count > 0)
                {
                    ascProd.MaxValue = Convert.ToInt32(dt.Rows[0]["PLAN"]);
                    lblDplanQty.Text = Convert.ToDouble(dt.Rows[0]["PLAN"]).ToString("#,#");
                    lblRplanQty.Text = Convert.ToDouble(dt.Rows[0]["RPLAN"]).ToString("#,#");
                    lblProdQty.Text = Convert.ToDouble(dt.Rows[0]["PROD_QTY"]).ToString("#,#");
                    lblRatePercent.Text = Convert.ToDouble(dt.Rows[0]["RATE"]).ToString("#,0") + "%";

                    ascProd.EnableAnimation = true;
                    ascProd.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                    ascProd.EasingFunction = new BackEase();
                    double num;
                    double.TryParse(dt.Rows[0]["PROD_QTY"].ToString(), out num);
                    ascProd.Value = (float)num;
                    labelComponent1.Text = Convert.ToDouble(num).ToString("#,0") + " Prs";

                    if (Convert.ToInt32(dt.Rows[0]["PROD_QTY"]) > 90)
                    {
                        lbl = lblGreen;
                        LastColor = lblGreen.BackColor;
                        arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Green;Style2:]");

                    }
                    else if (Convert.ToInt32(dt.Rows[0]["PROD_QTY"]) > 80 && Convert.ToInt32(dt.Rows[0]["PROD_QTY"]) <= 90)
                    {
                        lbl = lblYellow;
                        LastColor = lblYellow.BackColor;
                        arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Yellow;Style2:]");
                    }
                    else
                    {
                        lbl = lblRed;
                        LastColor = lblRed.BackColor;
                        arcScaleRangeBarComponent1.Shader = new DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Red;Style2:]");
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
