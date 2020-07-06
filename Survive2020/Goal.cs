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
        public static readonly int Width = 80;
        public static readonly int Height = 70;

        private int X { get; set; }
        private int Y { get; set; }
        private Image Image { get; set; }
        public Point Center { get; set; }
        public bool IsEnabled { get; set; }

        public Goal(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.goal_disabled;
            Center = new Point(X + Width / 2, Y + Height / 2);
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
