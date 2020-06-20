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
        public Form1(int currentLevel)
        {
            InitializeComponent();
            this.CurrentLevel = currentLevel;
            Level = new Level(CurrentLevel);
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
