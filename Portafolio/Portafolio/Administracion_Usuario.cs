using BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Administracion_Usuario : Form
    {
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

        public Administracion_Usuario()
        {
            InitializeComponent();
        }
        Metodos_Tabla metodos = new Metodos_Tabla();
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar_Usuario editar = new Editar_Usuario();
            editar.Show();
        }

       
        private void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarTabla();
        }


        public void mostrarTabla() {

            OracleCommand comando = new OracleCommand();
            OracleDataAdapter adaptador = new OracleDataAdapter();

            con.Open();
            comando = new OracleCommand("SP_SELECT_USUARIO", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;

            DataTable tabla = new DataTable();
            metodos.mostrarTabla(comando, adaptador);
            adaptador.Fill(tabla);
            dgvTabla.DataSource = tabla;
            con.Close();

        }




    }
}
