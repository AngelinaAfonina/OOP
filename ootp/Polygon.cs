using System;
using System.Drawing;

namespace lab_1
{
    public class Polygon : Figures
    {
        private Brush brush { get; set; }
        private PointF[] angles;
        public int numOfangles;


        public Polygon(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            angles = new PointF[numOfangles];
            angles[0] = points[1];
            PointF start = points[0];
            PointF polyg = new PointF(1 * (float)Math.Cos(Math.Acos(-1.0) * 2 / numOfangles), 1 * (float)Math.Sin(Math.Acos(-1.0) * 2 / numOfangles));
            PointF finish = new PointF(points[1].X - start.X, points[1].Y - start.Y);
            PointF temp = new PointF();

            for (int i = 1; i < numOfangles; i++)
            {
                temp.X = finish.X * polyg.X - finish.Y * polyg.Y;
                temp.Y = finish.X * polyg.Y + finish.Y * polyg.X;

                finish.X = temp.X;
                finish.Y = temp.Y;

                angles[i].X = start.X + finish.X;
                angles[i].Y = start.Y + finish.Y;
            }

            graphics.FillPolygon(brush, angles);
            graphics.DrawPolygon(pen, angles);
        }
    }
}
