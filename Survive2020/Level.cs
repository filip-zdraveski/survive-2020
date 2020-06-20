using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive2020
{
    public class Level
    {
        private int LevelNumber { get; set; }
        public Hero Hero;
        public List<Mask> Masks;
        public List<Disinfectant> Disinfectants;
        public Level(int levelNumber)
        {
            this.LevelNumber = levelNumber;
            Masks = new List<Mask>();
            Disinfectants = new List<Disinfectant>();
            Hero = new Hero(280, 150);
            switch(LevelNumber)
            {
                case 1:
                    Masks.Add(new Mask(120, 50));
                    Disinfectants.Add(new Disinfectant(400, 230));
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            
        }
        public void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Hero.MoveLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                Hero.MoveRight();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Hero.MoveUp();
            }
            else if (e.KeyCode == Keys.Down)
            {
                Hero.MoveDown();
            }
        }

        public void Draw(Graphics g)
        {
            Hero.Draw(g);
            foreach (Mask mask in Masks)
            {
                mask.Draw(g);
            }
            foreach (Disinfectant disinfectant in Disinfectants)
            {
                disinfectant.Draw(g);
            }
        }

        public void CheckCollisions()
        {
            foreach(Mask mask in Masks)
            {
                Hero.CheckMask(mask);
            }
            foreach(Disinfectant disinfectant in Disinfectants)
            {
                Hero.CheckDisinfectant(disinfectant);
            }
        }
    }
}
