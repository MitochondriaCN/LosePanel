using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LosePanel.SDK;
using LosePanel.DataSystem;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace LosePanel.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IDataProvidable dp;

        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            //将设置载入管理器
            SettingsManager.LoadOn();
            LogApp("设置已载入管理器。");

            //将数据源列表载入管理器
            DataProviderManager.LoadOnDataProviders();
            LogApp("数据源列表已载入管理器。");
            //将当前选择的数据源载入管理器
            DataProviderManager.SetCurrentDataProvider(SettingsManager.SelectedDataProvider);
            dp = DataProviderManager.CurrentDataProvider;

            //设定计时器
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, SettingsManager.RefreshFrequency);
            timer.Tick += TimerCallback;
            timer.Start();

            //初始化控件
            dtpDatePicker.SelectedDate = DateTime.Today;

            //直接调用计时器方法
            TimerCallback(timer, new EventArgs());
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            bool isOK = false;
            //更新在线玩家数、数据源名
            lblOnlinePlayerNumber.Content = dp.OnlinePlayerNumber;
            lblDataProviderName.Content = dp.ProviderName;

            //更新服务器日志
            lblServerLogHeader.Content = dp.LogIsConnected ? "服务器日志" : "服务器日志（未提供）";
            txbServerLog.Text = dp.Log.ToString();

            //更新图表
            try
            {
                UpdateChartDisplay(dp.GetPlayerNumbersOfDay((DateTime)dtpDatePicker.SelectedDate));
                isOK = true;
            }
            catch (Exception ex)
            {
                ChangeStatus(StatusLevels.Error, "无法更新图表");
                LogApp("更新图表失败：" + ex.Message);
            }

            if (isOK)
            {
                LogApp("数据已更新。");
                ChangeStatus(StatusLevels.Fine, "已更新");
            }
        }

        private void LogApp(string str)
        {
            string nowTime = DateTime.Now.ToString();
            string log = nowTime + " " + str;
            txbAppLog.Text += log + "\n";
        }

        private void ChangeStatus(StatusLevels level, string text)
        {
            SolidColorBrush bgbrush;
            switch(level)
            {
                case StatusLevels.Fine:
                    bgbrush = new SolidColorBrush(Color.FromRgb(0, 153, 51));
                    break;
                case StatusLevels.Warning:
                    bgbrush = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                    break;
                case StatusLevels.Error:
                    bgbrush = new SolidColorBrush(Color.FromRgb(204, 51, 0));
                    break;
                case StatusLevels.Waiting:
                    bgbrush = new SolidColorBrush(Color.FromRgb(102, 153, 153));
                    break;
                default:
                    bgbrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                    break;
            }
            string srcContent = lblStatus.Content.ToString();
            lblStatus.Background = bgbrush;
            lblStatus.Content = text;

            if (!(text == srcContent))
            {
                DoubleAnimation anim = new DoubleAnimation();
                anim.From = 0;
                anim.To = 1;
                anim.Duration = TimeSpan.FromMilliseconds(700);
                lblStatus.BeginAnimation(Label.OpacityProperty, anim);
            }
        }

        private void ChangeMessage(string message)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 1;
            anim.Duration = TimeSpan.FromMilliseconds(700);

            lblMessage.Content = message;
            lblMessage.BeginAnimation(Label.OpacityProperty, anim);
        }

        /// <summary>
        /// 更新图表核心代码
        /// </summary>
        /// <param name="collection"></param>
        private void UpdateChartDisplay(List<TimePointPlayerNumber> collection)
        {
            lsrOnlinePlayers.Values = new LiveCharts.ChartValues<int>();
            axisX.Labels = new List<string>();
            foreach (var v in collection)
            {
                lsrOnlinePlayers.Values.Add(v.PlayerNumber);
                axisX.Labels.Add(v.TimePoint.TimeOfDay.ToString());
            }
        }

        private enum StatusLevels
        {
            Fine,
            Warning,
            Error,
            Waiting
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void frmSettings_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
