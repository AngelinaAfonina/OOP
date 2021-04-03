using System.Drawing;

namespace lab_1
{
    class Line : Figures
    {

        public Line(int x0, int y0, Graphics graphics, Pen pen, Color FillColor) : base(x0, y0, graphics, pen, FillColor)
        {}

        public override Point SecondPoint
        {
            get => base.FirstPoint;
            set
            {
                secondpoint = value;
                graphics.DrawLine(pen, firstpoint, secondpoint);
            }
            
        }
    }
}
