using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estática
            //Matemática.taxa = 10;

            //int valor1 = Matemática.Adicionar(200);
            //int valor2 = Matemática.Adicionar(200);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.idade = Pessoa.CalcularIdade(1985);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);

            Console.ReadKey();  
        }
    }
}
