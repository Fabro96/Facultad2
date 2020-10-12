using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Empleado : Persona
    {
        //ATRIBUTOS
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        //CONSTRUCTORES
        public Empleado() { }
        public Empleado(int legajo, string apellido, string nombre, DateTime ingreso)
        {

        }

        //PROPIEDADES
        public int Antiguedad
        {
            get { return (DateTime.Now - _fechaIngreso).Days / 365; }
        }
        public DateTime FechaIngreso
        {
            set { _fechaIngreso = value; }
            get { return _fechaIngreso;  }
        }
        public DateTime FechaNacimiento
        {
            set { _fechaNac = value; }
            get { return _fechaNac;  }
        }
        public int Legajo
        {
            set { _legajo = value; }
            get { return _legajo;  }
        }
        public List<Salario> Salarios
        {
            get { return _salarios; }
        }
        public Salario UltimoSalario
        {
            get { return _salarios.Last(); }
        }

        //MÉTODOS
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string GetCredencial()
        {
            return string.Format("{0} - {1} Salario $ {2}", this._legajo, this.GetNombreCompleto(), this.UltimoSalario);
        }
        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public void AgregarSalario(Salario salario)
        {
            throw new NotImplementedException();
        }
    }
}
