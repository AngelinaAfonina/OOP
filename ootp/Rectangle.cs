using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_1
{
    class Rectangle : Figures
    {
        private Point firstpoint { get; set; }
        private Point secondpoint { get; set; }
        private Brush brush { get; set; }

        public Rectangle(float PenWidth, Color PenColor, Color FillColor, Point firstpoint, Point secondpoint) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
            this.firstpoint = firstpoint;
            this.secondpoint = secondpoint;

        }

        public override void Drawing(Graphics graphics)
        {
            Point LeftPoint = new Point(Math.Min(firstpoint.X, secondpoint.X), Math.Min(firstpoint.Y, secondpoint.Y));
            Point RightPoint = new Point(Math.Max(firstpoint.X, secondpoint.X), Math.Max(firstpoint.Y, secondpoint.Y));

            graphics.DrawRectangle(pen, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
            graphics.FillRectangle(brush, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
        }
    }
}
