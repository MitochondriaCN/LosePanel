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
using MahApps.Metro.Controls;

namespace LosePanel.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
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
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            string srcStatus = lblStatus.Content.ToString();
            lblStatus.Content = "正在获取数据……";

            lblOnlinePlayerNumber.Content = dp.OnlinePlayerNumber;
            lblDataProviderName.Content = dp.ProviderName;

            lblStatus.Content = srcStatus;
            LogApp("数据已更新。");
        }

        private void LogApp(string str)
        {
            string nowTime = DateTime.Now.ToString();
            string log = nowTime + " " + str;
            txbAppLog.Text += log + "\n";
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void frmSettings_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
