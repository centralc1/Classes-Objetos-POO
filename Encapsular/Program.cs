using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            

            Console.Write("Digite seu Nome e Sobrenome: ");
            string Cliente = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Digite um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            c.Depositar(valor);

            Console.WriteLine();

            Console.Write("Digite um valor para saque: ");
            double valor2 = double.Parse(Console.ReadLine());
            c.Sacar(valor2);

            Console.WriteLine();

            Console.WriteLine("Cliente: " + Cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();  
        }
    }
}
