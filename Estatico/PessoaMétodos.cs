using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    partial class PessoaMétodos
    {
        private string nome;

        public void Apresentar()
        {
            Console.WriteLine("Ola eu sou " + nome);
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
