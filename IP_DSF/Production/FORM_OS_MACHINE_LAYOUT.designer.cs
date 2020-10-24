namespace OS_DSF
{
    partial class FORM_OS_MACHINE_LAYOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_OS_MACHINE_LAYOUT));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_blind = new System.Windows.Forms.Timer(this.components);
            this.lblDmp = new System.Windows.Forms.Label();
            this.lblDmc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblNoUse = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMoldChange = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNoPlan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPlan = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.axGridRight = new AxFPUSpreadADO.AxfpSpread();
            this.axGridLeft = new AxFPUSpreadADO.AxfpSpread();
            this.axGridTop = new AxFPUSpreadADO.AxfpSpread();
            ((System.ComponentModel.ISupportInitialize)(this.axGridRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGridLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGridTop)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_blind
            // 
            this.tmr_blind.Tick += new System.EventHandler(this.tmr_blind_Tick);
            // 
            // lblDmp
            // 
            this.lblDmp.BackColor = System.Drawing.Color.IndianRed;
            this.lblDmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDmp.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmp.ForeColor = System.Drawing.Color.Black;
            this.lblDmp.Location = new System.Drawing.Point(1794, 8);
            this.lblDmp.Name = "lblDmp";
            this.lblDmp.Size = new System.Drawing.Size(120, 50);
            this.lblDmp.TabIndex = 685;
            this.lblDmp.Text = "DMP";
            this.lblDmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDmc
            // 
            this.lblDmc.BackColor = System.Drawing.Color.Gray;
            this.lblDmc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDmc.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDmc.Location = new System.Drawing.Point(1673, 8);
            this.lblDmc.Name = "lblDmc";
            this.lblDmc.Size = new System.Drawing.Size(120, 50);
            this.lblDmc.TabIndex = 684;
            this.lblDmc.Text = "DMC";
            this.lblDmc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Turquoise;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1920, 100);
            this.lblTitle.TabIndex = 686;
            this.lblTitle.Text = "Outsole Machine Layout";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblDate.Location = new System.Drawing.Point(1667, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(253, 100);
            this.lblDate.TabIndex = 687;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel6.Location = new System.Drawing.Point(736, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(54, 26);
            this.panel6.TabIndex = 699;
            // 
            // lblNoUse
            // 
            this.lblNoUse.AutoSize = true;
            this.lblNoUse.BackColor = System.Drawing.Color.Turquoise;
            this.lblNoUse.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoUse.ForeColor = System.Drawing.Color.White;
            this.lblNoUse.Location = new System.Drawing.Point(796, 65);
            this.lblNoUse.Name = "lblNoUse";
            this.lblNoUse.Size = new System.Drawing.Size(101, 33);
            this.lblNoUse.TabIndex = 698;
            this.lblNoUse.Text = "NO USE";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(983, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(54, 26);
            this.panel5.TabIndex = 697;
            // 
            // lblMoldChange
            // 
            this.lblMoldChange.AutoSize = true;
            this.lblMoldChange.BackColor = System.Drawing.Color.Turquoise;
            this.lblMoldChange.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoldChange.ForeColor = System.Drawing.Color.White;
            this.lblMoldChange.Location = new System.Drawing.Point(1043, 65);
            this.lblMoldChange.Name = "lblMoldChange";
            this.lblMoldChange.Size = new System.Drawing.Size(186, 33);
            this.lblMoldChange.TabIndex = 696;
            this.lblMoldChange.Text = "MOLD CHANGE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Location = new System.Drawing.Point(983, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 26);
            this.panel4.TabIndex = 691;
            this.panel4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Turquoise;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1043, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 690;
            this.label3.Text = "ACTUAL PLAN";
            this.label3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(736, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 26);
            this.panel2.TabIndex = 695;
            // 
            // lblNoPlan
            // 
            this.lblNoPlan.AutoSize = true;
            this.lblNoPlan.BackColor = System.Drawing.Color.Turquoise;
            this.lblNoPlan.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPlan.ForeColor = System.Drawing.Color.White;
            this.lblNoPlan.Location = new System.Drawing.Point(796, 29);
            this.lblNoPlan.Name = "lblNoPlan";
            this.lblNoPlan.Size = new System.Drawing.Size(116, 33);
            this.lblNoPlan.TabIndex = 694;
            this.lblNoPlan.Text = "NO PLAN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(736, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 26);
            this.panel3.TabIndex = 693;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.BackColor = System.Drawing.Color.Turquoise;
            this.lblPlan.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.ForeColor = System.Drawing.Color.White;
            this.lblPlan.Location = new System.Drawing.Point(796, -1);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(74, 33);
            this.lblPlan.TabIndex = 692;
            this.lblPlan.Text = "PLAN";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Turquoise;
            this.pnMenu.Location = new System.Drawing.Point(1308, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(353, 94);
            this.pnMenu.TabIndex = 701;
            // 
            // axGridRight
            // 
            this.axGridRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGridRight.DataSource = null;
            this.axGridRight.Location = new System.Drawing.Point(524, 821);
            this.axGridRight.Name = "axGridRight";
            this.axGridRight.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGridRight.OcxState")));
            this.axGridRight.Size = new System.Drawing.Size(1394, 271);
            this.axGridRight.TabIndex = 689;
            this.axGridRight.Visible = false;
            // 
            // axGridLeft
            // 
            this.axGridLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.axGridLeft.DataSource = null;
            this.axGridLeft.Location = new System.Drawing.Point(2, 821);
            this.axGridLeft.Name = "axGridLeft";
            this.axGridLeft.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGridLeft.OcxState")));
            this.axGridLeft.Size = new System.Drawing.Size(507, 273);
            this.axGridLeft.TabIndex = 688;
            // 
            // axGridTop
            // 
            this.axGridTop.DataSource = null;
            this.axGridTop.Location = new System.Drawing.Point(3, 103);
            this.axGridTop.Name = "axGridTop";
            this.axGridTop.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGridTop.OcxState")));
            this.axGridTop.Size = new System.Drawing.Size(1917, 710);
            this.axGridTop.TabIndex = 660;
            this.axGridTop.BeforeEditMode += new AxFPUSpreadADO._DSpreadEvents_BeforeEditModeEventHandler(this.axGrid_BeforeEditMode);
            // 
            // FORM_OS_MACHINE_LAYOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1092);
            this.ControlBox = false;
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblNoUse);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblMoldChange);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNoPlan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.axGridRight);
            this.Controls.Add(this.axGridLeft);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDmp);
            this.Controls.Add(this.lblDmc);
            this.Controls.Add(this.axGridTop);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_OS_MACHINE_LAYOUT";
            this.Text = "Production Status";
            this.Load += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Mold_WS_Change_By_Shift_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axGridRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGridLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGridTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxFPUSpreadADO.AxfpSpread axGridTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmr_blind;
        private System.Windows.Forms.Label lblDmp;
        private System.Windows.Forms.Label lblDmc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer2;
        private AxFPUSpreadADO.AxfpSpread axGridLeft;
        private AxFPUSpreadADO.AxfpSpread axGridRight;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNoUse;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMoldChange;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNoPlan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Panel pnMenu;
    }
}