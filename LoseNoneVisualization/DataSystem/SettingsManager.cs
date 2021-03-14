using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Drawing;

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

        /// <summary>
        /// 控制台前景色，十六进制。
        /// </summary>
        public static Option<string> TerminalForeground { get; private set; }

        /// <summary>
        /// 控制台背景色，十六进制。
        /// </summary>
        public static Option<string> TerminalBackground { get; private set; }

        public static void LoadOn()
        {
            //初始化各设置对象
            SelectedDataProvider = new Option<string>("SelectedDataProvider", "选定数据源", "软件当前使用的数据源。");
            RefreshFrequency = new Option<int>("RefreshFrequency", "刷新频率", "从数据源获取数据的频率。");
            IsSaveLog = new Option<bool>("IsSaveLog", "保存日志", "保存日志到文件。");

            TerminalForeground = new Option<string>("TerminalForeground", "控制台前景色", "控制台前景色。");
            TerminalBackground = new Option<string>("TerminalBackground", "控制台背景色", "控制台背景色。");

            //设定初始值
            try
            {
                XElement xd = XDocument.Load("settings.ini").Element("LosePanelSettings");

                SelectedDataProvider.SetValueDirectly(xd.Element(SelectedDataProvider.Name).Value);
                RefreshFrequency.SetValueDirectly(int.Parse(xd.Element(RefreshFrequency.Name).Value));
                IsSaveLog.SetValueDirectly(xd.Element(IsSaveLog.Name).Value == "True" ? true : false);

                TerminalForeground.SetValueDirectly(xd.Element(TerminalForeground.Name).Value);
                TerminalBackground.SetValueDirectly(xd.Element(TerminalBackground.Name).Value);
            }
            catch
            {
                //加载默认值
                SelectedDataProvider.SetValueDirectly("洛书南统计服务器");
                RefreshFrequency.SetValueDirectly(10);
                IsSaveLog.SetValueDirectly(false);

                TerminalForeground.SetValueDirectly("#FFD5D5E6");
                TerminalBackground.SetValueDirectly("#FF1E1E1E");
            }

        }
    }
}
