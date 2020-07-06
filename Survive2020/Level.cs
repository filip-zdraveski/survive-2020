using Survive2020.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive2020
{
    [Serializable]
    public class Level
    {
        public readonly int HeartWidth = 50;
        public readonly int HeartHeight = 50;

        private Hero Hero { get; set; }
        private Image Heart1 { get; set; }
        private Image Heart2 { get; set; }
        private Image Heart3 { get; set; }
        private Random Random { get; set; }
        private List<Mask> Masks { get; set; }
        private List<Disinfectant> Disinfectants { get; set; }
        public List<SickPerson> SickPersons { get; set; }
        public int LevelNumber { get; set; }
        public bool IsEnabled { get; set; }
        public Darkness Darkness { get; set; }
        public Goal Goal { get; set; }
        public int Points { get; set; }
        public int RequiredPoints { get; set; }

        public Level(int levelNumber)
        {
            Hero = new Hero(280, 150);
            Heart1 = Resources.heart;
            Heart2 = Resources.heart;
            Heart3 = Resources.heart;
            Random = new Random();
            Masks = new List<Mask>();
            Disinfectants = new List<Disinfectant>();
            SickPersons = new List<SickPerson>();
            LevelNumber = levelNumber;
            IsEnabled = true;
            Points = 0;
            RequiredPoints = 4 + 2 * LevelNumber;

            switch (LevelNumber)
            {
                case 1:
                    Masks.Add(new Mask(120, 50));
                    Disinfectants.Add(new Disinfectant(400, 230));
                    break;
                case 2:
                    Disinfectants.Add(new Disinfectant(800, 450));
                    break;
                case 3:
                    Disinfectants.Add(new Disinfectant(350, 630));
                    break;
                case 4:
                    Disinfectants.Add(new Disinfectant(520, 380));
                    Disinfectants.Add(new Disinfectant(120, 570));
                    break;
                case 5:
                    Disinfectants.Add(new Disinfectant(150, 620));
                    Disinfectants.Add(new Disinfectant(1000, 350));
                    break;
            }
        }

        private void ChangeHearts()
        {
            if (Hero.Lives == 2)
            {
                Heart3 = Resources.empty_heart;
            }
            else if (Hero.Lives == 1)
            {
                Heart2 = Resources.empty_heart;
            }
            else if (Hero.Lives == 0)
            {
                Heart1 = Resources.empty_heart;
            }
        }

        public void Draw(Graphics g)
        {
            Hero.Draw(g);
            g.DrawImage(Heart1, Game.ActualFormWidth - 210, 10, HeartWidth, HeartHeight);
            g.DrawImage(Heart2, Game.ActualFormWidth - 150, 10, HeartWidth, HeartHeight);
            g.DrawImage(Heart3, Game.ActualFormWidth - 90, 10, HeartWidth, HeartHeight);
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
            Goal.Draw(g);
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
            int x = Random.Next(Darkness.Width, Game.ActualFormWidth - Mask.Width - Goal.Width);
            int y = Random.Next(70, Game.ActualFormHeight - Mask.Height);
            Masks.Add(new Mask(x, y));
        }

        public void AddDisinfectant()
        {
            int x = Random.Next(Darkness.Width, Game.ActualFormWidth - Disinfectant.Width - Goal.Width);
            int y = Random.Next(70, Game.ActualFormHeight - Disinfectant.Height);
            Disinfectants.Add(new Disinfectant(x, y));
        }

        public void AddSickPerson()
        {
            int y = Random.Next(70, Game.ActualFormHeight - SickPerson.Height);
            SickPersons.Add(new SickPerson(Game.ActualFormWidth - 20, y));
        }

        public void IncreaseDarkness(int width)
        {
            Darkness.Increase(width);
            CheckDarknessCollisions();
        }

        public void MoveSickPerson()
        {
            for (int i = 0; i < SickPersons.Count; i++)
            {
                SickPersons[i].Move(10);
                if (!Hero.IsMasked)
                {
                    if (Hero.CheckSickPerson(SickPersons[i]))
                    {
                        SickPersons.Remove(SickPersons[i]);
                        ChangeHearts();
                    }
                    if (Hero.Lives == 0)
                    {
                        IsEnabled = false;
                        CustomMessageBox cmb = new CustomMessageBox();
                        cmb.SetMessage("You lost all your lives. Game over!");
                        cmb.Show();
                        break;
                    }
                }
            }
        }

        public void CheckHeroCollisions()
        {
            for (int i = 0; i < Masks.Count; i++)
            {
                if (Hero.CheckMask(Masks[i]))
                {
                    Masks.Remove(Masks[i]);
                }
            }
            for (int i = 0; i < Disinfectants.Count; i++)
            {
                if (Hero.CheckDisinfectant(Disinfectants[i]))
                {
                    Disinfectants.Remove(Disinfectants[i]);
                    ++Points;
                }
            }
            if (Hero.CheckDarkness(Darkness))
            {
                IsEnabled = false;
                CustomMessageBox cmb = new CustomMessageBox();
                cmb.SetMessage("The darkness caught you. Game over!");
                cmb.Show();
            }
            if (!Hero.IsMasked)
            {
                for (int i = 0; i < SickPersons.Count; i++)
                {
                    if (Hero.CheckSickPerson(SickPersons[i]))
                    {
                        SickPersons.Remove(SickPersons[i]);
                        ChangeHearts();
                    }
                    if (Hero.Lives == 0)
                    {
                        IsEnabled = false;
                        CustomMessageBox cmb = new CustomMessageBox();
                        cmb.SetMessage("You lost all your lives. Game over!");
                        cmb.Show();
                        break;
                    }
                }
            }
            if (Goal.IsEnabled && Hero.CheckGoal(Goal))
            {
                IsEnabled = false;
                if (LevelNumber < 5)
                {
                    ++Game.CurrentLevel;
                    CustomMessageBox cmb = new CustomMessageBox();
                    cmb.SetMessage(string.Format("Level {0} finished. Good job!", LevelNumber.ToString()));
                    cmb.Show();
                }
                else
                {
                    CustomMessageBox cmb = new CustomMessageBox();
                    cmb.SetMessage("Game finished. Congratulations!");
                    cmb.Show();
                }
            }
            if (!Goal.IsEnabled && Points >= RequiredPoints)
            {
                Goal.Enable();
            }
        }

        private void CheckDarknessCollisions()
        {
            for (int i = 0; i < Masks.Count; i++)
            {
                if (Darkness.CheckMask(Masks[i]))
                {
                    Masks.Remove(Masks[i]);
                }
            }
            for (int i = 0; i < Disinfectants.Count; i++)
            {
                if (Darkness.CheckDisinfectant(Disinfectants[i]))
                {
                    Disinfectants.Remove(Disinfectants[i]);
                }
            }
            for (int i = 0; i < SickPersons.Count; i++)
            {
                if (Darkness.CheckSickPerson(SickPersons[i]))
                {
                    SickPersons.Remove(SickPersons[i]);
                }
            }
            if (Hero.CheckDarkness(Darkness))
            {
                IsEnabled = false;
                CustomMessageBox cmb = new CustomMessageBox();
                cmb.SetMessage("The darkness caught you. Game over!");
                cmb.Show();
            }
        }
    }
}
