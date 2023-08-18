using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Carro c = new Carro();  
            //Bicicleta b = new Bicicleta();

            //c.Acelerar();
            //b.Acelerar();
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();

            Console.WriteLine("Humano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("Pessoa");
            b.Olhos();
            b.Cabelos();

            Console.ReadKey();  
        }
    }
}
