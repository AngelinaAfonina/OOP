using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Polygon : Figures
    {
        private Brush brush { get; set; }

        public Polygon(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Drawing(Graphics graphics)
        {
            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points);
        }
    }
}
