using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosePanel.SDK
{
    public class TimePointPlayerNumber
    {
        public int PlayerNumber { get; private set; }
        public DateTime TimePoint { get; private set; }
        public TimePointPlayerNumber(DateTime time, int playerNum)
        {
            PlayerNumber = playerNum;
            TimePoint = time;
        }
    }
}
