using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = new string[] {"enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "setiembre", "octubre", 
                "noviembre", "diciembre"};
            string mes;
            bool aux = false;
            Console.Write("Ingrese nombre del mes: ");
            mes= Console.ReadLine().ToLower();
            for (int i = 1; i <= meses.Length; i++)
            {
                if (mes == meses[i-1])
                {
                    Console.WriteLine("\nEl nro de mes es: " + i);
                    aux = true;
                }
            }
            if (aux == false)
            {
                Console.WriteLine("\nEl nombre ingresado no corresponde a ningun mes valido.");
            }
            Console.WriteLine();
        }
    }
}
