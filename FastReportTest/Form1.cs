using FastReportTest.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastReportTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ControlMoverOrResizer.Init(panel1);
            ControlMoverOrResizer.Init(panel2);
            ControlMoverOrResizer.Init(panel3);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Figure circle = new Circle(panel1.Height <= panel1.Width ? panel1.Height / 2 : panel1.Width / 2, Color.Black, Color.Black, new Point(0, 0));    
            e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0, panel1.Width - 1, panel1.Height - 1);
            circle.Draw(e.Graphics);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Figure triangle = new Triangle(1.047, 190, Color.Black, Color.Black, new Point(10, 10));       
            e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0, panel2.Width - 1, panel2.Height - 1 );
            triangle.Draw(e.Graphics);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Figure rectangle = new Classes.Rectangle(panel3.Height - 1, panel3.Width - 1, Color.Red, Color.Red, new Point(0, 0));
            rectangle.Draw(e.Graphics);
        }

    }
}
