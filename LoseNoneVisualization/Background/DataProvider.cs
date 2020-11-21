using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoseNoneVisualization.Background
{
    class DataProvider
    {
        #region 计时器
        /// <summary>
        /// 5秒一次的计时器。
        /// </summary>
        private Timer _5secTimer = new Timer();
        /// <summary>
        /// 30分钟一次的计时器。
        /// </summary>
        private Timer _30minTimer = new Timer();
        /// <summary>
        /// 60分钟一次的计时器。
        /// </summary>
        private Timer _60minTimer = new Timer();
        #endregion

        #region 杂项模块
        /// <summary>
        /// 在线玩家数。
        /// </summary>
        public int OnlinePlayerNumber = 0;
        #endregion

        #region 在线玩家模块
        /// <summary>
        /// 一天中各时段玩家数量（30分钟为一单位，未知为0）。
        /// </summary>
        public List<int> olPlayerNumber = new List<int>(48) { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
        #endregion

        /// <summary>
        /// 一些数据常量。
        /// </summary>
        public static class Constants
        {
            /// <summary>
            /// 以半小时为单位的时间轴。
            /// </summary>
            public static List<double> olPlayerHours = new List<double>() { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5,
            4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5,
            13, 13.5, 14, 14.5, 15, 15.5, 16, 16.5, 17, 17.5, 18, 18.5, 19, 19.5, 20, 20.5,
            21, 21.5, 22, 22.5, 23, 23.5 };
        }

        public DataProvider()
        {
            //初始化计时器
            _5secTimer.Interval = 5000;
            _30minTimer.Interval = 1800000;
            _60minTimer.Interval = 3600000;

            //设定定时方法
            _5secTimer.Tick += UpdateOnlinePlayerNumber;

            _5secTimer.Start();
            _30minTimer.Start();
            _60minTimer.Start();
        }

        private void UpdateOnlinePlayerNumber(object sender, EventArgs e)
        {
            string str = NetworkTools.GetUrlReturn("http://139.199.127.51:23233/?Qgetnum");
            //示例：document.write("在线人数:1:Qiaoyiiii6;")
            string onlinenum = str.Substring(21, 1);
            OnlinePlayerNumber = int.Parse(onlinenum);
        }
    }
}
