using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace LosePanel.DataSystem
{
    public static class SettingsManager
    {
        /// <summary>
        /// 已选择的数据源名（ProviderName）。
        /// </summary>
        public static Option<string> SelectedDataProvider { get; set; }

        /// <summary>
        /// 数据更新频率，单位为秒。
        /// </summary>
        public static Option<int> RefreshFrequency { get; set; }

        /// <summary>
        /// 是否保存日志。
        /// </summary>
        public static Option<bool> IsSaveLog { get; set; }

        

        public static void LoadOn()
        {
            try
            {
                XElement xd = XDocument.Load("settings.ini").Element("LosePanelSettings");
                SelectedDataProvider = new Option<string>("SelectedDataProvider", "选定数据源", "软件当前使用的数据源。", xd.Element("SelectedDataProvider").Value);
                RefreshFrequency = new Option<int>("RefreshFrequency", "刷新频率", "从数据源获取数据的频率。", int.Parse(xd.Element("RefreshFrequency").Value));
                IsSaveLog = new Option<bool>("IsSaveLog", "保存日志", "保存日志到文件。", xd.Element("IsSaveLog").Value == "True" ? true : false);
            }
            catch
            {
                //加载默认值
                SelectedDataProvider = new Option<string>("SelectedDataProvider", "选定数据源", "软件当前使用的数据源。", "LoseNoneDataProvider");
                RefreshFrequency = new Option<int>("RefreshFrequency", "刷新频率", "从数据源获取数据的频率。", 5);
                IsSaveLog = new Option<bool>("IsSaveLog", "保存日志", "保存日志到文件。", false);
            }
             


        }
    }
}
