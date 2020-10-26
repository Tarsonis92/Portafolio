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
    public class DAOIngrediente
    {
        Ingrediente dto = new Ingrediente();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Usuario(int id_ingrediente, string nombre, DateTime vencimiento, int id_proveedor, int id_producto, int id_promocion, int id_bodega)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar Ingrediente?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_INGREDIENTE", con);
             //   comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_INGREDIENTE", OracleType.Int32).Value = id_ingrediente;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_VENCIMIENTO", OracleType.Date).Value = vencimiento;
                comando.Parameters.Add("P_ID_PROVEEDOR", OracleType.Int32).Value = id_proveedor;
                comando.Parameters.Add("P_ID_PRODUCTO", OracleType.Int32).Value = id_producto;
                comando.Parameters.Add("P_ID_PROMOCION", OracleType.Int32).Value = id_promocion;
                comando.Parameters.Add("P_ID_BODEGA", OracleType.Int32).Value = id_bodega;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ingrediente Actualizado");
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

        public void Agregar_Usuario(int id_ingrediente, string nombre, DateTime vencimiento, int id_proveedor, int id_producto, int id_promocion, int id_bodega)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_INGREDIENTE", con);
               // command.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_INGREDIENTE", OracleType.Int32).Value = id_ingrediente;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_VENCIMIENTO", OracleType.Date).Value = vencimiento;
                comando.Parameters.Add("P_ID_PROVEEDOR", OracleType.Int32).Value = id_proveedor;
                comando.Parameters.Add("P_ID_PRODUCTO", OracleType.Int32).Value = id_producto;
                comando.Parameters.Add("P_ID_PROMOCION", OracleType.Int32).Value = id_promocion;
                comando.Parameters.Add("P_ID_BODEGA", OracleType.Int32).Value = id_bodega;

                command.ExecuteNonQuery();
                MessageBox.Show("Ingrediente Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Ingrediente(int id_ingrediente)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar  El Ingrediente?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_INGREDIENTE", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_INGREDIENTE", OracleType.Int32).Value = id_ingrediente;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ingrediente Eliminado");
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

        public List<Ingrediente> Listar()
        {
            List<Ingrediente> usa = new List<Ingrediente>();
            Ingrediente dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_INGREDIENTE", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Ingrediente();
                                dto.Id_ingrediente = dr["ID_INGREDIENTE"].ToString();
                                dto.Nombre = dr["NOMBRE"].ToString();
                                dto.Vencimiento = dr["VENCIMIENTO"].ToString();
                                dto.Id_proveedor = dr["ID_PROVEEDOR"].ToString();
                                dto.Id_producto = dr["ID_PRODUCTO"].ToString();
                                dto.Id_promocion = dr["ID_PROMOCION"].ToString();
                                dto.Id_bodegae = dr["ID_BODEGA"].ToString();
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
