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
    public partial class UC_ABSENT : UserControl
    {
        public UC_ABSENT(string Title)
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
            }
            catch { }
        }
    }
}
