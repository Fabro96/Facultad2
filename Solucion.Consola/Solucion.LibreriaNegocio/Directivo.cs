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
        public Directivo(int legajo, string apellido, string nombre)
        {
            this._legajo = legajo;
            this._apellido = apellido;
            this._nombre = nombre;
        }

        //PROPIEDADES
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Directivo " + this._apellido.ToUpper() ;
        }
        
    }
}
