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

        public List<int> PlayerNumberDuringDay { get; private set; }
        
        public int OnlinePlayerNumber { get; private set; }

        public bool OnlinePlayerNumberIsConnected { get; private set; }

        public string ProviderName { get { return "洛书南统计服务器"; } }

        public string Description
        {
            get
            {
                return "本数据源由洛书南（Losenone）团队提供，线粒体（XianlitiCN）开发。" +
                  "它可以提供洛书南服务器的各项信息，包括日志系统。\n特别鸣谢：Qiaoyiiii6，mofcandy。" +
                  "\n洛书南服务器官网：losenone.cn";
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
            //try
            //{
                //更新在线玩家数字
                string str = NetworkTools.GetUrlReturn("http://139.199.127.51:23233/?Qgetnum");
                //示例：document.write("在线人数:1:Qiaoyiiii6;")
                string onlinenum = str.Substring(21, 1);
                OnlinePlayerNumber = int.Parse(onlinenum);
                OnlinePlayerNumberIsConnected = true;

                //更新各时段在线玩家数
                string playersOnTime = NetworkTools.GetUrlReturn("http://139.199.127.51/Qnum/newest.txt");
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
                    int hour = int.Parse(time.Substring(8, 2));//取得小时
                    int min = int.Parse(time.Substring(10, 2));//取得分钟
                    int diff = min - 30;//将分钟数与30分钟作差
                    if (diff >= 15)//若差大于等于15，即时间点已过半点又15分钟，也就是xx:45分以后
                    {
                        hour++;//将数据算入后一小时整点，
                        min = 0;//即(hour+1):00
                        int index = hour * 2;//在PlayerNumberDuringDay中的数据索引号，具体为什么自己想吧，数学问题
                        PlayerNumberDuringDay[index] = int.Parse(num);//设置数据
                    }
                    else if (diff < 15 && diff >= 0)//若差小于15且大于等于0，即时间点已过半点但未到15分钟，也就是xx:45分以前、xx:30及以后
                    {
                        min = 30;//将数据算入半点
                        int index = int.Parse(((hour + 0.5) * 2).ToString());//依然是数学问题
                        PlayerNumberDuringDay[index] = int.Parse(num);
                    }
                    else if (diff > -15 && diff <= 0)//判断条件与上相反，代码同
                    {
                        min = 30;
                        int index = int.Parse(((hour + 0.5) * 2).ToString());
                        PlayerNumberDuringDay[index] = int.Parse(num);
                    }
                    else if (diff <= -15 && diff >= -30)
                    {
                        int index = hour * 2;
                        PlayerNumberDuringDay[index] = int.Parse(num);
                    }
                }
            //}
            //catch
            //{
            //   OnlinePlayerNumberIsConnected = false;
            //   OnlinePlayerNumber = 0;
            //}
            
        }
        #endregion

        override public string ToString()
        {
            return ProviderName;
        }
    }
}
