using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Alumno : Persona
    {
        //ATRIBUTOS
        private int _codigo;

        //CONSTRUCTORES
        public Alumno()
        {

        }
        public Alumno(int codigo, string nombre, string apellido, DateTime nacimiento) : base(nombre, apellido, nacimiento)
        {
            this._codigo = codigo;
        }
        public Alumno(int codigo)
        {
            this._codigo = codigo;
        }

        //PROPIEDADES
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public string Credencial
        {
            get { return GetCredencial(); }
        }

        //MÉTODOS
        public override string GetCredencial()
        {
            return string.Format("Código {0} - {1}, {2}", this._codigo, this._apellido.ToUpper(), this._nombre.ToUpper()); ;
        }
        public override string ToString()
        {
            return GetCredencial();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Alumno))
                return false;

            Alumno alumno1 = (Alumno)obj;

            return (this._codigo == alumno1.Codigo);
        }



    }
}
