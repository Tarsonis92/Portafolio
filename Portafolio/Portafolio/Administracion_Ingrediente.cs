using BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Administracion_Ingrediente : MetroFramework.Forms.MetroForm
    {
        DAOBodega bodega = new DAOBodega();
        public Administracion_Ingrediente()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bodega.Actualizar_Ingrediente(Convert.ToInt32(txtId_Ingrediente.Text),txtNombre.Text,dtpIngreso.Value,dtpVencimiento.Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bodega.Agregar_Ingrediente(txtNombre.Text,dtpIngreso.Value,dtpVencimiento.Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bodega.Eliminar_Ingrediente(Convert.ToInt32(txtId_Ingrediente.Text));
        }
    }
}
