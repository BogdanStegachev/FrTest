using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReportTest.Classes
{
    public class Rectangle : Figure
    {
        public Rectangle(int height, int width, Color color, Color fillcolor, Point position)
        {
            Height = height;
            Width = width;
            Color = color;
            Color = fillcolor;
            Position = position;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, Width, Height);
            gr.FillRectangle(new SolidBrush(FillColor), Position.X, Position.Y, Width, Height);
        }

    }
}
