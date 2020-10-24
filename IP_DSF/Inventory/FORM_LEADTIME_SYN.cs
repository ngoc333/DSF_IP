using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.PowerPacks;
using System.Threading;
//using System.Windows.Media.Animation;

namespace IP
{
    public partial class FORM_LEADTIME_SYN : Form
    {
        System.Drawing.Color _lineColor = System.Drawing.Color.Black;
        System.Drawing.Pen _myPen = new System.Drawing.Pen(System.Drawing.Color.Black, 3);
       // int _wlr = 6;
        int _wn = 3;
      //  DataTable _dt = null;
        int _speed = 20;
        int icount = 0;
        int iStopTruck;
        int _reload = 0;

        public FORM_LEADTIME_SYN()
        {
            InitializeComponent();
          
        }

        #region Func

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius, int corner)
        {
            try
            {
                GraphicsPath gp = new GraphicsPath();

                switch (corner)
                {
                    case 0:
                        gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
                        gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                        gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
                        gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);

                        gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
                        gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                        gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
                        gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
                        break;
                    case 1:

                        break;
                    case 2:
                        gp.AddLine(X, Y, X + width - (radius * 2), Y);
                        gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                        gp.AddLine(X + width, Y + radius, X + width, Y + height);
                        gp.AddLine(X + width, Y + height, X, Y + height);
                        gp.AddLine(X, Y + height, X, Y);
                        break;
                    case 3:
                        break;
                    case 4:
                        gp.AddLine(X, Y, X + width, Y);

                        gp.AddLine(X + width, Y, X + width, Y + height);


                        gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
                        gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                        gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);

                        break;

                    case 5:
                        gp.AddLine(X + width / 2, Y, X, Y + height / 2);
                        gp.AddLine(X + width / 2, Y, X + width, Y + height / 2);
                        gp.AddLine(X + width / 2, Y + height, X, Y + height / 2);

                        //  gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
                        // gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
                        // gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);

                        //  gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
                        //   gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
                        //    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
                        //   gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
                        break;

                }

