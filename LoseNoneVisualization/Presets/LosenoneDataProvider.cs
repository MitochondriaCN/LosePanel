using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using LosePanel.SDK;
using LosePanel.DataSystem;

namespace LosePanel.Presets
{
    class LosenoneDataProvider : IDataProvidable
    {
        #region 计时器
        /// <summary>
        /// 5秒一次的计时器。
        /// </summary>
        private Timer _5secTimer = new Timer(5000);
        /// <summary>
        /// 30分钟一次的计时器。
        /// </summary>
        private Timer _30minTimer = new Timer(1800000);
        /// <summary>
        /// 60分钟一次的计时器。
        /// </summary>
        private Timer _60minTimer = new Timer(3600000);
        #endregion

        public List<int> PlayerNumberDuringDay { get; private set; }
        
        public int OnlinePlayerNumber { get; private set; }

        public bool IsConnected { get; private set; }

        public string ProviderName { get { return "洛书南统计服务器"; } }

        public string Description
        {
            get
            {
                return "本数据源由洛书南（Losenone）团队提供，线粒体（XianlitiCN）开发。" +
                  "它可以提供洛书南服务器的各项信息，包括日志系统。此外，该数据源也作为其它" +
                  "数据源的开发范例，为广大开发者提供指导。为了保护洛书南服务器的内部信息，它的源码" +
                  "暂不能提供。\n洛书南服务器官网：losenone.cn";
            }
        }

        public string WrittenBy
        {
            get { return "洛书南 Losenone && 线粒体 XianlitiCN"; }
        }

        public LosenoneDataProvider()
        {
            //初始化各成员
            PlayerNumberDuringDay = new List<int>(48) { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
            OnlinePlayerNumber = 0;

            //设定定时器方法
            _5secTimer.Elapsed += UpdateOnlinePlayerNumber;

            //启动定时器
            _5secTimer.Start();
            _30minTimer.Start();
            _60minTimer.Start();
        }

        #region 5秒定时方法
        private void UpdateOnlinePlayerNumber(object sender, EventArgs e)
        {
            try
            {
                string str = NetworkTools.GetUrlReturn("http://139.199.127.51:23233/?Qgetnum");
                //示例：document.write("在线人数:1:Qiaoyiiii6;")
                string onlinenum = str.Substring(21, 1);
                OnlinePlayerNumber = int.Parse(onlinenum);
                IsConnected = true;
            }
            catch
            {
                IsConnected = false;
                OnlinePlayerNumber = 0;
            }
            
        }
        #endregion
    }
}
