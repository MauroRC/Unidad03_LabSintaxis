using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int anio;
                Console.Write("Ingrese un año (debe tener entre 1 y 4 digitos): ");
                anio = int.Parse(Console.ReadLine());
                if (anio > 0 & anio < 10000)
                {
                    if (anio % 100 == 0)
                    {
                        if (anio % 400 == 0)
                        {
                            Console.WriteLine("\nAño bisiesto.");
                        }
                        else
                        {
                            Console.WriteLine("\nAño no bisiesto.");
                        }
                    }
                    else if (anio % 4 == 0)
                    {
                        Console.WriteLine("\nAño bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine("\nAño no bisiesto.");
                    }

                }
                else
                {
                    Console.WriteLine("\nEl año se encuentra fuera del rango establecido.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nERROR: El dato ingresado debe ser un numero");
            }
        }
    }
}
