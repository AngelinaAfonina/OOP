using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace lab_1
{
    public class IdealPolygon_Painting : Painting
    {
        public Figures GetFigure(float PenWidth, Color PenColor, Color FillColor)
        {
            return new IdealPolygon(PenWidth, PenColor, FillColor);
        }
        public bool angles { get { return false; } }
        public bool Click { get { return false; } }
    }
}