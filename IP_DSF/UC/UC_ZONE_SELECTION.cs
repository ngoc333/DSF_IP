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
    public partial class UC_ZONE_SELECTION : UserControl
    {
        private string sValue = "001";
      
        private string sMonthValue = "001" ;
        private string[] _arrMonthValue = { "001", "002", "003", "004", "005", "006", "007"};
        private string[] _arrMonthShortName = { "001", "002", "003", "004", "005", "006", "007" };
        private string[] _arrMonthLongName = { "001", "002", "003", "004", "005", "006", "007" };

        [Browsable(true)]   
        public event EventHandler ValueChangeEvent;
       // public event EventHandler ValueYearChangeEvent;
       // public event EventHandler ValueMonthChangeEvent;
       

        public UC_ZONE_SELECTION()
        {
            InitializeComponent();
          
            lblMonth.Text = _arrMonthShortName[Convert.ToInt32(sMonthValue) - 1].ToString();
        }
        public UC_ZONE_SELECTION(string _sYearValue, string _sMonthValue)
        {
            InitializeComponent();
            sValue = _sYearValue + _sMonthValue;
          
            lblMonth.Text = _arrMonthShortName[Convert.ToInt32(sMonthValue) - 1].ToString();
        }
   
      
        public void EnableControl(bool _b)
        {
           
            btnPrevMonth.Enabled = _b;
            btnNextMonth.Enabled = _b;
        }
        public void SetValue( string _sMonthValue)
        {
          
            sMonthValue = _sMonthValue;
          
            lblMonth.Text = _arrMonthValue[Convert.ToInt32(sMonthValue) - 1].ToString();
        }
        public void SetShortName(string _sYearValue, string _sMonthValue)
        {
          
            sMonthValue = _sMonthValue;
           
            lblMonth.Text = _arrMonthShortName[Convert.ToInt32(sMonthValue) -1 ].ToString();
        }

        public void SetLongName(string _sMonthValue)
        {
          
            sMonthValue = _sMonthValue;
          
            lblMonth.Text = _arrMonthLongName[Convert.ToInt32(sMonthValue) - 1].ToString();
        }
        public string GetValue()
        {
            return sValue;
        }
        

        public string GetMonthValue()
        {
            return sMonthValue;
        }



        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(sMonthValue) == 1)
            {
                sMonthValue = "007";
                //DO
               
                
            }
            else
            {
                sMonthValue = (Convert.ToInt32(sMonthValue) - 1).ToString("000");
            }
            sValue = sMonthValue;
            SetValue(sMonthValue);
           
            this.btnPrevMonth.Focus();
            
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sMonthValue) == 7)
            {
                sMonthValue = "001";
                //DO
               
                
            }
            else
            {
                sMonthValue = (Convert.ToInt32(sMonthValue) + 1).ToString("000");
                
            }
            sValue = sMonthValue;
            SetValue(sMonthValue);
          
            this.btnNextMonth.Focus();
        }

        private void lblMonth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EnableControl(false);
                if (this.ValueChangeEvent != null)
                {
                    this.ValueChangeEvent(this, e);
                }
                EnableControl(true);
            }
            catch (Exception ex)
            {
                EnableControl(true);
            }
        }

        

        

        
    }
}
