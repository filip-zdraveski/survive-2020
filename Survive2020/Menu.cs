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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(1);
            game.Show();
            this.Hide();
        }

        private void btnHowToPlay_Click_1(object sender, EventArgs e)
        {
            HowToPlay instructions = new HowToPlay(this);
            instructions.Show();
            this.Hide();
        }
        

        private void btnLevel_Click(object sender, EventArgs e)
        {
            LevelMenu levelMenu = new LevelMenu(this);
            levelMenu.Show();
            this.Hide();

        }
    }
}
