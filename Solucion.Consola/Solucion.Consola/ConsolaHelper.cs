using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    public static class ConsolaHelper
    {
        public static int OpcionMenu(int min, int max)
        {
            int res;
            Console.WriteLine("Indique la opción a la que desea ingresar: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.\n" +
                        "Recuerde que tiene que ser un número entre " + min + " y " + max + ".");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static string PedirNombre()
        {
            string s;
            Console.WriteLine("\nIngrese el nombre del alumno: ");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo nuevamente por favor.");
                s = Console.ReadLine();
            }

            return s.ToUpper();
        }
        public static string PedirApellido()
        {
            string s;
            Console.WriteLine("\nIngrese el apellido del alumno: ");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo nuevamente por favor.");
                s = Console.ReadLine();
            }

            return s.ToUpper();
        }
        public static int PedirCodigo(int min, int max)
        {
            int res;
            Console.WriteLine("\nIngrese el código del Alumno: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIntentolo nuevamente por favor. Recuerde que debe ser un número entero.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static DateTime PedirFecha(string msg)
        {
            Console.WriteLine("\nIngrese fecha " + msg + " solo en este formato YYYY-MM-DD");

            DateTime f = Convert.ToDateTime(Console.ReadLine());

            return f;
        }
    }
}
