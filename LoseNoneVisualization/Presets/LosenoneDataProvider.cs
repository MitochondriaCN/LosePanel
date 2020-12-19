using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using LosePanel.SDK;
using LosePanel.DataSystem;
using System.Text.RegularExpressions;

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

        public int OnlinePlayerNumber { get; private set; }

        public string ProviderName { get { return "洛书南统计服务器"; } }

        public string Description
        {
            get
            {
                return "本数据源由洛书南（Losenone）团队提供，线粒体（XianlitiCN）开发。" +
                  "它可以提供洛书南服务器的各项信息，包括日志系统。\n特别鸣谢：Qiaoyiiii6，mofcandy。" +
                  "\n洛书南服务器官网：https://www.losenone.cn";
            }
        }

        public string WrittenBy
        {
            get { return "洛书南 Losenone && 线粒体 XianlitiCN"; }
        }

        public StringBuilder Log { get { return new StringBuilder(""); } }

        public bool LogIsConnected { get { return false; } }

        public LosenoneDataProvider()
        {
            //初始化各成员
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
                //更新在线玩家数字
                string str = NetworkTools.GetUrlReturn("http://139.199.127.51:23233/?Qgetnum");
                //示例：document.write("在线人数:1:Qiaoyiiii6;")
                string onlinenum = str.Substring(21, 1);
                OnlinePlayerNumber = int.Parse(onlinenum);
            }
            catch
            {
                throw;
            }

        }
        #endregion

        override public string ToString()
        {
            return ProviderName;
        }

        /// <summary>
        /// 获取指定日期各时段玩家数。
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<TimePointPlayerNumber> GetPlayerNumbersOfDay(DateTime date)
        {
            try
            {
                List<TimePointPlayerNumber> ret = new List<TimePointPlayerNumber>();
                string _date = date.Year.ToString() + (date.Month.ToString().Length == 2 ? date.Month.ToString() : "0" + date.Month.ToString()) +
                    (date.Day.ToString().Length == 2 ? date.Day.ToString() : "0" + date.Day.ToString());
                string playersOnTime = NetworkTools.GetUrlReturn("http://139.199.127.51/Qnum/" + _date + ".txt");
                char[] spchar = { '\\', '\\' };
                string[] lines = Regex.Split(playersOnTime, "\\\\", RegexOptions.IgnoreCase);
                foreach (string s in lines)
                {
                    if (s == "")
                    { continue; }
                    string time = s.Split(':')[0];
                    string num = s.Split(':')[1];

                    //*** 判断最接近的时间点并将数据填充到PlayerNumberDuringDay的合适位置 ***
                    //以下算法极为烧脑，请酌情修改
                    //可联系时间轴帮助理解算法
                    int year = int.Parse(time.Substring(0, 4));//取得年
                    int month = int.Parse(time.Substring(4, 2));//取得月
                    int day = int.Parse(time.Substring(6, 2));//取得日
                    int hour = int.Parse(time.Substring(8, 2));//取得小时
                    int min = int.Parse(time.Substring(10, 2));//取得分钟
                    ret.Add(new TimePointPlayerNumber(new DateTime(year, month, day, hour, min, 0), int.Parse(num)));
                }
                return ret;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}

