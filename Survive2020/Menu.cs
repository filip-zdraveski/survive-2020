using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Survive 2020 (*.covid)|*.covid";
            openFileDialog.Title = "Open saved game";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game.FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(Game.FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        Game.Level = (Level)formater.Deserialize(fileStream);
                        Game game = new Game(Game.Level.LevelNumber);
                        game.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + Game.FileName);
                    Game.FileName = null;
                    return;
                }
                
            }
        }
    }
}
