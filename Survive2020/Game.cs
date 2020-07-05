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
    public partial class Game : Form
    {
        public static Level Level { get; set; }
        public static string FileName { get; set; }
        public static int ActualFormWidth { get; set; }
        public static int ActualFormHeight { get; set; }
        public static bool IsPaused { get; set; }
        private int AutoMoveInterval { get; set; }
        private int labelLvlPoints = 0;
        public static int CurrentLevel = 1;
        private Pause PauseForm { get; set; }
        public int DarknessIncrement { get; set; }
        public Timer MaskTimer { get; set; }
        public Timer DisinfectantTimer { get; set; }
        public Timer DarknessTimer { get; set; }
        public Timer SickPersonSpawnTimer { get; set; }
        public Timer SickPersonMoveTimer { get; set; }

        public Game(int currentLevel)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            CurrentLevel = currentLevel;
            Level = new Level(CurrentLevel);
            IsPaused = false;

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

            InitializeTimers();

            UpdatePoints();

            PauseForm = new Pause();

            switch (CurrentLevel)
            {
                case 1:
                    BackgroundImage = Resources.park;
                    break;
                case 2:
                    BackgroundImage = Resources.gtc;
                    break;
                case 3:
                    BackgroundImage = Resources.cair;
                    break;
                case 4:
                    BackgroundImage = Resources.jsp;
                    break;
                case 5:
                    BackgroundImage = Resources.avenue;
                    break;
            }

            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InitializeTimers()
        {
            MaskTimer.Interval = 5000 * CurrentLevel;
            DisinfectantTimer.Interval = 5500 - 500 * CurrentLevel;
            DarknessTimer.Interval = 3100 - 100 * CurrentLevel;
            DarknessIncrement = 15 + 5 * CurrentLevel;
            SickPersonSpawnTimer.Interval = 3250 - 250 * CurrentLevel;
            SickPersonMoveTimer.Interval = 550 - 50 * CurrentLevel;

            StartTimers();
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

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            if (Level.IsEnabled)
            {
                Level.Draw(e.Graphics);
            }
        }

        private void UpdatePoints()
        {
            lbPoints.Text = "Points: " + Level.Points + "/" + Level.RequiredPoints;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsPaused)
            {
                Level.KeyDown(e);
                Level.CheckHeroCollisions();
                if (labelLvlPoints != Level.Points)
                {
                    UpdatePoints();
                    labelLvlPoints = Level.Points;
                }
                if (Level.SickPersons.Count >= 3)
                {
                    ++AutoMoveInterval;
                    if (AutoMoveInterval == 30)
                    {
                        Level.MoveSickPerson();
                        Level.IncreaseDarkness(DarknessIncrement);
                        AutoMoveInterval = 0;
                    }
                }
                Invalidate();
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopTimers();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (!IsPaused)
            {
                StopTimers();
                IsPaused = true;
                pause.Image = Resources.play_icon;
                PauseForm.Show();
            }
            else
            {
                StartTimers();
                IsPaused = false;
                pause.Image = Resources.pause_icon;
                PauseForm.Hide();
            }
        }

        private void StartTimers()
        {
            DisinfectantTimer.Start();
            MaskTimer.Start();
            DarknessTimer.Start();
            SickPersonSpawnTimer.Start();
            SickPersonMoveTimer.Start();
        }

        private void StopTimers()
        {
            DisinfectantTimer.Stop();
            MaskTimer.Stop();
            DarknessTimer.Stop();
            SickPersonSpawnTimer.Stop();
            SickPersonMoveTimer.Stop();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            lblLevelNumber.Text = "Level " + CurrentLevel;
            Level.Darkness = new Darkness(0, 0, 0, SystemInformation.VirtualScreen.Height);
        }

        private void Game_Activated(object sender, EventArgs e)
        {
            ActualFormWidth = SystemInformation.VirtualScreen.Width;
            ActualFormHeight = SystemInformation.VirtualScreen.Height;
            Level.Goal = new Goal(ActualFormWidth - 100, ActualFormHeight - 80);
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
            if (!Level.IsEnabled)
            {
                pause.Enabled = false;
            }
        }
    }
}
