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
    public partial class HowToPlay : Form
    {
        Menu menu;
        public HowToPlay(Menu menu)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.menu = menu;
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }
    }
}
