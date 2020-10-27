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

namespace BD
{
    public class DAOTipoUsuario 
    {
        TipoUsuario dto = new TipoUsuario();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

        public void Actualizar_Tipo_Usuario(int id_tipo, string nombre)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar al Usuario?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_TIPO_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = id_tipo;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tipo Usuario Actualizado");
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
        public void Agregar_Tipo_Usuario(int id_tipo, string nombre)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_Tipo_Usuario", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new OracleParameter("P_ID_TIPO", OracleType.Int32)).Value = id_tipo;
                command.Parameters.Add(new OracleParameter("P_NOMBRE", OracleType.VarChar)).Value = nombre;
               
                
                command.ExecuteNonQuery();
                MessageBox.Show("Tipo Usuario Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_Tipo_Usuario(int id_tipo)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Tipo De Usuario?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_TIPO_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = id_tipo;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tipo De Usuario Eliminado");
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

        public List<TipoUsuario> Listar()
        {
            List<TipoUsuario> usa = new List<TipoUsuario>();
            TipoUsuario dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_TIPO_USUARIO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new TipoUsuario();
                                dto.Id_usuario = Convert.ToInt32(dr["ID_TIPO"].ToString());
                                dto.Nombre = dr["NOMBRE"].ToString();
                               
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


