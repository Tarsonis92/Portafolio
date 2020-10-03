using BD.Contract;
using Clases;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class DAOUsuario : Conexion, Metodos_CRUD<Usuario>
    {
        Usuario dto = new Usuario();

        public string Actualizar(Usuario dto)
        {
            string result = string.Empty;
            try
            {

                using (OracleConnection con = new OracleConnection())
                {
                    con.Open();
                    using (OracleCommand comand = new OracleCommand("SP_ACTUALIZAR_USUARIO", con))
                    {

                        comand.CommandType = System.Data.CommandType.StoredProcedure;
                        comand.Parameters.Add(new OracleParameter("P_ID_USUARIO", OracleType.VarChar)).Value = dto.Id_usuario;
                        comand.Parameters.Add(new OracleParameter("P_NOMBRE", OracleType.VarChar)).Value = dto.Nombre;
                        comand.Parameters.Add(new OracleParameter("P_APELLIDO", OracleType.VarChar)).Value = dto.Apellido;
                        comand.Parameters.Add(new OracleParameter("P_CONTRASENA", OracleType.VarChar)).Value = dto.Contrasena;
                        comand.Parameters.Add(new OracleParameter("P_CORREO", OracleType.VarChar)).Value = dto.Correo;
                        comand.Parameters.Add(new OracleParameter("P_ID_TIPO", OracleType.Int32)).Value = dto.Id_tipo;
                        comand.Parameters.Add(new OracleParameter("P_RESULT", OracleType.VarChar)).Direction = System.Data.ParameterDirection.Output;
                        comand.ExecuteNonQuery();
                        result = Convert.ToString(comand.Parameters["P_RESULT"].Value);

                    }
                    con.Close();
                }


            }
            catch (Exception)
            {

                throw;

            }

            return result;
        }

        public string Eliminar(string dto)
        {

            string result = string.Empty;
            try
            {

                using (OracleConnection con = new OracleConnection())
                {
                    con.Open();
                    using (OracleCommand comand = new OracleCommand("SP_ELIMINAR_USUARIO", con))
                    {

                        comand.CommandType = System.Data.CommandType.StoredProcedure;
                        comand.Parameters.Add(new OracleParameter("P_ID_USUARIO", OracleType.VarChar)).Value = dto;
                        comand.Parameters.Add(new OracleParameter("P_RESULT", OracleType.VarChar)).Direction = System.Data.ParameterDirection.Output;
                        comand.ExecuteNonQuery();
                        result = Convert.ToString(comand.Parameters["P_RESULT"].Value);

                    }
                    con.Close();
                }


            }
            catch (Exception)
            {

                throw;

            }

            return result;

        }

        public string Insertar(Usuario dto)
        {
            string result = string.Empty;
            try {

                using (OracleConnection con = new OracleConnection()){

                    con.Open();
                    using (OracleCommand command = new OracleCommand("SP_INSERTAR_CLIENTE", con)) 
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add(new OracleParameter("P_ID_USUARIO", OracleType.VarChar)).Value = dto.Id_usuario;
                        command.Parameters.Add(new OracleParameter("P_NOMBRE", OracleType.VarChar)).Value = dto.Nombre;
                        command.Parameters.Add(new OracleParameter("P_APELLIDO", OracleType.VarChar)).Value = dto.Apellido;
                        command.Parameters.Add(new OracleParameter("P_CONTRASENA", OracleType.VarChar)).Value = dto.Contrasena;
                        command.Parameters.Add(new OracleParameter("P_CORREO", OracleType.VarChar)).Value = dto.Correo;
                        command.Parameters.Add(new OracleParameter("P_ID_TIPO", OracleType.VarChar)).Value = dto.Id_tipo;
                        command.Parameters.Add(new OracleParameter("P_RESULT",OracleType.VarChar)).Direction=System.Data.ParameterDirection.Output;

                        result = Convert.ToString(command.Parameters["P_RESULT"].Value);

                    }
                    con.Close();
                }
            
            } catch (Exception) {

                throw;
            
            }

            return result;
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
                                dto.Id_usuario = dr["ID_USUARIO"].ToString();
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Apellido = dr["APELLIDO"].ToString();
                                dto.Contrasena = dr["CONTRASENA"].ToString();
                                dto.Correo = dr["CORREO"].ToString();
                                dto.Id_tipo = Convert.ToInt32(dr["ID_TIPO"].ToString());
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
