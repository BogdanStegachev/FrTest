using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReportTest.Classes
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics gr);
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public Color FillColor { get; set; }
        public Point Position { get; set; }


    }
}
