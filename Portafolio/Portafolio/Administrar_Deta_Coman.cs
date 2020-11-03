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
    public partial class Administrar_Deta_Coman : MetroFramework.Forms.MetroForm
    {
        DAOCocina cocina = new DAOCocina();
        public Administrar_Deta_Coman()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cocina.Actualizar_DetaComan(Convert.ToInt32(txtId_Detalle.Text), Convert.ToInt32(txtCantidad.Text) , Convert.ToInt32(txtId_Producto.Text), Convert.ToInt32(txtId_Comanda.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cocina.Agregar_DetaComan(Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtId_Producto.Text), Convert.ToInt32(txtId_Comanda.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cocina.Eliminar_DetaComan(Convert.ToInt32(txtId_Detalle.Text));
        }
    }
}
