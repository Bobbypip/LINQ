using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class SkipWhile_TakeWhile
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // Toma los elementos que cumplan la condicion del parametro del metodo Take(), tomara elementos de las lista y se detendra en el elemento que no cumpla la condicion
            var tomaMientras = numeros.TakeWhile(x => x < 6).ToList();
            // Se salta los primeros elementos que no cumplan con la condicion del metodo SkipWhile, despues los toma todos
            var saltaMientras = numeros.SkipWhile(x => x < 6).ToList();

            Console.Read();
        }
    }
}
