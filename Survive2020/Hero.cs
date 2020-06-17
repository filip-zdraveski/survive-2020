using Survive2020.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive2020
{
    public class Hero
    {
        public Image Image { get; set; }
        public bool Masked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public readonly int Width = 60;
        public readonly int Height = 60;

        public Hero(int x, int y, bool masked)
        {
            X = x;
            Y = y;
            Masked = masked;
            if (masked)
            {
                Image = Resources.masked_hero;
            }
            else
            {
                Image = Resources.hero;
            }
        }

        public void Draw(Graphics g)
        {
            if (X + Width > 0)
            {
                g.DrawImage(Image, X, Y, Width, Height);
            }
        }
    }
}
