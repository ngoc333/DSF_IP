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
    public partial class UC_POD : UserControl
    {
        public UC_POD(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }
        public void BindingData(DataTable dt)
        {
            try
            {

                ascPOD.EnableAnimation = false;
                ascPOD.EasingMode = EasingMode.EaseInOut;
                ascPOD.EasingFunction = new ElasticEase();
                ascPOD.Value = 0;

                lblGreen.Text = "Rate >" + Convert.ToInt32(dt.Rows[0]["yellow_qty"]).ToString()+"%";

                lblYellow.Text = "Rate >" + Convert.ToInt32(dt.Rows[0]["red_qty"]) + "% ~ " + Convert.ToInt32(dt.Rows[0]["yellow_qty"]).ToString()+"%";

                lblRed.Text = "Rate <" + Convert.ToInt32(dt.Rows[0]["red_qty"]).ToString()+"%";
                ascPOD.Ranges[0].EndValue = ascPOD.Ranges[1].StartValue = Convert.ToInt32(dt.Rows[0]["red_qty"]);

                ascPOD.Ranges[1].EndValue = ascPOD.Ranges[2].StartValue = Convert.ToInt32(dt.Rows[0]["yellow_qty"]);
                ascPOD.Ranges[2].EndValue = Convert.ToInt32(dt.Rows[0]["MAX_QTY"]);
                ascPOD.MaxValue = Convert.ToInt32(dt.Rows[0]["MAX_QTY"]);
                
                ascPOD.EnableAnimation = true;
                ascPOD.EasingMode = EasingMode.EaseInOut;
                ascPOD.EasingFunction = new BackEase();

                ascPOD.Value = Convert.ToInt32(dt.Rows[0]["QTY"]); ;
                labelComponent1.Text = Convert.ToDouble(dt.Rows[0]["QTY"]).ToString("#.0");


            }
            catch { }
        }
    }
}
