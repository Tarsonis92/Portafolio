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
    public partial class Administrar_Cuenta : MetroFramework.Forms.MetroForm
    {
        DAOFinanzas finanzas = new DAOFinanzas();
        public Administrar_Cuenta()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            finanzas.Actualizar_Cuenta(Convert.ToInt32(txtId_Cuenta.Text),dtpFecha_Emision.Value,dtpFecha_Pago.Value,Convert.ToChar(cbxEstado.SelectedValue),Convert.ToInt32(txtVuelto.Text),Convert.ToInt32(txtTotal_Cuenta.Text),Convert.ToInt32(txtId_Comanda.Text),Convert.ToInt32(txtId_Cliente.Text),Convert.ToInt32(cbxTipo_Pago.SelectedValue));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            finanzas.Agregar_Cuenta(dtpFecha_Emision.Value, dtpFecha_Pago.Value, Convert.ToChar(cbxEstado.SelectedValue), Convert.ToInt32(txtVuelto.Text), Convert.ToInt32(txtTotal_Cuenta.Text), Convert.ToInt32(txtId_Comanda.Text), Convert.ToInt32(txtId_Cliente.Text), Convert.ToInt32(cbxTipo_Pago.SelectedValue));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            finanzas.Eliminar_Cuenta(Convert.ToInt32(txtTotal_Cuenta.Text));
        }
    }
}
