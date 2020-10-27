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
    public class DAOBodega 
    {
        Bodega dto = new Bodega();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Bodega(int id_bodega, int stock)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar la Bodega?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_BODEGA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_BODEGA", OracleType.Int32).Value = id_bodega;
                comando.Parameters.Add("P_STOCK", OracleType.Int32).Value = stock;
              

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Bodega Actualizada");
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
        public void Agregar_Bodega( int stock)
        {
            try
            {

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_BODEGA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_STOCK", OracleType.Int32).Value = stock;
                command.ExecuteNonQuery();
                MessageBox.Show("Bodega Agregada");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }
        public void Eliminar_Bodega(int id_bodega)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar La Bodega?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_BODEGA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_BODEGA", OracleType.Int32).Value = id_bodega;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Bodega Eliminada");
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
        public List<Bodega> Listar()
        {
            List<Bodega> usa = new List<Bodega>();
            Bodega dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_BODEGA", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new Usuario();
                                dto.Id_bodega = dr["ID_BODEGA"].ToString();
                                dto.stock = dr["STOCK"].ToString();
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