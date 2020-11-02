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
    public class DAOAdmin : Conexion, //Metodos_CRUD<Usuario>
    {
        // Usuario dto = new Usuario();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");
        public void Actualizar_Producto(int id_producto, String nombre, int precio, DateTime tiempo_preparacion, string descripcion,/*string imagen,*/int cate_prod_id_categoria)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar EL Producto?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_PRODUCTO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PRODUCTO", OracleType.Int32).Value = id_producto;
                comando.Parameters.Add("P_NOMBRE", OracleType.Varchar2).Value = nombre;
                comando.Parameters.Add("P_PRECIO", OracleType.Int32).Value = precio;
                comando.Parameters.Add("P_TIEMPO_PREPARACION", OracleType.Int32).Value = tiempo_preparacion;
                comando.Parameters.Add("P_DESCRIPCION", OracleType.Varchar2).Value = descripcion;
                comando.Parameters.Add("P_CATE_PROD_ID_CATEGORIA", OracleType.Int32).Value = cate_prod_id_categoria;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Producto Actualizado");
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
        public void Agregar_Producto(String nombre, int precio, DateTime tiempo_preparacion, string descripcion,/*string imagen,*/int cate_prod_id_categoria)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("ACTUALIZAR_PRODUCTO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_NOMBRE", OracleType.Varchar2).Value = nombre;
                command.Parameters.Add("P_PRECIO", OracleType.Int32).Value = precio;
                command.Parameters.Add("P_TIEMPO_PREPARACION", OracleType.Int32).Value = tiempo_preparacion;
                command.Parameters.Add("P_DESCRIPCION", OracleType.Varchar2).Value = descripcion;
                command.Parameters.Add("P_CATE_PROD_ID_CATEGORIA", OracleType.Int32).Value = cate_prod_id_categoria;
                command.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_Producto(int id_producto)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Producto?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_RESERVACION", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PRODUCTO", OracleType.Int32).Value = id_producto;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Producto Eliminado");
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

        public List<Producto> Listar_producto()
        {
            List<Producto> usa = new List<Producto>();
            Producto dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_PRODUCTO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Reservacion();
                                dto.Id_producto = dr["ID_PRODUCTO"].ToString();
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Precio = dr["PRECIO"].ToString();
                                dto.Tiempo_preparacion = dr["TIEMPO_PREPARACION"].ToString();
                                dto.Descripcion = dr["DESCRIPCION"].ToString();
                                //dto.Imagen = dr["IMAGEN"].ToString();
                                dto.Cate_prod_id_categoria = dr["CATE_PROD_ID_CATEGORIA"].ToString();
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
        public void Actualizar_Deta_producto(int id_detalle, int cantidad, int ingrediente_id_ingrediente, int producto_id_producto)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar EL Detalle Del Producto?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_DETA_PRODUCTO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_producto;
                comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = nombre;
                comando.Parameters.Add("P_INGREDIENTE_ID_INGREDIENTE", OracleType.Int32).Value = precio;
                comando.Parameters.Add("P_PRODUCTO_ID_PRODUCTO", OracleType.Int32).Value = tiempo_preparacion;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Detalle De Producto Actualizado");
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

        public void Agregar_Deta_producto(int cantidad, int ingrediente_id_ingrediente, int producto_id_producto)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("ACTUALIZAR_DETA_PRODUCTO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = nombre;
                command.Parameters.Add("P_INGREDIENTE_ID_INGREDIENTE", OracleType.Int32).Value = precio;
                command.Parameters.Add("P_PRODUCTO_ID_PRODUCTO", OracleType.Int32).Value = tiempo_preparacion;
                command.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Deta_producto(int id_detalle)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Detalle Del Producto?", "Eliminar", MessageBoxButtons.YesNo);

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

        public List<Producto> Listar_Deta_producto()
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

                                dto = new Reservacion();
                                dto.Id_detalle = dr["ID_DETALLE"].ToString();
                                dto.Cantidad = dr["CANTIDAD"].ToString();
                                dto.Ingrediente_id_ingrediente = dr["INGREDIENTE_ID_INGREDIENTE"].ToString();
                                dto.Producto_id_producto = dr["PRODUCTO_ID_PRODUCTO"].ToString();
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
        public void Actualizar_Proveedor(int id_proveedor, String nombre, String direccion, String rut, int telefono, string correo)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar EL Proveedor?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_PROVEEDOR", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PROVEEDOR", OracleType.Int32).Value = id_proveedor;
                comando.Parameters.Add("P_NOMBRE", OracleType.Varchar2).Value = nombre;
                comando.Parameters.Add("P_DIRECCION", OracleType.Varchar2).Value = direccion;
                comando.Parameters.Add("P_RUT", OracleType.Varchar2).Value = rut;
                comando.Parameters.Add("P_TELEFONO", OracleType.Varchar2).Value = telefono;
                comando.Parameters.Add("P_CORREO", OracleType.Varchar2).Value = correo;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Producto Actualizado");
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


        public void Agregar_Proveedor(String nombre, String direccion, String rut, int telefono, string correo)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("ACTUALIZAR_PROVEEDOR", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("P_NOMBRE", OracleType.Varchar2).Value = nombre;
                command.Parameters.Add("P_DIRECCION", OracleType.Varchar2).Value = direccion;
                command.Parameters.Add("P_RUT", OracleType.Varchar2).Value = rut;
                command.Parameters.Add("P_TELEFONO", OracleType.Varchar2).Value = telefono;
                command.Parameters.Add("P_CORREO", OracleType.Varchar2).Value = correo;
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }
        public void Eliminar_Proveedor(int id_proveedor)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar El Proveedor?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_PROVEEDOR", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PROVEEDOR", OracleType.Int32).Value = id_detalle;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Proveedor Eliminado");
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

        public List<Proveedor> Listar_Proveedor()
        {
            List<Proveedor> usa = new List<Proveedor>();
            Proveedor dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_PROVEEDOR", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Reservacion();
                                dto.Id_proveedor = dr["ID_PROVEEDOR"].ToString();
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Direccion = dr["DIRECCION"].ToString();
                                dto.Rut = dr["RUT"].ToString();
                                dto.Telefono = dr["TELEFONO"].ToString();
                                dto.Correo = dr["CORREO"].ToString();
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
