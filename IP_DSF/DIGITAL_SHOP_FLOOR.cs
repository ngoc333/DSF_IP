using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;


namespace OS_DSF
{
    public partial class DIGITAL_SHOP_FLOOR : Form
    {
        public DIGITAL_SHOP_FLOOR()
        {
            InitializeComponent();
        }
        #region UserControl
        UC.UC_MENU_OS UC_MENU = new UC.UC_MENU_OS("MENU");
        UC.UC_OSD UC_OSD = new UC.UC_OSD("OS&&D");
        UC.UC_PRODUCTION UC_PRODUCTION = new UC.UC_PRODUCTION("Production");
        UC.UC_POD UC_POD = new UC.UC_POD("POD");
        UC.UC_INV UC_INV = new UC.UC_INV("Inventory");
        UC.UC_ABSENT UC_ABSENT = new UC.UC_ABSENT("Absenteeism");

        #endregion
        #region Variable
        int cCount = 0;
        #endregion
        #region Db
        Addons.Database Db = new Addons.Database();
        #endregion


        private void DIGITAL_SHOP_FLOOR_Load(object sender, EventArgs e)
        {
            try
            {
                if (tblMain.Controls.Count > 0)
                    tblMain.Controls.Clear();
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Đợi chút...");
                //Load All Datatable
                DataTable dtOSD = Db.SEL_OSD_DATA("Q");
                DataTable dtPROD = Db.SEL_OS_PRODUCTION_DATA("Q");
                DataTable dtINV = Db.SEL_OS_INV_DATA("Q");
                DataTable dtAbsent = Db.SEL_OS_ABSENT_DATA("Q");
                DataTable dtPOD = Db.SEL_OS_POD_DATA("Q");
                tblMain.Controls.Add(UC_MENU, 0, 0);
                UC_MENU.OnMenuClick += MenuOnClick;
                tblMain.Controls.Add(UC_OSD, 1, 0);

                tblMain.Controls.Add(UC_PRODUCTION, 2, 0);

                tblMain.Controls.Add(UC_POD, 0, 1);

                tblMain.Controls.Add(UC_INV, 1, 1);

                tblMain.Controls.Add(UC_ABSENT, 2, 1);
                UC_OSD.BindingData(dtOSD);
                UC_PRODUCTION.BindingData(dtPROD);
                UC_POD.BindingData(dtPOD);
                UC_INV.BindingData(dtINV);
                UC_ABSENT.BindingData(dtAbsent);

                splashScreenManager1.CloseWaitForm();
            }
            catch
            {
                splashScreenManager1.CloseWaitForm();
            }
        }


