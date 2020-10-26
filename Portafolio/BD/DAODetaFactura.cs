using System;

ing BD.Contract;
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
    public class DAODetaFactura 
    {
        Deta_Factura dto = new Deta_Factura();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

        public void Actualizar_DetaFactura(int id_detalle,int total_factura,int vuelto, DateTime fecha_pago,int factura_id_factura)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar EL Detalle De La Factura?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_DETA_FACTURA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_TOTAL_FACTURA", OracleType.Int32).Value = total_factura;
                comando.Parameters.Add("P_VUELTO", OracleType.Int32).Value = vuelto;
                comando.Parameters.Add("P_FECHA_PAGO", OracleType.Date).Value = fecha_pago;
                comando.Parameters.Add("P_FACTURA_ID_FACTURA", OracleType.Int32).Value = factura_id_factura;
                


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle De Factura Actualizado");
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
        public void Agregar_DetaFactura(int id_detalle, int total_factura, int vuelto, DateTime fecha_pago, int factura_id_factura)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_DETA_FACTURA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_TOTAL_FACTURA", OracleType.Int32).Value = total_factura;
                comando.Parameters.Add("P_VUELTO", OracleType.Int32).Value = vuelto;
                comando.Parameters.Add("P_FECHA_PAGO", OracleType.Date).Value = fecha_pago;
                comando.Parameters.Add("P_FACTURA_ID_FACTURA", OracleType.Int32).Value = factura_id_factura; ;
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle Factura  Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_DetaFactura(int id_detalle)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar Detalle Factura?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_DETA_FACTURA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Factura Eliminado");
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
            List<Deta_Factura> usa = new List<Deta_Factura>();
            Deta_Factura dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_DETA_FACTURA", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Deta_Factura();
                                dto.Id_detalle = Convert.ToInt32(dr["ID_DETALLE"].ToString());
                                dto.Total_factura = Convert.ToInt32(dr["TOTAL_FACTURA"].ToString();
                                dto.Vuelto = Convert.ToInt32(dr["VUELTO"].ToString();
                                dto.Fecha_pago = dr["FECHA_PAGO"].ToString();
                                dto.Factura_id_factura = Convert.ToInt32(dr["P_FACTURA_ID_FACTURA"].ToString();
                            
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
