using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LosePanel.SDK;
using LosePanel.Presets;

namespace LosePanel.DataSystem
{
    public class DataProviderManager
    {
        /// <summary>
        /// 所有可用的数据源（包括预置）。
        /// </summary>
        public List<IDataProvidable> DataProviders { get; private set; }

        /// <summary>
        /// 加载所有可用数据源（包括预置）。
        /// </summary>
        public DataProviderManager()
        {
            DataProviders = new List<IDataProvidable>();

            //加入预置（注意：0号元素必须为默认元素）
            DataProviders.Add(new LosenoneDataProvider());
        }
    }
}
