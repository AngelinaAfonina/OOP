using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace lab_1
{
    public partial class Form1 : Form
    {
        private Painting painting;
        private Figures figures;
        private List<Point> points;
        private bool drawing;
        private Point FirstPoint;
        private Point SecondPoint;

        private Undo ListFigure;
        private Redo Figures_St;

        private Color penColor;
        private float penWidth;
        private Color FillColor;

        private int numOfangles;

        public Form1()
        {
            ListFigure = new Undo();
            Figures_St = new Redo();
            drawing = false;
            points = new List<Point>();

            penColor = Color.Black;
            FillColor = Color.White;

            penWidth = 1;
            numOfangles = 3;

            InitializeComponent();
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            painting = new EllipsePainting();
        }

        private void Line_Click(object sender, EventArgs e)
        {
            painting = new LinePainting();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            painting = new RectanglePainting();
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            painting = new IdealPolygonPainting();
        }


        private void Lines_Click(object sender, EventArgs e)
        {
            painting = new LinesPainting();
        }

        private void Polygon_Idel_Click(object sender, EventArgs e)
        {
            painting = new PolygonPainting();
        }

        private void outline_color_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                outline_color.BackColor = colorDialog2.Color;
                penColor = outline_color.BackColor;
            }
        }

        private void fill_color_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                fill_color.BackColor = colorDialog2.Color;
                FillColor = fill_color.BackColor;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (painting != null)
            {
                if (!drawing && !painting.Click)
                {
                    figures = painting.GetFigure(penWidth, penColor, FillColor);

                    if (painting.angles)
                    {
                        (figures as IdealPolygon).numOfangles = numOfangles;
                    }

                    drawing = !drawing;
                    FirstPoint.X = e.X;
                    FirstPoint.Y = e.Y;
                    points.Clear();
                    points.Add(FirstPoint);
                    points.Add(FirstPoint);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing && !painting.Click)
            {
                SecondPoint.X = e.X;
                SecondPoint.Y = e.Y;

                drawing = !drawing;

                if (FirstPoint != SecondPoint)
                {
                    points[1] = SecondPoint;
                    ListFigure.Add(figures);
                    Figures_St.ClearSt();
                }
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e) 
        {
            ListFigure.draw(e.Graphics);
            if (drawing)
            {
                figures.Drawing(e.Graphics);
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                SecondPoint.X = e.X;
                SecondPoint.Y = e.Y;
                points[points.Count - 1] = SecondPoint;

                figures.points = points.ToArray();
                pictureBox1.Refresh();
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (painting != null)
            {
                if (painting.Click)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        FirstPoint.X = e.X;
                        FirstPoint.Y = e.Y;

                        if (!drawing)
                        {
                            figures = painting.GetFigure(penWidth, penColor, FillColor);
                            

                            points.Clear();
                            points.Add(FirstPoint);
                            points.Add(FirstPoint);
                            drawing = !drawing;

                        }
                        else
                        {
                            points.Add(FirstPoint);
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        drawing = !drawing;
                        ListFigure.Add(figures);
                        Figures_St.ClearSt();
                    }

                }
            }
        }


        private void AngleUpDown_ValueChanged(object sender, EventArgs e)
        {
            numOfangles = (int)AngleUpDown.Value;
        }

        private void WidthUpDown_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (float)WidthUpDown.Value;
            if (figures != null)
            {
                figures.pen = new Pen(penColor, penWidth);
            }
        }

        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            if (ListFigure.IsEmpty())
            {
                Figures_St.Push(ListFigure.Delete());
                pictureBox1.Refresh();

            }
        }

        private void RedoMenuItem_Click(object sender, EventArgs e)
        {
            if (Figures_St.Blank())
            {
                ListFigure.Add(Figures_St.Pop());
                pictureBox1.Refresh();
            }
        }

       
    }

}
