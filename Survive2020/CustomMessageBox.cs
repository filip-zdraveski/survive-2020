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
        public bool BtnNextLvl { get; set; }
        public CustomMessageBox(bool btnNextLvl)
        {
            InitializeComponent();
            BtnNextLvl = btnNextLvl;
            SetButtonText();
        }

        public void SetMessage(string message)
        {
            lbMessage.Text = message;
        }

        public void SetButtonText()
        {
            if (BtnNextLvl)
            {
                btnAction.Text = "Next level";
            }
            else
            {
                btnAction.Text = "Exit game";
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.ActiveForm.Close();
            if (BtnNextLvl)
            {
                Form1 nextLevel = new Form1(++Form1.CurrentLevel);
                nextLevel.Show();
            }
        }
    }
}
