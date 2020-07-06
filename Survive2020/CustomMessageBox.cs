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
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public void SetMessage(string message)
        {
            lbMessage.Text = message;
        }

        public void SetRetryButton(bool retry)
        {
            if (Game.CurrentLevel <= 5 && !retry)
            {
                btnLeft.Text = "Next level";
            }
            else if (Game.CurrentLevel <= 5 && retry)
            {
                btnLeft.Text = "Retry";
            }
            if (Game.CurrentLevel > 5)
            {
                btnLeft.Text = "Next level";
                btnLeft.Enabled = false;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Close();
            ActiveForm.Close();
            if (Game.CurrentLevel <= 5)
            {
                Game nextLevel = new Game(Game.CurrentLevel);
                nextLevel.Show();
            }
            else
            {
                Game replay = new Game(--Game.CurrentLevel);
                replay.Show();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Close();
            ActiveForm.Close();
        }
    }
}
