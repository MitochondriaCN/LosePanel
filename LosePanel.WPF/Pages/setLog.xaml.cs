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
using LosePanel.DataSystem;

namespace LosePanel.WPF.Pages
{
    /// <summary>
    /// setLog.xaml 的交互逻辑
    /// </summary>
    public partial class setLog : Page
    {
        public setLog()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tgbSaveLogs.IsChecked = SettingsManager.IsSaveLog;
        }

        private void btnstSaveAndRestart_Click(object sender, RoutedEventArgs e)
        {
            SettingsManager.IsSaveLog = (bool)tgbSaveLogs.IsChecked;
            SettingsManager.Save();
            Application.Current.Shutdown();
        }
    }
}
