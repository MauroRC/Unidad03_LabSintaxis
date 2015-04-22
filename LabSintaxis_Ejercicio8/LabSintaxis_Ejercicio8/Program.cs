using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis_Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximoIntentos = 3;
            string clave = "1234";
            string rta;
            for (int i = 0; i < maximoIntentos; i++)
			{
                Console.Write("Introduzca clave: ");
                rta = Console.ReadLine();
                if (rta== clave)
                {
                    Console.WriteLine("\nClave correcta !!!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nClave incorrecta\n");
                }
			}
            Console.WriteLine("\nFIN DE LA APLICACION\n");
        }
    }
}
