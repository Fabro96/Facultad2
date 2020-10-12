using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Docente : Empleado
    {
        //ATRIBUTOS
        //CONSTRUCTORES
        public Docente() { }

        //PROPIEDADES
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Docente " + this._apellido.ToUpper();
        }
        
    }
}