        void MenuOnClick(string MenuName, string BtnCD)
        {
            try
            {
                //   MessageBox.Show(MenuName + "_" + BtnCD);
                System.Windows.Forms.Form F = null;
                Form fc1 = null;
                this.Cursor = Cursors.WaitCursor;
                switch (Convert.ToInt32(BtnCD))
                {
                    case 1:
                        //Empty
                        break;
                    case 2:
                        /*Internal OS&D
                        Author: DO.IT*/
                        fc1 = Application.OpenForms["FRM_SMT_IP_OSD_MONTH"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_IP_OSD_MONTH IN_OSD = new FRM_SMT_IP_OSD_MONTH();
                        F = IN_OSD;

                        break;
                    case 3:
                        /*External OS&D
                       Author: DO.IT*/
                        fc1 = Application.OpenForms["FRM_SMT_OS_OSD_EXT_MONTH"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_OS_OSD_EXT_MONTH EXT_OSD = new FRM_SMT_OS_OSD_EXT_MONTH();
                        F = EXT_OSD;

                        break;

                    case 4:
                        /*Mold OverHoul 
                        Author: Ngọc.IT*/
                        fc1 = Application.OpenForms["FORM_IP_MOLD_OVERHAUL"];
                        if (fc1 != null)
                            fc1.Close();
                        FORM_IP_MOLD_OVERHAUL OS_OVERHAUL = new FORM_IP_MOLD_OVERHAUL();
                        F = OS_OVERHAUL;

                        break;
                    case 5:
                        /*Mold Layout 
                       Author: Ngọc.IT*/
                        fc1 = Application.OpenForms["FORM_OS_MACHINE_LAYOUT"];
                        if (fc1 != null)
                            fc1.Close();
                        FORM_OS_MACHINE_LAYOUT OS_LAYOUT = new FORM_OS_MACHINE_LAYOUT();
                        F = OS_LAYOUT;

                        break;
                    case 6:
                        /*Mold Layout 
                     Author: Ngọc.IT*/
                        fc1 = Application.OpenForms["FRM_SMT_OS_MOLD_ACTUAL_PLAN"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_OS_MOLD_ACTUAL_PLAN MOLD_PLAN_ACTUAL = new FRM_SMT_OS_MOLD_ACTUAL_PLAN();
                        F = MOLD_PLAN_ACTUAL;
                        break;
                    case 7:
                        /*Production Status
                          Author: DO.IT*/
                        fc1 = Application.OpenForms["FRM_SMT_OS_PROD_DAILY"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_OS_PROD_DAILY PROD_STATS = new FRM_SMT_OS_PROD_DAILY();
                        F = PROD_STATS;
                        break;
                    case 8:/*OEE MONTH
                          Author: LUAN.IT*/
                        fc1 = Application.OpenForms["FRM_SMT_OS_OEE"];
                        if (fc1 != null)
                            fc1.Close();
                        Machinery.FRM_SMT_OS_OEE OS_OEE = new Machinery.FRM_SMT_OS_OEE();
                        F = OS_OEE;
                        break;
                        
                    case 9:
                        break;
                    case 10:
                        fc1 = Application.OpenForms["FRM_SMT_OS_INVENTORY"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_OS_INVENTORY OS_INV = new FRM_SMT_OS_INVENTORY();
                        F = OS_INV;
                        break;
                    case 11:
                        fc1 = Application.OpenForms["FRM_SMT_OS_FSS_INVENTORY"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_OS_FSS_INVENTORY OS_FSS_INV = new FRM_SMT_OS_FSS_INVENTORY();
                        F = OS_FSS_INV;
                        break;
                        break;
                    case 12:
                        /*Absent
                          Author: NGOC.IT*/
                        fc1 = Application.OpenForms["FRM_SMT_OS_HR_ABSENT"];
                        if (fc1 != null)
                            fc1.Close();
                        FRM_SMT_OS_HR_ABSENT HR_ABSENT = new FRM_SMT_OS_HR_ABSENT();
                        F = HR_ABSENT;
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        ///*LeadTime
                        //  Author: NGOC.IT*/
                        //fc1 = Application.OpenForms["FORM_SMT_OS_LEADTIME"];
                        //if (fc1 != null)
                        //    fc1.Close();
                       
                        //FORM_SMT_OS_LEADTIME LEADTIME_OS = new FORM_SMT_OS_LEADTIME();
                        //F = LEADTIME_OS;
                        break;

                    default:
                        break;
                }
                if (F != null)
                {

                    F.Show();
                    F.BringToFront();

                    if (Db.INSERT_FRM_LOG("OS_SMT", this.Name + " (Inside Office)", BtnCD, F.Name, "Open Form", GetIP() + "/" + System.Environment.MachineName)){ }
                    this.Cursor = Cursors.Default;
                }
                else
                    this.Cursor = Cursors.Default;
                

            }
            catch { this.Cursor = Cursors.Default; }
        }


        private string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName(); 

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();

        }

        private void lblDateTime_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDateTime.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                cCount++;
                if (cCount >= 30)
                {
                    //splashScreenManager1.ShowWaitForm();
                    //splashScreenManager1.SetWaitFormCaption("Đợi chút...");
                    DataTable dtOSD = Db.SEL_OSD_DATA("Q");
                    DataTable dtPROD = Db.SEL_OS_PRODUCTION_DATA("Q");
                    DataTable dtINV = Db.SEL_OS_INV_DATA("Q");
                    DataTable dtAbsent = Db.SEL_OS_ABSENT_DATA("Q");
                    DataTable dtPOD = Db.SEL_OS_POD_DATA("Q");

                    //  splashScreenManager1.SetWaitFormDescription("Loading Data...");
                    UC_OSD.BindingData(dtOSD);
                    UC_PRODUCTION.BindingData(dtPROD);
                    UC_POD.BindingData(dtPOD);
                    UC_INV.BindingData(dtINV);
                    UC_ABSENT.BindingData(dtAbsent);
                    // splashScreenManager1.CloseWaitForm();
                    cCount = 0;
                }
            }
            catch
            { //splashScreenManager1.CloseWaitForm(); 
            }
        }

        private void lblTitle2_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            //DataTable dtOSD = Db.SEL_OSD_DATA("Q");
            //DataTable dtPROD = Db.SEL_OS_PRODUCTION_DATA("Q");
            //DataTable dtINV = Db.SEL_OS_INV_DATA("Q");
            //DataTable dtAbsent = Db.SEL_OS_ABSENT_DATA("Q");
            //DataTable dtPOD = Db.SEL_OS_POD_DATA("Q");


            //UC_OSD.BindingData(dtOSD);
            //UC_PRODUCTION.BindingData(dtPROD);
            //UC_POD.BindingData(dtPOD);
            //UC_INV.BindingData(dtINV);
            //UC_ABSENT.BindingData(dtAbsent);
            cCount = 0;
        }
    }
}
