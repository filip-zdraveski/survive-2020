using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive2020
{
    public class Darkness
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Darkness(int s, int e, int w, int h)
        {
            Start = s;
            End = e;
            Width = w;
            Height = h;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, new Rectangle(Start, End, Width, Height));
            brush.Dispose();
        }

        public bool CheckDisinfectant(Disinfectant disinfectant)
        {
            if (disinfectant.Center.X <= End + Width)
            {
                return true;
            }
            return false;
        }

        public bool CheckMask(Mask mask)
        {
            if (mask.Center.X <= End + Width)
            {
                return true;
            }
            return false;
        }
    }
}
