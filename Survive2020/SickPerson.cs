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
        private Image Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public static readonly int Width = 40;
        public static readonly int Height = 44;
        public SickPerson(int x, int y)
        {
            X = x;
            Y = y;
            CenterX = X + Width / 2;
            CenterY = Y + Height / 2;
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
            CenterX -= distance;
        }
    }
}
