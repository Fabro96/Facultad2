using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Facultad
    {
        //ATRIBUTOS
        private string _nombre;
        private int _cantidadadSedes;
        private List<Empleado> _empleados;
        private List<Alumno> _alumnos;

        //CONSTRUCTORES
        public Facultad() { }
        public Facultad(string nombre, int cantidadeSedes)
        {
            this._nombre = nombre;
            this._cantidadadSedes = cantidadeSedes;
            this._empleados = new List<Empleado>();
            this._alumnos = new List<Alumno>();
        }

        //PROPIEDADES
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public int Sedes
        {
            set { _cantidadadSedes = value; }
            get { return _cantidadadSedes;  }
        }
        public List<Empleado> Empleados
        {
            get { return _empleados; }
        }
        public List<Alumno> Alumnos
        {
            get { return _alumnos; }
        }
        public bool TieneAlumnos
        {
            get { return _alumnos.Count > 0; }
        }
        public bool TieneEmpleados
        {
            get { return _empleados.Count > 0; }
        }

        //MÉTODOS
        public void AgregarAlumno(int codigo, string nombre, string apellido, DateTime nacimiento)
        {
            Alumno alumno = new Alumno(codigo, nombre, apellido, nacimiento);

            foreach(Alumno alumno1 in this._alumnos)
            {
                if (alumno1.Equals(alumno))
                    throw new AlumnoExistenteException("\nYa existe el alumno que desea ingresar.");
            }

            this._alumnos.Add(alumno);
        }
        public void AgregarEmpleado(int legajo, string apellido, string nombre, int TipoEmpleado, string apodo)
        {
            Empleado empleado;

            switch (TipoEmpleado)
            {
                case 1:
                    empleado = new Bedel(legajo, apellido, nombre, apodo);
                    break;
                case 2:
                    empleado = new Docente(legajo, apellido, nombre);
                    break;
                case 3:
                    empleado = new Directivo(legajo, apellido, nombre);
                    break;
                default:
                    throw new Exception("\nTipo de Empleado inválido");
            }
            this._empleados.Add(empleado);
        }
        public void EliminarAlumno(int codigo)
        {
            Alumno alumno = this._alumnos.SingleOrDefault(x => x.Codigo == codigo);

            if(alumno != null)
            {
                this._alumnos.Remove(alumno);
            }
            else
            {
                Console.WriteLine("No se ha encontrado el alumno que desea eliminar.");
            }
        }
        public void EliminarEmpleado(int i)
        {
            throw new NotImplementedException();
        }
        public void ModificarEmpleado(int legajo, string apellido)
        {
            Empleado empleado = this._empleados.SingleOrDefault(x => x.Legajo == legajo);

            foreach(Empleado empleado1 in this._empleados)
            {
                if(empleado1 != null)
                {
                    empleado1.Apellido = apellido;
                }
                else
                {
                    throw new Exception("No existe el empleado que está buscando.");
                }
                
            }
        }
        public List<Alumno> TraerAlumnos()
        {

            return _alumnos;

        }
        public Empleado TraerEmpleadoPorLegajo(int i)
        {
            throw new NotImplementedException();
        }
        public List<Empleado> TraerEmpleados()
        {
            throw new NotImplementedException();
        }
        public List<Empleado> TraerEmpleadoPorNombre(int i)
        {
            throw new NotImplementedException();
        }


    }
}
