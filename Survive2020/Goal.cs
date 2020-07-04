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
    public class Goal
    {
        public Image Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public static readonly int Width = 80;
        public static readonly int Height = 70;
        public bool IsEnabled { get; set; }

        public Goal(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.goal_disabled;
            CenterX = X + Width / 2;
            CenterY = Y + Height / 2;
            IsEnabled = false;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, Width, Height);
        }

        public void Enable()
        {
            IsEnabled = true;
            Image = Resources.goal;
        }
    }
}
