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
public class DAOMesa 
    {
	//Usuario dto = new Usuario();
	OracleCommand comando = new OracleCommand();
	OracleDataAdapter adaptador = new OracleDataAdapter();
	OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

	public void Actualizar_Mesa(int id_mesa, int capacidad, int id_reservacion)
    {
        try
            {

            DialogResult result = MessageBox.Show("¿Desea Actualizar La Mesa?", "Actualizar", MessageBoxButtons.YesNo);

            con.Open();
            OracleCommand comando = new OracleCommand("ACTUALIZAR_MESA", con);
           // comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_ID_MESA", OracleType.Int32).Value = id_mesa;
            comando.Parameters.Add("P_CAPACIDAD", OracleType.number).Value = capacidad;
            comando.Parameters.Add("P_ID_RESERVACION", OracleType.Int32).Value = id_reservacion;


            if (result == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Mesa Actualizada");
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
    public void Agregar_Mesa(int id_mesa, int capacidad, int id_reservacion)
    {
        try
        {
            con.Open();
            OracleCommand command = new OracleCommand("INSERTAR_USUARIO", con);
            //command.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_ID_MESA", OracleType.Int32).Value = id_mesa;
            comando.Parameters.Add("P_CAPACIDAD", OracleType.number).Value = capacidad;
            comando.Parameters.Add("P_ID_RESERVACION", OracleType.Int32).Value = id_reservacion;
            command.ExecuteNonQuery();
            MessageBox.Show("Mesa Agregada");
        }

        catch (Exception)
        {
            MessageBox.Show("Error!!!, Algo salio mal");
        }
        con.Close();
    }



         public void Eliminar_Mesa(int id_mesa)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Mesa?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_MESA", con);
                //comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_MESA", OracleType.Int32).Value = id_MESA;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Mesa Eliminada");
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
        public List<Mesa> Listar()
        {
            List<Mesa> usa = new List<Mesa>();
            Mesa dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_MESA", con))
                    {
                    //    comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Usuario();
                                dto.Id_mesa = dr["ID_MESA"].ToString();
                                dto.Capacidad = dr["CAPACIDAD"].ToString();
                                dto.Id_reservacion = dr["ID_RESERVACION"].ToString();
                                
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
