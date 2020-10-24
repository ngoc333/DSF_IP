using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DIGITAL_SHOP_FLOOR_IP());
            //Application.Run(new FRM_BOTTOM_INV_SET_ANALYSIS());
         
        }
    }
}
