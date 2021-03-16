using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_1
{
    class Lines : Figures
    {
        private Point[] points { get; set; }

        public Lines(float PenWidth, Color PenColor, Point[] points) : base(PenWidth, PenColor)
        {
            this.points = points;
        }

        public override void Drawing(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
