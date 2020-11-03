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
    public partial class Administrar_Proveedor : MetroFramework.Forms.MetroForm
    {
        DAOAdmin admin = new DAOAdmin();
        Administrar_Deta_Producto deta = new Administrar_Deta_Producto();
        public Administrar_Proveedor()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            admin.Actualizar_Proveedor(Convert.ToInt32(txtId_Proveedor.Text),txtNombre.Text,txtDireccion.Text,txtRut.Text,Convert.ToInt32(txtTelefono.Text),txtCorreo.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            admin.Agregar_Proveedor(txtNombre.Text,txtDireccion.Text,txtRut.Text,Convert.ToInt32(txtTelefono.Text),txtCorreo.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            admin.Eliminar_Proveedor(Convert.ToInt32(txtId_Proveedor.Text));
        }

        private void btnDetalle_Producto_Click(object sender, EventArgs e)
        {
            deta.Show();
        }
    }
}
