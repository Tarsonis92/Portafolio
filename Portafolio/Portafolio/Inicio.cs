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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Editar_Usuario usuario = new Editar_Usuario();
            usuario.Show();
        }
    }
}
