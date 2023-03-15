using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBoxVisivel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisivel.Checked)
            {
                pictureBox.Visible = true;
            }
            else
            {
                pictureBox.Visible = false;
            }
        }

        private void radioButtonSNES_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.snes;
        }

        private void radioButtonGenesis_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.genesis;
        }

        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void radioButtonNoB_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.BorderStyle = BorderStyle.None;
        }

        private void radioButton2DB_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void radioButton3DB_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
