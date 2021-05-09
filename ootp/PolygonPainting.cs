using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace lab_1
{
    public class PolygonPainting : Painting
    {
        public Figures GetFigure(float PenWidth, Color PenColor, Color FillColor)
        {
            return new Polygon(PenWidth, PenColor, FillColor);
        }
        public bool angles { get { return false; } }
        public bool Click { get { return true; } }
    }
}