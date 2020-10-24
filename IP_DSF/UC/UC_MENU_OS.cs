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
    public partial class UC_MENU_OS : UserControl
    {
        public UC_MENU_OS(string Title)
        {
            InitializeComponent();
            lblTitle.Text = Title;
            bsVQuality.Selected = true;
        }
        #region Variable
        string _MenuName = "bsVQuality";
        #endregion
        #region Delegate
        //===menu click
        public delegate void MenuHandler(string MenuName, string ButtonCD);
        public MenuHandler OnMenuClick = null;
        #endregion

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (_MenuName != null)
            {
                if (OnMenuClick != null)
                    OnMenuClick(_MenuName, ((DevExpress.XtraEditors.SimpleButton)sender).Tag.ToString());
            }
        }

        private void bsV_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            _MenuName = e.Item.Name.ToString();
        }

    }
}
