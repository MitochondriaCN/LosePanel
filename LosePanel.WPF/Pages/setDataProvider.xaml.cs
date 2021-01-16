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
    /// setDataProvider.xaml 的交互逻辑
    /// </summary>
    public partial class setDataProvider : Page
    {
        public setDataProvider()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cmbDataProviders.ItemsSource = DataProviderManager.DataProviders;
            cmbDataProviders.SelectedItem = DataProviderManager.CurrentDataProvider;
            sldRefreshFrequency.Value = SettingsManager.RefreshFrequency;
        }

        private void btnSaveDataProvider_Click(object sender, RoutedEventArgs e)
        {
            SettingsManager.SelectedDataProvider = cmbDataProviders.SelectedItem.ToString();
            SettingsManager.RefreshFrequency = int.Parse(sldRefreshFrequency.Value.ToString());
            SettingsManager.Save();
            Application.Current.Shutdown();
        }
    }
}
