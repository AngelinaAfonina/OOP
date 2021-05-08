using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_1
{
    public class Rectangle : Figures
    {
        private Brush brush { get; set; }

        public Rectangle(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            Point FirstAngle = new Point(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            Point SecondAngle = new Point(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));

            graphics.FillRectangle(brush, FirstAngle.X, FirstAngle.Y, SecondAngle.X - FirstAngle.X, SecondAngle.Y - FirstAngle.Y);
            graphics.DrawRectangle(pen, FirstAngle.X, FirstAngle.Y, SecondAngle.X - FirstAngle.X, SecondAngle.Y - FirstAngle.Y);
        }
    }
}
