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
    public class DAODetaProducto 
    {
        Deta_Producto dto = new Deta_Producto();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");



        public void Actualizar_DetaProducto(int id_detalle, int cantidad, int ingrediente_id_ingrediente, int producto_id_producto)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar El Detalle Del Producto?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_DETA_PRODUCTO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
                comando.Parameters.Add("P_INGREDIENTE_ID_INGREDIENTE", OracleType.Int32).Value = ingrediente_id_ingrediente;
                comando.Parameters.Add("P_PRODUCTO_ID_PRODUCTO", OracleType.Int32).Value = producto_id_producto;
             


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Del Producto Actualizado");
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

        public void Agregar_DetaProducto( int cantidad, int ingrediente_id_ingrediente, int producto_id_producto)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_DETA_PRODUCTO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
     
                comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
                comando.Parameters.Add("P_INGREDIENTE_ID_INGREDIENTE", OracleType.Int32).Value = ingrediente_id_ingrediente;
                comando.Parameters.Add("P_PRODUCTO_ID_PRODUCTO", OracleType.Int32).Value = producto_id_producto;
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle De Producto Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_DetaProducto(int id_detalle)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Detalle De Producto?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_DETA_PRODUCTO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Del Producto Eliminado");
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


        public List<Deta_Producto> Listar()
        {
            List<Deta_Producto> usa = new List<Deta_Producto>();
            Deta_Producto dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_DETA_PRODUCTO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Deta_Producto();
                                dto.Id_detalle = Convert.ToInt32(dr["ID_DETALLE"].ToString());
                                dto.Cantidad = Convert.ToInt32(dr["CANTIDAD"].ToString());
                                dto.Ingrediente_id_ingrediente = Convert.ToInt32(dr["INGREDIENTE_ID_INGREDIENTE"].ToString());
                                dto.Producto_id_producto = Convert.ToInt32(dr["PRODUCTO_ID_PRODUCTO"].ToString());
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

