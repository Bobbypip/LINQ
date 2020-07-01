using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Skip_Take
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // Toma los elementos segun el valor del parametro del metodo Take()
            var dosElementos = numeros.Take(2).ToList();

            // Toma los p elementos segun el valor del parametro del metodo Take(), despues de saltarse el numero de elementos del valor del parametro del metodo Skip()
            // De una lista de todos los numeros mayores de 4
            var dosElementosSaltarUno = numeros.Where(x => x > 4).Skip(1).Take(3).ToList();

            Console.Read();
        }
    }
}

