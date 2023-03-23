using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Dados
    {
        public static int Acerto = 0; // Variavel de contagem de acertos
        public static int Erro = 0; // Variavel de contagem de erros

        public static void Acertou() // Método para incrementar a contagem de acertos
        {
            Acerto++;
        }
        public static void Errou() // Método para incrementar a contagem de erros
        {
            Erro++;
        }
        public static int MostrarAcertos() // Método para exibir a quantidade de acertos
        {
            return Acerto;
        }
        public static int MostrarErros() // Método para exibir a quantidade de erros
        {
            return Erro;
        }
    }
}
