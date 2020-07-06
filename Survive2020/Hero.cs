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
    [Serializable]
    public class Hero
    {
        public readonly int Width = 60;
        public readonly int Height = 60;

        private int X { get; set; }
        private int Y { get; set; }
        private Image Image { get; set; }
        public bool IsMasked { get; set; }
        public int Lives { get; set; }

        [NonSerialized]
        private readonly Timer PowerUp;

        public Hero(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.hero;
            IsMasked = false;
            Lives = 3;

            PowerUp = new Timer
            {
                Interval = 5000
            };
            PowerUp.Tick += PowerUp_Tick;
        }

        private void PowerUp_Tick(object sender, EventArgs e)
        {
            IsMasked = false;
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
            if (X <= Game.ActualFormWidth - Width)
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
            if (Y <= Game.ActualFormHeight - Height - 10)
            {
                Y += 10;
            }
        }

        public bool CheckMask(Mask mask)
        {
            if ((X + Width / 2 - mask.Center.X) * (X + Width / 2 - mask.Center.X) + (Y + Height / 2 - mask.Center.Y) * (Y + Height / 2 - mask.Center.Y) <= Width * Height)
            {
                IsMasked = true;
                Image = Resources.masked_hero;
                PowerUp.Enabled = true;
                PowerUp.Start();
                return true;
            }
            return false;
        }

        public bool CheckDisinfectant(Disinfectant disinfectant)
        {
            if ((X + Width / 2 - disinfectant.Center.X) * (X + Width / 2 - disinfectant.Center.X) + (Y + Height / 2 - disinfectant.Center.Y) * (Y + Height / 2 - disinfectant.Center.Y) <= Width * Height)
            {
                return true;
            }
            return false;
        }

        public bool CheckDarkness(Darkness darkness)
        {
            if (darkness.Width >= X)
            {
                return true;
            }
            return false;
        }

        public bool CheckSickPerson(SickPerson sickPerson)
        {
            if ((X + Width / 2 - sickPerson.Center.X) * (X + Width / 2 - sickPerson.Center.X) + (Y + Height / 2 - sickPerson.Center.Y) * (Y + Height / 2 - sickPerson.Center.Y) <= Width * Height)
            {
                Lives--;
                return true;
            }
            return false;
        }

        public bool CheckGoal(Goal goal)
        {
            if ((X + Width / 2 - goal.Center.X) * (X + Width / 2 - goal.Center.X) + (Y + Height / 2 - goal.Center.Y) * (Y + Height / 2 - goal.Center.Y) <= Width * Height)
            {
                return true;
            }
            return false;
        }
    }
}
