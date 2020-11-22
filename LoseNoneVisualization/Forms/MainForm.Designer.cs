
namespace LosePanel
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tblMainLayouter = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnlinePlayerNumber = new System.Windows.Forms.Label();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblLoseNoneAnalStat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpOnlinePlayers = new System.Windows.Forms.TabPage();
            this.chartOnlinePlayers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataProvider = new System.Windows.Forms.ComboBox();
            this.tblMainLayouter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpOnlinePlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOnlinePlayers)).BeginInit();
            this.tbpSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainLayouter
            // 
            this.tblMainLayouter.ColumnCount = 1;
            this.tblMainLayouter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayouter.Controls.Add(this.lblTitle, 0, 0);
            this.tblMainLayouter.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblMainLayouter.Controls.Add(this.tabControl1, 0, 2);
            this.tblMainLayouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayouter.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMainLayouter.Name = "tblMainLayouter";
            this.tblMainLayouter.RowCount = 3;
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tblMainLayouter.Size = new System.Drawing.Size(976, 444);
            this.tblMainLayouter.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑 Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "洛书面板 - 实时";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOnlinePlayerNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProviderName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLoseNoneAnalStat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 20);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "在线玩家";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOnlinePlayerNumber
            // 
            this.lblOnlinePlayerNumber.AutoSize = true;
            this.lblOnlinePlayerNumber.Location = new System.Drawing.Point(65, 0);
            this.lblOnlinePlayerNumber.Name = "lblOnlinePlayerNumber";
            this.lblOnlinePlayerNumber.Size = new System.Drawing.Size(32, 17);
            this.lblOnlinePlayerNumber.TabIndex = 1;
            this.lblOnlinePlayerNumber.Text = "未知";
            this.lblOnlinePlayerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProviderName.Location = new System.Drawing.Point(849, 0);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(112, 23);
            this.lblProviderName.TabIndex = 2;
            this.lblProviderName.Text = "正在连接数据源……";
            this.lblProviderName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLoseNoneAnalStat
            // 
            this.lblLoseNoneAnalStat.AutoSize = true;
            this.lblLoseNoneAnalStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoseNoneAnalStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoseNoneAnalStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoseNoneAnalStat.Location = new System.Drawing.Point(967, 0);
            this.lblLoseNoneAnalStat.Name = "lblLoseNoneAnalStat";
            this.lblLoseNoneAnalStat.Size = new System.Drawing.Size(0, 23);
            this.lblLoseNoneAnalStat.TabIndex = 4;
            this.lblLoseNoneAnalStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::LosePanel.Properties.Resources.Cloud_256px_1075710_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(818, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tbpOnlinePlayers);
            this.tabControl1.Controls.Add(this.tbpSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 360);
            this.tabControl1.TabIndex = 2;
            // 
            // tbpOnlinePlayers
            // 
            this.tbpOnlinePlayers.Controls.Add(this.chartOnlinePlayers);
            this.tbpOnlinePlayers.Location = new System.Drawing.Point(4, 4);
            this.tbpOnlinePlayers.Name = "tbpOnlinePlayers";
            this.tbpOnlinePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOnlinePlayers.Size = new System.Drawing.Size(962, 330);
            this.tbpOnlinePlayers.TabIndex = 0;
            this.tbpOnlinePlayers.Text = "在线人数";
            this.tbpOnlinePlayers.UseVisualStyleBackColor = true;
            // 
            // chartOnlinePlayers
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.Title = "从 0 点开始的小时数";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea3.AxisY.Title = "玩家数";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea3.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.Name = "ctaPlayers";
            this.chartOnlinePlayers.ChartAreas.Add(chartArea3);
            this.chartOnlinePlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "lgnNormal";
            legend3.Title = "图例";
            this.chartOnlinePlayers.Legends.Add(legend3);
            this.chartOnlinePlayers.Location = new System.Drawing.Point(3, 3);
            this.chartOnlinePlayers.Name = "chartOnlinePlayers";
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ctaPlayers";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "lgnNormal";
            series3.LegendText = "在线玩家数";
            series3.MarkerBorderColor = System.Drawing.Color.RoyalBlue;
            series3.MarkerColor = System.Drawing.Color.RoyalBlue;
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "serOnlinePlayerNumber";
            series3.ShadowColor = System.Drawing.Color.White;
            series3.ShadowOffset = 1;
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            this.chartOnlinePlayers.Series.Add(series3);
            this.chartOnlinePlayers.Size = new System.Drawing.Size(956, 324);
            this.chartOnlinePlayers.TabIndex = 0;
            this.chartOnlinePlayers.Text = "chart1";
            title3.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title3.Name = "titRealtimePlayers";
            title3.Text = "实时玩家数";
            this.chartOnlinePlayers.Titles.Add(title3);
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.tableLayoutPanel2);
            this.tbpSettings.Location = new System.Drawing.Point(4, 4);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Size = new System.Drawing.Size(962, 330);
            this.tbpSettings.TabIndex = 1;
            this.tbpSettings.Text = "设置";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 386F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbDataProvider, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 21);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据源";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDataProvider
            // 
            this.cmbDataProvider.FormattingEnabled = true;
            this.cmbDataProvider.Items.AddRange(new object[] {
            "洛书南统计服务器",
            "自定义数据源……"});
            this.cmbDataProvider.Location = new System.Drawing.Point(53, 3);
            this.cmbDataProvider.Name = "cmbDataProvider";
            this.cmbDataProvider.Size = new System.Drawing.Size(201, 25);
            this.cmbDataProvider.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 444);
            this.Controls.Add(this.tblMainLayouter);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(781, 380);
            this.Name = "MainForm";
            this.Text = "洛书面板 - 代号霜";
            this.tblMainLayouter.ResumeLayout(false);
            this.tblMainLayouter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpOnlinePlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOnlinePlayers)).EndInit();
            this.tbpSettings.ResumeLayout(false);
            this.tbpSettings.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayouter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnlinePlayerNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpOnlinePlayers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOnlinePlayers;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoseNoneAnalStat;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDataProvider;
    }
}

