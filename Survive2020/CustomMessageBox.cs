using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survive2020
{
    public partial class CustomMessageBox : Form
    {
        public bool HasNextLevel { get; set; }
        public CustomMessageBox(bool hasNextLevel)
        {
            InitializeComponent();
            HasNextLevel = hasNextLevel;
            SetButtonText();
        }

        public void SetMessage(string message)
        {
            lbMessage.Text = message;
        }

        public void SetButtonText()
        {
            if (HasNextLevel)
            {
                btnLeft.Text = "Next level";
            }
            else
            {
                btnLeft.Text = "Retry";
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Close();
            ActiveForm.Close();
            if (HasNextLevel)
            {
                Game nextLevel = new Game(++Game.CurrentLevel);
                nextLevel.Show();
            }
            else
            {
                Game replay = new Game(Game.CurrentLevel);
                replay.Show();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Close();
            ActiveForm.Close();
        }

        private void CustomMessageBox_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