                gp.CloseFigure();
                g.DrawPath(p, gp);
                gp.Dispose();
            }
            catch 
            {}
           
        }

        //private void animation()
        //{
        //    pn_left.Hide();
        //    pn_z1.Hide();
        //    pn_z2.Hide();
        //    pn_z3.Hide();
        //    pn_z4.Hide();
        //    pn_z5.Hide();
        //    pn_z6.Hide();
        //    pn_bottom.Hide();


        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_bottom.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_bottom.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z6.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z6.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z5.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z5.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z4.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z4.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z3.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z3.Show();
        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z2.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_z2.Show();
        //    pn_z1.Show();

        //    IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_left.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("4"));
        //    pn_left.Show();
        //}

 

        private void load_data(DataTable arg_dt)
        {
            try
            {
                if (arg_dt != null && arg_dt.Rows.Count > 0)
                {

                    add_data(pn_body, arg_dt);
                    add_data(pn_z1, arg_dt);
                    add_data(pn_z2, arg_dt);
                    add_data(pn_z3, arg_dt);
                    add_data(pn_z4, arg_dt);
                    add_data(pn_z5, arg_dt);
                    add_data(pn_z6, arg_dt);
                    add_data(pn_z7, arg_dt);
                    add_data(pn_left, arg_dt);
                    add_data(pn_bottom, arg_dt);
                    lblDaily_Plan.Text = arg_dt.Rows[0]["Daily_Plan"].ToString();
                }
            }
            catch (Exception)
            {}
            //string str_column = "";
           
        }

        private void add_data(Panel arg_pn, DataTable arg_dt)
        {
            try
            {
                foreach (Control con in arg_pn.Controls)
                {
                    if (con.Name.Substring(0, 3) == "lbl")
                    {

                        // Label lbl = (Label)con;
                        // str_column = con.Name.ToUpper();
                        con.Text = arg_dt.Rows[0][con.Name.Remove(0, 3)].ToString().Replace("  ", "\n");

                    }

                }
            }
            catch 
            {

            }
            
        }


        #endregion Func


        #region DB
        private DataTable LOAD_DATA_LEADTIME()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            System.Data.DataSet ds_ret;
            try
            {
                string process_name = "SEPHIROTH.PKG_IPEX3.SELECT_LEAD_TIME_V2";
                //ARGMODE
                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        #endregion DB


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                icount++;
                _reload++;
                lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
                //blink_oval(oval_Z1_CND);
                //blink_oval(oval_Z2_CND);
                //blink_oval(oval_Z3_CND);
                //blink_oval(oval_Z4_CND);
                //blink_oval(oval_Z5_CND);
                //blink_oval(oval_Z6_CND);

                if (icount == 5 || _reload==25)
                {
                    DataTable dt = LOAD_DATA_LEADTIME();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        load_data(dt);
                    }
                    _reload = 0;
                    icount = 10;
                } 
            }
            catch (Exception)
            {
            } 
        }

        private void setup_pn_truck(Panel arg_pn_truck, bool visible, Panel arg_pn_hide)
        {
            try
            {
                if (visible)
                {
                    arg_pn_truck.Width = 110;
                    arg_pn_truck.Height = pn_z1.Height;
                    arg_pn_truck.Location = new Point(0, 0);
                    arg_pn_truck.Visible = true;

                    arg_pn_hide.Width = pn_z1.Width - arg_pn_truck.Width;
                    arg_pn_hide.Height = arg_pn_truck.Height;
                    arg_pn_hide.Location = new Point(arg_pn_truck.Width, 0);
                    arg_pn_hide.Visible = true;
                }
                else
                {
                    arg_pn_truck.Visible = false;
                    arg_pn_hide.Visible = false;
                }
            }
            catch 
            {}
            
        }

        private void animation()
        {
            try
            {
                setup_pn_truck(pnZ1_truck, true, pnZ1_hide);
                timerZ1.Interval = 10;
                timerZ1.Start();

                setup_pn_truck(pnZ2_truck, true, pnZ2_hide);
                timerZ2.Interval = 10;
                timerZ2.Start();

                setup_pn_truck(pnZ3_truck, true, pnZ3_hide);
                timerZ3.Interval = 10;
                timerZ3.Start();

                setup_pn_truck(pnZ4_truck, true, pnZ4_hide);
                timerZ4.Interval = 10;
                timerZ4.Start();

                setup_pn_truck(pnZ5_truck, true, pnZ5_hide);
                timerZ5.Interval = 10;
                timerZ5.Start();

                setup_pn_truck(pnZ6_truck, true, pnZ6_hide);
                timerZ6.Interval = 10;
                timerZ6.Start();

                setup_pn_truck(pnZ7_truck, true, pnZ7_hide);
                timerZ7.Interval = 10;
                timerZ7.Start();
            }
            catch 
            {}
            
        }

        private void blink_oval(OvalShape arg_oval)
        {
            //if (arg_oval.FillColor == Color.Red)
            //{
            //    arg_oval.FillColor = Color.Yellow;
            //    arg_oval.BorderColor = Color.Yellow;
            //    foreach (Control con in pn_body.Controls)
            //    {
            //        if (con.Name.Length >= 10 && con.Name.Substring(0, 10) == "lbl" + arg_oval.Name.Replace("oval","") && con.BackColor==Color.Red)
            //        {
            //            con.BackColor = Color.Yellow;
            //            con.ForeColor = Color.Black;
            //        }

            //    }
            //}
            //else
            //{
            //    arg_oval.FillColor = Color.Red;
            //    arg_oval.BorderColor = Color.Red;
            //    foreach (Control con in pn_body.Controls)
            //    {
            //        if (con.Name.Length >= 10 && con.Name.Substring(0, 10) == "lbl" + arg_oval.Name.Replace("oval", "") && con.BackColor == Color.Yellow)
            //        {
            //            con.BackColor = Color.Red;
            //            con.ForeColor = Color.White;

            //        }

            //    }
            //}
        }

        private void FORM_IPEX3_LOGISTIC_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    // pn_body.Hide();
                    icount = 0;
                    timer1.Start();

                    // load_data(LOAD_DATA_LEADTIME());
                    //animation();





                    //   pn_body.Show();


                }
                else
                {

                    timer1.Stop();
                    timerZ1.Stop();
                    timerZ2.Stop();
                    timerZ3.Stop();
                    timerZ4.Stop();
                    timerZ5.Stop();
                    timerZ6.Stop();
                    timerZ7.Stop();

                }
            }
            catch 
            {}

                
        }

        
       

        private void FORM_IPEX3_LOGISTIC_Load(object sender, EventArgs e)
        {
            try
            {
                GoFullscreen(true);
                // _myPen.Width = _wlr;

                lblTitle.Text = "Comprehensive Inventory (Lead Time)";

                iStopTruck = picZ1.Location.X;
                load_data(LOAD_DATA_LEADTIME());
            }
            catch 
            {}
         //   pn_z1.Hide();

           
            
         //   IPEX_Monitor.ClassLib.WinAPI.AnimateWindow(this.pn_z1.Handle, 500, IPEX_Monitor.ClassLib.WinAPI.getSlidType("1"));           
         //   pn_z1.Show();    
          //  load_data(LOAD_DATA_LEADTIME());
           
           // lblDate.Text = string.Format(DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"));
            
            
        }




        private void lblDate_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }

        }

        #region Lable Paint

        private void lblLeft_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
            DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 2);
        }

        private void lblRec_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
            DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 5);
        }

        private void lblRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomal_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics v = e.Graphics;
          //  DrawRoundRect(v, _myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 20, 0);

            ControlPaint.DrawBorder(e.Graphics, lbl.DisplayRectangle, Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid,
                                                                      Color.Blue, _wn, ButtonBorderStyle.Solid);
        }


        private void lineArrow_Paint(object sender, PaintEventArgs e)
        {
            LineShape line = (LineShape)sender;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.NoAnchor;
            e.Graphics.DrawLine(pen, line.EndPoint, line.StartPoint);    
        }

        #endregion Lable Paint


        private void timerZ1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pnZ1_truck.Location.X >= iStopTruck)
                {
                    setup_pn_truck(pnZ1_truck, false, pnZ1_hide);
                    timerZ1.Stop();

                }
                else
                {
                    pnZ1_truck.Location = new Point(pnZ1_truck.Location.X + _speed, pnZ1_truck.Location.Y);
                    pnZ1_hide.Location = new Point(pnZ1_hide.Location.X + _speed, pnZ1_hide.Location.Y);
                    pnZ1_hide.Width = pnZ1_hide.Width - _speed;
                }
            }
            catch 
            {}
            
        }

        private void timerZ2_Tick(object sender, EventArgs e)
        {
            if (pnZ2_truck.Location.X >= iStopTruck)
            {
                setup_pn_truck(pnZ2_truck, false, pnZ2_hide);
                timerZ2.Stop();
            }
            else
            {
                pnZ2_truck.Location = new Point(pnZ2_truck.Location.X + _speed, pnZ2_truck.Location.Y);
                pnZ2_hide.Location = new Point(pnZ2_hide.Location.X + _speed, pnZ2_hide.Location.Y);
                pnZ2_hide.Width = pnZ2_hide.Width - _speed;
            }
        }

        private void timerZ3_Tick(object sender, EventArgs e)
        {
            if (pnZ3_truck.Location.X >= iStopTruck)
            {
                setup_pn_truck(pnZ3_truck, false, pnZ3_hide);
                timerZ3.Stop();
            }
            else
            {
                pnZ3_truck.Location = new Point(pnZ3_truck.Location.X + _speed, pnZ3_truck.Location.Y);
                pnZ3_hide.Location = new Point(pnZ3_hide.Location.X + _speed, pnZ3_hide.Location.Y);
                pnZ3_hide.Width = pnZ3_hide.Width - _speed;
            }
        }

        private void timerZ4_Tick(object sender, EventArgs e)
        {
            if (pnZ4_truck.Location.X >= iStopTruck)
            {
                setup_pn_truck(pnZ4_truck, false, pnZ4_hide);
                timerZ4.Stop();
            }
            else
            {
                pnZ4_truck.Location = new Point(pnZ4_truck.Location.X + _speed, pnZ4_truck.Location.Y);
                pnZ4_hide.Location = new Point(pnZ4_hide.Location.X + _speed, pnZ4_hide.Location.Y);
                pnZ4_hide.Width = pnZ4_hide.Width - _speed;
            }
        }

        private void timerZ5_Tick(object sender, EventArgs e)
        {
            if (pnZ5_truck.Location.X >= iStopTruck)
            {
                setup_pn_truck(pnZ5_truck, false, pnZ5_hide);
                timerZ5.Stop();
            }
            else
            {
                pnZ5_truck.Location = new Point(pnZ5_truck.Location.X + _speed, pnZ5_truck.Location.Y);
                pnZ5_hide.Location = new Point(pnZ5_hide.Location.X + _speed, pnZ5_hide.Location.Y);
                pnZ5_hide.Width = pnZ5_hide.Width - _speed;
            }
        }

        private void timerZ6_Tick(object sender, EventArgs e)
        {
            if (pnZ6_truck.Location.X >= iStopTruck)
            {
                setup_pn_truck(pnZ6_truck, false, pnZ6_hide);
                timerZ6.Stop();
            }
            else
            {
                pnZ6_truck.Location = new Point(pnZ6_truck.Location.X + _speed, pnZ6_truck.Location.Y);
                pnZ6_hide.Location = new Point(pnZ6_hide.Location.X + _speed, pnZ6_hide.Location.Y);
                pnZ6_hide.Width = pnZ6_hide.Width - _speed;
            }
        }

        private void timerZ7_Tick(object sender, EventArgs e)
        {
            if (pnZ7_truck.Location.X >= iStopTruck)
            {
                setup_pn_truck(pnZ7_truck, false, pnZ7_hide);
                timerZ7.Stop();
            }
            else
            {
                pnZ7_truck.Location = new Point(pnZ7_truck.Location.X + _speed, pnZ7_truck.Location.Y);
                pnZ7_hide.Location = new Point(pnZ7_hide.Location.X + _speed, pnZ7_hide.Location.Y);
                pnZ7_hide.Width = pnZ7_hide.Width - _speed;
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            try
            {

                this.Close();
            }
            catch
            {
            }
        }

        private void cmd_Week_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FORM_SMT_IP_LEADTIME_WEEK"];
            if (fc != null)
            {

                fc.Show();
                this.Hide();
            }
            else
            {
                FORM_SMT_IP_LEADTIME_WEEK f = new FORM_SMT_IP_LEADTIME_WEEK();
                f.Show();
                this.Hide();
            }
        }

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FORM_SMT_IP_LEADTIME_MONTH"];
            if (fc != null)
            {

                fc.Show();
                this.Hide();
            }
            else
            {
                FORM_SMT_IP_LEADTIME_MONTH f = new FORM_SMT_IP_LEADTIME_MONTH();
                f.Show();
                this.Hide();
                
            }
        }

        private void cmdYear_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["FORM_SMT_IP_LEADTIME_YEAR"];
            if (fc != null)
            {

                fc.Show();
                this.Hide();
            }
            else
            {
                FORM_SMT_IP_LEADTIME_YEAR f = new FORM_SMT_IP_LEADTIME_YEAR();
                f.Show();
                this.Hide();
            }
        }

       




    }
}
