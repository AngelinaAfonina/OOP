using System.Drawing;

namespace lab_1
{
    public abstract class Figures
    {
        public Point[] points;
        public Pen pen { get; set; }

        public Figures(float PenWidth, Color PenColor)
        {
            pen = new Pen(PenColor, PenWidth);
        }

        public abstract void Drawing(Graphics graphics);
    }
}


