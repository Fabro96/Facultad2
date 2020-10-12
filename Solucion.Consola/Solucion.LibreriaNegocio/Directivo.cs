using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Directivo : Empleado
    {
        //ATRIBUTOS
        //CONSTRUCTORES
        public Directivo() { }

        //PROPIEDADES
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Directivo " + this._apellido.ToUpper() ;
        }
        
    }
}
