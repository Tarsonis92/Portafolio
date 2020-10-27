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
    public partial class Inicio : MetroFramework.Forms.MetroForm
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administrar_Usuario usuario = new Administrar_Usuario();
            usuario.Show();
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            Cocina cocina = new Cocina();
            cocina.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }
    }
}
