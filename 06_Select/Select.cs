using LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Select
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe", Edad = 99, Salario = 5},
                new Persona() { Nombre = "Claudia", Edad = 35, Salario = 7},
                new Persona() { Nombre = "Mateo", Edad = 17, Salario = 10},
                new Persona() { Nombre = "Patricia", Edad = 12, Salario = 1},
                new Persona() { Nombre = "Ana", Edad = 22, Salario = 5}
            };

            var nombre = personas.Where(x => x.Edad < 18).Select(x => 
            // Si usamos un tipo anonimo nos pasara los datos que se seleccionemos
            new
            {
                Edad = x.Edad,
                Nombre = x.Nombre
            }
            // Si usamos un tipo Persona nos para Edad y Nombre, pero tambien Salario aunque este tendra un valor por defecto ya que no se le esta asignando uno
            //new Persona()
            //{
            //    Edad = x.Edad,
            //    Nombre = x.Nombre
            //}
            ).FirstOrDefault();

            Console.Read();
        }
        
    }
}
