using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoseNoneVisualization.Background;

namespace LoseNoneVisualization
{
    public partial class MainForm : Form
    {
        DataProvider dp = new DataProvider();

        Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            chartOnlinePlayers.Series[0].Points.DataBindXY(DataProvider.Constants.olPlayerHours, dp.olPlayerNumber);

            //设置Timer
            timer.Interval = 5000;
            timer.Tick += UpdateDataDisplay;
            timer.Start();
        }

        private void UpdateDataDisplay(object sender, EventArgs e)
        {
            lblOnlinePlayerNumber.Text = dp.OnlinePlayerNumber.ToString();
        }
    }
}
