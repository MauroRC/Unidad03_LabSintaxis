using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nro1, nro2, rta;
                Console.Write("\nIngrese 1er nro: ");
                nro1 = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese 2er nro: ");
                nro2 = int.Parse(Console.ReadLine());
                rta= nro1 + nro2;
                Console.WriteLine("\nEl resultado de la suma de " + nro1 + " y " + nro2 + " es " + rta);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nERROR: Debe ingresar un numero!!!");
            }
        }
    }
}
