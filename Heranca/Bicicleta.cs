﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Bicicleta : Veiculo
    {
        public void Pedalar()
        {
            
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a Bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a Bicicleta!");
        }
    }
}
