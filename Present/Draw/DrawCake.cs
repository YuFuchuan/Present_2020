using System.Drawing;
using System.Drawing.Drawing2D;

namespace Present.Draw
{
    public class DrawCake
    {
        public static void Draw_Cake(Graphics g,int time)
        {
            int width = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Width / 2) - 155;
            int heigth = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size.Height / 2);
            Draw_(g, width, heigth, time);
        }
        
        public static void Draw_(Graphics g, int x, int y, int time)
        {
            int angel = time % 180;
            if (angel > 90)
            {
                angel = 180 - angel;
            }

            //SolidBrush solidColorBrush = new SolidBrush(Color.Red);
            Brush brush1 = new LinearGradientBrush(new Rectangle(-500, -500, 1000, 1000), Color.MintCream, Color.MediumVioletRed, angel, true);
            Brush brush2 = new LinearGradientBrush(new Rectangle(100, -150, 1000, 1000), Color.Navy, Color.Blue, angel, true);
            Brush brush3 = new LinearGradientBrush(new Rectangle(155, -150, 500, 500), Color.Red, Color.Yellow, angel, true);

            Pen pen1 = new Pen(brush1)
            {
                Width = 20,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };

            Pen pen2 = new Pen(brush2)
            {
                Width = 20,
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };

            Pen pen3 = new Pen(brush3)
            {
                Width = 20,
                StartCap = LineCap.Round,
                EndCap = LineCap.Triangle
            };

            if (time > 90)
            {
                LineAndArc.DrawArc(g, pen1, x, y, 0, 0, 100, 100, -180, 90);
                time -= 90;
                if (time > 210)
                {
                    LineAndArc.DrawLine(g, pen1, x, y, 50, 0, 260, 0);
                    time -= 210;
                    if (time > 225)
                    {
                        LineAndArc.DrawArc(g, pen1, x, y, 210, 0, 100, 100, -90, 225);
                        time -= 225;
                        if (time > 90)
                        {
                            LineAndArc.DrawArc(g, pen1, x, y, 140, 70, 100, 100, -45, -90);
                            time -= 90;
                            if (time > 90)
                            {
                                LineAndArc.DrawArc(g, pen1, x, y, 70, 0, 100, 100, 45, 90);
                                time -= 90;
                                if (time > 135)
                                {
                                    LineAndArc.DrawArc(g, pen1, x, y, 0, 70, 100, 100, -45, -135);
                                    time -= 135;
                                    {
                                        if (time > 50)
                                        {
                                            LineAndArc.DrawLine(g, pen1, x, y, 0, 120, 0, 170);
                                            time -= 50;
                                            if (time > 310)
                                            {
                                                LineAndArc.DrawLine(g, pen1, x, y, 0, 170, 310, 170);
                                                time -= 310;
                                                if (time > 50)
                                                {
                                                    LineAndArc.DrawLine(g, pen1, x, y, 310, 170, 310, 120);
                                                    time -= 50;
                                                    if (time > 90)
                                                    {
                                                        LineAndArc.DrawLine(g, pen2, x, y, 155, -30, 155, -120);
                                                        time -= 90;
                                                        if (time > 10)
                                                        {
                                                            LineAndArc.DrawLine(g, pen3, x, y, 155, -150, 155, -160);
                                                        }
                                                        else
                                                        {
                                                            LineAndArc.DrawLine(g, pen1, x, y, 155, -150, 155, -150 - time);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        LineAndArc.DrawLine(g, pen2, x, y, 155, -30, 155, -30 - time);
                                                    }
                                                }
                                                else
                                                {
                                                    LineAndArc.DrawLine(g, pen1, x, y, 310, 170, 310, 170 - time);
                                                }
                                            }
                                            else
                                            {
                                                LineAndArc.DrawLine(g, pen1, x, y, 0, 170, time, 170);
                                            }
                                        }
                                        else
                                        {
                                            LineAndArc.DrawLine(g, pen1, x, y, 0, 120, 0, 120 + time);
                                        }
                                    }
                                }
                                else
                                {
                                    LineAndArc.DrawArc(g, pen1, x, y, 0, 70, 100, 100, -45, -time);
                                }
                            }
                            else
                            {
                                LineAndArc.DrawArc(g, pen1, x, y, 70, 0, 100, 100, 45, time);
                            }
                        }
                        else
                        {
                            LineAndArc.DrawArc(g, pen1, x, y, 140, 70, 100, 100, -45, -time);
                        }
                    }
                    else
                    {
                        LineAndArc.DrawArc(g, pen1, x, y, 210, 0, 100, 100, -90, time);
                    }
                }
                else
                {
                    LineAndArc.DrawLine(g, pen1, x, y, 50, 0, time + 50, 0);
                }
            }
            else
            {
                LineAndArc.DrawArc(g, pen1, x, y, 0, 0, 100, 100, -180, time);
            }
        }
    }
}
