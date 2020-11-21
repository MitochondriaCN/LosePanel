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
        public MainForm()
        {
            InitializeComponent();

            List<int> x = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            List<int> data = new List<int>() { 2, 6, 4, 5, 5, 7, 4, 6, 6, 1, 8, 4, 1, 5, 0, 4, 0, 2, 2, 6, 6, 0, 0, 1 };
            chartOnlinePlayers.Series[0].Points.DataBindXY(x, data);
        }
    }
}
