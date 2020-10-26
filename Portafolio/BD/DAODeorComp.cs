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
    public class DAODeorComp 
    {
        Deor_Comp dto = new Deor_Comp();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_DeorComp(int id_detalle, int cantidad, int total_compra,int orden_compra_id_compra)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Orden De Compra?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_DEOR_COMP", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
                comando.Parameters.Add("P_TOTAL_COMPRA", OracleType.Int32).Value = total_compra;
                comando.Parameters.Add("P_ORDEN_COMPRA_ID_COMPRA", OracleType.Int32).Value = orden_compra_id_compra;
              
                

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Orden De Compra Actualizada");
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
        public void Agregar_DeorComp(int id_detalle, int cantidad, int total_compra, int orden_compra_id_compra)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_DEOR_COMP", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
                comando.Parameters.Add("P_TOTAL_COMPRA", OracleType.Int32).Value = total_compra;
                comando.Parameters.Add("P_ORDEN_COMPRA_ID_COMPRA", OracleType.Int32).Value = orden_compra_id_compra;
                command.ExecuteNonQuery();
                MessageBox.Show("Orden De Compra Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_DeorComp(int id_detalle)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Orden De Compra?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_DEOR_COMP", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Orden De Compra Eliminada");
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

        public List<DeorComp> Listar()
        {
            List<Deor_Comp> usa = new List<Deor_Comp>();
            Deor_Comp dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_DEOR_COMP", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new DeorComp();
                                dto.Id_detalle = Convert.ToInt32(dr["ID_DETALLE"].ToString());
                                dto.Nombre = Convert.ToInt32(dr["CANTIDAD"].ToString());
                                dto.Apellido = Convert.ToInt32(dr["TOTAL_COMPRA"].ToString());
                                dto.Contrasena = Convert.ToInt32(dr["ORDEN_COMPRA_ID_COMPRA"].ToString());
                          
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


