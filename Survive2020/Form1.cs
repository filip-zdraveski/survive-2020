using Survive2020.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive2020
{
    public partial class Form1 : Form
    {
        private Level Level;
        private int labelLvlPoints = 0;
        public static int CurrentLevel = 1;
        public int DarknessIncrement { get; set; }
        public Timer MaskTimer { get; set; }
        public Timer DisinfectantTimer { get; set; }
        public Timer DarknessTimer { get; set; }
        public Timer SickPersonSpawnTimer { get; set; }
        public Timer SickPersonMoveTimer { get; set; }
        public Form1(int currentLevel)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            CurrentLevel = currentLevel;
            Level = new Level(CurrentLevel);
            MaskTimer = new Timer();
            MaskTimer.Tick += new EventHandler(MaskTimer_Tick);
            DisinfectantTimer = new Timer();
            DisinfectantTimer.Tick += new EventHandler(DisinfectantTimer_Tick);
            DarknessTimer = new Timer();
            DarknessTimer.Tick += new EventHandler(DarknessTimer_Tick);
            SickPersonSpawnTimer = new Timer();
            SickPersonSpawnTimer.Tick += new EventHandler(SickPersonSpawnTimer_Tick);
            SickPersonMoveTimer = new Timer();
            SickPersonMoveTimer.Tick += new EventHandler(SickPersonMoveTimer_Tick);

            lbPoints.Text = "Points: " + Level.Points + "/" + Level.RequiredPoints;

            switch (CurrentLevel)
            {
                case 1:
                    DarknessIncrement = 20;
                    MaskTimer.Interval = 10000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    DarknessTimer.Interval = 3000;
                    DarknessTimer.Start();
                    SickPersonSpawnTimer.Interval = 3000;
                    SickPersonSpawnTimer.Start();
                    SickPersonMoveTimer.Interval = 500;
                    SickPersonMoveTimer.Start();
                    this.BackgroundImage = Resources.park;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    DarknessIncrement = 25;
                    MaskTimer.Interval = 15000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    DarknessTimer.Interval = 2500;
                    DarknessTimer.Start();
                    SickPersonSpawnTimer.Interval = 3000;
                    SickPersonSpawnTimer.Start();
                    SickPersonMoveTimer.Interval = 500;
                    SickPersonMoveTimer.Start();
                    this.BackgroundImage = Resources.gtc;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    DarknessIncrement = 30;
                    MaskTimer.Interval = 20000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 4000;
                    DisinfectantTimer.Start();
                    DarknessTimer.Interval = 2500;
                    DarknessTimer.Start();
                    SickPersonSpawnTimer.Interval = 3000;
                    SickPersonSpawnTimer.Start();
                    SickPersonMoveTimer.Interval = 500;
                    SickPersonMoveTimer.Start();
                    this.BackgroundImage = Resources.cair;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    DarknessIncrement = 35;
                    MaskTimer.Interval = 25000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 3500;
                    DisinfectantTimer.Start();
                    DarknessTimer.Interval = 2500;
                    DarknessTimer.Start();
                    SickPersonSpawnTimer.Interval = 3000;
                    SickPersonSpawnTimer.Start();
                    SickPersonMoveTimer.Interval = 500;
                    SickPersonMoveTimer.Start();
                    this.BackgroundImage = Resources.jsp;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 5:
                    DarknessIncrement = 40;
                    MaskTimer.Interval = 30000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 3000;
                    DisinfectantTimer.Start();
                    DarknessTimer.Interval = 2000;
                    DarknessTimer.Start();
                    SickPersonSpawnTimer.Interval = 3000;
                    SickPersonSpawnTimer.Start();
                    SickPersonMoveTimer.Interval = 500;
                    SickPersonMoveTimer.Start();
                    this.BackgroundImage = Resources.avenue;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }
        }

        private void DisinfectantTimer_Tick(object sender, EventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.AddDisinfectant();
                Invalidate();
            }
            else
            {
                DisinfectantTimer.Stop();
            }
        }

        private void MaskTimer_Tick(object sender, EventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.AddMask();
                Invalidate();
            }
            else
            {
                MaskTimer.Stop();
            }
        }

        private void DarknessTimer_Tick(object sender, EventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.IncreaseDarkness(DarknessIncrement);
                Invalidate();
            }
            else
            {
                DarknessTimer.Stop();
            }
        }

        private void SickPersonSpawnTimer_Tick(object sender, EventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.AddSickPerson();
                Invalidate();
            }
            else
            {
                SickPersonSpawnTimer.Stop();
            }
        }

        private void SickPersonMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.MoveSickPerson();
                Invalidate();
            }
            else
            {
                SickPersonMoveTimer.Stop();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.Draw(e.Graphics);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Level.KeyDown(e);
            Level.CheckHeroCollisions();
            if (labelLvlPoints != Level.Points)
            {
                UpdatePoints();
                labelLvlPoints = Level.Points;
            }
            Invalidate();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblLevelNumber.Text = "Level " + CurrentLevel;
            Level.Darkness = new Darkness(0, 0, 10, ActiveForm.Height);
            Level.Goal = new Goal(ActiveForm.Width - 100, ActiveForm.Height - 110);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisinfectantTimer.Stop();
            MaskTimer.Stop();
            DarknessTimer.Stop();
            SickPersonSpawnTimer.Stop();
            SickPersonMoveTimer.Stop();
        }

        public void UpdatePoints()
        {
            lbPoints.Text = "Points: " + Level.Points + "/" + Level.RequiredPoints;
        }
    }
}
