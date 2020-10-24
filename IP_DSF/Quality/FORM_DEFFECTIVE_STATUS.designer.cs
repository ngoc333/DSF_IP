namespace OS_DSF
{
    partial class FORM_DEFFECTIVE_STATUS
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public System.Windows.Forms.Button cmdBack;
        public DevExpress.XtraEditors.SimpleButton cmdMonth;
        public DevExpress.XtraEditors.SimpleButton cmdYear;
        private UC.UC_MONTH_SELECTION uC_MONTH_SELECTION1;

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_DEFFECTIVE_STATUS));
        //    this.panel1 = new System.Windows.Forms.Panel();
        //    this.button1 = new System.Windows.Forms.Button();
        //    this.lblDate = new System.Windows.Forms.Label();
        //    this.label1 = new System.Windows.Forms.Label();
        //    this.timer2 = new System.Windows.Forms.Timer(this.components);
        //    this.chart1 = new ChartDirector.WinChartViewer();
        //    this.chart2 = new ChartDirector.WinChartViewer();
        //    this.axfpSpread = new AxFPSpreadADO.AxfpSpread();
        //    this.panel1.SuspendLayout();
        //    ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).BeginInit();
        //    this.SuspendLayout();
        //    // 
        //    // panel1
        //    // 
        //    this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
        //    this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        //    this.panel1.Controls.Add(this.button1);
        //    this.panel1.Controls.Add(this.lblDate);
        //    this.panel1.Controls.Add(this.label1);
        //    this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    this.panel1.Location = new System.Drawing.Point(0, 0);
        //    this.panel1.MaximumSize = new System.Drawing.Size(1920, 109);
        //    this.panel1.MinimumSize = new System.Drawing.Size(1920, 109);
        //    this.panel1.Name = "panel1";
        //    this.panel1.Size = new System.Drawing.Size(1920, 109);
        //    this.panel1.TabIndex = 0;
        //    // 
        //    // button1
        //    // 
        //    this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        //    this.button1.Location = new System.Drawing.Point(1548, 0);
        //    this.button1.Name = "button1";
        //    this.button1.Size = new System.Drawing.Size(127, 109);
        //    this.button1.TabIndex = 58;
        //    this.button1.UseVisualStyleBackColor = true;
        //    this.button1.Click += new System.EventHandler(this.button1_Click);
        //    // 
        //    // lblDate
        //    // 
        //    this.lblDate.BackColor = System.Drawing.Color.DodgerBlue;
        //    this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //    this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
        //    this.lblDate.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.lblDate.ForeColor = System.Drawing.Color.White;
        //    this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        //    this.lblDate.Location = new System.Drawing.Point(1676, 0);
        //    this.lblDate.Name = "lblDate";
        //    this.lblDate.Size = new System.Drawing.Size(244, 109);
        //    this.lblDate.TabIndex = 46;
        //    this.lblDate.Text = "lblDate";
        //    this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        //    this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
        //    // 
        //    // label1
        //    // 
        //    this.label1.BackColor = System.Drawing.Color.DodgerBlue;
        //    this.label1.Font = new System.Drawing.Font("Malgun Gothic", 58F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.label1.ForeColor = System.Drawing.Color.White;
        //    this.label1.Location = new System.Drawing.Point(8, 0);
        //    this.label1.Name = "label1";
        //    this.label1.Size = new System.Drawing.Size(1649, 103);
        //    this.label1.TabIndex = 0;
        //    this.label1.Text = "Defective Status by Process && Reason";
        //    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //    // 
        //    // timer2
        //    // 
        //    this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
        //    // 
        //    // chart1
        //    // 
        //    this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        //                | System.Windows.Forms.AnchorStyles.Right)));
        //    this.chart1.Location = new System.Drawing.Point(1221, 116);
        //    this.chart1.Name = "chart1";
        //    this.chart1.Size = new System.Drawing.Size(683, 448);
        //    this.chart1.TabIndex = 64;
        //    this.chart1.TabStop = false;
        //    // 
        //    // chart2
        //    // 
        //    this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
        //                | System.Windows.Forms.AnchorStyles.Right)));
        //    this.chart2.Location = new System.Drawing.Point(1221, 575);
        //    this.chart2.Name = "chart2";
        //    this.chart2.Size = new System.Drawing.Size(683, 451);
        //    this.chart2.TabIndex = 65;
        //    this.chart2.TabStop = false;
        //    // 
        //    // axfpSpread
        //    // 
        //    this.axfpSpread.DataSource = null;
        //    this.axfpSpread.Location = new System.Drawing.Point(5, 114);
        //    this.axfpSpread.Name = "axfpSpread";
        //    this.axfpSpread.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfpSpread.OcxState")));
        //    this.axfpSpread.Size = new System.Drawing.Size(1207, 914);
        //    this.axfpSpread.TabIndex = 63;
        //    // 
        //    // FORM_DEFFECTIVE_STATUS
        //    // 
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        //    this.ClientSize = new System.Drawing.Size(1916, 1054);
        //    this.Controls.Add(this.chart2);
        //    this.Controls.Add(this.chart1);
        //    this.Controls.Add(this.panel1);
        //    this.Controls.Add(this.axfpSpread);
        //    this.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.KeyPreview = true;
        //    this.Name = "FORM_DEFFECTIVE_STATUS";
        //    this.Text = "FORM_DEFFECTIVE_STATUS";
        //    this.Activated += new System.EventHandler(this.FORM_DEFFECTIVE_STATUS_Activated);
        //    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_DEFFECTIVE_STATUS_FormClosing);
        //    this.Load += new System.EventHandler(this.FORM_DEFFECTIVE_STATUS_Load);
        //    this.VisibleChanged += new System.EventHandler(this.FORM_DEFFECTIVE_STATUS_VisibleChanged);
        //    this.panel1.ResumeLayout(false);
        //    ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.axfpSpread)).EndInit();
        //    this.ResumeLayout(false);

        //}

        #endregion

        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label lblDate;
        //private System.Windows.Forms.Timer timer2;
        ////private AxFPSpreadADO.AxfpSpread axfDailyReport_Header;
        //private AxFPSpreadADO.AxfpSpread axfpSpread;
        //private ChartDirector.WinChartViewer chart1;
        //private ChartDirector.WinChartViewer chart2;
        //private System.Windows.Forms.Button button1;
    }
}

