using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Bedel : Empleado
    {
        //ATRIBUTOS
        private string _apodo;

        //CONSTRUCTORES
        public Bedel() { }

        //PROPIEDADES
        public string Apodo
        {
            set { _apodo = value; }
            get { return _apodo;  }
        }

        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Bedel " + this._apodo.ToUpper() ;
        }
        
    }
}
