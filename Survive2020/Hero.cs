using Survive2020.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive2020
{
    public class Hero
    {
        public Image Image { get; set; }
        public bool Masked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Timer PowerUp { get; set; }
        public readonly int Width = 60;
        public readonly int Height = 60;

        public Hero(int x, int y)
        {
            X = x;
            Y = y;
            Masked = false;
            Image = Resources.hero;
            PowerUp = new Timer();
            PowerUp.Interval = 5000;
            PowerUp.Tick += PowerUp_Tick;
        }

        private void PowerUp_Tick(object sender, EventArgs e)
        {
            Masked = false;
            Image = Resources.hero;
            PowerUp.Enabled = false;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, Width, Height);
        }

        public void MoveLeft()
        {
            if (X >= 10)
            {
                X -= 10;
            }
        }

        public void MoveRight()
        {
            if (X <= Form1.ActiveForm.Width - 10 - Width)
            {
                X += 10;
            }
        }

        public void MoveUp()
        {
            if (Y >= 10)
            {
                Y -= 10;
            }
        }

        public void MoveDown()
        {
            if (Y <= Form1.ActiveForm.Height - 10 - Height)
            {
                Y += 10;
            }
        }

        public void CheckMask(Mask mask)
        {
            if ((X + Width/2 - mask.Center.X) * (X + Width/2 - mask.Center.X) + (Y + Height/2 - mask.Center.Y) * (Y + Height/2 - mask.Center.Y) <= 60*60)
            {
                Masked = true;
                mask.ChangeState();
                Image = Resources.masked_hero;
                PowerUp.Enabled = true;
                PowerUp.Start();
            }
        }

        public void CheckDisinfectant(Disinfectant disinfectant)
        {
            if ((X + Width/2 - disinfectant.Center.X) * (X + Width/2 - disinfectant.Center.X) + (Y + Height/2 - disinfectant.Center.Y) * (Y + Height/2 - disinfectant.Center.Y) <= 60*60)
            {
                disinfectant.ChangeState();
            }
        }
    }
}
