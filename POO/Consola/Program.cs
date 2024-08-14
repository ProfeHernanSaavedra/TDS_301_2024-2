using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Monica";
            persona.Apellido = "Caballero";
            persona.FechaNacimiento = new DateTime(1980, 8, 14);

            Console.WriteLine("Hola " + persona); //aca llamamos al toString
            Console.WriteLine("Tienes {0} años",persona.Edad());


            Persona persona2 = new Persona("Andres","Troncoso");
            persona2.FechaNacimiento = new DateTime(1992, 11, 4);
            Console.WriteLine("Hola " + persona2.Nombre);
            Console.WriteLine("Tienes {0} años", persona2.Edad());
            Console.ReadLine();
        }
    }
}
