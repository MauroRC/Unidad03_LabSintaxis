using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones =5;
            string [] arrayDeString = new string [cantIteraciones];

            Console.WriteLine("Ingrese " + cantIteraciones + " strings");
            for (int i = 1; i < arrayDeString.Length + 1; i++)
            {
                Console.Write("\nIngrese el " + i + "º string: ");
                arrayDeString[i - 1] = Console.ReadLine();
            }
            Console.WriteLine("\nStrings ingresados ordenados del ultimo al primero ingresados:");
            for (int i = arrayDeString.Length - 1; i >=0; i--)
            {
                Console.WriteLine(arrayDeString[i]);
            }
        }
    }
}
