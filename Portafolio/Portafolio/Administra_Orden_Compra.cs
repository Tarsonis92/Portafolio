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
    public partial class Administra_Orden_Compra : MetroFramework.Forms.MetroForm
    {
        DAOFinanzas finanzas = new DAOFinanzas();

        public Administra_Orden_Compra()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            finanzas.Actualizar_Orden_compra(Convert.ToInt32(txtId_Orden_Compra.Text), dtpFecha_Emision.Value, Convert.ToChar(cbxEstado_Pago.SelectedValue), lbxObservacion.Text , Convert.ToInt32(txtId_Proveedor.Text) ,
             Convert.ToInt32(txtId_Usuario.Text), Convert.ToInt32(cbxEstado_Pago.SelectedValue) );
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            finanzas.Agregar_Orden_compra(dtpFecha_Emision.Value, Convert.ToChar(cbxEstado_Pago.SelectedValue), lbxObservacion.Text, Convert.ToInt32(txtId_Proveedor.Text),
            Convert.ToInt32(txtId_Usuario.Text),Convert.ToInt32(cbxId_Tipo.SelectedValue));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            finanzas.Eliminar_Orden_compra(Convert.ToInt32(txtId_Orden_Compra.Text));
        }
    }
}
