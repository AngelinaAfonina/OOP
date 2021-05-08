using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Redo
    {
        private Stack<Figures> Figures_St;
        public Redo()
        {
            Figures_St = new Stack<Figures>();
        }

        public void Push(Figures figures)
        {
            Figures_St.Push(figures);
        }

        public Figures Pop()
        {
            return Figures_St.Pop();
        }

        public void Clear_St()
        {
            Figures_St.Clear();
        }

        public bool Blank()
        {
            if (Figures_St.Count == 0)
                return false;

            return true;
        }
    }
}
