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
    public partial class Administrar_Comanda : MetroFramework.Forms.MetroForm
    {
        DAOCocina cocina = new DAOCocina();
        Administrar_Deta_Coman coman = new Administrar_Deta_Coman();
        public Administrar_Comanda()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cocina.Actualizar_Comanda(Convert.ToInt32(txtId_Comanda.Text),Convert.ToInt32(txtId_Mesa.Text),dtpFecha_Orden.Value,dtpHora_Entrada.Value,dtpHora_Salida.Value);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cocina.Agregar_Comanda(Convert.ToInt32(txtId_Mesa.Text),dtpFecha_Orden.Value,dtpHora_Entrada.Value,dtpHora_Salida.Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cocina.Eliminar_Comanda(Convert.ToInt32(txtId_Comanda.Text));
        }

        private void btnDetalle_Comanda_Click(object sender, EventArgs e)
        {
            coman.Show();
        }
    }
}
