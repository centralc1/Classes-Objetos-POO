using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Acessar a = new Acessar();

            if (a.Login("abc123")) 
            {
                Console.WriteLine("Seja Bem Vindo !");
            }
            else 
            {
                Console.WriteLine("Acesso negado !");
            }

            Console.ReadKey();  
        }
    }
}
