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
        public bool IsEnabled;
        public Hero Hero;
        public List<Mask> Masks;
        public List<Disinfectant> Disinfectants;
        public List<SickPerson> SickPersons;
        public Darkness Darkness;
        private Random random;

        public Level(int levelNumber)
        {
            LevelNumber = levelNumber;
            IsEnabled = true;
            Masks = new List<Mask>();
            Disinfectants = new List<Disinfectant>();
            SickPersons = new List<SickPerson>();
            Hero = new Hero(280, 150);
            random = new Random();
            switch (LevelNumber)
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

        public void AddMask()
        {
            int x = random.Next(Darkness.Width, Form1.ActiveForm.Width - Mask.Width);
            int y = random.Next(Form1.ActiveForm.Height - Mask.Height);
            Masks.Add(new Mask(x, y));
        }

        public void AddDisinfectant()
        {
            int x = random.Next(Darkness.Width, Form1.ActiveForm.Width - Disinfectant.Width);
            int y = random.Next(Form1.ActiveForm.Height - Disinfectant.Height);
            Disinfectants.Add(new Disinfectant(x, y));
        }

        public void AddSickPerson()
        {
            int y = random.Next(Form1.ActiveForm.Height);
            SickPersons.Add(new SickPerson(Form1.ActiveForm.Width - 20, y));
        }

        public void IncreaseDarkness()
        {
            Darkness.Width += 50;
            Form1.ActiveForm.Invalidate();
            if (Hero.CheckDarkness(Darkness))
            {
                IsEnabled = false;
                MessageBox.Show("The darkness caught you. Game over!");
                Form.ActiveForm.Close();
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
            foreach (SickPerson sickPerson in SickPersons)
            {
                sickPerson.Draw(g);
            }
            Darkness.Draw(g);
        }

        public void MoveSickPerson()
        {
            for (int i = 0; i < SickPersons.Count; i++)
            {
                SickPersons[i].Move(10);
                if (!Hero.Masked)
                {
                    if (Hero.CheckSickPerson(SickPersons[i]))
                    {
                        SickPersons.Remove(SickPersons[i]);
                    }
                    if (Hero.Lives == 0)
                    {
                        IsEnabled = false;
                        MessageBox.Show("You lost all your lives. Game over!");
                        Form.ActiveForm.Close();
                        break;
                    }
                }
            }
        }

        public void CheckCollisions()
        {
            foreach (Mask mask in Masks)
            {
                if (!mask.IsCollected)
                    Hero.CheckMask(mask);
            }
            foreach (Disinfectant disinfectant in Disinfectants)
            {
                if (!disinfectant.IsCollected)
                    Hero.CheckDisinfectant(disinfectant);
            }
            if (Hero.CheckDarkness(Darkness))
            {
                IsEnabled = false;
                MessageBox.Show("The darkness caught you. Game over!");
                Form.ActiveForm.Close();
            }
            if (!Hero.Masked)
            {
                for (int i = 0; i < SickPersons.Count; i++)
                {
                    if (Hero.CheckSickPerson(SickPersons[i]))
                    {
                        SickPersons.Remove(SickPersons[i]);
                    }
                    if (Hero.Lives == 0)
                    {
                        IsEnabled = false;
                        MessageBox.Show("You lost all your lives. Game over!");
                        Form.ActiveForm.Close();
                        break;
                    }
                }
            }
        }
    }
}
