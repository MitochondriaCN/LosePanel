using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosePanel.SDK
{
    /// <summary>
    /// 代表服务器指令。
    /// </summary>
    public class QueryReturn
    {
        /// <summary>
        /// 指令是否执行完毕。
        /// </summary>
        public bool IsCompleted { get; private set; }

        /// <summary>
        /// 返回值，未执行时为 null 。
        /// </summary>
        public string Return { get; private set; }

        /// <summary>
        /// 根据指定指令构建指令对象。
        /// </summary>
        /// <param name="command"></param>
        public QueryReturn(bool isCompleted, string queryReturn)
        {
            IsCompleted = isCompleted;
            Return = queryReturn;
        }
    }
}
