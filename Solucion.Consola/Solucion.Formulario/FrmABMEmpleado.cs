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
    public partial class FrmABMEmpleado : Form
    {
        private Facultad _facultad;

        public FrmABMEmpleado(Facultad facultad, Form formPropietario)
        {

            this._facultad = facultad;
            this.Owner = formPropietario;
            this.Owner.Hide();
            InitializeComponent();

        }

        private void FrmABMEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
