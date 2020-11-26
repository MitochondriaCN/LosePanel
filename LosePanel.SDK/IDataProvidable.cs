using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosePanel.SDK
{
    /// <summary>
    /// 表示一个数据源。一般来讲，由于面板并不需要修改服务器数据，因此在实现本接口时，
    /// 应将其中的字段全部实现为只读，然后在实现类中使用方法修改它们的值。换言之，
    /// 实现该接口的类对外只暴露接口中定义的字段，其余方法、字段等均应设置为 private。
    /// </summary>
    public interface IDataProvidable
    {
        /// <summary>
        /// 一天中各时段玩家数量。30分钟为一单位，共48个数据，未知为0。顺序为从0点开始的每30分钟。
        /// 若数据数量不足48个，则报错。
        /// </summary>
        List<int> PlayerNumberDuringDay { get; }

        /// <summary>
        /// 实时在线玩家数。该数据应当实时更新以确保时效性。
        /// </summary>
        int OnlinePlayerNumber { get; }

        /// <summary>
        /// 实时服务器连接状态。该数据应当实时更新以确保时效性。
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// 此数据提供器的名称。
        /// </summary>
        string ProviderName { get; }

        /// <summary>
        /// 此数据提供器的介绍和描述。
        /// </summary>
        string Description { get; }

        /// <summary>
        /// 此数据提供器的开发者。
        /// </summary>
        string WrittenBy { get; }
    }
}
