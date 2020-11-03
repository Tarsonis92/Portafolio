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
    public class DAOCliente : Conexion,// Metodos_CRUD<Usuario>
    {
        Reservacion dto = new Reservacion();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");



        public void Actualizar_Reservacion(int id_reservacion, DateTime fecha_hora,int cantidad_personas, int cliente_id_cliente, int mesa_id_mesa)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar la Reservación?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_RESERVACION", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_RESERVA", OracleType.Int32).Value = id_reservacion;
                comando.Parameters.Add("P_FECHA_HORA", OracleType.Date).Value = fecha_hora;
                comando.Parameters.Add("P_CANTIDAD_PERSONAS", OracleType.Int32).Value = cantidad_personas;
                comando.Parameters.Add("P_MESA_ID_MESA", OracleType.Int32).Value = mesa_id_mesa;
                comando.Parameters.Add("P_CLIENTE_ID_CLIENTE", OracleType.Int32).Value = cliente_id_cliente;


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
        public void Agregar_Reservacion(DateTime fecha_hora,int cantidad_personas, int cliente_id_cliente, int mesa_id_mesa)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("ACTUALIZAR_RESERVACION", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.Add("P_FECHA_HORA", OracleType.Date).Value = fecha_hora;
                command.Parameters.Add("P_CANTIDAD_PERSONAS", OracleType.Int32).Value = cantidad_personas; 
                command.Parameters.Add("P_MESA_ID_MESA", OracleType.Int32).Value = mesa_id_mesa;
                command.Parameters.Add("P_CLIENTE_ID_CLIENTE", OracleType.Int32).Value = cliente_id_cliente;
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
        public List<Reservacion> Listar_reservacion()
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

                                dto = new Reservacion();
                                dto.Id_reserva = dr["ID_RESERVA"].ToString();
                                dto.Fecha_hora = dr["FECHA_HORA"].ToString();
                                dto.Cantidad_personas = dr["CANTIDAD_PERSONAS"].ToString();
                                dto.Cliente_id_cliente = dr["CLIENTE_ID_CLIENTE"].ToString();
                                dto.Mesa_id_mesa = dr["MESA_ID_MESA"].ToString();
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





        public void Actualizar_Cliente(int id_cliente, String rut, String nombre, String apellido)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar la Reservación?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_CLIENTE", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_CLIENTE", OracleType.Int32).Value = id_cliente;
                comando.Parameters.Add("P_RUT", OracleType.VarChar).Value = rut;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = apellido;



                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente  Actualizad");
                }
                else if (result == DialogResult.No)
                {

                }


            } catch (Exception) 
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


           public void Agregar_Cliente(String rut, String nombre, String apellido)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("ACTUALIZAR_CLIENTE", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_RUT", OracleType.VarChar).Value = rut;
                command.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                command.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = apellido;
                command.ExecuteNonQuery();
                MessageBox.Show("Cliente Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }





        public void Eliminar_Cliente(int id_cliente)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar Cliente", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_CLIENTE", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_cliente", OracleType.Int32).Value = id_cliente;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente Eliminado");
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


            public List<Cliente> Listar_cliente()
            {
                List<Cliente> usa = new List<Cliente>();
                Cliente dto = null;
                try
                {
                    using (OracleConnection con = new OracleConnection())
                    {

                        con.Open();
                        using (OracleCommand comando = new OracleCommand("SP_SELECT_CLIENTE", con))
                        {
                            comando.CommandType = System.Data.CommandType.StoredProcedure;
                            comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                            using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                            {

                                while (dr.Read())
                                {

                                    dto = new Cliente();
                                    dto.Id_cliente = dr["ID_CLIENTE"].ToString();
                                    dto.Rut = dr["RUT"].ToString();
                                    dto.Nombre = dr["NOMBRE"].ToString();
                                    dto.Apellido = dr["APELLIDO"].ToString();
                               
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
