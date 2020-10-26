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
    public class DAOProveedor
    {
        Proveedor dto = new Proveedor();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Proveedor(int id_proveedor, string nombre, string direccion, string rut, int telefono, string correo)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar al Proveeodor?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_PROVEEDOR", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PROVEEDOR", OracleType.Int32).Value = id_proveedor;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_DIRECCION", OracleType.VarChar).Value = direccion;
                comando.Parameters.Add("P_RUT", OracleType.VarChar).Value = rut;
                comando.Parameters.Add("P_TELEFONO", OracleType.Int32).Value = telefono;
                comando.Parameters.Add("P_CORREO", OracleType.VarChar).Value = correo;


                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Proveedor Actualizado");
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
        public void Agregar_Proveedor(int id_proveedor, string nombre, string direccion, string rut, int telefono, string correo)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_PROVEEDOR", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PROVEEDOR", OracleType.Int32).Value = id_proveedor;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_DIRECCION", OracleType.VarChar).Value = direccion;
                comando.Parameters.Add("P_RUT", OracleType.VarChar).Value = rut;
                comando.Parameters.Add("P_TELEFONO", OracleType.Int32).Value = telefono;
                comando.Parameters.Add("P_CORREO", OracleType.VarChar).Value = correo;

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
                DialogResult result = MessageBox.Show("¿Desea Eliminar al Usuario?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_PROVEEDOR", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PROVEEDOR ", OracleType.Int32).Value = id_proveedor;

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
        public List<Proveedor> Listar()
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

                                dto = new Proveedor();
                                dto.Id_usuario = dr["ID_PROVEEDOR"].ToString();
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
}
