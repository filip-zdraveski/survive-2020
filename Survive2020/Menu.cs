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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game(Game.CurrentLevel);
            game.Show();
        }

        private void btnChooseLvl_Click(object sender, EventArgs e)
        {
            LevelMenu levelMenu = new LevelMenu();
            levelMenu.Show();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlay instructions = new HowToPlay();
            instructions.Show();
        }

        private void btnOpenSaved_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Survive 2020 (*.covid)|*.covid",
                Title = "Open saved game"
            };
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
                catch
                {
                    MessageBox.Show("Could not read file: " + Game.FileName);
                    Game.FileName = null;
                    return;
                }
            }
        }
    }
}
