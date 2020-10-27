using BD;
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
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=porta_final;USER ID=porta_final");
        OracleCommand command = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        Metodos_Tabla metodos = new Metodos_Tabla();
        public Clientes()
        {
            InitializeComponent();
        }

        public void mostrar_Clientes()
        {
            con.Open();
            OracleCommand comando = new OracleCommand("MOSTRAR_CLIENTES", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = comando;
            metodos.mostrarTabla(comando, adapter);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvClientes.DataSource = tabla;
            con.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            mostrar_Clientes();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvClientes.CurrentRow.Selected = true;
                lbl_Id_Usuario.Text = dgvClientes.Rows[e.RowIndex].Cells["ID_USUARIO"].FormattedValue.ToString();
                lbl_Nombre.Text = dgvClientes.Rows[e.RowIndex].Cells["NOMBRE"].FormattedValue.ToString();
                lbl_Apellido.Text = dgvClientes.Rows[e.RowIndex].Cells["APELLIDO"].FormattedValue.ToString();
                lbl_Contrasena.Text = dgvClientes.Rows[e.RowIndex].Cells["CONTRASEÑA"].FormattedValue.ToString();
                lbl_Correo.Text = dgvClientes.Rows[e.RowIndex].Cells["CORREO"].FormattedValue.ToString();
                lbl_Id_Tipo.Text = dgvClientes.Rows[e.RowIndex].Cells["ID_TIPO"].FormattedValue.ToString();
            }
        }
    }
}
