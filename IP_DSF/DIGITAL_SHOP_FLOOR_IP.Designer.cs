namespace IP
{
    partial class DIGITAL_SHOP_FLOOR_IP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIGITAL_SHOP_FLOOR_IP));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnIP_WS = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMoldWH = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::IP.WaitForm1), true, true);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picContructor = new System.Windows.Forms.PictureBox();
            this.MoldShop = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContructor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Turquoise;
            this.pnHeader.Controls.Add(this.MoldShop);
            this.pnHeader.Controls.Add(this.btnIP_WS);
            this.pnHeader.Controls.Add(this.cmdBack);
            this.pnHeader.Controls.Add(this.button2);
            this.pnHeader.Controls.Add(this.btnMoldWH);
            this.pnHeader.Controls.Add(this.lblDateTime);
            this.pnHeader.Controls.Add(this.lblTitle2);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1904, 100);
            this.pnHeader.TabIndex = 1;
            // 
            // btnIP_WS
            // 
            this.btnIP_WS.BackColor = System.Drawing.Color.Turquoise;
            this.btnIP_WS.BackgroundImage = global::IP.Properties.Resources.BtnMainG;
            this.btnIP_WS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIP_WS.FlatAppearance.BorderSize = 0;
            this.btnIP_WS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIP_WS.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnIP_WS.ForeColor = System.Drawing.Color.Yellow;
            this.btnIP_WS.Location = new System.Drawing.Point(1226, 4);
            this.btnIP_WS.Name = "btnIP_WS";
            this.btnIP_WS.Size = new System.Drawing.Size(102, 94);
            this.btnIP_WS.TabIndex = 67;
            this.btnIP_WS.Text = "IP";
            this.btnIP_WS.UseVisualStyleBackColor = false;
            this.btnIP_WS.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.Turquoise;
            this.cmdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBack.BackgroundImage")));
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(875, 0);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 66;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Visible = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.BackgroundImage = global::IP.Properties.Resources.BtnMainG;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(1335, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 94);
            this.button2.TabIndex = 1;
            this.button2.Text = "KPIs";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMoldWH
            // 
            this.btnMoldWH.BackColor = System.Drawing.Color.Turquoise;
            this.btnMoldWH.BackgroundImage = global::IP.Properties.Resources.BtnMainG;
            this.btnMoldWH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoldWH.FlatAppearance.BorderSize = 0;
            this.btnMoldWH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoldWH.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.btnMoldWH.ForeColor = System.Drawing.Color.Yellow;
            this.btnMoldWH.Location = new System.Drawing.Point(1442, 4);
            this.btnMoldWH.Name = "btnMoldWH";
            this.btnMoldWH.Size = new System.Drawing.Size(102, 94);
            this.btnMoldWH.TabIndex = 1;
            this.btnMoldWH.Text = "Mold W/H";
            this.btnMoldWH.UseVisualStyleBackColor = false;
            this.btnMoldWH.Click += new System.EventHandler(this.btnMoldWH_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1679, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(225, 100);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "20-10-2018\r\n00:00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(3, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(889, 100);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Digital Shop Floor For IP";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle2.Click += new System.EventHandler(this.lblTitle2_Click);
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Silver;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 100);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(1904, 942);
            this.tblMain.TabIndex = 2;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picContructor
            // 
            this.picContructor.BackColor = System.Drawing.Color.Transparent;
            this.picContructor.BackgroundImage = global::IP.Properties.Resources.under_construction;
            this.picContructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picContructor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picContructor.Location = new System.Drawing.Point(700, 400);
            this.picContructor.Name = "picContructor";
            this.picContructor.Size = new System.Drawing.Size(465, 417);
            this.picContructor.TabIndex = 62;
            this.picContructor.TabStop = false;
            this.picContructor.Visible = false;
            // 
            // MoldShop
            // 
            this.MoldShop.BackColor = System.Drawing.Color.Turquoise;
            this.MoldShop.BackgroundImage = global::IP.Properties.Resources.BtnMainG;
            this.MoldShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoldShop.FlatAppearance.BorderSize = 0;
            this.MoldShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoldShop.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.MoldShop.ForeColor = System.Drawing.Color.Yellow;
            this.MoldShop.Location = new System.Drawing.Point(1546, 3);
            this.MoldShop.Name = "MoldShop";
            this.MoldShop.Size = new System.Drawing.Size(102, 94);
            this.MoldShop.TabIndex = 68;
            this.MoldShop.Text = "Mold Shop";
            this.MoldShop.UseVisualStyleBackColor = false;
            this.MoldShop.Click += new System.EventHandler(this.MoldShop_Click);
            // 
            // DIGITAL_SHOP_FLOOR_IP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.picContructor);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DIGITAL_SHOP_FLOOR_IP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIGITAL_SHOP_FLOOR_OS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DIGITAL_SHOP_FLOOR_IP_FormClosing);
            this.Load += new System.EventHandler(this.DIGITAL_SHOP_FLOOR_IP_Load);
            this.VisibleChanged += new System.EventHandler(this.DIGITAL_SHOP_FLOOR_IP_VisibleChanged);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picContructor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMoldWH;
        public System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.PictureBox picContructor;
        private System.Windows.Forms.Button btnIP_WS;
        private System.Windows.Forms.Button MoldShop;
    }
}