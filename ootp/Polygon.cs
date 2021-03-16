using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_1
{
    class Polygon : Figures
        
    {
        private Brush brush { get; set; }

        private Point[] angles { get; set; }

        public Polygon(float PenWidth, Color PenColor, Color FillColor, Point[] points) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
            angles = points;
            
        }

        public override void Drawing(Graphics graphics)
        {
            graphics.DrawPolygon(pen, angles);
            graphics.FillPolygon(brush, angles);
        }
    }
}
