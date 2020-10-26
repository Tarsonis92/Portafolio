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
    public class DAOReservacion 
    {
        Reservacion dto = new Reservacion();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");



        public void Actualizar_Reservacion(int id_reservacion, DateTime fecha_hora, int id_usuario)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar la Reservación?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_RESERVACION", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_RESERVACION", OracleType.Int32).Value =id_reservacion ;
                comando.Parameters.Add("P_FECHA_HORA", OracleType.VarChar).Value = fecha_hora;
                comando.Parameters.Add("P_ID_USUARIO", OracleType.Int32).Value = id_usuario;
                


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Reservación Actualizada");
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
        public void Agregar_Reservacion(int id_reservacion, DateTime fecha_hora, int id_usuario)
        {
            try
            {
                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_RESERVACION", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_RESERVACION", OracleType.Int32).Value = id_reservacion;
                comando.Parameters.Add("P_FECHA_HORA", OracleType.VarChar).Value = fecha_hora;
                comando.Parameters.Add("P_ID_USUARIO", OracleType.Int32).Value = id_usuario;
                command.ExecuteNonQuery();
                MessageBox.Show("Reservación Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Reservacion(int id_reservacion)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Reservación?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_RESERVACION", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_reservacion", OracleType.Int32).Value = id_reservacion;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Reservación Eliminada");
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
        public List<Reservacion> Listar()
        {
            List<Reservacion> usa = new List<Reservacion>();
            Reservacion dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_RESERVACION", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Usuario();
                                dto.Id_reservacion = dr["ID_RESERVACION"].ToString();
                                dto.Fecha_hora = dr["FECHA_HORA"].ToString();
                                dto.Id_usuario = dr["ID_USUARIO"].ToString();
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
