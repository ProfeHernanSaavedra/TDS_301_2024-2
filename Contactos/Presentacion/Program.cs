using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactoBLL cbll = new ContactoBLL();

            Persona persona1 = new Persona("Armando", "Casas", 98765544);
            Persona persona2 = new Persona("Electro", "Custico", 987224);
            Persona persona3 = new Persona("Alam", "Brito", 9899844);

            persona1.Grupo = Clasificacion.Trabajo;
            persona3.Grupo = Clasificacion.Trabajo;

            cbll.Agregar(persona1);
            cbll.Agregar(persona2);
            cbll.Agregar(persona3);

            //Console.WriteLine("Grupo Default:");
            Console.WriteLine("Todos los  contactos");
            foreach (Persona p in cbll.Listar())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nLos contactos de grupo Trabajo:");

            foreach (Persona p in cbll.Listar(Clasificacion.Trabajo))
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}
