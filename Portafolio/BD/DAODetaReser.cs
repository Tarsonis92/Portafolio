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
    public class DAODetaReser 
    {
        Deta_Reser dto = new Deta_Reser();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

        public void Actualizar_DetaReser(int id_detalle, int cantidad_personas, int reservacion_id_reserva)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar El Detalle De La Reserva?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_DETA_RESER", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_CANTIDAD_PERSONAS", OracleType.Int32.Value = cantidad_personas;
                comando.Parameters.Add("P_RESERVACION_ID_RESERVA", OracleType.Int32).Value = reservacion_id_reserva;
     

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Reserva Actualizado");
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

        public void Agregar_DetaReser( int cantidad_personas, int reservacion_id_reserva)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_DETA_RESER", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_CANTIDAD_PERSONAS", OracleType.Int32.Value = cantidad_personas;
                command.Parameters.Add("P_RESERVACION_ID_RESERVA", OracleType.Int32).Value = reservacion_id_reserva;
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle Reserva  Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_DetaReser(int id_detalle)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar al Usuario?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_DETA_RESER", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Reserva Eliminado");
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

        public List<Deta_Reser> Listar()
        {
            List<Deta_Reser> usa = new List<Deta_Reser>();
            Usuario dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_DETA_RESER", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Usuario();
                                dto.Id_detalle = Convert.ToInt32(dr["ID_DETALLE"].ToString());
                                dto.Cantidad_personas = Convert.ToInt32["CANTIDAD_PERSONAS"].ToString();
                                dto.Reservacion_id_reserva = Convert.ToInt32["RESERVACION_ID_RESERVA"].ToString();
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
