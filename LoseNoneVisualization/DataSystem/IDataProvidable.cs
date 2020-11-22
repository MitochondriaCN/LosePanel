using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosePanel.DataSystem
{
    /// <summary>
    /// 表示一个数据源。
    /// </summary>
    interface IDataProvidable
    {
        /// <summary>
        /// 一天中各时段玩家数量（30分钟为一单位，共48个数据，未知为0）。
        /// </summary>
        List<int> PlayerNumberDuringDay { get; set; }

        /// <summary>
        /// 在线玩家数。
        /// </summary>
        int OnlinePlayerNumber { get; set; }
    }
}
