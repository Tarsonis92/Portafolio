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
    public partial class Editar_Usuario : Form
    {
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");
        Metodos_Tabla metodos = new Metodos_Tabla();
        public Editar_Usuario()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarTabla();
        }

        public void mostrarTabla()
        {

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

        public DataTable Datos()
        {

            DataTable data = new DataTable();
            string query = "SELECT ID_TIPO,NOMBRE FROM TIPO_USUARIO";
            OracleCommand command = new OracleCommand(query, con);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(data);
            return data;

        }


        private void Editar_Usuario_Load(object sender, EventArgs e)
        {
            cbxID_Tipo.DataSource = Datos();
            cbxID_Tipo.DisplayMember = "NOMBRE";
            cbxID_Tipo.ValueMember = "NOMBRE";
        }
    }
}
