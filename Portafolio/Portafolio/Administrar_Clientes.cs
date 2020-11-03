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
    public partial class Administrar_Clientes : MetroFramework.Forms.MetroForm
    {
        DAOCliente cliente = new DAOCliente();
        public Administrar_Clientes()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cliente.Actualizar_Cliente(Convert.ToInt32(txtId_Cliente.Text),txtRut.Text,txtNombre.Text,txtApellido.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliente.Agregar_Cliente(txtRut.Text,txtNombre.Text,txtApellido.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cliente.Eliminar_Cliente(Convert.ToInt32(txtId_Cliente.Text));
        }
    }
}
