using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class First_FirstOrDefault
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            // Si no hay datos en la lista regresa el valor por defecto del tipo de la lista, en este caso el valor por defecto de int es 0
            var primerElementoODefault = numeros.FirstOrDefault();
            // Ademas la funcion admite un delegado
            var primerElementoODefaultPar = numeros.FirstOrDefault(x => x % 2 == 0);
            // Si no hay datos en la lista devolvera una excepcion
            var primerElemento = numeros.First();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe", Edad = 99, Salario = 5},
                new Persona() { Nombre = "Claudia", Edad = 35, Salario = 7},
                new Persona() { Nombre = "Mateo", Edad = 17, Salario = 10},
                new Persona() { Nombre = "Patricia", Edad = 12, Salario = 1},
                new Persona() { Nombre = "Ana", Edad = 22, Salario = 5}
            };

            var personaMayorDeEdad = personas.FirstOrDefault(x => x.Edad < 18);

            Console.Read();
        }
    }
}
