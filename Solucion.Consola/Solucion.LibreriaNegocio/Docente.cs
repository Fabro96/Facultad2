﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Docente : Persona
    {
        //ATRIBUTOS
        //CONSTRUCTORES
        public Docente() { }

        //PROPIEDADES
        //MÉTODOS
        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }
        public override string GetCredencial()
        {
            throw new NotImplementedException();
        }


    }
}
