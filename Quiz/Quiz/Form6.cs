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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if ((Dados.Acerto >= 4) && (Dados.Acerto <= 7))
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nPrecisa melhorar!";
            }

            if ((Dados.Acerto >= 0) && (Dados.Acerto <= 3))
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nVocê realmente precisa melhorar!";
            }
            if ((Dados.Acerto >= 7) && (Dados.Acerto <= 9))
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nMuito bem está em um bom nivel!";
            }
            if (Dados.Acerto == 10)
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nVOCÊ está excelente!";
            }
        }
    }
}
