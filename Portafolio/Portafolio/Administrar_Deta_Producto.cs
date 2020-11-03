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
    public partial class Administrar_Deta_Producto : MetroFramework.Forms.MetroForm
    {
        DAOAdmin admin = new DAOAdmin();

        public Administrar_Deta_Producto()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            admin.Actualizar_Deta_producto(Convert.ToInt32(txtId_Detalle.Text),Convert.ToInt32(txtCantidad.Text),Convert.ToInt32(txtId_Ingrediente.Text),Convert.ToInt32(txtId_Producto.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            admin.Agregar_Deta_producto(Convert.ToInt32(txtCantidad.Text),Convert.ToInt32(txtId_Ingrediente.Text),Convert.ToInt32(txtId_Producto.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            admin.Eliminar_Deta_producto(Convert.ToInt32(txtId_Detalle.Text));
        }
    }
}
