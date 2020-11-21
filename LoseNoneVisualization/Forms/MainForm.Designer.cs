
namespace LoseNoneVisualization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tblMainLayouter = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnlinePlayerNumber = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartOnlinePlayers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoseNoneAnalStat = new System.Windows.Forms.Label();
            this.tblMainLayouter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOnlinePlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMainLayouter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblMainLayouter.Size = new System.Drawing.Size(1006, 439);
            this.tblMainLayouter.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑 Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LoseNone 实时";
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLoseNoneAnalStat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 20);
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
            // 
            // lblOnlinePlayerNumber
            // 
            this.lblOnlinePlayerNumber.AutoSize = true;
            this.lblOnlinePlayerNumber.Location = new System.Drawing.Point(65, 0);
            this.lblOnlinePlayerNumber.Name = "lblOnlinePlayerNumber";
            this.lblOnlinePlayerNumber.Size = new System.Drawing.Size(15, 17);
            this.lblOnlinePlayerNumber.TabIndex = 1;
            this.lblOnlinePlayerNumber.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 369);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartOnlinePlayers);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "在线人数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartOnlinePlayers
            // 
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.MajorGrid.Interval = 1D;
            chartArea6.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX.Title = "从 0 点开始的小时数";
            chartArea6.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea6.AxisY.Title = "玩家数";
            chartArea6.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.BackColor = System.Drawing.Color.White;
            chartArea6.BackSecondaryColor = System.Drawing.Color.White;
            chartArea6.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea6.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea6.Name = "ctaPlayers";
            this.chartOnlinePlayers.ChartAreas.Add(chartArea6);
            this.chartOnlinePlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.IsTextAutoFit = false;
            legend6.Name = "lgnNormal";
            legend6.Title = "图例";
            this.chartOnlinePlayers.Legends.Add(legend6);
            this.chartOnlinePlayers.Location = new System.Drawing.Point(3, 3);
            this.chartOnlinePlayers.Name = "chartOnlinePlayers";
            series6.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series6.BorderWidth = 3;
            series6.ChartArea = "ctaPlayers";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.RoyalBlue;
            series6.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsValueShownAsLabel = true;
            series6.Legend = "lgnNormal";
            series6.LegendText = "在线玩家数";
            series6.MarkerBorderColor = System.Drawing.Color.RoyalBlue;
            series6.MarkerColor = System.Drawing.Color.RoyalBlue;
            series6.MarkerSize = 6;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "serOnlinePlayerNumber";
            series6.ShadowColor = System.Drawing.Color.White;
            series6.ShadowOffset = 1;
            series6.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            this.chartOnlinePlayers.Series.Add(series6);
            this.chartOnlinePlayers.Size = new System.Drawing.Size(986, 333);
            this.chartOnlinePlayers.TabIndex = 0;
            this.chartOnlinePlayers.Text = "chart1";
            title6.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title6.Name = "titRealtimePlayers";
            title6.Text = "实时玩家数";
            this.chartOnlinePlayers.Titles.Add(title6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(86, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "LoseNone 统计器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::LoseNoneVisualization.Properties.Resources.Tick_24px_1061514_easyicon_net;
            this.pictureBox1.Location = new System.Drawing.Point(922, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoseNoneAnalStat
            // 
            this.lblLoseNoneAnalStat.AutoSize = true;
            this.lblLoseNoneAnalStat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoseNoneAnalStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoseNoneAnalStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoseNoneAnalStat.Location = new System.Drawing.Point(953, 0);
            this.lblLoseNoneAnalStat.Name = "lblLoseNoneAnalStat";
            this.lblLoseNoneAnalStat.Size = new System.Drawing.Size(44, 23);
            this.lblLoseNoneAnalStat.TabIndex = 4;
            this.lblLoseNoneAnalStat.Text = "未连接";
            this.lblLoseNoneAnalStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 439);
            this.Controls.Add(this.tblMainLayouter);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(781, 380);
            this.Name = "MainForm";
            this.Text = "LoseNone 可视化 - 代号霜";
            this.tblMainLayouter.ResumeLayout(false);
            this.tblMainLayouter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOnlinePlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayouter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnlinePlayerNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOnlinePlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoseNoneAnalStat;
    }
}

