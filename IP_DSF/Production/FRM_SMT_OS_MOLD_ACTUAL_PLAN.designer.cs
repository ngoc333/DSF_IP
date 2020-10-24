namespace OS_DSF
{
    partial class FRM_SMT_OS_MOLD_ACTUAL_PLAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SMT_OS_MOLD_ACTUAL_PLAN));
            this.axGrid = new AxFPUSpreadADO.AxfpSpread();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblPH3 = new System.Windows.Forms.Label();
            this.lblPH2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Actual = new System.Windows.Forms.Label();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.lbl_Shift = new System.Windows.Forms.Label();
            this.lblPH1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(2, 196);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(1914, 865);
            this.axGrid.TabIndex = 660;
            this.axGrid.BeforeEditMode += new AxFPUSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPH3
            // 
            this.lblPH3.BackColor = System.Drawing.Color.IndianRed;
            this.lblPH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH3.ForeColor = System.Drawing.Color.Black;
            this.lblPH3.Location = new System.Drawing.Point(1759, 126);
            this.lblPH3.Name = "lblPH3";
            this.lblPH3.Size = new System.Drawing.Size(143, 50);
            this.lblPH3.TabIndex = 685;
            this.lblPH3.Text = "C";
            this.lblPH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH3.Visible = false;
            // 
            // lblPH2
            // 
            this.lblPH2.BackColor = System.Drawing.Color.Gray;
            this.lblPH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPH2.Location = new System.Drawing.Point(1615, 126);
            this.lblPH2.Name = "lblPH2";
            this.lblPH2.Size = new System.Drawing.Size(143, 50);
            this.lblPH2.TabIndex = 684;
            this.lblPH2.Text = "B";
            this.lblPH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(938, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 690;
            this.label6.Text = "Difference Plan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(936, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 693;
            this.label1.Text = "Plan/Acual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // lbl_Actual
            // 
            this.lbl_Actual.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Actual.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Actual.ForeColor = System.Drawing.Color.White;
            this.lbl_Actual.Location = new System.Drawing.Point(1096, 101);
            this.lbl_Actual.Name = "lbl_Actual";
            this.lbl_Actual.Size = new System.Drawing.Size(225, 32);
            this.lbl_Actual.TabIndex = 695;
            this.lbl_Actual.Text = "Total Actual: 704";
            this.lbl_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.BackColor = System.Drawing.Color.Green;
            this.lbl_Plan.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Plan.ForeColor = System.Drawing.Color.White;
            this.lbl_Plan.Location = new System.Drawing.Point(1095, 134);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(225, 30);
            this.lbl_Plan.TabIndex = 694;
            this.lbl_Plan.Text = "Total Plan:  704";
            this.lbl_Plan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Shift.Font = new System.Drawing.Font("Calibri", 30.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Shift.ForeColor = System.Drawing.Color.White;
            this.lbl_Shift.Location = new System.Drawing.Point(703, 106);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(204, 52);
            this.lbl_Shift.TabIndex = 696;
            this.lbl_Shift.Text = "Shift 1";
            this.lbl_Shift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPH1
            // 
            this.lblPH1.BackColor = System.Drawing.Color.Gray;
            this.lblPH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPH1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPH1.Location = new System.Drawing.Point(1471, 126);
            this.lblPH1.Name = "lblPH1";
            this.lblPH1.Size = new System.Drawing.Size(143, 50);
            this.lblPH1.TabIndex = 697;
            this.lblPH1.Text = "A";
            this.lblPH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPH1.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Turquoise;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1914, 100);
            this.lblTitle.TabIndex = 698;
            this.lblTitle.Text = "Outsole Mold APS Plan && Actual";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Turquoise;
            this.pnMenu.Location = new System.Drawing.Point(1228, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(427, 93);
            this.pnMenu.TabIndex = 703;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Turquoise;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(1661, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 100);
            this.lblDate.TabIndex = 702;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.DoubleClick += new System.EventHandler(this.lblDate_DoubleClick);
            // 
            // FRM_SMT_OS_MOLD_ACTUAL_PLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1914, 1064);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPH1);
            this.Controls.Add(this.lbl_Shift);
            this.Controls.Add(this.lbl_Actual);
            this.Controls.Add(this.lbl_Plan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPH3);
            this.Controls.Add(this.lblPH2);
            this.Controls.Add(this.axGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SMT_OS_MOLD_ACTUAL_PLAN";
            this.Text = "APS Plan && Actual";
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxFPUSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblPH3;
        private System.Windows.Forms.Label lblPH2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Actual;
        private System.Windows.Forms.Label lbl_Plan;
        private System.Windows.Forms.Label lbl_Shift;
        private System.Windows.Forms.Label lblPH1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lblDate;
    }
}