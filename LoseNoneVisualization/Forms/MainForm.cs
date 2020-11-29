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

            //加载设置
            SettingsManager.LoadOn();

            //设置Timer
            timer.Interval = SettingsManager.RefreshFrequency * 1000;
            timer.Tick += UpdateDataDisplay;
            timer.Start();

            //设置数据源
            switch (SettingsManager.SelectedDataProvider)
            {
                case "_defLosenoneDataProvider":
                    cmbDataProvider.SelectedItem = "（预置）洛书南统计服务器";
                    dp = new LosenoneDataProvider();
                    break;
                default:
                    //TODO: 使用反射初始化自定义数据源。
                    break;
            }

            //设置控件
            lblAbtProviderName.Text = dp.ProviderName;
            lblAbtWrittenBy.Text = dp.WrittenBy;
            rtbAbtDescription.Text = dp.Description;
        }

        private void UpdateDataDisplay(object sender, EventArgs e)
        {
            lblProviderName.Text = "数据源：" + dp.ProviderName;
            lblOnlinePlayerNumber.Text = dp.OnlinePlayerNumber.ToString();
            if (dp.IsConnected)
            {
                lblLoseNoneAnalStat.Text = "正在以 5 秒一次的频率从数据源获得数据。";
                lblLoseNoneAnalStat.ForeColor = Color.Black;
            }
            else
            {
                lblLoseNoneAnalStat.Text = "无法连接到统计服务器。";
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
            switch (cmbDataProvider.SelectedItem)
            {
                case "（预置）洛书南统计服务器":
                    SettingsManager.SelectedDataProvider = "_defLosenoneDataProvider";
                    break;
                default:
                    SettingsManager.SelectedDataProvider = cmbDataProvider.SelectedItem.ToString();
                    break;
            }

            SettingsManager.Save();
            MessageBox.Show("已保存。");
        }
    }
}
