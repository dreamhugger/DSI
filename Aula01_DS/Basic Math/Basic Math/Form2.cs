using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Math
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa mensagem é um alerta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poderia informar seus dados para futuro contato?", "Pergunta", MessageBoxButtons.YesNo);
        }

        private void Pergunta2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("É isso mesmo que pensou?", "Pergunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
