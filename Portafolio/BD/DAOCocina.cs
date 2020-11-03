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
    public class DAOCocina : Conexion, //Metodos_CRUD<Usuario>
    {
        Orden dto = new Orden();// instanciar
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Comanda(int id_comanda, int mesa_id_mesa,DateTime fecha_orden,DateTime hora_entrada,DateTime hora_salida)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar Comanda?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_COMANDA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_COMANDA", OracleType.Int32).Value = id_comanda;
                comando.Parameters.Add("P_MESA_ID_MESA", OracleType.Int32).Value = mesa_id_mesa;
                comando.Parameters.Add("P_FECHA_ORDEN", OracleType.Date).Value = fecha_orden;
                comando.Parameters.Add("P_HORA_ENTRADA", OracleType.Date).Value = hora_entrada;
                comando.Parameters.Add("P_HORA_SALIDA", OracleType.Date).Value = hora_salida;

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
        public void Agregar_Comanda(int mesa_id_mesa, DateTime fecha_orden, DateTime hora_entrada, DateTime hora_salida)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_COMANDA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_MESA_ID_MESA", OracleType.Int32).Value = mesa_id_mesa;
                command.Parameters.Add("P_FECHA_ORDEN", OracleType.Date).Value = fecha_orden;
                command.Parameters.Add("P_HORA_ENTRADA", OracleType.Date).Value = hora_entrada;
                command.Parameters.Add("P_HORA_SALIDA", OracleType.Date).Value = hora_salida;
                command.ExecuteNonQuery();
                MessageBox.Show("Orden Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Comanda(int id_comanda)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Orden?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_COMANDA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_COMANDA", OracleType.Int32).Value = id_comanda;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Comanda Eliminada");
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

        public List<Comanda> Listar_Comanda()
        {
            List<COMANDA> usa = new List<COMANDA>();
            Orden dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_COMANDA", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Comanda();
                                dto.Id_orden = dr["ID_COMANDA"].ToString();
                                dto.Mesa_id_mesa = dr["MESA_ID_MESA"].ToString();
                                dto.Fecha_orden = dr["FECHA_ORDEN"].ToString();
                                dto.Hora_entrada = dr["HORA_ENTRADA"].ToString();
                                dto.Hora_salida = dr["HORA_SALIDA"].ToString();
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

      

        
        public void Actualizar_DetaComan(int id_detalle, int cantidad,int producto_id_producto,int comanda_id_comanda)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar El Detalle de la Comanda?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_DETACOMAN", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
                comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
                comando.Parameters.Add("P_PRODUCTO_ID_PRODUCTO", OracleType.Int32).Value = producto_id_producto;
                comando.Parameters.Add("P_COMANDA_ID_COMANDA", OracleType.Int32).Value = comanda_id_comanda;
        

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Comanda Actualizada");
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

        public void Agregar_DetaComan(int cantidad, int producto_id_producto, int comanda_id_comanda)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_COMANDA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
                command.Parameters.Add("P_PRODUCTO_ID_PRODUCTO", OracleType.Int32).Value = producto_id_producto;
                command.Parameters.Add("P_COMANDA_ID_COMANDA", OracleType.Int32).Value = comanda_id_comanda;
                command.ExecuteNonQuery();
                MessageBox.Show("Detalle Comanda Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_DetaComan(int id_detalle)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Detalle de la Comanda?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_DETACOMAN", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle Comanda Eliminado");
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

        public List<DetaComan> Listar_DetaComan()
        {
            List<DetaComan> usa = new List<DetaComan>();
            DetaComan dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_DETACOMAN", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Comanda();
                                dto.Id_detalle = dr["ID_DETALLE"].ToString();
                                dto.Cantidad = dr["CANTIDAD"].ToString();
                                dto.Producto_id_producto = dr["PRODUCTO_ID_PRODUCTO"].ToString();
                                dto.Comanda_id_comanda = dr["COMANDA_ID_COMANDA"].ToString();
                               
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