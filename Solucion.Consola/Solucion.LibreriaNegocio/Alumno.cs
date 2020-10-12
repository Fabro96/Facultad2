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
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }



    }
}
