using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using LosePanel.SDK;
using LosePanel.DataSystem;
using System.Windows.Media.Animation;
using System.ComponentModel;
using LiveCharts;
using LosePanel.WPF.DataSystem;

namespace LosePanel.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IDataProvidable dp;

        DataProviderManager dataProviderManager;
        SettingsManager settingsManager;

        public MainWindow()
        {
            InitializeComponent();

            //载入数据源管理器
            dataProviderManager=new DataProviderManager();
            //载入设置管理器
            settingsManager = new SettingsManager(dataProviderManager);

            //初始化控件
            dtpDatePicker.SelectedDate = DateTime.Today;
        }

        private void BgwGraphicsUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ChartValues<int> v = (e.Result as ChartInformation).Values;
            List<string> l = (e.Result as ChartInformation).Labels;
            lsrOnlinePlayers.Values = v;
            axisX.Labels = l;

            ChangeMessage("图表更新完毕");
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

        /// <summary>
        /// 加载设置选项卡
        /// </summary>
        private void LoadSettingsTab()
        {
            //清除原有元素
            stpSettingItemsPanel.Children.Clear();
            //加入“设置”标题
            Label bigTitle=new Label();
            bigTitle.Style = (Style)stpSettingItemsPanel.FindResource("TitleLabel");
            bigTitle.Content = "设置";
            stpSettingItemsPanel.Children.Add(bigTitle);

            //对于每一个设置项
            foreach (var v in settingsManager.Settings)
            {
                //初始化标题
                Label title = new Label();
                title.Style = (Style)stpSettingItemsPanel.FindResource("SecondaryLabel");
                title.Content = v.Name;
                stpSettingItemsPanel.Children.Add(title);
            }
        }

        private void btnUpdateGraphics_Click(object sender, RoutedEventArgs e)
        {
            //更新图表
            try
            {
                //bgwGraphicsUpdater.RunWorkerAsync(dp.GetPlayerNumbersOfDay((DateTime)dtpDatePicker.SelectedDate));
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
    }
}
