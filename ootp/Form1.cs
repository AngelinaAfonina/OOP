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
        Graphics graphics;
        Pen pen;
        Figures selectedFifure;
        Bitmap box = new Bitmap(1000, 1000);
        LinkedList<Type> FiguresList = new LinkedList<Type>();
        

        private void outline_color_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                outline_color.BackColor = colorDialog2.Color;
                pen.Color = colorDialog2.Color;
            }
        }

        private void fill_color_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                fill_color.BackColor = colorDialog2.Color;
                selectedFifure.FillColor = colorDialog2.Color;
            }
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            selectedFifure = (Figures)Activator.CreateInstance(FiguresList.ElementAt<Type>(), -1, -1, graphics, pen, fill_color.BackColor);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            selectedFifure = (Figures)Activator.CreateInstance(FiguresList.ElementAt<Type>(), -1, -1, graphics, pen, fill_color.BackColor);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            selectedFifure = (Figures)Activator.CreateInstance(FiguresList.ElementAt<Type>(), -1, -1, graphics, pen, fill_color.BackColor);
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            selectedFifure = (Figures)Activator.CreateInstance(FiguresList.ElementAt<Type>(), -1, -1, graphics, pen, fill_color.BackColor);
        }

        private void Lines_Click(object sender, EventArgs e)
        {
            selectedFifure = (Figures)Activator.CreateInstance(FiguresList.ElementAt<Type>(), -1, -1, graphics, pen, fill_color.BackColor);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            selectedFifure.FirstPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                graphics = Graphics.FromImage(box);
                selectedFifure.graphics = graphics;

                if (e.Button == MouseButtons.Right) selectedFifure.end = true;

                selectedFifure.SecondPoint = new Point(e.X, e.Y);

                selectedFifure.FirstPoint = new Point(-2, -2);
                pictureBox1.Image = box;

            }
            catch
            {
            }
        }

        private bool StartCheck()
        {
            bool check = false;

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                foreach (PropertyInfo pi in types[i].GetProperties())
                {
                    if ((pi.Name == "FName") && (pi.CanRead) && (!pi.CanWrite))
                    {
                        if (!types[i].IsAbstract)
                        {
                            FiguresList.AddLast(types[i]);
                            check = true;
                        }
                    }
                }
            }
            return check;
        }

        public Form1()
        {
            InitializeComponent();
            if (!StartCheck())
            {
                Application.Exit();
            }
            graphics = Graphics.FromImage(box);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Width = (int)WidthUpDown.Value;
            pictureBox1.Image = box;
        }

        private void WidthUpDown_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)WidthUpDown.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
    }

}
