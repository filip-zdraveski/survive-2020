using Survive2020.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive2020
{
    public class SickPerson
    {
        private Image Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public readonly int Width = 40;
        public readonly int Height = 44;
        public SickPerson(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.sick_emoji;
        }

        public void Draw(Graphics g)
        {
            if(X + Width > 0)
            {
                g.DrawImage(Image, X, Y, Width, Height);
            }
        }

        public void Move (int distance)
        {
            X -= distance;
        }
    }
}
