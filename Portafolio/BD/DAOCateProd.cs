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
    public class DAOUCateProd 
    {
        Usuario dto = new CateProd();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");



        public void Actualizar_Cate_Prod(int id_categoria,String  nombre, String descripcion)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Actualizar La Categoría Del Producto?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_CATE_PROD", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_CATEGORIA", OracleType.Int32).Value = id_categoria;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;
               


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Categoría Actualizada");
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

        public void Agregar_CateProd(int id_categoria, String nombre, String descripcion)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_USUARIO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_CATEGORIA", OracleType.Int32).Value = id_categoria;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = descripcion;
                command.ExecuteNonQuery();
                MessageBox.Show("Categoría Producto Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_CateProd(int id_categoria)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Categoría De Producto?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_CATEGORIA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_CATEGORIA", OracleType.Int32).Value = id_categoria;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Categoría Eliminada");
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


        public List<CateProd> Listar()
        {
            List<CateProd> usa = new List<Cate_Prod>();
            Cate_Prod dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_CATE_PROD", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new CateProd();
                                dto.Id_categoria = dr["ID_CATEGORIA"].ToString();
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Detalle = dr["DETALLE"].ToString();
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
