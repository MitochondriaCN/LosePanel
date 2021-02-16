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

namespace LosePanel.WPF.Pages
{
    /// <summary>
    /// SettingsMain.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsMain : Page
    {
        public SettingsMain()
        {
            InitializeComponent();
        }

        private void btnstDataProvider_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new setDataProvider());
        }

        private void btnstLog_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new setLog());
        }

        private void btnstViewFile_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.File.Exists("settings.ini"))
            {
                System.Diagnostics.Process.Start("settings.ini");
            }
            else
            {
                MessageBox.Show("文件不存在，可能您正在使用默认设置。", "错误");
            }
        }
    }
}
