using System.Drawing;

namespace Present.Draw
{
    public class LineAndArc
    {
        /// <summary>
        /// 绘制直线
        /// </summary>
        /// <param name="g">绘图画面</param>
        /// <param name="pen">画笔</param>
        /// <param name="x0">横坐标偏移</param>
        /// <param name="y0">纵坐标偏移</param>
        /// <param name="x1">起始点横坐标</param>
        /// <param name="y1">起始点纵坐标</param>
        /// <param name="x2">截至点横坐标</param>
        /// <param name="y2">截至点纵坐标</param>
        public static void DrawLine(Graphics g, Pen pen, int x0, int y0, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(pen, x0 + x1, y0 + y1, x0 + x2, y0 + y2);
        }

        /// <summary>
        /// 绘制弧线
        /// </summary>
        /// <param name="g">绘图画面</param>
        /// <param name="pen">画笔</param>
        /// <param name="x0">横坐标偏移</param>
        /// <param name="y0">纵坐标偏移</param>
        /// <param name="x1">锚点横坐标</param>
        /// <param name="y1">锚点纵坐标</param>
        /// <param name="width">椭圆宽度</param>
        /// <param name="height">椭圆高度</param>
        /// <param name="startAngle">起始角</param>
        /// <param name="sweepAngle">角跨度</param>
        public static void DrawArc(Graphics g, Pen pen, int x0, int y0, int x1, int y1, int width, int height, int startAngle, int sweepAngle)
        {
            g.DrawArc(pen, x0 + x1, y0 + y1, width, height, startAngle, sweepAngle);
        }
    }
}
