using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Present.Draw;
using System.Threading;

namespace Present.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form0 page = new Form0();
            page.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置窗体打开后在显示器中心
            //int width = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - 260;
            //int heigth = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height / 2) - 260;
            //this.SetDesktopLocation(width, heigth); 

            //this.Width = 519;
            //this.Height = 519;

            this.SetDesktopLocation(0, 0);
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height;

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
            this.TransparencyKey = Color.AliceBlue;
            // 设置窗体鼠标穿透
            SetPenetrate();
            // 设置窗口在最上层
            this.TopMost = true;

            //GetWx1();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawAll(e);
        }

        /// <summary>
        /// 绘制
        /// </summary>
        /// <param name="e"></param>
        private void DrawAll(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //for(int time = 0; time < 2000; time += 25)
            //{
            //    DrawBlack.Draw_Black(g, time / 2000);
            //    Thread.Sleep(25);
            //}

            for (int time = 0; time < 4400; time += 5)
            {
                Thread.Sleep(25);
                g.Clear(Color.AliceBlue);

                DrawArc.Draw_Arc(g, time);
            }

            for (int time = 0; time < 5000; time += 5)
            {
                Thread.Sleep(25);
                g.Clear(Color.AliceBlue);

                DrawCake.Draw_Cake(g, time);

                if (time > 1350)
                {
                    DrawWords.Draw_HAPPYBIRTHDAY_ChangeColor(g, time);
                }

                DrawMorse.Draw_Morse(g, Color.Black);
            }
        }
        
        #region win32 api
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
            IntPtr hwnd,
            int nIndex,
            uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
            IntPtr hwnd,
            int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
            IntPtr hwnd,
            int crKey,
            int bAlpha,
            int dwFlags
        );
        #endregion

        /// <summary> 
        /// 设置窗体具有鼠标穿透效果 
        /// </summary> 
        public void SetPenetrate()
        {
            GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }
    }
}
