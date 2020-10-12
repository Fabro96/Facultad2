using System;
using Solucion.LibreriaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarActivo = true;
            
            Facultad FCE = new Facultad("FCE", 3);

            Console.WriteLine("BIENVENIDOS A " + FCE.Nombre);
            Console.WriteLine("\nIngrese una tecla para pasar al Menú de Usuario.");
            Console.ReadKey();
            Console.Clear();

            do
            {
                
                Console.WriteLine("MENÚ DE USUARIO\n");
                Console.WriteLine("1 - AGREGAR ALUMNO\n" +
                                  "2 - AGREGAR EMPLEADO\n" +
                                  "3 - ELIMINAR ALUMNO\n" +
                                  "4 - ELIMINAR EMPLEADO\n" +
                                  "5 - MODIFICAR EMPLEADO\n" +
                                  "6 - LISTAR ALUMNOS\n" +
                                  "7 - LISTAR EMPLEADOS\n" +
                                  "8 - EXIT\n");

                try
                {
                    int opcion = ConsolaHelper.OpcionMenu(1, 8);
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            Program.AgregarAlumno(FCE);
                            break;
                        case 2:
                            Program.AgregarEmpleado(FCE);
                            break;
                        case 3:
                            Program.EliminarAlumno(FCE);
                            break;
                        case 4:
                            Program.EliminarEmpleado(FCE);
                            break;
                        case 5:
                            Program.ModificarEmpleado(FCE);
                            break;
                        case 6:
                            Program.ListarAlumnos(FCE);
                            break;
                        case 7:
                            Program.ListarEmpleados(FCE);
                            break;
                        case 8:
                            Program.Exit();
                            continuarActivo = false;
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                

            } while (continuarActivo == true);
            
        }
        public static void AgregarAlumno(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void AgregarEmpleado(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void EliminarAlumno(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void EliminarEmpleado(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ModificarEmpleado(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        public static void ListarAlumnos(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ListarEmpleados(Facultad FCE)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void Exit()
        {
            try
            {
                Console.WriteLine("MUCHAS GRACIAS POR HABER USADO NUESTRO SISTEMA! NOS VEMOS LA PRÓXIMA!");
                Console.WriteLine("\nIngrese una tecla para salir");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + "Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
