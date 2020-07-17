using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Present.Draw
{
    public class DrawArc
    {
        static int width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width;
        static int height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height;

        public static void Draw_Arc(Graphics g, int time)
        {
            int angel = time % 180;
            if (angel > 90)
            {
                angel = 180 - angel;
            }
            
            Brush brush1 = new LinearGradientBrush(new Rectangle(-500, 0, 3000, 2000), Color.Silver, Color.MediumVioletRed, angel, true);

            Pen pen = new Pen(brush1)
            {
                Width = 20,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };

            Draw_(g, pen, time, 0);
        }

        public static void Draw_(Graphics g, Pen pen, int time, int group)
        {
            if (time <= 180 * group)
            {
                if (group % 2 == 0)
                {
                    LineAndArc.DrawArc(g, pen, (group - 6) * 100, (height / 2) - 100, 0, 0, 400, 200, -time, time - group * 180);
                    LineAndArc.DrawArc(g, pen, (group - 4) * 100, (height / 2) - 100, 0, 0, 200, 200, 0, -180);
                    LineAndArc.DrawArc(g, pen, (group - 4) * 100, (height / 2) - 100, 0, 0, 400, 200, 180, -180);
                    LineAndArc.DrawArc(g, pen, (group - 2) * 100, (height / 2) - 100, 0, 0, 200, 200, 0, (group - 1) * 180 - time);
                }
                else
                {
                    LineAndArc.DrawArc(g, pen, (group - 5) * 100, (height / 2) - 100, 0, 0, 200, 200, -time, time - group * 180);
                    LineAndArc.DrawArc(g, pen, (group - 5) * 100, (height / 2) - 100, 0, 0, 400, 200, 180, -180);
                    LineAndArc.DrawArc(g, pen, (group - 3) * 100, (height / 2) - 100, 0, 0, 200, 200, 0, -180);
                    LineAndArc.DrawArc(g, pen, (group - 3) * 100, (height / 2) - 100, 0, 0, 400, 200, 180, (group - 1) * 180 - time);
                }

                g.DrawString("Loading...", new Font("Verdana", 50, FontStyle.Regular), new LinearGradientBrush(new Rectangle(500, 500, 1000, 1000), Color.Silver, Color.MediumVioletRed, 90, true),width / 2, height / 2 + 300);
            }
            else
            {
                Draw_(g, pen, time, group + 1);
            }
        }
    }
}
