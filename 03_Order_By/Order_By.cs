using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Order_By
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            var numerosEnOrdenAscendente = numeros.Where(x => x > 0).OrderBy(x => x).ToList();
            var numerosEnOrdenDescendente = numeros.Where(x => x > 0).OrderByDescending(x => x).ToList();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe", Edad = 99, Salario = 5},
                new Persona() { Nombre = "Claudia", Edad = 35, Salario = 7},
                new Persona() { Nombre = "Mateo", Edad = 17, Salario = 10},
                new Persona() { Nombre = "Patricia", Edad = 12, Salario = 1},
                new Persona() { Nombre = "Ana", Edad = 22, Salario = 5}
            };

            var listaPersonsaOrdenadaPorNombre = personas.OrderBy(x => x.Nombre).ToList();
            var listaPersonsaOrdenadaPorEdad = personas.OrderBy(x => x.Edad).ToList();
            // ThenBy sigue ordenando lo que OrderBy habia ordenado
            var listaPersonaOrdenadaPorSalario_Nombre = personas.OrderBy(x => x.Salario).ThenBy(x => x.Nombre).ToList();

            Console.Read();
        }
    }
}
