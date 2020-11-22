using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LosePanel.DataSystem;

namespace LosePanel
{
    public partial class MainForm : Form
    {
        LosenoneDataProvider dp = new LosenoneDataProvider();

        Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            chartOnlinePlayers.Series[0].Points.DataBindXY(LosenoneDataProvider.Constants.olPlayerHours, dp.olPlayerNumber);

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
