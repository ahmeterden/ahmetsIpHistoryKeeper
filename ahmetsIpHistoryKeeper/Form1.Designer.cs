namespace ahmetsIpHistoryKeeper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_ipHistory = new System.Windows.Forms.TextBox();
            this.TB_appLogs = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_appLog = new System.Windows.Forms.Label();
            this.LBL_ipHistory = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_ipHistory
            // 
            this.TB_ipHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_ipHistory.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TB_ipHistory.Location = new System.Drawing.Point(3, 16);
            this.TB_ipHistory.Multiline = true;
            this.TB_ipHistory.Name = "TB_ipHistory";
            this.TB_ipHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_ipHistory.Size = new System.Drawing.Size(494, 465);
            this.TB_ipHistory.TabIndex = 2;
            this.TB_ipHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBs_KeyDown);
            // 
            // TB_appLogs
            // 
            this.TB_appLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_appLogs.Font = new System.Drawing.Font("Consolas", 11F);
            this.TB_appLogs.Location = new System.Drawing.Point(503, 16);
            this.TB_appLogs.Multiline = true;
            this.TB_appLogs.Name = "TB_appLogs";
            this.TB_appLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_appLogs.Size = new System.Drawing.Size(495, 465);
            this.TB_appLogs.TabIndex = 3;
            this.TB_appLogs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBs_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(230, 17);
            this.toolStripStatusLabel1.Text = "Ready (Click to run timer action manually)";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_appLog, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_ipHistory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_ipHistory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_appLogs, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 506);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // LBL_appLog
            // 
            this.LBL_appLog.AutoSize = true;
            this.LBL_appLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_appLog.Location = new System.Drawing.Point(503, 0);
            this.LBL_appLog.Name = "LBL_appLog";
            this.LBL_appLog.Size = new System.Drawing.Size(495, 13);
            this.LBL_appLog.TabIndex = 11;
            this.LBL_appLog.Text = "Temporary Application Logs";
            // 
            // LBL_ipHistory
            // 
            this.LBL_ipHistory.AutoSize = true;
            this.LBL_ipHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_ipHistory.Location = new System.Drawing.Point(3, 0);
            this.LBL_ipHistory.Name = "LBL_ipHistory";
            this.LBL_ipHistory.Size = new System.Drawing.Size(494, 13);
            this.LBL_ipHistory.TabIndex = 10;
            this.LBL_ipHistory.Text = "Today\'s IP History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ahmet\'s IP History Keeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_ipHistory;
        private System.Windows.Forms.TextBox TB_appLogs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_appLog;
        private System.Windows.Forms.Label LBL_ipHistory;
    }
}

