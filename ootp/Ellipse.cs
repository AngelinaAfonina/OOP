using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_1
{
    class Ellipse : Figures
    {
        private Point firstpoint { get; set; }
        private Point secondpoint { get; set; }
        private Brush brush { get; set; }

        public Ellipse(float PenWidth, Color PenColor, Color FillColor, Point firstpoint, Point secondpoint) : base(PenWidth, PenColor)
        {
            brush = new SolidBrush(FillColor);
            this.firstpoint = firstpoint;
            this.secondpoint = secondpoint;
        }

        public override void Drawing(Graphics graphics)
        {
            int width = Math.Abs(firstpoint.X - secondpoint.X);
            int height = Math.Abs(firstpoint.Y - secondpoint.Y);

            graphics.DrawEllipse(pen, firstpoint.X, secondpoint.Y, width, height);
            graphics.FillEllipse(brush, firstpoint.X, secondpoint.Y, width, height);
        }
        
    }
}


