using System;
using Solucion.LibreriaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

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
                Console.Clear();
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
                Console.WriteLine("AGREGAR ALUMNO\n");
                string nombre = ConsolaHelper.PedirNombre();
                string apellido = ConsolaHelper.PedirApellido();
                int codigo = ConsolaHelper.PedirCodigo(0, 999999);
                DateTime nacimiento = ConsolaHelper.PedirFecha("nacimiento");

                FCE.AgregarAlumno(codigo, nombre, apellido, nacimiento);

                Console.WriteLine("\nAlumno agregado existosamente.");
            }
            catch (AlumnoExistenteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos hubo un error en el sistema. " + ex.Message + " Intentelo nuevamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
        }
        public static void AgregarEmpleado(Facultad FCE)
        {
            try
            {
                Console.WriteLine("\nAGREGAR EMPLEADO\n");
                int legajo = ConsolaHelper.PedirLegajo(0, 99999);
                string nombre = ConsolaHelper.PedirNombreEmpleado();
                string apellido = ConsolaHelper.PedirApellidoEmpleado();
                int tipoEmpleado = ConsolaHelper.TipoEmpleado(1, 3);

                string apodo = string.Empty;

                if(tipoEmpleado == 1)
                {
                    apodo = ConsolaHelper.PedirApodo();
                }


                FCE.AgregarEmpleado(legajo, apellido, nombre, tipoEmpleado, apodo);
                Console.WriteLine("\nEl empleado a sido agregado correctamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
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
        public static void EliminarAlumno(Facultad FCE)
        {
            try
            {
                if(FCE.TieneAlumnos is true)
                {
                    Console.WriteLine("ELIMINAR ALUMNO\n");
                    Program.ListarAlumnos(FCE);                   
                    int codigo = ConsolaHelper.PedirCodigo(0, 999999);
                    FCE.EliminarAlumno(codigo);
                    Console.WriteLine("\nAlumno eliminado correctamente.");
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No hay alumnos cargados en el sistema.");
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
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
                if(FCE.TieneEmpleados is true)
                {
                    Console.WriteLine("ELIMNAR EMPLEADO\n");
                    ListarEmpleados(FCE);
                    int legajo = ConsolaHelper.PedirLegajo(0, 999999);
                    FCE.EliminarEmpleado(legajo);
                    Console.WriteLine("\nEmpleado eliminado correctamente.");
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
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
                Console.WriteLine("MODIFICAR EMPLEADOS\n");
                ListarEmpleados(FCE);
                int legajo = ConsolaHelper.PedirLegajo(0, 999999);
                string apellido = ConsolaHelper.PedirApellidoEmpleado();
                FCE.ModificarEmpleado(legajo, apellido);
                Console.WriteLine("\nEmpleado modificado correctamente.");
                Console.WriteLine("\nIngrese una tecla para continuar.");
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
        
        public static void ListarAlumnos(Facultad FCE)
        {
            try
            {
                Console.WriteLine("LISTADO ALUMNOS\n");

                if(FCE.TieneAlumnos is true)
                {
                    foreach(Alumno alumno in FCE.Alumnos)
                    {
                        Console.WriteLine(alumno.ToString());
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No hay alumnos cargados en el sistema.");
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
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
                Console.WriteLine("LISTADO EMPLEADOS\n");
                if(FCE.TieneEmpleados is true)
                {
                    foreach(Empleado empleado in FCE.Empleados)
                    {
                        Console.WriteLine(empleado.ToString());
                    }
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("No hay empleados cargados en el sistema.");
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }
                
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
