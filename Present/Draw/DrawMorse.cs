using System.Drawing;

namespace Present.Draw
{
    public class DrawMorse
    {
        public static void Draw_Morse(Graphics g,Color color)
        {
            int width = 10;
            int heigth = 10;
            Draw_(g, width, heigth, color);
        }

        private static void Draw_(Graphics g, int x, int y, Color color)
        {
            SolidBrush solidColorBrush = new SolidBrush(color);
            Pen pen = new Pen(solidColorBrush)
            {
                Width = 5,
            };

            Draw_H(g, pen, x + 0, y + 0);
            Draw_T(g, pen, x + 0, y + 10);
            Draw_T(g, pen, x + 0, y + 20);
            Draw_P(g, pen, x + 0, y + 30);
            Draw_S(g, pen, x + 0, y + 40);

            Draw_G(g, pen, x + 0, y + 60);
            Draw_I(g, pen, x + 0, y + 70);
            Draw_T(g, pen, x + 0, y + 80);
            Draw_H(g, pen, x + 0, y + 90);
            Draw_U(g, pen, x + 0, y + 100);
            Draw_B(g, pen, x + 0, y + 110);
            
            Draw_C(g, pen, x + 0, y + 130);
            Draw_O(g, pen, x + 0, y + 140);
            Draw_M(g, pen, x + 0, y + 150);

            Draw_Y(g, pen, x + 0, y + 170);
            Draw_U(g, pen, x + 0, y + 180);
            Draw_F(g, pen, x + 0, y + 190);
            Draw_U(g, pen, x + 0, y + 200);
            Draw_C(g, pen, x + 0, y + 210);
            Draw_H(g, pen, x + 0, y + 220);
            Draw_U(g, pen, x + 0, y + 230);
            Draw_A(g, pen, x + 0, y + 240);
            Draw_N(g, pen, x + 0, y + 250);

            Draw_C(g, pen, x + 0, y + 270);
            Draw_O(g, pen, x + 0, y + 280);
            Draw_D(g, pen, x + 0, y + 290);
            Draw_E(g, pen, x + 0, y + 300);

        }

        private static void Draw_H(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
            LineAndArc.DrawLine(g, pen, x, y, 30, 0, 35, 0);
        }

        private static void Draw_T(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
        }

        private static void Draw_P(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 25, 0);
            LineAndArc.DrawLine(g, pen, x, y, 30, 0, 45, 0);
            LineAndArc.DrawLine(g, pen, x, y, 50, 0, 55, 0);
        }

        private static void Draw_S(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
        }

        private static void Draw_G(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 35, 0);
            LineAndArc.DrawLine(g, pen, x, y, 40, 0, 45, 0);
        }

        private static void Draw_I(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 15, 0);
        }

        private static void Draw_U(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 35, 0);
        }

        private static void Draw_B(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
            LineAndArc.DrawLine(g, pen, x, y, 30, 0, 35, 0);
            LineAndArc.DrawLine(g, pen, x, y, 40, 0, 45, 0);
        }

        private static void Draw_C(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
            LineAndArc.DrawLine(g, pen, x, y, 30, 0, 45, 0);
            LineAndArc.DrawLine(g, pen, x, y, 50, 0, 55, 0);
        }

        private static void Draw_O(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 35, 0);
            LineAndArc.DrawLine(g, pen, x, y, 40, 0, 55, 0);
        }

        private static void Draw_M(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 35, 0);
        }

        private static void Draw_Y(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
            LineAndArc.DrawLine(g, pen, x, y, 30, 0, 45, 0);
            LineAndArc.DrawLine(g, pen, x, y, 50, 0, 65, 0);
        }

        private static void Draw_F(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 35, 0);
            LineAndArc.DrawLine(g, pen, x, y, 40, 0, 45, 0);
        }

        private static void Draw_A(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
            LineAndArc.DrawLine(g, pen, x, y, 10, 0, 25, 0);
        }

        private static void Draw_N(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
        }

        private static void Draw_D(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 15, 0);
            LineAndArc.DrawLine(g, pen, x, y, 20, 0, 25, 0);
            LineAndArc.DrawLine(g, pen, x, y, 30, 0, 35, 0);
        }

        private static void Draw_E(Graphics g, Pen pen, int x, int y)
        {
            LineAndArc.DrawLine(g, pen, x, y, 0, 0, 5, 0);
        }
    }
}
