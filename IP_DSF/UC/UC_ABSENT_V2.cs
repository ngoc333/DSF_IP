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
    public partial class UC_ABSENT_V2 : UserControl
    {
        public UC_ABSENT_V2(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
        }

        public void BindingData(DataTable dt)
        {
            try
            {
                chartAbsent.DataSource = dt;
                chartAbsent.Series[0].ArgumentDataMember = "CAPTION";
                chartAbsent.Series[0].ValueDataMembers.AddRange(new string[] { "VALUE_DATA" });
                double dPlan = Convert.ToDouble(dt.Rows[0]["VALUE_DATA"].ToString());
                double dNoplan = Convert.ToDouble(dt.Rows[1]["VALUE_DATA"].ToString());
                double dAttend = Convert.ToDouble(dt.Rows[2]["VALUE_DATA"].ToString());
                double total = dPlan + dNoplan + dAttend;
                double dRate = 0;
                if (total == 0)
                {
                    dRate = 0;
                }
                else
                {
                    dRate = Math.Round((dPlan + dNoplan) /total * 100, 1);
                }
                lblAbsent.Text = "Total Absent" + "\n" + (dPlan + dNoplan).ToString() + " Person(s)" + "\n" + dRate.ToString() + "%";

                

               

            
            }
            catch { }
        }
    }
}
