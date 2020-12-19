﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LosePanel.SDK;
using LosePanel.Presets;
using LosePanel.DataSystem;

namespace LosePanel.Forms
{
    public partial class MainForm : Form
    {
        IDataProvidable dp;

        Timer timer = new Timer();
        long TimerInterval { set; get; }

        /// <summary>
        /// 以半小时为单位的时间轴。
        /// </summary>
        public static List<double> OnlinePlayerAxis = new List<double>() { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5,
            4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5,
            13, 13.5, 14, 14.5, 15, 15.5, 16, 16.5, 17, 17.5, 18, 18.5, 19, 19.5, 20, 20.5,
            21, 21.5, 22, 22.5, 23, 23.5 };

        public MainForm()
        {
            InitializeComponent();

            //设置字体
            //Font FZYH = new Font(Program.CustomFont.Families[0], 11);
            //this.Font = FZYH;

            //将设置载入管理器
            SettingsManager.LoadOn();
            LogApp("设置已载入管理器。");
            LoadSettingsIntoUI();

            //设置Timer
            timer.Interval = SettingsManager.RefreshFrequency * 1000;
            timer.Tick += UpdateDataDisplay;
            timer.Start();
            LogApp("计时器开始，每" + SettingsManager.RefreshFrequency.ToString() + "秒一次。");

            //设置控件
            lblAbtProviderName.Text = dp.ProviderName;
            lblAbtWrittenBy.Text = dp.WrittenBy;
            rtbAbtDescription.Text = dp.Description;

            //设置背景图片
            //string url = SettingsManager.BackgroundImagePath;
            //chartOnlinePlayers.BackImage = url;
        }

        /// <summary>
        /// 更新数据显示。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDataDisplay(object sender, EventArgs e)
        {
            try
            {
                //更新数据源名
                lblProviderName.Text = "数据源：" + dp.ProviderName;

                //更新在线玩家数
                lblOnlinePlayerNumber.Text = dp.OnlinePlayerNumber.ToString();
                LogApp("在线玩家数已获取。");

                //更新图表
                List<TimePointPlayerNumber> timep = dp.GetPlayerNumbersOfDay(mclDateSelector.SelectionStart);//取得各时段玩家数
                if (timep != null)
                {
                    List<string> XValues = new List<string>();
                    List<int> YValues = new List<int>();
                    foreach (var v in timep)
                    {
                        string hour = v.TimePoint.Hour.ToString();
                        if (hour.Length == 1)
                        { hour = "0" + hour; }
                        string min = v.TimePoint.Minute.ToString();
                        if (min.Length == 1)
                        { min = "0" + min; }
                        string full = hour + ":" + min;
                        XValues.Add(full);

                        YValues.Add(v.PlayerNumber);
                    }
                    chartOnlinePlayers.Series[0].Points.DataBindXY(XValues, YValues);
                }

                //更新状态
                lblLoseNoneAnalStat.Text = "正在以 " + SettingsManager.RefreshFrequency.ToString() +
                    " 秒一次的频率从数据源获得数据。";
                lblLoseNoneAnalStat.ForeColor = Color.Black;
                LogApp("数据源指示已连接到服务器。");
            }
            catch(Exception ex)
            {
                //更新状态
                lblLoseNoneAnalStat.Text = "获取一项或多项数据出现问题。重试中……";
                lblLoseNoneAnalStat.ForeColor = Color.Red;
                LogApp("获取数据出现问题：" + ex.Message);
            }
        }

        protected void LogApp(string str)
        {
            string nowTime = DateTime.Now.ToString();
            string log = nowTime + " " + str;
            rtbLogApp.AppendText(log + "\n");
        }

        private void LoadSettingsIntoUI()
        {
            //加载刷新频率
            numRefreshFrequency.Value = SettingsManager.RefreshFrequency;
            //将数据源列表载入管理器
            DataProviderManager.LoadOnDataProviders();
            LogApp("数据源列表已载入管理器。");
            //将当前选择的数据源载入管理器
            DataProviderManager.SetCurrentDataProvider(SettingsManager.SelectedDataProvider);
            //加载数据源列表
            cmbDataProvider.DataSource = DataProviderManager.DataProviders;
            //加载已选数据源
            cmbDataProvider.SelectedItem = DataProviderManager.CurrentDataProvider;
            dp = DataProviderManager.CurrentDataProvider;
            //加载背景图片
            lblBgImagePath.Text = SettingsManager.BackgroundImagePath;
            LogApp("设置加载完毕。");
            
        }


        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.RefreshFrequency = (int)numRefreshFrequency.Value;
            SettingsManager.SelectedDataProvider = cmbDataProvider.SelectedItem.ToString();
            SettingsManager.BackgroundImagePath = lblBgImagePath.Text;

            SettingsManager.Save();
            MessageBox.Show("已保存，即将重启。", "信息");
            Application.Restart();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSettingsIntoUI();
        }

        private void btnBgImageSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "选择背景图片";
            of.Filter = "图片(JPEG,GIF)|*.jpg;*.jpeg;*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                string path = of.FileName;
                lblBgImagePath.Text = path;
            }
        }

        private void mclDateSelector_DateChanged(object sender, DateRangeEventArgs e)
        {
            //强制执行计时器方法
            UpdateDataDisplay(timer, null);
        }
    }
}
