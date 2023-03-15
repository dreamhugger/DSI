using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(trackBarRed.Value,trackBarGreen.Value,trackBarBlue.Value);
            labelRed.Text = trackBarRed.Value.ToString();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            labelGreen.Text = trackBarGreen.Value.ToString();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            panel.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            labelBlue.Text = trackBarBlue.Value.ToString();
        }
    }
}
