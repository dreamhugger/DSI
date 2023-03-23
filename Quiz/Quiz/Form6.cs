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

        private void Form6_Load(object sender, EventArgs e) // Código rodará ao carregar o formulário
        {
            if (Dados.Acerto == 0)
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nVocê realmente precisa melhorar!";
            } 
            else if (Dados.Acerto >= 3)
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nPrecisa melhorar!";
            }
            else if (Dados.Acerto == 4)
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nMuito bem está em um bom nivel!";
            }
            else if (Dados.Acerto == 5)
            {
                richTextBox1.Text = "\n\nAcertos: " + Dados.MostrarAcertos() + "\n\nErros: " + Dados.MostrarErros() + "\n\nVOCÊ está excelente!";
            } // Verifica a quantidade de acertos e exibi uma mensagem correspondente com certo valor de acertos
        }
    }
}
