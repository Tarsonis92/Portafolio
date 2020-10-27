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
    public class DAOProducto
    {
        Producto dto = new Producto();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

        public void Actualizar_Producto(int id_producto, string nombre, int precio, string descripcion, int cate_prod_id_categoria)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar Producto?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_PRODUCTO", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PRODUCTO", OracleType.Int32).Value = id_producto;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_PRECIO", OracleType.Int32).Value = precio;
                comando.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;
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
        public void Agregar_Producto( string nombre, int precio, string descripcion, int cate_prod_id_categoria)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_PRODUCTO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                command.Parameters.Add("P_PRECIO", OracleType.Int32).Value = precio;
                command.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;
                command.Parameters.Add("P_CATE_PROD_ID_CATEGORIA", OracleType.Int32).Value = cate_prod_id_categoria;
                command.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado");
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
                DialogResult result = MessageBox.Show("¿Desea Eliminar al Usuario?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_PRODUCTO", con);
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


        public List<Producto> Listar()
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

                                dto = new Producto();
                                dto.Id_producto = dr["ID_PRODUCTO"].ToString();
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Precio = dr["PRECIO"].ToString();
                                dto.Descripcion = dr["DESCRIPCION"].ToString();
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


    }
}

