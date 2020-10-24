using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IP.UC
{
    public partial class UC_OSD : UserControl
    {
        public UC_OSD(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }
        

        public void BindingData(DataTable dt)
        {
            try
            {
                chartOSD.DataSource = dt.Select("DIV <> 'RATE'").CopyToDataTable();
                chartOSD.Series[0].ArgumentDataMember = "DIV";
                chartOSD.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE" });

                lblProductionQty.Text = Convert.ToDouble(dt.Rows[0]["VALUE"]).ToString("#,0") + " Prs";
                lblOSDQty.Text = Convert.ToDouble(dt.Rows[1]["VALUE"]).ToString("#,0") + " Prs";
                lblRatePercent.Text = Convert.ToDouble(dt.Rows[2]["VALUE"]).ToString("0.0#") + "%";
            }
            catch { }
        }
    }
}
