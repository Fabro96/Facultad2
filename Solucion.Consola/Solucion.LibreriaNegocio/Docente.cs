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
        public Docente(int legajo, string apellido, string nombre)
        {
            this._legajo = legajo;
            this._apellido = apellido;
            this._nombre = nombre;
        }

        //PROPIEDADES
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return "Docente " + this._apellido.ToUpper();
        }
        
    }
}
