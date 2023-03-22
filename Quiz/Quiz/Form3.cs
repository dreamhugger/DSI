using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Dados.Acertou();
            }
            else
            {
                Dados.Errou();
            }

            Form4 p4 = new Form4();
            p4.Show();
            this.Hide();

        }
    }
}
