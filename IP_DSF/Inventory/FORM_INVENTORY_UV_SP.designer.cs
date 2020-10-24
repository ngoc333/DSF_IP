namespace IP
{
    partial class FORM_INVENTORY_UV_SP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_INVENTORY_UV_SP));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_Body = new System.Windows.Forms.Panel();
            this.lbl_UV = new System.Windows.Forms.Label();
            this.lbl_UV_HK = new System.Windows.Forms.Label();
            this.lbl_UV_HK_SP = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Zone = new System.Windows.Forms.Label();
            this.pnChart = new System.Windows.Forms.Panel();
            this.Chart_INV = new ChartDirector.WinChartViewer();
            this.pn_main = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_reload = new System.Windows.Forms.Timer(this.components);
            this.timerDrawChart = new System.Windows.Forms.Timer(this.components);
            this.timerdRawLine = new System.Windows.Forms.Timer(this.components);
            this.cmdBack = new System.Windows.Forms.Button();
            this.axfGrid_Main = new AxFPSpreadADO.AxfpSpread();
            this.pn_Body.SuspendLayout();
            this.pnChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_INV)).BeginInit();
            this.pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axfGrid_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1914, 109);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Supermarket Inventory";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1662, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 109);
            this.lblDate.TabIndex = 47;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn_Body
            // 
            this.pn_Body.BackColor = System.Drawing.Color.White;
            this.pn_Body.Controls.Add(this.lbl_UV);
            this.pn_Body.Controls.Add(this.lbl_UV_HK);
            this.pn_Body.Controls.Add(this.lbl_UV_HK_SP);
            this.pn_Body.Controls.Add(this.lbl);
            this.pn_Body.Controls.Add(this.label4);
            this.pn_Body.Controls.Add(this.label3);
            this.pn_Body.Controls.Add(this.label2);
            this.pn_Body.Controls.Add(this.lbl_Zone);
            this.pn_Body.Controls.Add(this.pnChart);
            this.pn_Body.Controls.Add(this.pn_main);
            this.pn_Body.Controls.Add(this.label25);
            this.pn_Body.Location = new System.Drawing.Point(3, 113);
            this.pn_Body.Name = "pn_Body";
            this.pn_Body.Size = new System.Drawing.Size(1911, 939);
            this.pn_Body.TabIndex = 48;
            // 
            // lbl_UV
            // 
            this.lbl_UV.BackColor = System.Drawing.Color.Green;
            this.lbl_UV.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UV.ForeColor = System.Drawing.Color.White;
            this.lbl_UV.Location = new System.Drawing.Point(1142, 8);
            this.lbl_UV.Name = "lbl_UV";
            this.lbl_UV.Size = new System.Drawing.Size(120, 23);
            this.lbl_UV.TabIndex = 202;
            this.lbl_UV.Text = "1.5 days";
            this.lbl_UV.Visible = false;
            // 
            // lbl_UV_HK
            // 
            this.lbl_UV_HK.BackColor = System.Drawing.Color.Green;
            this.lbl_UV_HK.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UV_HK.ForeColor = System.Drawing.Color.White;
            this.lbl_UV_HK.Location = new System.Drawing.Point(1422, 8);
            this.lbl_UV_HK.Name = "lbl_UV_HK";
            this.lbl_UV_HK.Size = new System.Drawing.Size(120, 23);
            this.lbl_UV_HK.TabIndex = 201;
            this.lbl_UV_HK.Text = "2 days";
            this.lbl_UV_HK.Visible = false;
            // 
            // lbl_UV_HK_SP
            // 
            this.lbl_UV_HK_SP.BackColor = System.Drawing.Color.Green;
            this.lbl_UV_HK_SP.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UV_HK_SP.ForeColor = System.Drawing.Color.White;
            this.lbl_UV_HK_SP.Location = new System.Drawing.Point(1782, 8);
            this.lbl_UV_HK_SP.Name = "lbl_UV_HK_SP";
            this.lbl_UV_HK_SP.Size = new System.Drawing.Size(120, 23);
            this.lbl_UV_HK_SP.TabIndex = 200;
            this.lbl_UV_HK_SP.Text = "3 days";
            this.lbl_UV_HK_SP.Visible = false;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(1552, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(230, 23);
            this.lbl.TabIndex = 199;
            this.lbl.Text = "IP - UV - HK - Spray";
            this.lbl.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1271, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 198;
            this.label4.Text = "IP - UV - HK";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1042, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 197;
            this.label3.Text = "IP - UV";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 196;
            this.label2.Text = "Supermarket inventory standard";
            this.label2.Visible = false;
            // 
            // lbl_Zone
            // 
            this.lbl_Zone.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Zone.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zone.ForeColor = System.Drawing.Color.White;
            this.lbl_Zone.Location = new System.Drawing.Point(8, 37);
            this.lbl_Zone.Name = "lbl_Zone";
            this.lbl_Zone.Size = new System.Drawing.Size(1895, 45);
            this.lbl_Zone.TabIndex = 195;
            this.lbl_Zone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.Chart_INV);
            this.pnChart.Location = new System.Drawing.Point(8, 87);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(1895, 439);
            this.pnChart.TabIndex = 175;
            // 
            // Chart_INV
            // 
            this.Chart_INV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_INV.Location = new System.Drawing.Point(0, 0);
            this.Chart_INV.Name = "Chart_INV";
            this.Chart_INV.Size = new System.Drawing.Size(1895, 439);
            this.Chart_INV.TabIndex = 10;
            this.Chart_INV.TabStop = false;
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.Transparent;
            this.pn_main.Controls.Add(this.axfGrid_Main);
            this.pn_main.Location = new System.Drawing.Point(8, 532);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1895, 400);
            this.pn_main.TabIndex = 174;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(417, 822);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(210, 56);
            this.label25.TabIndex = 128;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_reload
            // 
            this.timer_reload.Tick += new System.EventHandler(this.timer_reload_Tick);
            // 
            // timerDrawChart
            // 
            this.timerDrawChart.Interval = 10;
            this.timerDrawChart.Tick += new System.EventHandler(this.timerDrawChart_Tick);
            // 
            // timerdRawLine
            // 
            this.timerdRawLine.Interval = 10;
            this.timerdRawLine.Tick += new System.EventHandler(this.timerdRawLine_Tick);
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBack.BackgroundImage = global::IP.Properties.Resources.Back_Icon;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(1548, 6);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(108, 101);
            this.cmdBack.TabIndex = 67;
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // axfGrid_Main
            // 
            this.axfGrid_Main.DataSource = null;
            this.axfGrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axfGrid_Main.Location = new System.Drawing.Point(0, 0);
            this.axfGrid_Main.Name = "axfGrid_Main";
            this.axfGrid_Main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfGrid_Main.OcxState")));
            this.axfGrid_Main.Size = new System.Drawing.Size(1895, 400);
            this.axfGrid_Main.TabIndex = 0;
            // 
            // FORM_INVENTORY_UV_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1914, 1054);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.pn_Body);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "FORM_INVENTORY_UV_SP";
            this.Text = "FORM_INVENTORY_UV_SP";
            this.Load += new System.EventHandler(this.FORM_OSD_OEE_ZONE_Load);
            this.VisibleChanged += new System.EventHandler(this.FORM_OSD_OEE_ZONE_VisibleChanged);
            this.pn_Body.ResumeLayout(false);
            this.pnChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_INV)).EndInit();
            this.pn_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axfGrid_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pn_Body;
        private System.Windows.Forms.Label label25;

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer_reload;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Panel pnChart;
        private System.Windows.Forms.Label lbl_Zone;
        private ChartDirector.WinChartViewer Chart_INV;
        private System.Windows.Forms.Label lbl_UV;
        private System.Windows.Forms.Label lbl_UV_HK;
        private System.Windows.Forms.Label lbl_UV_HK_SP;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AxFPSpreadADO.AxfpSpread axfGrid_Main;
        private System.Windows.Forms.Timer timerDrawChart;
        private System.Windows.Forms.Timer timerdRawLine;
        protected System.Windows.Forms.Button cmdBack;
       
    }
}