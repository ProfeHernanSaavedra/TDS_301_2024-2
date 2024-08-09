using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] dias = new string[7];
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            Console.WriteLine(dias[0]+"\n");

            //for+tab+tab
            Console.WriteLine("Usando For");
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }

            Console.WriteLine("\nUsando For each");
            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }

            int[,] sala = new int[8, 10];
            Random rand = new Random(); //instanciar la clase Random!
            Console.WriteLine("\n\nMatriz de {0} x {1}",sala.GetLength(0),sala.GetLength(1));
            Console.WriteLine("Contenido posición 0,0: "+ sala[0,0]);

            Console.WriteLine("\nRecorrer con for");
            for (int f = 0; f < sala.GetLength(0); f++)
            {
                for (int c = 0; c < sala.GetLength(1); c++)
                {
                    sala[f, c] = rand.Next(0, 2);
                    Console.Write(sala[f,c] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\nListas");
            List<string> colores = new List<string>();
            colores.Add("rojo");
            colores.Add("azul");
            colores.Add("verde");

            Console.WriteLine("Primer elemento: " + colores[0]);

            Console.WriteLine("\nRecorrido con foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Add("amarillo");
            Console.WriteLine("\nRecorrido con foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Insert(0, "blanco");

            Console.WriteLine("\nRecorrido con foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Total de elementos de la lista: " + colores.Count);
            Console.ReadLine();

        }
    }
}
