using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Line : Figures
    {
        private Point firstpoint { get; set; }
        private Point secondpoint { get; set; }
        public Line(float PenWidth, Color PenColor, Point firstpoint, Point secondpoint) : base(PenWidth, PenColor)
        {
            this.firstpoint = firstpoint;
            this.secondpoint = secondpoint;
        }

        public override void Drawing(Graphics graphics)
        {
            graphics.DrawLine(pen, firstpoint, secondpoint);
        }
    }
}
