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
        public Lines(float PenWidth, Color PenColor) : base(PenWidth, PenColor) { }

        public override void Drawing(Graphics graphics)
        {
            graphics.DrawLines(pen, points);
        }
    }
}
