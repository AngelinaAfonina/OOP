using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Blue, 3); 
            Graphics g = CreateGraphics();
            g.DrawEllipse(pn, 20, 50, 70, 35);
        }

        private void Line_Click_1(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Red, 3);
            Graphics g = CreateGraphics();
            g.DrawLine(pn, 145, 45, 145, 95);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Blue, 3);
            Graphics g = CreateGraphics();
            g.DrawRectangle(pn, 225, 45, 70, 45);
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Red, 3);
            Graphics g = CreateGraphics();
            Point point1 = new Point(370, 45);
            Point point2 = new Point(405, 75);
            Point point3 = new Point(390, 105);
            Point point4 = new Point(350, 105);
            Point point5 = new Point(335, 75);
            Point[] Points =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5
             };
            g.DrawPolygon(pn, Points);
        }

        private void Lines_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Blue, 3);
            Graphics g = CreateGraphics();
            Point[] points =
            {
                 new Point(500, 45),
                 new Point(480, 75),
                 new Point(490, 70),
                 new Point(470, 105)
             };
            g.DrawLines(pn, points);
        }

        
    }
}
