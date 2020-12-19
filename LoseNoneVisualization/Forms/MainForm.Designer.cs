
namespace LosePanel.Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tblMainLayouter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnlinePlayerNumber = new System.Windows.Forms.Label();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblLoseNoneAnalStat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpOnlinePlayers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.chartOnlinePlayers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpLog = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbLogApp = new System.Windows.Forms.RichTextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIsLogConnected = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBgImagePath = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDataProvider = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numRefreshFrequency = new System.Windows.Forms.NumericUpDown();
            this.btnBgImageSelect = new System.Windows.Forms.Button();
            this.tbpAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAbtProviderName = new System.Windows.Forms.Label();
            this.lblAbtWrittenBy = new System.Windows.Forms.Label();
            this.rtbAbtDescription = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.mclDateSelector = new System.Windows.Forms.MonthCalendar();
            this.label13 = new System.Windows.Forms.Label();
            this.tblMainLayouter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbpOnlinePlayers.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOnlinePlayers)).BeginInit();
            this.tbpLog.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshFrequency)).BeginInit();
            this.tbpAbout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainLayouter
            // 
            this.tblMainLayouter.ColumnCount = 1;
            this.tblMainLayouter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayouter.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblMainLayouter.Controls.Add(this.tabControl1, 0, 2);
            this.tblMainLayouter.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tblMainLayouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayouter.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayouter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMainLayouter.Name = "tblMainLayouter";
            this.tblMainLayouter.RowCount = 3;
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainLayouter.Size = new System.Drawing.Size(1132, 595);
            this.tblMainLayouter.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 20);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "在线玩家";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOnlinePlayerNumber
            // 
            this.lblOnlinePlayerNumber.AutoSize = true;
            this.lblOnlinePlayerNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOnlinePlayerNumber.Location = new System.Drawing.Point(72, 0);
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
            this.lblProviderName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProviderName.Location = new System.Drawing.Point(1011, 0);
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
            this.lblLoseNoneAnalStat.Location = new System.Drawing.Point(1129, 0);
            this.lblLoseNoneAnalStat.Name = "lblLoseNoneAnalStat";
            this.lblLoseNoneAnalStat.Size = new System.Drawing.Size(0, 23);
            this.lblLoseNoneAnalStat.TabIndex = 4;
            this.lblLoseNoneAnalStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::LosePanel.Properties.Resources.Cloud_256px_1075710_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(980, 3);
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
            this.tabControl1.Controls.Add(this.tbpLog);
            this.tabControl1.Controls.Add(this.tbpSettings);
            this.tabControl1.Controls.Add(this.tbpAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 101);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 491);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbpOnlinePlayers
            // 
            this.tbpOnlinePlayers.Controls.Add(this.tableLayoutPanel7);
            this.tbpOnlinePlayers.Location = new System.Drawing.Point(4, 4);
            this.tbpOnlinePlayers.Name = "tbpOnlinePlayers";
            this.tbpOnlinePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOnlinePlayers.Size = new System.Drawing.Size(1118, 461);
            this.tbpOnlinePlayers.TabIndex = 0;
            this.tbpOnlinePlayers.Text = "在线人数";
            this.tbpOnlinePlayers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.chartOnlinePlayers, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1112, 455);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // chartOnlinePlayers
            // 
            this.chartOnlinePlayers.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartOnlinePlayers.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartOnlinePlayers.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.Title = "时间";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.Interval = 1D;
            chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.Interval = 1D;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisY.MinorGrid.Interval = 1D;
            chartArea1.AxisY.MinorTickMark.Interval = 1D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisY.Title = "玩家数";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ctaPlayers";
            this.chartOnlinePlayers.ChartAreas.Add(chartArea1);
            this.chartOnlinePlayers.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chartOnlinePlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartOnlinePlayers.Location = new System.Drawing.Point(3, 3);
            this.chartOnlinePlayers.Name = "chartOnlinePlayers";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.DodgerBlue;
            series1.BorderWidth = 5;
            series1.ChartArea = "ctaPlayers";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.LightSteelBlue;
            series1.EmptyPointStyle.AxisLabel = "0";
            series1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            series1.LegendText = "在线玩家数";
            series1.MarkerBorderColor = System.Drawing.Color.DodgerBlue;
            series1.MarkerColor = System.Drawing.Color.DodgerBlue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "serOnlinePlayerNumber";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.ShadowOffset = 2;
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.YValuesPerPoint = 2;
            this.chartOnlinePlayers.Series.Add(series1);
            this.chartOnlinePlayers.Size = new System.Drawing.Size(862, 449);
            this.chartOnlinePlayers.TabIndex = 0;
            this.chartOnlinePlayers.Text = "各时段在线玩家数";
            title1.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title1.Name = "titRealtimePlayers";
            title1.Text = "各时段在线玩家数";
            this.chartOnlinePlayers.Titles.Add(title1);
            // 
            // tbpLog
            // 
            this.tbpLog.Controls.Add(this.tableLayoutPanel5);
            this.tbpLog.Location = new System.Drawing.Point(4, 4);
            this.tbpLog.Name = "tbpLog";
            this.tbpLog.Size = new System.Drawing.Size(1118, 461);
            this.tbpLog.TabIndex = 3;
            this.tbpLog.Text = "日志";
            this.tbpLog.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label10, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.rtbLogApp, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.rtbLog, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1118, 461);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(562, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 16, 3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(553, 28);
            this.label10.TabIndex = 6;
            this.label10.Text = "面板";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbLogApp
            // 
            this.rtbLogApp.BackColor = System.Drawing.Color.White;
            this.rtbLogApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogApp.Location = new System.Drawing.Point(562, 78);
            this.rtbLogApp.Name = "rtbLogApp";
            this.rtbLogApp.ReadOnly = true;
            this.rtbLogApp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLogApp.Size = new System.Drawing.Size(553, 380);
            this.rtbLogApp.TabIndex = 4;
            this.rtbLogApp.Text = "";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(3, 78);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(553, 380);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblIsLogConnected, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1112, 17);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "日志系统连接状态：";
            // 
            // lblIsLogConnected
            // 
            this.lblIsLogConnected.AutoSize = true;
            this.lblIsLogConnected.Location = new System.Drawing.Point(125, 0);
            this.lblIsLogConnected.Name = "lblIsLogConnected";
            this.lblIsLogConnected.Size = new System.Drawing.Size(44, 17);
            this.lblIsLogConnected.TabIndex = 1;
            this.lblIsLogConnected.Text = "未连接";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 16, 3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(553, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "服务器";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.tableLayoutPanel2);
            this.tbpSettings.Location = new System.Drawing.Point(4, 4);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Size = new System.Drawing.Size(1118, 461);
            this.tbpSettings.TabIndex = 1;
            this.tbpSettings.Text = "设置";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblBgImagePath, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbDataProvider, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveSettings, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.numRefreshFrequency, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBgImageSelect, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1118, 126);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(471, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 33);
            this.label12.TabIndex = 10;
            this.label12.Text = "此图片将作为面板背景。";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBgImagePath
            // 
            this.lblBgImagePath.AutoSize = true;
            this.lblBgImagePath.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBgImagePath.Location = new System.Drawing.Point(65, 60);
            this.lblBgImagePath.Name = "lblBgImagePath";
            this.lblBgImagePath.Size = new System.Drawing.Size(20, 33);
            this.lblBgImagePath.TabIndex = 8;
            this.lblBgImagePath.Text = "无";
            this.lblBgImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Location = new System.Drawing.Point(3, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 33);
            this.label11.TabIndex = 7;
            this.label11.Text = "背景图片";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(471, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(536, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "数据刷新频率，单位为秒。注意，这是面板从数据源获得数据的频率，并非数据源更新数据的频率。";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "刷新频率";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据源";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDataProvider
            // 
            this.cmbDataProvider.FormattingEnabled = true;
            this.cmbDataProvider.Items.AddRange(new object[] {
            "（预置）洛书南统计服务器"});
            this.cmbDataProvider.Location = new System.Drawing.Point(65, 3);
            this.cmbDataProvider.Name = "cmbDataProvider";
            this.cmbDataProvider.Size = new System.Drawing.Size(201, 25);
            this.cmbDataProvider.TabIndex = 1;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.AutoSize = true;
            this.btnSaveSettings.Location = new System.Drawing.Point(1013, 96);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(102, 27);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "保存并重启软件";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(471, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "选择面板数据来源。您可以将自定义数据源放置在面板目录中 DataProviders 文件夹下。";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numRefreshFrequency
            // 
            this.numRefreshFrequency.AutoSize = true;
            this.numRefreshFrequency.Dock = System.Windows.Forms.DockStyle.Left;
            this.numRefreshFrequency.Location = new System.Drawing.Point(65, 34);
            this.numRefreshFrequency.Name = "numRefreshFrequency";
            this.numRefreshFrequency.Size = new System.Drawing.Size(45, 23);
            this.numRefreshFrequency.TabIndex = 5;
            this.numRefreshFrequency.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBgImageSelect
            // 
            this.btnBgImageSelect.AutoSize = true;
            this.btnBgImageSelect.Location = new System.Drawing.Point(1013, 63);
            this.btnBgImageSelect.Name = "btnBgImageSelect";
            this.btnBgImageSelect.Size = new System.Drawing.Size(63, 27);
            this.btnBgImageSelect.TabIndex = 9;
            this.btnBgImageSelect.Text = "选择...";
            this.btnBgImageSelect.UseVisualStyleBackColor = true;
            this.btnBgImageSelect.Click += new System.EventHandler(this.btnBgImageSelect_Click);
            // 
            // tbpAbout
            // 
            this.tbpAbout.Controls.Add(this.tableLayoutPanel4);
            this.tbpAbout.Location = new System.Drawing.Point(4, 4);
            this.tbpAbout.Name = "tbpAbout";
            this.tbpAbout.Size = new System.Drawing.Size(1118, 461);
            this.tbpAbout.TabIndex = 2;
            this.tbpAbout.Text = "关于";
            this.tbpAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 415F));
            this.tableLayoutPanel4.Controls.Add(this.richTextBox1, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblAbtProviderName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblAbtWrittenBy, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rtbAbtDescription, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1118, 461);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(718, 107);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(390, 351);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "主程序：XianlitiCN\n测试：mofcandy\n协助：Qiaoyiiii6\n\n洛书面板——Minecraft 服务器面板，多平台通用，可自行适配服务器，提供" +
    "数据统计、日志管理等功能。\n欢迎加入洛书南（Losenone）服务器：https://www.losenone.cn\n更多信息请移步洛书面板官网：https:/" +
    "/lp.apocalypse.icu";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(718, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "V0.3 霜";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(713, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "洛书面板";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAbtProviderName
            // 
            this.lblAbtProviderName.AutoSize = true;
            this.lblAbtProviderName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAbtProviderName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAbtProviderName.Location = new System.Drawing.Point(10, 0);
            this.lblAbtProviderName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblAbtProviderName.Name = "lblAbtProviderName";
            this.lblAbtProviderName.Size = new System.Drawing.Size(104, 66);
            this.lblAbtProviderName.TabIndex = 0;
            this.lblAbtProviderName.Text = "数据源";
            this.lblAbtProviderName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAbtWrittenBy
            // 
            this.lblAbtWrittenBy.AutoSize = true;
            this.lblAbtWrittenBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAbtWrittenBy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAbtWrittenBy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAbtWrittenBy.Location = new System.Drawing.Point(15, 66);
            this.lblAbtWrittenBy.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblAbtWrittenBy.Name = "lblAbtWrittenBy";
            this.lblAbtWrittenBy.Size = new System.Drawing.Size(106, 38);
            this.lblAbtWrittenBy.TabIndex = 1;
            this.lblAbtWrittenBy.Text = "数据源开发者";
            // 
            // rtbAbtDescription
            // 
            this.rtbAbtDescription.BackColor = System.Drawing.Color.White;
            this.rtbAbtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAbtDescription.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbAbtDescription.Location = new System.Drawing.Point(15, 107);
            this.rtbAbtDescription.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.rtbAbtDescription.Name = "rtbAbtDescription";
            this.rtbAbtDescription.ReadOnly = true;
            this.rtbAbtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAbtDescription.Size = new System.Drawing.Size(564, 351);
            this.rtbAbtDescription.TabIndex = 2;
            this.rtbAbtDescription.Text = "数据源说明";
            this.rtbAbtDescription.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1132, 73);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 73);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "洛书面板 LosePanel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.mclDateSelector, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(871, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(238, 449);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // mclDateSelector
            // 
            this.mclDateSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.mclDateSelector.Location = new System.Drawing.Point(9, 37);
            this.mclDateSelector.Name = "mclDateSelector";
            this.mclDateSelector.TabIndex = 2;
            this.mclDateSelector.TodayDate = new System.DateTime(2020, 12, 19, 0, 0, 0, 0);
            this.mclDateSelector.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mclDateSelector_DateChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("微软雅黑 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 28);
            this.label13.TabIndex = 3;
            this.label13.Text = "历史记录";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 595);
            this.Controls.Add(this.tblMainLayouter);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(781, 380);
            this.Name = "MainForm";
            this.Text = "洛书面板 - 代号霜";
            this.tblMainLayouter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbpOnlinePlayers.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOnlinePlayers)).EndInit();
            this.tbpLog.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tbpSettings.ResumeLayout(false);
            this.tbpSettings.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshFrequency)).EndInit();
            this.tbpAbout.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayouter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnlinePlayerNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpOnlinePlayers;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoseNoneAnalStat;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDataProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tbpAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblAbtProviderName;
        private System.Windows.Forms.Label lblAbtWrittenBy;
        private System.Windows.Forms.RichTextBox rtbAbtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numRefreshFrequency;
        private System.Windows.Forms.TabPage tbpLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIsLogConnected;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbLogApp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBgImagePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBgImageSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOnlinePlayers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.MonthCalendar mclDateSelector;
        private System.Windows.Forms.Label label13;
    }
}

