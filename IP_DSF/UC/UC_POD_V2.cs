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
    public partial class UC_POD_V2 : UserControl
    {
        public UC_POD_V2(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }
        public void BindingData(DataTable dt)
        {
            try
            {

                arcScaleComponent1.EnableAnimation = false;
                arcScaleComponent1.EasingMode = EasingMode.EaseInOut;
                arcScaleComponent1.EasingFunction = new ElasticEase();
                arcScaleComponent1.Value = 0;

               // lblGreen.Text = "Rate >" + Convert.ToInt32(dt.Rows[0]["yellow_qty"]).ToString()+"%";

               // lblYellow.Text = "Rate >" + Convert.ToInt32(dt.Rows[0]["red_qty"]) + "% ~ " + Convert.ToInt32(dt.Rows[0]["yellow_qty"]).ToString()+"%";

               // lblRed.Text = "Rate <" + Convert.ToInt32(dt.Rows[0]["red_qty"]).ToString()+"%";
                //arcScaleComponent1.Ranges[0].EndValue = ascPOD.Ranges[1].StartValue = Convert.ToInt32(dt.Rows[0]["red_qty"]);

                //arcScaleComponent1.Ranges[1].EndValue = ascPOD.Ranges[2].StartValue = Convert.ToInt32(dt.Rows[0]["yellow_qty"]);
                //arcScaleComponent1.Ranges[2].EndValue = Convert.ToInt32(dt.Rows[0]["MAX_QTY"]);
                //arcScaleComponent1.MaxValue = Convert.ToInt32(dt.Rows[0]["MAX_QTY"]);

                arcScaleComponent1.EnableAnimation = true;
                arcScaleComponent1.EasingMode = EasingMode.EaseInOut;
                arcScaleComponent1.EasingFunction = new BackEase();
                string strvalue = dt.Rows[0]["QTY"].ToString() == "" ? "0" : dt.Rows[0]["QTY"].ToString();
                arcScaleComponent1.Value = Convert.ToSingle(strvalue);
                labelComponent1.Text = Convert.ToDouble(strvalue).ToString("#.0");
                //arcScaleComponent1.MinValue = 0;
                //arcScaleComponent1.Ranges[0].StartValue = 0;

                arcScaleComponent1.Ranges.Clear();

                DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
                if (Convert.ToSingle(strvalue) > 86)
                {
                    arcScaleRange.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
                    arcScaleRange.EndValue = Convert.ToSingle(strvalue);
                    arcScaleRange.EndThickness = 14F;
                    arcScaleRange.ShapeOffset = -15F;
                    arcScaleRange.StartThickness = 14F;
                    arcScaleRange.Name = "Range0";
                    arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRange });
                    labelComponent2.Text = strvalue;
                    //labelComponent2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
                    //labelComponent2.AppearanceBackground.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
                }
                else if (Convert.ToSingle(strvalue) >= 83.6 && Convert.ToSingle(strvalue) <= 86)
                {
                    arcScaleRange.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Yellow");
                    arcScaleRange.EndValue = Convert.ToSingle(strvalue);
                    arcScaleRange.EndThickness = 14F;
                    arcScaleRange.ShapeOffset = -15F;
                    arcScaleRange.StartThickness = 14F;
                    arcScaleRange.Name = "Range0";
                    arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRange });
                    labelComponent2.Text = strvalue;
                    //labelComponent2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
                    //labelComponent2.AppearanceBackground.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Yellow");
                }
                else
                {
                    arcScaleRange.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
                    arcScaleRange.EndValue = Convert.ToSingle(strvalue);
                    arcScaleRange.EndThickness = 14F;
                    arcScaleRange.ShapeOffset = -15F;
                    arcScaleRange.StartThickness = 14F;
                    arcScaleRange.Name = "Range0";
                    arcScaleRange.EndValue = Convert.ToSingle(strvalue);
                    arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRange });
                    labelComponent2.Text = strvalue;
                    //labelComponent2.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
                    //labelComponent2.AppearanceBackground.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
                }
            }
            catch { }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
