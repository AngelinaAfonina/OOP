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
        
        public Rectangle(int x0, int y0, Graphics graphics, Pen pen, Color FillColor) : base(x0, y0, graphics, pen, FillColor)
        {}

        public override Point SecondPoint
        {
            get => base.FirstPoint;
            set
            {
                var brush = new SolidBrush(FillColor);
                secondpoint = value;
                Point MainPicture = new Point(firstpoint.X, secondpoint.Y);

                Drawing(ref firstpoint, ref secondpoint);
                Point LeftPoint = new Point(Math.Min(firstpoint.X, secondpoint.X), Math.Min(firstpoint.Y, secondpoint.Y));
                Point RightPoint = new Point(Math.Max(firstpoint.X, secondpoint.X), Math.Max(firstpoint.Y, secondpoint.Y));

                graphics.DrawRectangle(pen, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
                graphics.FillRectangle(brush, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
                firstpoint = MainPicture;
            }
        }
    }
}
