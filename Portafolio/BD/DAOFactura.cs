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

    public class DAOFactura
    {
        Factura dto = new Factura();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Factura(int id_factura, DateTime fecha_emision, Char estado)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar La Factura ?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_FACTURA", con);
                // comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_FACTURA", OracleType.Int32).Value = id_factura;
                comando.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                comando.Parameters.Add("P_ESTADO", OracleType.Char).Value = estado;



                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Factura Actualizada");
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

        public void Agregar_Factura( DateTime fecha_emision, Char estado)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_USUARIO", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
  
                command.Parameters.Add("P_FECHA_EMISION", OracleType.Date).Value = fecha_emision;
                command.Parameters.Add("P_ESTADO", OracleType.Char).Value = estado;
                command.ExecuteNonQuery();
                MessageBox.Show("Factura Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }


        public void Eliminar_Usuario(int id_factura)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Factura ?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_FACTURA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_FACTURA", OracleType.Int32).Value = id_factura;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario Eliminado");
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

        public List<Factura> Listar()
        {
            List<Factura> usa = new List<Factura>();
            Factura dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_USUARIO", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Factura();
                                dto.Id_factura = dr["ID_FACTURA"].ToString();
                                dto.Fecha_Emision = dr["FECHA_EMISION"].ToString();
                                dto.Estado = dr["ESTADO"].ToString();
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
