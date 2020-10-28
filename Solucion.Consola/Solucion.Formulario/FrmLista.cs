using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.Formulario
{
    public partial class FrmLista : Form
    {
        private string _nombre;
        private Facultad _facultad;

        public FrmLista(string nombre, Facultad facultad)
        {
            this._nombre = nombre;
            this._facultad = facultad;

            InitializeComponent();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {

        }
    }
}
