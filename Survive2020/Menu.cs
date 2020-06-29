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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game(Game.CurrentLevel);
            game.Show();
        }

        private void btnHowToPlay_Click_1(object sender, EventArgs e)
        {
            HowToPlay instructions = new HowToPlay(this);
            instructions.Show();
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            LevelMenu levelMenu = new LevelMenu(this);
            levelMenu.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
