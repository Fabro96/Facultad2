using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public abstract class Persona
    {
        //ATRIBUTOS
        protected string _apellido;
        protected string _nombre;
        protected DateTime _fechaNac;
        
        //CONSTRUCTORES
        public Persona()
        {

        }
        public Persona(string apellido, string nombre, DateTime nacimiento)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._fechaNac = nacimiento;
        }

        //PROPIEDADES
        public string Apellido
        {
            set { _apellido = value; }
            get { return _apellido;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public int Edad
        {
            get { return ((DateTime.Now - _fechaNac).Days / 365); }
        }

        //MÉTODOS
        public abstract string GetCredencial();

        public virtual string GetNombreCompleto()
        {
            return string.Format("{0}, {1}", this._apellido.ToUpper(), this._nombre.ToUpper());
        }


    }
}
