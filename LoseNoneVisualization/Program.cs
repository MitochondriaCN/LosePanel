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
            byte[] fontData = Properties.Resources.FZYH;
            //打开"允许不安全代码编译"开关，此句才不报错 
            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    CustomFont.AddMemoryFont((System.IntPtr)pFontData, fontData.Length);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
