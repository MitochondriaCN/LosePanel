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

namespace LosePanel.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IDataProvidable dp;

        long TimerInterval { set; get; }

        public MainWindow()
        {
            InitializeComponent();

            //将设置载入管理器
            SettingsManager.LoadOn();
            LogApp("设置已载入管理器。");
            LoadSettingsIntoUI();

            //将数据源列表载入管理器
            DataProviderManager.LoadOnDataProviders();
            LogApp("数据源列表已载入管理器。");
            //将当前选择的数据源载入管理器
            DataProviderManager.SetCurrentDataProvider(SettingsManager.SelectedDataProvider);
            dp = DataProviderManager.CurrentDataProvider;
        }

        private void LogApp(string str)
        {
            string nowTime = DateTime.Now.ToString();
            string log = nowTime + " " + str;
            txbAppLog.Text += log + "\n";
        }

        /// <summary>
        /// 该方法只刷新界面，不处理逻辑。
        /// </summary>
        private void LoadSettingsIntoUI()
        {
            //加载刷新频率
            sldRefreshFrequency.Value = SettingsManager.RefreshFrequency;
            //加载数据源列表
            cmbDataProviders.ItemsSource = DataProviderManager.DataProviders;
            //加载已选数据源
            cmbDataProviders.SelectedItem = DataProviderManager.CurrentDataProvider;
            //加载背景图片
            //lblBgImagePath.Text = SettingsManager.BackgroundImagePath;
            //LogApp("设置加载完毕。");
            //TODO:完成这个

            LogApp("“设置”已同步。");
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadSettingsIntoUI();
        }
    }
}
