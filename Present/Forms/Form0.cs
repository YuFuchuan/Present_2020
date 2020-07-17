using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Present.Forms
{
    public partial class Form0 : Form
    {
        //private WindowsAPI.HideTaskmgrList _List = new WindowsAPI.HideTaskmgrList();

        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            if (Configure.DISABLE_TASKMGR)
            {
                try
                {
                    Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                    rk.SetValue("DisableTaskMgr", 1, Microsoft.Win32.RegistryValueKind.DWord);
                }
                catch { }
            }
            
            int width = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - 260;
            int heigth = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height / 2) - 160;
            // 设置窗体打开后在显示器中心
            this.SetDesktopLocation(width, heigth);

            this.Width = 520;
            this.Height = 320;

            this.Text = "";
            // 不在窗体标题栏中显示控件
            ControlBox = false;

            // 禁用最大、小化
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // 禁用拉伸
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // 设置背景全透明
            this.BackColor = Color.AliceBlue;
            //this.TransparencyKey = Color.AliceBlue;
            // 设置窗口在最上层
            this.TopMost = true;

            //_List.ProcessName = "Present.exe";
            //_List.Star();

            label1.Text = TextManager.TextManager.GetLabel();
            button1.Text = TextManager.TextManager.GetButton();
        }

        private void Form0_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.ShowInTaskbar = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextManager.TextManager.Test())
            {
                label1.Text = TextManager.TextManager.GetLabel();
                button1.Text = TextManager.TextManager.GetButton();
            }
            else
            {
                if (Configure.DISABLE_TASKMGR) 
                {
                    try
                    {
                        Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                        rk.SetValue("DisableTaskMgr", 0, Microsoft.Win32.RegistryValueKind.DWord);
                    }
                    catch { }
                }
                
                this.Dispose();
            }
        }
    }
}
