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
    public partial class Administracion_Reservacion : MetroFramework.Forms.MetroForm
    {

        DAOCliente cliente = new DAOCliente();
        public Administracion_Reservacion()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cliente.Actualizar_Reservacion(Convert.ToInt32(txtId_Reserva.Text),dtpFecha.Value,Convert.ToInt32(txtCant_Personas.Text),Convert.ToInt32(txtId_Cliente.Text),Convert.ToInt32(txtId_Mesa.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliente.Agregar_Reservacion(dtpFecha.Value,Convert.ToInt32(txtCant_Personas.Text),Convert.ToInt32(txtId_Cliente.Text),Convert.ToInt32(txtId_Mesa.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.Eliminar_Reservacion(Convert.ToInt32(txtId_Reserva.Text));
        }
    }
}
