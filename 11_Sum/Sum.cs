using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Sum
    {
        static void Main(string[] args)
        {
            // Suma de todos los elementos de la lista
            List<int> numeros = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            var suma = numeros.Sum();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe", Edad = 99, Salario = 5},
                new Persona() { Nombre = "Claudia", Edad = 35, Salario = 7},
                new Persona() { Nombre = "Mateo", Edad = 17, Salario = 10},
                new Persona() { Nombre = "Patricia", Edad = 12, Salario = 1},
                new Persona() { Nombre = "Ana", Edad = 22, Salario = 5}
            };

            var totalSalario = personas.Sum(x => x.Salario);

            var miObjeto = new
            {
                TotalSalario = personas.Sum(x => x.Salario),
                Conteo = personas.Count
            };

            Console.Read();
        }
    }
}
