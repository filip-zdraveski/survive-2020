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
    public partial class LevelMenu : Form
    {
        public LevelMenu()
        {
            InitializeComponent();
        }

        private void EnableButtons()
        {
            if (Game.CurrentLevel >= 2)
            {
                btnL2.Enabled = true;
            }
            if (Game.CurrentLevel >= 3)
            {
                btnL3.Enabled = true;
            }
            if (Game.CurrentLevel >= 4)
            {
                btnL4.Enabled = true;
            }
            if (Game.CurrentLevel >= 5)
            {
                btnL5.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnL1_Click(object sender, EventArgs e)
        {
            Game game = new Game(1);
            game.Show();
        }

        private void btnL2_Click(object sender, EventArgs e)
        {
            Game game = new Game(2);
            game.Show();
        }

        private void btnL3_Click(object sender, EventArgs e)
        {
            Game game = new Game(3);
            game.Show();
        }

        private void btnL4_Click(object sender, EventArgs e)
        {
            Game game = new Game(4);
            game.Show();
        }

        private void btnL5_Click(object sender, EventArgs e)
        {
            Game game = new Game(5);
            game.Show();
        }

        private void LevelMenu_Activated(object sender, EventArgs e)
        {
            EnableButtons();
        }
    }
}
