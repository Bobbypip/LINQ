using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Min_Max_Average
    {
        static void Main(string[] args)
        {
            // Suma de todos los elementos de la lista
            List<int> numeros = new List<int>()
            {
                10, 1, 12, 3, 4, 5
            };

            var min = numeros.Min();
            var max = numeros.Max();
            var promedio = numeros.Average();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe", Edad = 99, Salario = 5},
                new Persona() { Nombre = "Claudia", Edad = 35, Salario = 7},
                new Persona() { Nombre = "Mateo", Edad = 17, Salario = 10},
                new Persona() { Nombre = "Patricia", Edad = 12, Salario = 1},
                new Persona() { Nombre = "Ana", Edad = 22, Salario = 5}
            };

            var salarioMinimo = personas.Min(x => x.Salario);
            var salarioMaximo = personas.Max(x => x.Salario);
            var promedioEdad = personas.Average(x => x.Edad);

            Console.Read();
        }
    }
}
