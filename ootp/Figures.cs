using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_1
{
    public abstract class Figures
    {
        public Pen pen { get; set; }
        

        public Figures (float PenWidth, Color PenColor) 
        {
            pen = new Pen(PenColor, PenWidth);
        }
        public abstract void Drawing(Graphics graphics);
    }
}       
