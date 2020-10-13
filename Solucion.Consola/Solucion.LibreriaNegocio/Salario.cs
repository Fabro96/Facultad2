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
        public Salario(DateTime fecha, string codigoTransferencia, double bruto)
        {
            this._fecha = fecha;
            this._codigoTransferencia = codigoTransferencia;
            this._bruto = bruto;
            this._descuento = bruto * 0.17;
            this.GetSalarioNeto();
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
            return _bruto - _descuento;
        }


    }
}
