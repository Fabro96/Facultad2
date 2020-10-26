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
    public partial class FmrFacultad : Form
    {
        //ATRIBUTOS
        private Facultad _facultad;

        //PROPIEDADES
        public Facultad Facultad
        {
            get { return _facultad; }
        }

        //CONSTRUCTOR
        public FmrFacultad(Facultad facultad)
        {
            _facultad = facultad;

            InitializeComponent();
        }

        private void FmrFacultad_Load(object sender, EventArgs e)
        {
            this.Text = _facultad.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLista lista = new FrmLista();
            lista.Show();
        }
    }
}
