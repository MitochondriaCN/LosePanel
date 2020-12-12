using System;
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

            #region 加载设置
            //将设置载入管理器
            SettingsManager.LoadOn();
            LogApp("设置已载入管理器。");
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
            LogApp("设置加载完毕。");
            #endregion


            //设置Timer
            timer.Interval = SettingsManager.RefreshFrequency * 1000;
            timer.Tick += UpdateDataDisplay;
            timer.Start();
            LogApp("计时器开始，每" + SettingsManager.RefreshFrequency.ToString() + "秒一次。");

            //设置控件
            lblAbtProviderName.Text = dp.ProviderName;
            lblAbtWrittenBy.Text = dp.WrittenBy;
            rtbAbtDescription.Text = dp.Description;
        }

        private void UpdateDataDisplay(object sender, EventArgs e)
        {
            //更新数据源名
            lblProviderName.Text = "数据源：" + dp.ProviderName;

            //更新在线玩家数
            if (dp.OnlinePlayerNumberIsConnected)
            {
                lblLoseNoneAnalStat.Text = "正在以 " + SettingsManager.RefreshFrequency.ToString() +
                    " 秒一次的频率从数据源获得数据。";
                lblLoseNoneAnalStat.ForeColor = Color.Black;
                LogApp("数据源指示已连接到服务器。");
                lblOnlinePlayerNumber.Text = dp.OnlinePlayerNumber.ToString();
                LogApp("在线玩家数已获取。");
            }
            else
            {
                lblLoseNoneAnalStat.Text = "无法连接到数据源。重试中……";
                lblLoseNoneAnalStat.ForeColor = Color.Red;
                LogApp("数据源指示未连接到服务器。");
            }

            //更新图表
            List<TimePointPlayerNumber> timep = dp.PlayerNumberDuringDay;//取得各时段玩家数
            if (timep != null)
            {
                List<string> XValues = new List<string>();
                List<int> YValues = new List<int>();
                foreach (var v in timep)
                {
                    string hour = v.TimePoint.Hour.ToString();
                    string min = v.TimePoint.Minute.ToString();
                    string full = hour + ":" + min;
                    XValues.Add(full);

                    YValues.Add(v.PlayerNumber);
                }
                chartOnlinePlayers.Series[0].Points.DataBindXY(XValues, YValues);
            }
            
        }

        protected void LogApp(string str)
        {
            string nowTime = DateTime.Now.ToString();
            string log = nowTime + " " + str;
            rtbLogApp.AppendText(log + "\n");
        }


        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.RefreshFrequency = (int)numRefreshFrequency.Value;
            SettingsManager.SelectedDataProvider = cmbDataProvider.SelectedItem.ToString();

            SettingsManager.Save();
            MessageBox.Show("已保存，即将重启。", "信息");
            Application.Restart();
        }

    }
}
