﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace lab_1
{
    public interface Painting
    {
        bool angles { get; }
        bool Click { get; }
        string name { get; }
        Figures GetFigure(float PenWidth, Color PenColor, Color FillColor);
    }
}
