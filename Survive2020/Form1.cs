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
        public int CurrentLevel { get; set; }
        public Timer MaskTimer { get; set; }
        public Timer DisinfectantTimer { get; set; }
        public Form1(int currentLevel)
        {
            InitializeComponent();
            this.CurrentLevel = currentLevel;
            Level = new Level(CurrentLevel);
            MaskTimer = new Timer();
            MaskTimer.Tick += new EventHandler(MaskTimer_Tick); 
            DisinfectantTimer = new Timer();
            DisinfectantTimer.Tick += new EventHandler(DisinfectantTimer_Tick);
            switch(CurrentLevel)
            {
                case 1:
                    MaskTimer.Interval = 10000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    break;
                case 2:
                    MaskTimer.Interval = 15000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    break;
                case 3:
                    MaskTimer.Interval = 20000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    break;
                case 4:
                    MaskTimer.Interval = 25000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    break;
                case 5:
                    MaskTimer.Interval = 30000;
                    MaskTimer.Start();
                    DisinfectantTimer.Interval = 5000;
                    DisinfectantTimer.Start();
                    break;
            }
        }

        private void DisinfectantTimer_Tick(object sender, EventArgs e)
        {
            Level.AddDisinfectant();
            Invalidate();
        }

        private void MaskTimer_Tick(object sender, EventArgs e)
        {
            Level.AddMask();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Level.Draw(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Level.KeyDown(e);
            Level.CheckCollisions();
            Invalidate();
        }
    }
}
