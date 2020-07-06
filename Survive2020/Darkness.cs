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
    [Serializable]
    public class Darkness
    {
        private int Start { get; set; }
        private int End { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Darkness(int start, int end, int width, int height)
        {
            Start = start;
            End = end;
            Width = width;
            Height = height;
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

        public bool CheckSickPerson(SickPerson sickPerson)
        {
            if (sickPerson.Center.X <= End + Width)
            {
                return true;
            }
            return false;
        }

        public void Increase(int width)
        {
            Width += width;
        }
    }
}
