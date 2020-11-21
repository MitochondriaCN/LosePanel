using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoseNoneVisualization
{
    public partial class MainForm : Form
    {
        #region Chart数据定义
        //在线玩家
        List<double> olPlayerHours = new List<double>() { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5, 9, 9.5, 10, 10.5, 11, 11.5, 12, 12.5, 13, 13.5, 14, 14.5, 15, 15.5, 16, 16.5, 17, 17.5, 18, 18.5, 19, 19.5, 20, 20.5, 21, 21.5, 22, 22.5, 23, 23.5 };
        List<int> olPlayerNumber = new List<int>(48);
        #endregion

        public MainForm()
        {
            InitializeComponent();
            chartOnlinePlayers.Series[0].Points.DataBindXY(olPlayerHours, olPlayerNumber);
        }
    }
}
