using BD;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Usuario usa = new Usuario();
        Conexion ora = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            

            try {

                usa.Nombre = txtNombre.Text;
                usa.Contrasena = txtContrasena.Text;

                
                ora.Conectar();

                ora.conexion_validar(txtNombre.Text, txtContrasena.Text);
                vacio();
                limpiarTextos();

            }
            catch (Exception) {

                throw;
            
            }

        }

        public void limpiarTextos() {
            txtNombre.Text = null;
            txtContrasena.Text = null;
        }

        public void vacio() {

            if (txtNombre.Text == "" && txtContrasena.Text == "")
            {
                
            }
            else 
            {
                Inicio cliente = new Inicio();
                cliente.Show();

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        

    }
}
