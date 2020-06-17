using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive2020
{
    public class Darkness
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public float Thickness { get; set; }

        public Darkness(Point s, Point e, float t)
        {
            Start = s;
            End = e;
            Thickness = t;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, Thickness);
            g.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
