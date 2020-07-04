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
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
        }

        private void Pause_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Game.FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Survive 2020 (*.covid)|*.covid";
                saveFileDialog.Title = "Save your game";
                saveFileDialog.FileName = Game.FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Game.FileName = saveFileDialog.FileName;
                }
            }
            if (Game.FileName != null)
            {
                using (FileStream fileStream = new FileStream(Game.FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, Game.Level);
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            ActiveForm.Close();
        }

        private void Pause_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
