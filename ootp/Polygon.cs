using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace lab_1
{
    class Polygon : Figures
        
    {
        public Polygon(int x0, int y0, Graphics graphics, Pen pen, Color FillColor) : base(x0, y0, graphics,
          pen, FillColor)
        {
        }

        public override Point FirstPoint
        {
            get => base.FirstPoint;
            set
            {
                firstpoint = value;
                if ((n == 0) && (value.X > 0))
                {
                    points.AddLast(value);
                    n++;
                }
            }
        }

        public override Point Second_Point
        {
            get => base.Second_Point;
            set { graphics.DrawLine(pen, points.ElementAt<Point>(n - 1), value); }
        }

        public override Point SecondPoint
        {
            get => base.SecondPoint;
            set
            {
                secondpoint = value;
                points.AddLast(value);
                if (!this.end)
                {
                    if (n > 0)
                    {
                        graphics.DrawLine(pen, points.ElementAt<Point>(n - 1),
                            points.ElementAt<Point>(n));
                    }

                    n++;
                }
                else
                {
                    var brush = new SolidBrush(FillColor);

                    n = 0;

                    graphics.DrawPolygon(pen, points.ToArray());
                    graphics.FillPolygon(brush, points.ToArray());
                    points.Clear();
                    brush.Dispose();
                    this.end = false;
                }
            }
        }
        private LinkedList<Point> points = new LinkedList<Point>();
        protected int n = 0;
    }
}
    
