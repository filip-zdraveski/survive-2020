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
        Menu menu;
        public LevelMenu(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
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
            if (Game.CurrentLevel == 5)
            {
                btnL5.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnL1_Click(object sender, EventArgs e)
        {
            Game game = new Game(1, false);
            game.Show();
        }

        private void btnL2_Click(object sender, EventArgs e)
        {
            Game game = new Game(2, false);
            game.Show();
        }

        private void btnL3_Click(object sender, EventArgs e)
        {
            Game game = new Game(3, false);
            game.Show();
        }

        private void btnL4_Click(object sender, EventArgs e)
        {
            Game game = new Game(4, false);
            game.Show();
        }

        private void btnL5_Click(object sender, EventArgs e)
        {
            Game game = new Game(5, false);
            game.Show();
        }

        private void LevelMenu_Activated(object sender, EventArgs e)
        {
            EnableButtons();
        }
    }
}
