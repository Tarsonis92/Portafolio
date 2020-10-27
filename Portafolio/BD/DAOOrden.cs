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
    public class DAOOrden
    {
       // Usuario dto = new Usuario();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");
      // hay que tener ojo con el datetime 

        public void Actualizar_Orden(int id_orden,  int mesa_id_mesa)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Orden?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_ORDEN", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ORDEN", OracleType.Int32).Value = id_orden;
                comando.Parameters.Add("P_MESA_ID_MESA", OracleType.Int32).Value = mesa_id_mesa;
   


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Orden Actualizada");
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
        public void Agregar_Orden( int mesa_id_mesa)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_ORDEN", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
            
                command.Parameters.Add("P_MESA_ID_MESA", OracleType.Int32).Value = mesa_id_mesa;
                command.ExecuteNonQuery();
                MessageBox.Show("Orden Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Orden(int id_orden)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Orden?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_ORDEN", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ORDEN", OracleType.Int32).Value = id_orden;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Orden Eliminada");
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

        public List<Orden> Listar()
        {
            List<Orden> usa = new List<Orden>();
            Orden dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_ORDEN", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Orden();
                                dto.Id_orden = dr["ID_ORDEN"].ToString();
                                dto.Fecha_Hora = dr["FECHA_HORA"].ToString();
                                dto.Id_factura = dr["ID_FACTURA"].ToString();
                                dto.Id_mesa = dr["ID_MESA"].ToString();
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


