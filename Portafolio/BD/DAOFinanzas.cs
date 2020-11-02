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
    public class DAOFinanzas : Conexion, Metodos_CRUD<Usuario>
    {
      //  Usuario dto = new Usuario();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");
        
        public void Actualizar_Cuenta(int id_cuenta, DateTime fecha_emision,DateTime fecha_pago,char estado_pago,int vuelto,
            int total_cuenta,int comanda_id_comanda,int cliente_id_cliente,int tipo_pago_id_tipo)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Cuenta?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_CUENTA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_CUENTA", OracleType.Int32).Value = id_cuenta;
                comando.Parameters.Add("P_FECHA_EMISION", OracleType.Date ).Value = fecha_emision;
                comando.Parameters.Add("P_FECHA_PAGO", OracleType.Date).Value = fecha_pago;
                comando.Parameters.Add("P_ESTADO_PAGO", OracleType.Char).Value = estado_pago;
                comando.Parameters.Add("P_VUELTO", OracleType.Int32).Value = vuelto;
                comando.Parameters.Add("P_COMANDA_ID_COMANDA", OracleType.Int32).Value = comanda_id_comanda;
                comando.Parameters.Add("P_CLIENTE_ID_CLIENTE", OracleType.Int32).Value = cliente_id_cliente;
                comando.Parameters.Add("P_TIPO_PAGO_ID_TIPO", OracleType.Int32).Value = tipo_pago_id_tipo;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cuenta Actualizada");
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

        public void Agregar_Cuenta(DateTime fecha_emision, DateTime fecha_pago, char estado_pago, int vuelto,
            int total_cuenta, int comanda_id_comanda, int cliente_id_cliente, int tipo_pago_id_tipo)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_COMANDA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                command.Parameters.Add("P_FECHA_PAGO", OracleType.Date).Value = fecha_pago;
                command.Parameters.Add("P_ESTADO_PAGO", OracleType.Char).Value = estado_pago;
                command.Parameters.Add("P_VUELTO", OracleType.Int32).Value = vuelto;
                command.Parameters.Add("P_COMANDA_ID_COMANDA", OracleType.Int32).Value = comanda_id_comanda;
                command.Parameters.Add("P_CLIENTE_ID_CLIENTE", OracleType.Int32).Value = cliente_id_cliente;
                command.Parameters.Add("P_TIPO_PAGO_ID_TIPO", OracleType.Int32).Value = tipo_pago_id_tipo;
                command.ExecuteNonQuery();
                MessageBox.Show("Cuenta Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Cuenta(int id_cuenta)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Cuenta?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_CUENTA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_CUENTA", OracleType.Int32).Value = id_cuenta;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cuenta Eliminada");
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
        public List<Cuenta> Listar_Cuenta()
        {
            List<Cuenta> usa = new List<Cuenta>();
            Orden dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_CUENTA", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Comanda();
                                dto.Id_cuenta = dr["ID_CUENTA"].ToString();
                                dto.Fecha_emision = dr["FECHA_EMISION"].ToString();
                                dto.Fecha_pago = dr["FECHA_PAGO"].ToString();
                                dto.Estado_pago = dr["ESTADO_PAGO"].ToString();
                                dto.Vuelto = dr["VUELTO"].ToString();
                                dto.Comanda_id_comanda = dr["COMANDA_ID_COMANDA"].ToString();
                                dto.Cliente_id_cliente = dr["CLIENTE_ID_CLIENTE"].ToString();
                                dto.Tipo_pago_id_tipo = dr["TIPO_PAGO_ID_TIPO"].ToString();
                 
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

        public void Actualizar_Tipo_pago(int id_tipo, String nombre)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Cuenta?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_TIPO_PAGO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = id_tipo;
                comando.Parameters.Add("P_NOMBRE", OracleType.Date).Value = nombre;
              

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tipo Pago Actualizado");
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


        public void Agregar_Tipo_pago(String nombre)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_COMANDA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_NOMBRE", OracleType.Date).Value = nombre;
                command.ExecuteNonQuery();
                MessageBox.Show("Tipo Pago Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }
        public void Eliminar_Tipo_pago(int tipo_pago)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Tipo De Pago?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_TIPO_PAGO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = id_cuenta;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tipo De Pago Eliminado");
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

        public List<Tipo_pago> Listar_Tipo_pago()
        {
            List<Tipo_pago> usa = new List<Tipo_pago>();
            Tipo_pago dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_TIPO_PAGO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Comanda();
                                dto.Id_tipo = dr["ID_TIPO"].ToString();
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



        public void Actualizar_Orden_compra(int id_compra,DateTime fecha_emision,char estado_pago,String observaciones, int proveedor_id_proveedor,
            int usuario_id_usuario,int tipo_pago_id_tipo)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Orden De Compra?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_ORDEN_COMPRA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_COMPRA", OracleType.Int32).Value = id_compra;
                comando.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                comando.Parameters.Add("P_ESTADO_PAGO", OracleType.Char).Value = estado_pago;
                comando.Parameters.Add("P_OBSERVACIONES", OracleType.Varchar2).Value = observaciones;
                comando.Parameters.Add("P_PROVEEDOR_ID_PROVEEDOR", OracleType.Int32).Value = proveedor_id_proveedor;
                comando.Parameters.Add("P_USUARIO_ID_USUARIO", OracleType.Int32).Value = usuario_id_usuario;
                comando.Parameters.Add("P_TIPO_PAGO_ID_TIPO", OracleType.Int32).Value = tipo_pago_id_tipo;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Orden De Compra Actualizado");
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
        public void Agregar_Orden_compra(DateTime fecha_emision, char estado_pago, String observaciones, int proveedor_id_proveedor,
            int usuario_id_usuario, int tipo_pago_id_tipo)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_ORDEN_COMPRA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                command.Parameters.Add("P_ESTADO_PAGO", OracleType.Char).Value = estado_pago;
                command.Parameters.Add("P_OBSERVACIONES", OracleType.Varchar2).Value = observaciones;
                command.Parameters.Add("P_PROVEEDOR_ID_PROVEEDOR", OracleType.Int32).Value = proveedor_id_proveedor;
                command.Parameters.Add("P_USUARIO_ID_USUARIO", OracleType.Int32).Value = usuario_id_usuario;
                command.Parameters.Add("P_TIPO_PAGO_ID_TIPO", OracleType.Int32).Value = tipo_pago_id_tipo;
                command.ExecuteNonQuery();
                MessageBox.Show("Orden De COmpra Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Orden_compra(int id_compra)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Orden De COmpra?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_ORDEN_COMPRA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_COMPRA", OracleType.Int32).Value = id_compra;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cuenta Eliminada");
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
        public List<Orden_Compra> Listar_Orden_Compra()
        {
            List<Orden_Compra> usa = new List<Orden_Compra>();
            Orden_Compra dto = null;
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

                                dto = new Comanda();
                                dto.Id_compra = dr["ID_COMPRA"].ToString();
                                dto.Fecha_emision = dr["FECHA_EMISION"].ToString();
                                dto.Estado_pago = dr["ESTADO_PAGO"].ToString();
                                dto.Observaciones = dr["OBSERVACIONES"].ToString();
                                dto.Proveedor_id_proveedor = dr["PROVEEDOR_ID_PROVEEDOR"].ToString();
                                dto.Usuario_id_usuario = dr["USUARIO_ID_USUARIO"].ToString();
                                dto.Tipo_pago_id_tipo = dr["TIPO_PAGO_ID_TIPO"].ToString();

                                usa.Add(dto);

                            }
                        }
                    }

                }

            }