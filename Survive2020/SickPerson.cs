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
    public class SickPerson
    {
        public static readonly int Width = 40;
        public static readonly int Height = 44;

        private int X { get; set; }
        private int Y { get; set; }
        private Image Image { get; set; }
        public Point Center { get; set; }

        public SickPerson(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.sick_emoji;
            Center = new Point(X + Width / 2, Y + Height / 2);
        }

        public void Draw(Graphics g)
        {
            if (X + Width > 0)
            {
                g.DrawImage(Image, X, Y, Width, Height);
            }
        }

        public void Move(int distance)
        {
            X -= distance;
            Center = new Point(Center.X - distance, Center.Y);
        }
    }
}
