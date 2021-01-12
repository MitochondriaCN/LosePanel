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
            //LogApp("设置已载入管理器。");
            //LoadSettingsIntoUI();
        }
    }
}
