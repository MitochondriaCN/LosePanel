using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosePanel
{
    static class Program
    {
        public static PrivateFontCollection CustomFont = new PrivateFontCollection();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Drawing.Color c = System.Drawing.Color.FromArgb(1, 5, 7);
            string str = c.ToString();
            System.IO.File.WriteAllText("D:\\file.txt", str);
        }
    }
}
