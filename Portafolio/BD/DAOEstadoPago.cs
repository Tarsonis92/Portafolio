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
    public class DAOEstadoPago 
    {
        EstadoPago dto = new EstadoPago();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");



        public void Actualizar_Estado_Pago(int id_estado, string nombre)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar El Estado De Pago?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_ESTADO_PAGO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ESTADO", OracleType.Int32).Value = id_estado;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Estado De Pago  Actualizado");
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


        public void Agregar_Estado_Pago(int id_estado, string nombre)
        {
            try
            {
                con.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_USUARIO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ESTADO", OracleType.Int32).Value = id_estado;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;

                command.ExecuteNonQuery();
                MessageBox.Show("Estado De Pago  Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }



        public void Eliminar_Usuario(int id_estado)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Estado De Pago?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_ESTADO_PAGO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ESTADO", OracleType.Int32).Value = id_estado;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Estado De Pago  Eliminado");
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

        public List<EstadoPago> Listar()
        {
            List<EstadoPago> usa = new List<EstadoPago>();
            Usuario dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_ESTADO_PAGO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new EstadoPago();
                                dto.Id_usuario = Convert.ToInt32(dr["ID_ESTADO"].ToString());
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

