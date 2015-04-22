using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            Console.Write("Ingrese texto: ");
            inputTexto = Console.ReadLine();
            if (inputTexto.Length != 0)
            {
                Console.Write("\nMENU:\n1- Mostrar texto en MAYUSCULA.\n2- Mostrar texto en minuscula. \n3- Mostrar cantidad de caracteres.\nRespuesta: ");
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.D1 )
                {
                    Console.WriteLine("\n\n"+inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\n\n" + inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\n\nCantidad de caracteres: " + inputTexto.Length);
                }
                else
                {
                    Console.WriteLine("\nHA INGRESADO UNA OPCION NO VALIDA.");
                }
            }
            else
            {
                Console.WriteLine("\nNO HA INGRESADO NINGUN TEXTO.");
            }
            Console.WriteLine("\nFIN DE LA APLICACION");  
        }
    }
}
