using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Present.Draw
{

    public class DrawWords
    {
        private static List<Color> colors = new List<Color>();
        private static int index = -1;

        public static void Init()
        {
            colors.Add(Color.AntiqueWhite);
            colors.Add(Color.Aqua);
            colors.Add(Color.Aquamarine);
            colors.Add(Color.Azure);
            colors.Add(Color.Beige);
            colors.Add(Color.Bisque);
            colors.Add(Color.BlanchedAlmond);
            colors.Add(Color.Blue);
            colors.Add(Color.BlueViolet);
            colors.Add(Color.Brown);
            colors.Add(Color.BurlyWood);
            colors.Add(Color.CadetBlue);
            colors.Add(Color.Chartreuse);
            colors.Add(Color.Chocolate);
            colors.Add(Color.Coral);
            colors.Add(Color.CornflowerBlue);
            colors.Add(Color.Cornsilk);
            colors.Add(Color.Crimson);
            colors.Add(Color.Cyan);
            colors.Add(Color.DeepPink);
            colors.Add(Color.DeepSkyBlue);
            colors.Add(Color.DimGray);
            colors.Add(Color.DodgerBlue);
            colors.Add(Color.Firebrick);
            colors.Add(Color.FloralWhite);
            colors.Add(Color.ForestGreen);
            colors.Add(Color.Fuchsia);
            colors.Add(Color.Gainsboro);
            colors.Add(Color.GhostWhite);
            colors.Add(Color.Gold);
            colors.Add(Color.Goldenrod);
            colors.Add(Color.Green);
            colors.Add(Color.GreenYellow);
            colors.Add(Color.Honeydew);
            colors.Add(Color.HotPink);
            colors.Add(Color.IndianRed);
            colors.Add(Color.Indigo);
            colors.Add(Color.Ivory);
            colors.Add(Color.Khaki);
            colors.Add(Color.Lavender);

            index = 0;
        }

        /// <summary>
        /// 渐变式
        /// </summary>
        /// <param name="g"></param>
        public static void Draw_HAPPYBIRTHDAY_ChangeColor(Graphics g, int time)
        {
            if (index < 0)
            {
                Init();
            }

            Draw_OneColor(g, colors[index], colors[index+1]);

            if (time % 100 == 0)
            {
                index++;
            }

            if (index == colors.Count-1)
            {
                index = 0;
            }
        }
        
        public static void Draw_OneColor(Graphics g, Color leftColor,Color rightColor)
        {

            //SolidBrush solidColorBrush = new SolidBrush(Color.Red);
            Brush brush = new LinearGradientBrush(new Rectangle(0, 500, 3000, 1000), leftColor, rightColor, 0, true);
            Pen pen = new Pen(brush)
            {
                Width = 5,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };

            int width = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - 700;
            int heigth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height - 170;

            Draw_H(g, pen, width + 0, heigth + 0);
            Draw_A(g, pen, width + 100, heigth + 0);
            Draw_P(g, pen, width + 200, heigth + 0);
            Draw_P(g, pen, width + 300, heigth + 0);
            Draw_Y(g, pen, width + 400, heigth + 0);
            Draw_B(g, pen, width + 600, heigth + 0);
            Draw_I(g, pen, width + 700, heigth + 0);
            Draw_R(g, pen, width + 800, heigth + 0);
            Draw_T(g, pen, width + 900, heigth + 0);
            Draw_H(g, pen, width + 1000, heigth + 0);
            Draw_D(g, pen, width + 1100, heigth + 0);
            Draw_A(g, pen, width + 1200, heigth + 0);
            Draw_Y(g, pen, width + 1300, heigth + 0);
            //Thread.Sleep(500);
        }

        public static void Draw_H(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 25, 125);
            LineAndArc.DrawLine(g, pen, x, y, 25, 75, 75, 75);
            LineAndArc.DrawLine(g, pen, x, y, 75, 25, 75, 125);
        }

        public static void Draw_A(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 50, 25, 25, 125);
            LineAndArc.DrawLine(g, pen, x, y, 38, 75, 62, 75);
            LineAndArc.DrawLine(g, pen, x, y, 50, 25, 75, 125);
        }

        public static void Draw_P(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 25, 125);
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 50, 25);
            LineAndArc.DrawLine(g, pen, x, y, 25, 75, 50, 75);
            LineAndArc.DrawArc(g, pen, x, y, 25, 25, 50, 50, -90, 180);
        }

        public static void Draw_Y(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 50, 75);
            LineAndArc.DrawLine(g, pen, x, y, 75, 25, 50, 75);
            LineAndArc.DrawLine(g, pen, x, y, 50, 75, 50, 125); 
        }

        public static void Draw_B(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 25, 125);
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 50, 25);
            LineAndArc.DrawLine(g, pen, x, y, 25, 75, 50, 75);
            LineAndArc.DrawLine(g, pen, x, y, 25, 125, 50, 125);
            LineAndArc.DrawArc(g, pen, x, y, 25, 25, 50, 50, -90, 180);
            LineAndArc.DrawArc(g, pen, x, y, 25, 75, 50, 50, -90, 180);
        }

        public static void Draw_I(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 50, 25, 50, 125);
            LineAndArc.DrawLine(g, pen, x, y, 35, 25, 65, 25);
            LineAndArc.DrawLine(g, pen, x, y, 35, 125, 65, 125);
        }
        
        public static void Draw_R(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 25, 125);
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 50, 25);
            LineAndArc.DrawLine(g, pen, x, y, 25, 75, 50, 75);
            LineAndArc.DrawLine(g, pen, x, y, 35, 75, 75, 125);
            LineAndArc.DrawArc(g, pen, x, y, 25, 25, 50, 50, -90, 180); 
        }

        public static void Draw_T(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 50, 25, 50, 125);
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 75, 25);
        }

        public static void Draw_D(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 25, 125);
            LineAndArc.DrawLine(g, pen, x, y, 25, 25, 50, 25);
            LineAndArc.DrawLine(g, pen, x, y, 25, 125, 50, 125);
            LineAndArc.DrawArc(g, pen, x, y, 25, 25, 50, 100, -90, 180);
        }

    }
}
