using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LosePanel.DataSystem;

namespace LosePanel
{
    public partial class MainForm : Form
    {
        IDataProvidable dp = new LosenoneDataProvider();

        Timer timer = new Timer();

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

            //设置Timer
            timer.Interval = 5000;
            timer.Tick += UpdateDataDisplay;
            timer.Start();
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
        }
    }
}
