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
    public class DAOPromocion
    { 


        Usuario dto = new Usuario();
    OracleCommand comando = new OracleCommand();
    OracleDataAdapter adaptador = new OracleDataAdapter();
    OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");

    public void Actualizar_Usuario(int id_promocion, string nombre, int precio_promocion)
    {
        try
        {

            DialogResult result = MessageBox.Show("¿Desea Actualizar al Promocion?", "Actualizar", MessageBoxButtons.YesNo);

            con.Open();
            OracleCommand comando = new OracleCommand("ACTUALIZAR_PROMOCION", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_ID_PROMOCION", OracleType.Int32).Value = id_promocion;
            comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
            comando.Parameters.Add("P_PRECIO_PROMOCION", OracleType.Int32).Value = precio_promocion;


            if (result == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Promocion Actualizada");
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
    public void Agregar_Promocion( string nombre, int precio_promocion)
    {
        try
        {
            con.Open();
            OracleCommand command = new OracleCommand("INSERTAR_PROMOCION", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
            command.Parameters.Add("P_PRECIO_PROMOCION", OracleType.Int32).Value = precio_promocion;
            command.ExecuteNonQuery();
            MessageBox.Show("Promocion Agregada");
        }

        catch (Exception)
        {
            MessageBox.Show("Error!!!, Algo salio mal");
        }
        con.Close();
    }

    public void Eliminar_Promocion(int id_promocion)
    {
        try
        {
            DialogResult result = MessageBox.Show("¿Desea Eliminar La Promoción?", "Eliminar", MessageBoxButtons.YesNo);

            con.Open();
            OracleCommand comando = new OracleCommand("ELIMINAR_PROMOCION", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_ID_PROMOCION", OracleType.Int32).Value = id_promocion;

            if (result == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Promoción Eliminada");
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

    public List<Promocion> Listar()
    {
        List<Promocion> usa = new List<Promocion>();
        Promocion dto = null;
        try
        {
            using (OracleConnection con = new OracleConnection())
            {

                con.Open();
                using (OracleCommand comando = new OracleCommand("SP_SELECT_PROMOCION", con))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                    using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {

                        while (dr.Read())
                        {

                            dto = new Usuario();
                            dto.Id_promocion = dr["ID_PROMOCION"].ToString();
                            dto.Nombre = dr["NOMBRE"].ToString();
                            dto.Precio_promocion = dr["PRECIO_PROMOCION"].ToString();
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
