using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReportTest.Classes
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(int radius, Color color, Color fillcolor, Point position)
        {
            Height = radius * 2;
            Width = radius * 2;
            Radius = radius;
            Color = color;
            Color = fillcolor;
            Position = position;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, Width, Height);
            gr.FillEllipse(new SolidBrush(FillColor), Position.X, Position.Y, Width, Height);
        }
    }
}
