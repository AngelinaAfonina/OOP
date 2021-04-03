using System;
using System.Drawing;

namespace lab_1
{
    class Ellipse : Figures
    {
       public Ellipse(int x0, int y0, Graphics graphics, Pen pen, Color FillColor) : base(x0, y0, graphics, pen, FillColor)
        { }
        public override Point SecondPoint {
            get => base.FirstPoint;
            set
            {
                var brush = new SolidBrush(FillColor);
                secondpoint = value;
                Point box = new Point(firstpoint.X, firstpoint.Y);
                Drawing(ref firstpoint, ref secondpoint);

                int width = Math.Abs(firstpoint.X - secondpoint.X);
                int height = Math.Abs(firstpoint.Y - secondpoint.Y);

                graphics.DrawEllipse(pen, firstpoint.X, secondpoint.Y, width, height);
                graphics.FillEllipse(brush, firstpoint.X, secondpoint.Y, width, height);

                firstpoint = box;
                brush.Dispose();

            }
        }
        
        
    }
}


