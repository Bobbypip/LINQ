using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Reverse
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // Revertir toda la lista
            //numeros.Reverse();
            // Revertir solo una parte de la lista
            numeros.Reverse(1, 8);

            Console.Read();
        }
    }
}
