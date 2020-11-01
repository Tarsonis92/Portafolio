using BD.Contract;
using Clases;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BD
{
    public class DAOUsuario : Conexion, Metodos_CRUD<Usuario>
    {
        Usuario dto = new Usuario();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=porta_final;USER ID=porta_final");



        public void Actualizar_Usuario(int id_usuario, string nombre, string apellido, string contrasena, string correo, int id_tipo)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar al Usuario?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_USUARIO", OracleType.Int32).Value = id_usuario;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = apellido;
                comando.Parameters.Add("P_CONTRASENA", OracleType.VarChar).Value = contrasena;
                comando.Parameters.Add("P_CORREO", OracleType.VarChar).Value = correo;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = id_tipo;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario Actualizado");
                }
                else if (result == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }

            con.Close();
        }

        public void Agregar_Usuario(string nombre, string apellido, string contrasena, string correo, int id_tipo)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_USUARIO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new OracleParameter("P_NOMBRE", OracleType.VarChar)).Value = nombre;
                command.Parameters.Add(new OracleParameter("P_APELLIDO", OracleType.VarChar)).Value = apellido;
                command.Parameters.Add(new OracleParameter("P_CONTRASENA", OracleType.VarChar)).Value = contrasena;
                command.Parameters.Add(new OracleParameter("P_CORREO", OracleType.VarChar)).Value = correo;
                command.Parameters.Add(new OracleParameter("P_ID_TIPO", OracleType.Int32)).Value = id_tipo;
                command.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }



        public void Eliminar_Usuario(int id_usuario)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar al Usuario?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_USUARIO", OracleType.Int32).Value = id_usuario;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario Eliminado");
                }
                else if (result == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }


            con.Close();
        }



        public List<Usuario> Listar()
        {
            List<Usuario> usa = new List<Usuario>();
            Usuario dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_USUARIO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Usuario();
                                dto.Id_usuario = Convert.ToInt32(dr["ID_USUARIO"].ToString());
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Apellido = dr["APELLIDO"].ToString();
                                dto.Contrasena = dr["CONTRASEÑA"].ToString();
                                dto.Correo = dr["CORREO"].ToString();
                                dto.Id_tipo = dr["ID_TIPO"].ToString();
                                usa.Add(dto);

                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                new Exception("Error en el metodo Listar" + ex.Message);
            }
            return usa;
        }

        
    }

}
