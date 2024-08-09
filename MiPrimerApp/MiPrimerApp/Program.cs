using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            //cw+tab+tab
            int num1 = 1, num2 = 5;
            int suma,num6;
            string nombre = "Juan";
            bool esCSharp = true;
            float num3 = 3.1f;
            decimal num4 = 4.3m;
            string num5 = "14";

            Console.WriteLine("Hola " + nombre) ;
            Console.WriteLine("Lenguaje C# : " + esCSharp + "\n");

            Console.WriteLine("Ingrese un número: ");
            //num6 = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out num6);
            suma = num1 + num2 + (int)num3 + (int)num4 + int.Parse(num5) + num6;
            Console.WriteLine(suma);
            //Esto es para que no se cierre la consola
            Console.ReadLine();

            
        }
    }
}
