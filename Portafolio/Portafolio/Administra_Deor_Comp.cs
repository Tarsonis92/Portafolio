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
    public partial class Administra_Deor_Comp : MetroFramework.Forms.MetroForm
    {
        DAOBodega bodega = new DAOBodega();

        public Administra_Deor_Comp()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bodega.Actualizar_DeorComp(Convert.ToInt32(txtId_Detalle.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtTotal_Compra.Text), Convert.ToInt32(txtId_Ingrediente.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bodega.Agregar_DeorComp( Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtTotal_Compra.Text), Convert.ToInt32(txtId_Ingrediente.Text) );
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bodega.Eliminar_DeorComp(Convert.ToInt32(txtId_Detalle.Text));
        }
    }
}
