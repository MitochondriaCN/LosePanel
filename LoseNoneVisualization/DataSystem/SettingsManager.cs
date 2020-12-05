﻿using System;
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
        public static string SelectedDataProvider { get; set; }

        /// <summary>
        /// 数据更新频率，单位为秒。
        /// </summary>
        public static int RefreshFrequency { get; set; }

        public static void LoadOn()
        {
            if (File.Exists("settings.ini"))
            {
                XElement xd = XDocument.Load("settings.ini").Element("LosePanelSettings");

                SelectedDataProvider = xd.Element("SelectedDataProvider").Value;
                RefreshFrequency = int.Parse(xd.Element("RefreshFrequency").Value);
            }
            else
            {
                //加载默认值
                SelectedDataProvider = "_defLosenoneDataProvider";
                RefreshFrequency = 5;
            }
        }

        public static void Save()
        {
            XDocument xd = new XDocument(
                new XElement("LosePanelSettings",
                    new XElement("SelectedDataProvider", SelectedDataProvider),
                    new XElement("RefreshFrequency", RefreshFrequency.ToString())));
            xd.Save("settings.ini");
        }
    }
}