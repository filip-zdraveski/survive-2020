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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // get measurements of current form
            int formHeight = Form1.ActiveForm.Height;
            int formWidth = Form1.ActiveForm.Width;

            // hero
            Hero hero = new Hero(280, 150, false);
            //Hero heroMasked = new Hero(280, 150, true);

            // sick persons
            SickPerson sickPerson1 = new SickPerson(100, 50);
            SickPerson sickPerson2 = new SickPerson(500, 70);
            SickPerson sickPerson3 = new SickPerson(200, 160);
            SickPerson sickPerson4 = new SickPerson(280, 30);
            SickPerson sickPerson5 = new SickPerson(280, 240);

            // disinfectants
            Disinfectant disinfectant1 = new Disinfectant(100, 220);
            Disinfectant disinfectant2 = new Disinfectant(500, 150);

            // masks
            Mask mask1 = new Mask(300, 300);
            Mask mask2 = new Mask(400, 50);

            // darkness
            Darkness darkness = new Darkness(new Point(0, 0), new Point(0, formHeight), 30.0f);

            // draw objects
            hero.Draw(e.Graphics);
            //heroMasked.Draw(e.Graphics);
            sickPerson1.Draw(e.Graphics);
            sickPerson2.Draw(e.Graphics);
            sickPerson3.Draw(e.Graphics);
            sickPerson4.Draw(e.Graphics);
            sickPerson5.Draw(e.Graphics);
            disinfectant1.Draw(e.Graphics);
            disinfectant2.Draw(e.Graphics);
            mask1.Draw(e.Graphics);
            mask2.Draw(e.Graphics);
            darkness.Draw(e.Graphics);
        }
    }
}
