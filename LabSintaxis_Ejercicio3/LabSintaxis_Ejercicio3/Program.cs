using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite = 20;
            int var1 = 0;
            int var2 = 1;
            int suma=0;
            Console.Write(var1);
            for (int i = 0; i < limite; i++)
            {
                Console.Write("," + var2);
                suma = var1 + var2;
                var1 = var2;
                var2 = suma;
            }
            Console.WriteLine();
        }
    }
}
