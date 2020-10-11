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
        DAOUsuario usuario1 = new DAOUsuario();
        Usuario Usuario = new Usuario();
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
            try
            {
                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_USUARIO", OracleType.Int32).Value = Convert.ToInt32(txtID_Usuario.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error algo salio mal" + ex);
            }
            con.Close();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("P_CONTRASENA", OracleType.VarChar).Value = txtContrasena.Text;
                comando.Parameters.Add("P_CORREO", OracleType.VarChar).Value = txtCorreo.Text;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = Convert.ToInt32(cbxID_Tipo.SelectedValue);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error algo salio mal" + ex);
            }

            con.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_USUARIO", OracleType.Int32).Value = Convert.ToInt32(txtID_Usuario.Text);
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = txtApellido.Text;
                comando.Parameters.Add("P_CONTRASENA", OracleType.VarChar).Value = txtContrasena.Text;
                comando.Parameters.Add("P_CORREO", OracleType.VarChar).Value = txtCorreo.Text;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = Convert.ToInt32(cbxID_Tipo.SelectedValue);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error algo salio mal" + ex);
            }

            con.Close();
        }   
    }
}
