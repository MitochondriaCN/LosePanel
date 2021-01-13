using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LosePanel.SDK;
using LosePanel.Presets;

namespace LosePanel.DataSystem
{
    public static class DataProviderManager
    {
        /// <summary>
        /// 所有可用的数据源（包括预置）。
        /// </summary>
        public static List<IDataProvidable> DataProviders { get; private set; }

        /// <summary>
        /// 当前使用的数据源。
        /// </summary>
        public static IDataProvidable CurrentDataProvider { get; private set; }
        /// <summary>
        /// 加载所有可用数据源（包括预置）。
        /// </summary>
        public static void LoadOnDataProviders()
        {
            DataProviders = new List<IDataProvidable>();

            //加入预置
            LosenoneDataProvider _defLosenoneDataProvider = new LosenoneDataProvider();
            DataProviders.Add(_defLosenoneDataProvider);
        }

        /// <summary>
        /// 将当前数据源设为指定ProviderName的数据源，前提是具有该ProviderName的数据源必须已被加载至DataProviders，否则将返回false。
        /// </summary>
        /// <param name="providerName"></param>
        /// <returns></returns>
        public static bool SetCurrentDataProvider(string providerName)
        {
            foreach (var v in DataProviders)
            {
                if (v.ProviderName == providerName)
                {
                    CurrentDataProvider = v;
                    return true;
                }
            }
            return false;
        }
    }
}
