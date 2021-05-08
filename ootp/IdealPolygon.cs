using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class IdealPolygon : Figures
    {
        private Brush brush { get; set; }

        public IdealPolygon(float PenWidth, Color PenColor, Color FillColor) : base(PenWidth, PenColor)
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
