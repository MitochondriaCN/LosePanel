using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LosePanel.DataSystem
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
            catch (Exception ex)
            {
                IsConnected = false;
                OnlinePlayerNumber = 0;
            }
            
        }
        #endregion
    }
}
