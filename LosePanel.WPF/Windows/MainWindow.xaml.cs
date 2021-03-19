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
using System.ComponentModel;
using LiveCharts;

namespace LosePanel.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IDataProvidable dp;

        BackgroundWorker bgwGraphicsUpdater;
        BackgroundWorker bgwCommandQueryer;

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
            DataProviderManager.SetCurrentDataProvider(SettingsManager.SelectedDataProvider.Value);
            dp = DataProviderManager.CurrentDataProvider;
            
            //设定计时器
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, SettingsManager.RefreshFrequency.Value);
            timer.Tick += TimerCallback;
            timer.Start();

            //设定BackgroundWorker:bgwGraphicsUpdater
            bgwGraphicsUpdater = new BackgroundWorker();
            bgwGraphicsUpdater.DoWork += BgwGraphicsUpdater_DoWork;
            bgwGraphicsUpdater.ProgressChanged += BgwGraphicsUpdater_ProgressChanged;
            bgwGraphicsUpdater.RunWorkerCompleted += BgwGraphicsUpdater_RunWorkerCompleted;
            bgwGraphicsUpdater.WorkerReportsProgress = true;

            //设定BackgroundWorker:bgwCommandQueryer
            bgwCommandQueryer = new BackgroundWorker();
            bgwCommandQueryer.DoWork += BgwCommandQueryer_DoWork;

            //初始化控件
            dtpDatePicker.SelectedDate = DateTime.Today;

            //直接调用计时器方法
            TimerCallback(timer, new EventArgs());
        }

        private void BgwCommandQueryer_DoWork(object sender, DoWorkEventArgs e)
        {
            txbTerminal.Text = txbTerminal.Text + "\n>\t" + e.Argument.ToString() + "\n";

            QueryReturn qr = dp.QueryToServer(e.Argument.ToString());

            ChangeMessage("指令已执行。");
            txbTerminal.Text = txbTerminal.Text + "\t" + qr.Return + "\n";
        }

        private void BgwGraphicsUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChartValues<int> v = (e.Result as ChartInformation).Values;
            List<string> l = (e.Result as ChartInformation).Labels;
            lsrOnlinePlayers.Values = v;
            axisX.Labels = l;

            ChangeMessage("图表更新完毕");
        }

        private void BgwGraphicsUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ChangeMessage("正在更新图表 - " + e.ProgressPercentage + "%");
        }

        private void BgwGraphicsUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            List<TimePointPlayerNumber> collection = e.Argument as List<TimePointPlayerNumber>;

            ChartValues<int> chtValues = new ChartValues<int>();
            List<string> axisXLabels = new List<string>();

            for (int i = 0; i < collection.Count; i++)
            {
                var v = collection[i];
                chtValues.Add(v.PlayerNumber);
                axisXLabels.Add(v.TimePoint.TimeOfDay.ToString());

                bgwGraphicsUpdater.ReportProgress((i + 1) / collection.Count);
            }

            e.Result = new ChartInformation(chtValues, axisXLabels);
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            //更新在线玩家数、数据源名
            lblOnlinePlayerNumber.Content = dp.OnlinePlayerNumber;
            lblDataProviderName.Content = dp.ProviderName;

            //更新服务器日志
            lblServerLogHeader.Content = dp.LogIsConnected ? "服务器日志" : "服务器日志（未提供）";
            txbServerLog.Text = dp.Log.ToString();

            LogApp("数据已更新。");
            ChangeMessage("数据已更新");
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
            switch (level)
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
            lblStatus.Background = bgbrush;
            lblStatus.Content = text;

            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 0;
            anim.To = 1;
            anim.Duration = TimeSpan.FromMilliseconds(700);
            lblStatus.BeginAnimation(Label.OpacityProperty, anim);
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


        private enum StatusLevels
        {
            Fine,
            Warning,
            Error,
            Waiting
        }

        private class ChartInformation
        {
            public ChartValues<int> Values { get; set; }
            public List<string> Labels { get; set; }
            public ChartInformation(ChartValues<int> values, List<string> labels)
            {
                this.Values = values;
                this.Labels = labels;
            }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((sender as TabControl).SelectedItem as TabItem).Header.ToString() == "设置")
            {
                LoadSettingsTab();
            }
        }

        private void SettingsTab_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSettingsTab();
        }

        private void LoadSettingsTab()
        {
            cmbDataProviders.ItemsSource = DataProviderManager.DataProviders;
            cmbDataProviders.SelectedItem = DataProviderManager.CurrentDataProvider;

            sldRefreshFrequency.Value = SettingsManager.RefreshFrequency.Value;

            tgbIsSaveLog.IsChecked = SettingsManager.IsSaveLog.Value;
        }

        private void btnUpdateGraphics_Click(object sender, RoutedEventArgs e)
        {
            //更新图表
            try
            {
                bgwGraphicsUpdater.RunWorkerAsync(dp.GetPlayerNumbersOfDay((DateTime)dtpDatePicker.SelectedDate));
            }
            catch (Exception ex)
            {
                ChangeStatus(StatusLevels.Error, "无法更新图表");
                LogApp("更新图表失败：" + ex.Message);
                return;
            }


            LogApp("数据已更新。");
            ChangeStatus(StatusLevels.Fine, "已更新");
        }

        private void btnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("若保存，将关闭软件，以待重启软件后生效。是否保存？", "信息", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SettingsManager.SelectedDataProvider.Value = cmbDataProviders.SelectedItem.ToString();
                SettingsManager.RefreshFrequency.Value = int.Parse(sldRefreshFrequency.Value.ToString());
                SettingsManager.IsSaveLog.Value = tgbIsSaveLog.IsChecked == true ? true : false;

                Application.Current.Shutdown(); 
            }
        }

        private void btnQueryCommand_Click(object sender, RoutedEventArgs e)
        {
            bgwCommandQueryer.RunWorkerAsync(txbInputTerminal.Text);
        }
    }
}
