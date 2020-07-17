using Present.Forms;
using System;
using System.Windows.Forms;

namespace Present
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form0());
            Application.Run(new Form1());
        }
    }
}
