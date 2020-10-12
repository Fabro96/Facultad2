using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Solucion.LibreriaNegocio
{
    public class Salario
    {
        //ATRIBUTOS
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuento;
        private DateTime _fecha;

        //CONSTRUCTORES
        public Salario() { }
        public Salario(double bruto)
        {

        }

        //PROPIEDADES
        public double Bruto
        {
            set { _bruto = value; }
            get { return _bruto;  }
        }
        public string CodigoTransferencia
        {
            set { _codigoTransferencia = value; }
            get { return _codigoTransferencia;  }
        }
        public double Descuentos
        {
            set { _descuento = value; }
            get { return _descuento;  }
        }
        public DateTime Fecha
        {
            set { _fecha = value; }
            get { return _fecha;  }
        }

        //MÉTODOS
        public double GetSalarioNeto()
        {
            throw new NotImplementedException();
        }


    }
}
