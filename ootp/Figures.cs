using System.Drawing;

namespace lab_1
{
    public abstract class Figures
    {
        public Graphics graphics;
        public Pen pen;
        public Color FillColor;
        protected Point firstpoint;
        protected Point secondpoint;
        public bool end = false;


        public Figures (int x0, int y0, Graphics graphics, Pen pen, Color FillColor) 
        {
            firstpoint = new Point(x0, y0);
        }

        public virtual Point FirstPoint
        {
            get { return firstpoint; }
            set { firstpoint = value; }
        }

        public virtual Point Second_Point
        {
            get { return secondpoint; }
            set { secondpoint = value; }
        }

        public virtual Point SecondPoint
        {
            get { return secondpoint; }
            set { secondpoint = value; }
        }

        protected void Drawing(ref Point box, ref Point image)
        {
            int buf;
            if (image.X < box.X)
            {
                buf = image.X;
                image.X = box.X;
                box.X = buf;
            }

            if (image.Y < box.Y)
            {
                buf = image.Y;
                image.Y = box.Y;
                box.Y = buf;
            }
        }

        public virtual string FigureName
        {
            get
            {
                return "FName";
            }
        }
    }
}


