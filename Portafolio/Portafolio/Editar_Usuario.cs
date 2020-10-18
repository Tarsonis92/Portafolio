using BD;
using Clases;
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
        DAOUsuario usuario = new DAOUsuario();
       
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
            cbxID_Tipo.ValueMember = "ID_TIPO";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario.Eliminar_Usuario(Convert.ToInt32(txtID_Usuario.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          usuario.Agregar_Usuario(txtNombre.Text, txtApellido.Text, txtContrasena.Text, txtCorreo.Text, Convert.ToInt32(cbxID_Tipo.SelectedValue));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario.Actualizar_Usuario(Convert.ToInt32(txtID_Usuario.Text), txtNombre.Text, txtApellido.Text, txtContrasena.Text, txtCorreo.Text, Convert.ToInt32(cbxID_Tipo.SelectedValue));
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTabla.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvTabla.CurrentRow.Selected = true;
                txtID_Usuario.Text = dgvTabla.Rows[e.RowIndex].Cells["ID_USUARIO"].FormattedValue.ToString();
                txtNombre.Text = dgvTabla.Rows[e.RowIndex].Cells["NOMBRE"].FormattedValue.ToString();
                txtApellido.Text = dgvTabla.Rows[e.RowIndex].Cells["APELLIDO"].FormattedValue.ToString();
                txtContrasena.Text = dgvTabla.Rows[e.RowIndex].Cells["CONTRASENA"].FormattedValue.ToString();
                txtCorreo.Text = dgvTabla.Rows[e.RowIndex].Cells["CORREO"].FormattedValue.ToString();
                cbxID_Tipo.SelectedValue = dgvTabla.Rows[e.RowIndex].Cells["ID_TIPO"].FormattedValue.ToString();
            }
        }
    }
}
