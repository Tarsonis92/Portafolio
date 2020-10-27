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
    public class DAOOrdenCOmpra 
    {
        OrdenCompra dto = new OrdenCompra();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");
        ID_COMPRA,FECHA_EMISION,OBSERVACIONES,proveedor_id_proveedor,
   usuario_id_usuario,estado_pago_id_estado

        public void Actualizar_OrdenCompra(int id_compra,DateTime fecha_emision, string observaciones, int proveedor_id_proveedor,int usuario_id_usuario, int estado_pago_id_estado)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Orden De Compra?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_ORDEN_COMPRA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_COMPRA", OracleType.Int32).Value = id_compra;
                comando.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                comando.Parameters.Add("P_OBSERVACIONES", OracleType.VarChar).Value = observaciones;
                comando.Parameters.Add("P_PROVEEDOR_ID_PROVEEDOR", OracleType.Int32).Value = proveedor_id_proveedor;
                comando.Parameters.Add("P_USUARIO_ID_USUARIO", OracleType.Int32).Value = usuario_id_usuario;
                comando.Parameters.Add("P_ESTADO_PAGO_ID_ESTADO", OracleType.Int32).Value = estado_pago_id_estado;


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


        public void Agregar_OrdenCompra( DateTime fecha_emision, string observaciones, int proveedor_id_proveedor, int usuario_id_usuario, int estado_pago_id_estado)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_ORDEN_COMPRA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
              
                command.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                command.Parameters.Add("P_OBSERVACIONES", OracleType.VarChar).Value = observaciones;
                command.Parameters.Add("P_PROVEEDOR_ID_PROVEEDOR", OracleType.Int32).Value = proveedor_id_proveedor;
                command.Parameters.Add("P_USUARIO_ID_USUARIO", OracleType.Int32).Value = usuario_id_usuario;
                command.Parameters.Add("P_ESTADO_PAGO_ID_ESTADO", OracleType.Int32).Value = estado_pago_id_estado;
                command.ExecuteNonQuery();
                MessageBox.Show("Orden De Compra  Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_OrdenCompra(int id_compra)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Orden De Comrpra?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_ORDEN_COMPRA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_COMPRA", OracleType.Int32).Value = id_compra;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Orden De Compra Eliminado");
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
            List<OrdenCompra> usa = new List<OrdenCompra>();
            OrdenCompra dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_ORDEN_COMPRA", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Usuario();
                                dto.Id_compra = Convert.ToInt32(dr["ID_COMPRA"].ToString());
                                dto.Fecha_emision = dr["FECHA_EMISION"].ToString();
                                dto.Observaciones = dr["OBSERVACIONES"].ToString();
                                dto.Proveedor_id_proveedor = Convert.ToInt32(dr["PROVEEDOR_ID_PROVEEDOR"].ToString());
                                dto.Usuario_id_usuario = Convert.ToInt32(dr["USUARIO_ID_USUARIO"].ToString());
                                dto.Estado_pago_id_estado = Convert.ToInt32(dr["ESTADO_PAGO_ID_ESTADO"].ToString());
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
