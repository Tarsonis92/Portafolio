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
    public class DAORegistroBodega 
    {
        RegistroBodega dto = new RegistroBodega();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Registro_Bodega(int id_registro, DateTime fecha_ingreso, int deor_comp_id_detalle)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar El Registro De La Bodega?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_REGISTRO_BODEGA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_REGISTRO", OracleType.Int32).Value = id_registro;
                comando.Parameters.Add("P_FECHA_INGRESO", OracleType.Date).Value = fecha_ingreso;
                comando.Parameters.Add("P_DEOR_COMP_ID_DETALLE", OracleType.Int32).Value = deor_comp_id_detalle;
                

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro De Bodega  Actualizado");
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
        public void Agregar_Registro_Bodega( DateTime fecha_ingreso, int deor_comp_id_detalle)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_REGISTRO_BODEGA", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
               
                command.Parameters.Add("P_FECHA_INGRESO", OracleType.Date).Value = fecha_ingreso;
                command.Parameters.Add("P_DEOR_COMP_ID_DETALLE", OracleType.Int32).Value = deor_comp_id_detalle;
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Bodega  Agregado");
            }

            catch (Exception)
            {
                MessageBox.Show("Error!!!, Algo salio mal");
            }
            con.Close();
        }

        public void Eliminar_Registro_Bodega(int id_registro)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Eliminar Registro Bodega?", "Eliminar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_REGISTRO_BODEGA", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_REGISTRO", OracleType.Int32).Value = id_registro;

                if (result == DialogResult.Yes)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Bodega Eliminado");
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


        public List<RegistroBodega> Listar()
        {
            List<RegistroBodega> usa = new List<RegistroBodega>();
            RegistroBodega dto = null;
            try
            {
                using (OracleConnection con = new OracleConnection())
                {

                    con.Open();
                    using (OracleCommand comando = new OracleCommand("SP_SELECT_REGISTRO_BODEGA", con))
                    {
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {

                            while (dr.Read())
                            {

                                dto = new RegistroBodega();
                                dto.Id_usuario = Convert.ToInt32(dr["ID_REGISTRO"].ToString());
                                dto.Nombre = dr["FECHA_INGRESO"].ToString();
                                dto.Apellido = Convert.ToInt32(dr["DEOR_COMP_ID_DETALLE"].ToString());
                               
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
