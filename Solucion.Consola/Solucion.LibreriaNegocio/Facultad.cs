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

        //MÉTODOS
        public void AgregarAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }
        public void AgregarEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }
        public void EliminarAlumno(int i)
        {
            throw new NotImplementedException();
        }
        public void EliminarEmpleado(int i)
        {
            throw new NotImplementedException();
        }
        public void ModificarEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }
        public List<Alumno> TraerAlumnos()
        {
            throw new NotImplementedException();
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
