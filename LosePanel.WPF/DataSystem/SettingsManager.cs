using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LosePanel.WPF.DataSystem;
using System.Xml.Linq;

namespace LosePanel.WPF.DataSystem
{
    /// <summary>
    /// 设置管理器
    /// </summary>
    public class SettingsManager
    {
        public List<Setting> Settings { get; private set; }

        /// <summary>
        /// 初始化设置管理器并载入设置对象，完成赋值，如果设置文件不存在，则赋初始值，并创建设置文件，设置文件名规定为 settings.lpi
        /// </summary>
        /// <param name="dpm">传入的DataProviderManager应为全软件唯一的</param>
        public SettingsManager(LosePanel.DataSystem.DataProviderManager dpm)
        {
            //初始化各项设置对象
            Settings = new List<Setting>();
            Setting selectedDataProvider = new Setting("选定数据源", Setting.SettingType.String, "当前选定数据源。");
            Setting isSaveLog = new Setting("保存日志到文件", Setting.SettingType.Bool, "保存日志到软件目录下的 log.txt。");
            Settings.Add(selectedDataProvider);
            Settings.Add(isSaveLog);

            //载入设置值
            try
            {
                Refresh();
            }
            catch
            {
                //捕捉错误，赋初始值并保存
                //当前数据源（0号数据源为默认）
                selectedDataProvider.Value = dpm.DataProviders[0].ToString();
                //保存日志到文件
                isSaveLog.Value = false;
                Save();
            }
        }

        /// <summary>
        /// 从文件重加载所有设置项值，若出错则抛出异常
        /// </summary>
        public void Refresh()
        {
            try
            {
                //读文件并赋值
                XElement root = XDocument.Load("settings.lpi").Element("LosePanelSettings");
                foreach (var v in Settings)
                {
                    v.Value = root.Element(v.Name).Value;
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 将所有设置值写入文件，该操作总覆盖原文件，若出错则抛出异常
        /// </summary>
        public void Save()
        {
            try
            {
                //创建文档
                XDocument file = new XDocument(new XElement("LosePanelSettings"));
                //写入设置值
                foreach (var v in Settings)
                {
                    file.Element("LosePanelSettings").Add(new XElement(v.Name, v.Value));
                }
                //直接覆盖保存
                file.Save("settings.lpi");
            }
            catch
            {
                throw;
            }
        }
    }
}
