using Survive2020.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive2020
{
    [Serializable]
    public class Mask
    {
        public static readonly int Width = 70;
        public static readonly int Height = 47;

        private int X { get; set; }
        private int Y { get; set; }
        private Image Image { get; set; }
        public Point Center { get; set; }

        public Mask(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.mask;
            Center = new Point(X + Width / 2, Y + Height / 2);
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, Width, Height);
        }
    }
}
