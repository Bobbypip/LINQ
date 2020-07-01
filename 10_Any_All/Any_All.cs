using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Any_All
    {
        static void Main(string[] args)
        {
            // Separados por ser impar o par
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            List<int> numeros2 = new List<int>()
            {
                2, 4, 8, 16, 32, 64
            };

            var sonParesTodos1 = numeros.All(x => x % 2 == 0);
            var sonParesTodos2 = numeros2.All(x => x % 2 == 0);

            var existeAlgunPar = numeros.Any(x => x % 2 == 0);
            var existeAlgunNumeroMayorQue10000 = numeros.Any(x => x > 1000);
        }
    }
}
