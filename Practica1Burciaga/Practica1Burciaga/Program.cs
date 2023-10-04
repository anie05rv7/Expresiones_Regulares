using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practica1Burciaga
{
    internal class Program
    {
        int hola;
        static void Main(string[] args)
        {
            while (true)
            {
                int opcion;

                Console.WriteLine("Menu");
                Console.WriteLine("1. Capturar cadena de entrada");
                Console.WriteLine("2. Creditos");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Seleccione una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CapturarCadena();
                        break;
                    case 3:
                        Environment.Exit(0); 
                        break;
                    case 2:
                        MostrarCreditos();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.ReadKey();

            }
        }

        static void CapturarCadena()
        {
            Console.WriteLine("Ingrese la cadena");
            string cadena = Console.ReadLine();
            if (ValidarCadena(cadena))
            {
                Console.WriteLine("Cadena es valida");
            }
            else
            {
                Console.WriteLine("Cadena no es valida");
            }
            Console.ReadKey();
        }

        static bool ValidarCadena(string cadena)
        {
            string expresionRegular = @"^(?:@#[AEIOU]$|\$[aeiou]$|(?:@#|\$)[0-9]{3}[13579][AEIOU]$)";
            return Regex.IsMatch(cadena, expresionRegular);
        }


        static void MostrarCreditos()
        {
            Console.WriteLine("Créditos:");
            Console.WriteLine(" integrantes:");
            Console.WriteLine(" Maria de los Anegeles Rivera Villegas");
            Console.WriteLine(" Jorge luis Luna Reyna");
            Console.WriteLine(" David Gomez Herrera");
            Console.WriteLine("Materia: Estructura De Datos");
            Console.WriteLine("Grado y Sección: 4C TIDSM");
            Console.ReadKey();
        }
    }
}
