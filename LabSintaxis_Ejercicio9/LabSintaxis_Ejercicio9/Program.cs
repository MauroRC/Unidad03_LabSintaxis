using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis_Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;
            Console.Write("Ingrese cantidad de filas: ");
            filas = int.Parse(Console.ReadLine());
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < (filas-i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i*2 +1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
