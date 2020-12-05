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
            //加载刷新频率
            numRefreshFrequency.Value = SettingsManager.RefreshFrequency;
            //将数据源列表载入管理器
            DataProviderManager.LoadOnDataProviders();
            //将当前选择的数据源载入管理器
            DataProviderManager.SetCurrentDataProvider(SettingsManager.SelectedDataProvider);
            //加载数据源列表
            cmbDataProvider.DataSource = DataProviderManager.DataProviders;
            //加载已选数据源
            cmbDataProvider.SelectedItem = DataProviderManager.CurrentDataProvider;
            dp = DataProviderManager.CurrentDataProvider;
            #endregion


            //设置Timer
            timer.Interval = SettingsManager.RefreshFrequency * 1000;
            timer.Tick += UpdateDataDisplay;
            timer.Start();

            //设置控件

            lblAbtProviderName.Text = dp.ProviderName;
            lblAbtWrittenBy.Text = dp.WrittenBy;
            rtbAbtDescription.Text = dp.Description;
        }

        private void UpdateDataDisplay(object sender, EventArgs e)
        {
            lblProviderName.Text = "数据源：" + dp.ProviderName;
            lblOnlinePlayerNumber.Text = dp.OnlinePlayerNumber.ToString();
            if (dp.OnlinePlayerNumberIsConnected)
            {
                lblLoseNoneAnalStat.Text = "正在以 " + SettingsManager.RefreshFrequency.ToString() +
                    " 秒一次的频率从数据源获得数据。";
                lblLoseNoneAnalStat.ForeColor = Color.Black;
            }
            else
            {
                lblLoseNoneAnalStat.Text = "无法连接到数据源。重试中……";
                lblLoseNoneAnalStat.ForeColor = Color.Red;
            }

            chartOnlinePlayers.Series[0].Points.DataBindXY(OnlinePlayerAxis, dp.PlayerNumberDuringDay);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsManager.RefreshFrequency = (int)numRefreshFrequency.Value;
            SettingsManager.SelectedDataProvider = cmbDataProvider.SelectedItem.ToString();

            SettingsManager.Save();
            MessageBox.Show("已保存，即将重启。", "信息");
            Application.Restart();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
