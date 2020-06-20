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

        private void LevelMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void btnL1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(1);
            game.Show();
            this.Hide();
        }

        private void btnL2_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(2);
            game.Show();
            this.Hide();
        }

        private void btnL3_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(3);
            game.Show();
            this.Hide();
        }

        private void btnL4_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(4);
            game.Show();
            this.Hide();
        }

        private void btnL5_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1(5);
            game.Show();
            this.Hide();
        }
    }
}
