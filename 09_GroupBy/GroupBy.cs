using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class GroupBy
    {
        static void Main(string[] args)
        {
            // Separados por ser impar o par
            List<int> numeros = new List<int>()
            {
                3, 5, 7, 8, 2, -3, -100, 523, 6, 22
            };

            var grupo2 = numeros.GroupBy(x => Math.Abs(x % 2));

            foreach (var clase in grupo2)
            {
                Console.WriteLine("Numeros cuyo residuo es: " + clase.Key);
                foreach (var numero in clase)
                {
                    Console.WriteLine(numero);
                }
                Console.WriteLine("");
            }

            // Separados por grupo de edad
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe", Edad = 99, Salario = 5},
                new Persona() { Nombre = "Claudia", Edad = 35, Salario = 7},
                new Persona() { Nombre = "Mateo", Edad = 17, Salario = 10},
                new Persona() { Nombre = "Patricia", Edad = 12, Salario = 1},
                new Persona() { Nombre = "Ana", Edad = 22, Salario = 5}
            };

            var gruposDePersonas = personas.GroupBy(x =>
            {
                if (x.Edad <= 20)
                {
                    return "Menor que 20";
                }
                else if (x.Edad >= 21 && x.Edad <= 40)
                {
                    return "Entre 21 y 40";
                }
                else
                {
                    return "Mayores que 41";
                }
            });

            foreach (var grupoDePersonas in gruposDePersonas)
            {
                Console.WriteLine("Grupo de: " + grupoDePersonas.Key + " --- cantidad: " + grupoDePersonas.Count());
                foreach (var persona in grupoDePersonas)
                {
                    Console.WriteLine(persona.Nombre);
                }
                Console.WriteLine("");
            }

            Console.Read();
        }
    }
}
