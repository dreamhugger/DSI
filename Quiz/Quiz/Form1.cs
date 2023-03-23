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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Quando o botão for clicado esse código rodará
        {
            if (radioButton2.Checked) // Condição verifica se radiobutton está marcado
            {
                Dados.Acertou(); // Método para incrementar a contagem de acertos, importado da classe Dados
            }
            else
            {
                Dados.Errou(); // Método para incrementar a contagem de erros, importado da classe Dados
            }

            Form2 p2 = new Form2(); // Variavel do form2
            p2.Show(); // Mostrar form2
            this.Hide(); // Esconder form atual
        }
    }
}
