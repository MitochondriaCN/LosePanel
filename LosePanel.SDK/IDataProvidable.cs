using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosePanel.SDK
{
    /// <summary>
    /// 表示一个数据源。一般来讲，由于面板并不需要也不会修改服务器数据，因此在实现本接口时，
    /// 应将其中的字段全部实现为只读，然后在实现类中使用方法修改它们的值。换言之，
    /// 实现该接口的类对外只暴露接口中定义的字段，其余方法、字段等均应设置为 private。
    /// </summary>
    public interface IDataProvidable
    {

        /// <summary>
        /// 获取指定日期一天中各时段玩家数。
        /// </summary>
        /// <param name="date">指定日期。</param>
        /// <returns>指定日期一天中各时段玩家数。</returns>
        List<TimePointPlayerNumber> GetPlayerNumbersOfDay(DateTime date);

        /// <summary>
        /// 实时在线玩家数。该数据应当实时更新以确保时效性。
        /// </summary>
        int OnlinePlayerNumber { get; }

        /// <summary>
        /// 服务器在线日志。该数据应当实时更新以确保时效性。
        /// </summary>
        StringBuilder Log { get; }

        /// <summary>
        /// 在线日志连接状态。该数据应当实时更新以确保时效性。
        /// </summary>
        bool LogIsConnected { get; }

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

        /// <summary>
        /// 此方法应当设计为返回ProviderName。
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
