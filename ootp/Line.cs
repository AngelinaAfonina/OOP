using System.Drawing;

namespace lab_1
{
    class Line : Figures
    {

        public Line(float PenWidth, Color PenColor) : base(PenWidth, PenColor) { }

        public override void Drawing(Graphics graphics)
        {
            graphics.DrawLine(pen, points[0], points[1]);
        }
    }
}
