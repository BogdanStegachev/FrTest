using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastReportTest.Classes
{
    public class Triangle : Figure
    {
        public double Angle { get; set; }
        public int Side { get; set; }

        public Triangle(double angle, int side, Color figureColor, Color fillColor, Point position)
        {
            Angle = angle;
            Side = side;
            Color = figureColor;
            FillColor = fillColor;
            Position = position;
            Height = Side;
            Width = (int)(Side * Math.Sqrt(3) / 2);
        }

        public override void Draw(Graphics gr)
        {
            var points = new Point[3]
            {
                new Point(Position.X, Position.Y),
                new Point(Position.X, Side),
                new Point((int)(Side * Math.Sin(Angle)), Side / 2)
            };

            gr.DrawPolygon(new Pen(Color), points);
            gr.FillPolygon(new SolidBrush(FillColor), points);
        }

    }
}
