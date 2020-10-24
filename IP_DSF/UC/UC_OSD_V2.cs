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
    public partial class UC_OSD_V2 : UserControl
    {
        public UC_OSD_V2(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }
        

        public void BindingData(DataTable dt)
        {
            try
            {
                //chartOSD.DataSource = dt.Select("DIV <> 'RATE'").CopyToDataTable();
                //chartOSD.Series[0].ArgumentDataMember = "DIV";
                //chartOSD.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE" });
                
                //lblProductionQty.Text = Convert.ToDouble(dt.Rows[0]["VALUE"]).ToString("#,0") + " Prs";
                //lblOSDQty.Text = Convert.ToDouble(dt.Rows[1]["VALUE"]).ToString("#,0") + " Prs";
                //lblRatePercent.Text = Convert.ToDouble(dt.Rows[2]["VALUE"]).ToString("0.0#") + "%";
                arcScale_VAL.EnableAnimation = false;
                //arcScale_VAL.EasingMode = EasingMode.EaseInOut;
                //arcScale_VAL.EasingFunction = new ElasticEase();
                arcScale_VAL.Value = 0;
                arcScale_VAL.EnableAnimation = true;
                arcScale_VAL.EasingMode = EasingMode.EaseInOut;
                arcScale_VAL.EasingFunction = new BackEase();
                arcScale_VAL.Ranges.Clear();
                DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
                if (dt.Rows.Count > 0)
                {
                    lblProd.Text = Convert.ToDouble(dt.Rows[0][1].ToString()).ToString("#,#") + " Prs";
                    lblOSD.Text = Convert.ToDouble(dt.Rows[1][1].ToString()).ToString("#,#") + " Prs";
                    if (Convert.ToSingle(dt.Rows[2][1].ToString()) > 10)
                    {
                        arcScale_VAL.Value = 10;
                        arcScaleRange.EndValue = 10;
                    }
                    else
                    {
                        arcScale_VAL.Value = Convert.ToSingle(dt.Rows[2][1].ToString());
                        arcScaleRange.EndValue = Convert.ToSingle(dt.Rows[2][1].ToString());
                    }
                    lbl_Scale.Text = dt.Rows[2][1].ToString() + "%";
                    if (Convert.ToSingle(dt.Rows[2][1].ToString()) < 3.6)
                    {
                        arcScaleRange.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
                        
                        arcScaleRange.Name = "Range0";
                        arcScaleRange.ShapeOffset = 29F;
                        this.arcScale_VAL.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRange });
                        lbl_Scale.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Green");
                    }
                    else
                    {
                        arcScaleRange.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
                        //arcScaleRange.EndValue = Convert.ToSingle(dt.Rows[2][1].ToString());
                        arcScaleRange.Name = "Range0";
                        arcScaleRange.ShapeOffset = 29F;
                        this.arcScale_VAL.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { arcScaleRange });
                        lbl_Scale.AppearanceText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
                    }
                }
            }
            catch { }
        }
    }
}
