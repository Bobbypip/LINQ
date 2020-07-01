using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Aggregate
    {
        static void Main(string[] args)
        {
            // Suma de todos los elementos de la lista
            List<int> numeros = new List<int>()
            {
                2, 3, 4, 5
            };

            var producto = numeros.Aggregate((anterior, actual) => anterior * actual);

            Console.Read();
        }
    }
}
