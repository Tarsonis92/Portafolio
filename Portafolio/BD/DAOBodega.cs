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
    public class DAOBodega : Conexion, //Metodos_CRUD<Usuario>
    {
        Bodega dto = new Bodega();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();
        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=portafolio;USER ID=portafolio");


        public void Actualizar_Ingrediente(int id_ingrediente, string nombre,DateTime ingreso, DateTime vencimiento)
        {
            try
            {

                DialogResult result = MessageBox.Show("¿Desea Actualizar Ingrediente?", "Actualizar", MessageBoxButtons.YesNo);

                con.Open();
                OracleCommand comando = new OracleCommand("ACTUALIZAR_INGREDIENTE", con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_INGREDIENTE", OracleType.Int32).Value = id_ingrediente;
                comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                comando.Parameters.Add("P_INGRESO", OracleType.Date).Value = ingreso;
                comando.Parameters.Add("P_VENCIMIENTO", OracleType.Date).Value = vencimiento;
              


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

        public void Agregar_Ingrediente(string nombre, DateTime ingreso, DateTime vencimiento)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("INSERTAR_INGREDIENTE", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = nombre;
                command.Parameters.Add("P_VENCIMIENTO", OracleType.Date).Value = ingreso;
                command.Parameters.Add("P_VENCIMIENTO", OracleType.Date).Value = vencimiento;
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

        public List<Ingrediente> Listar_Ingrediente()
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
                                dto.Ingreso = dr["FECHA_INGRESO"].ToString();
                                dto.Vencimiento = dr["FECHA_VENCIMIENTO"].ToString();
                              
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

    public void Actualizar_DeorComp(int id_detalle, int cantidad, int total_compra, int ingrediente_id_ingrediente)
    {
        try
        {

            DialogResult result = MessageBox.Show("¿Desea Actualizar La Orden De Compra?", "Actualizar", MessageBoxButtons.YesNo);

            con.Open();
            OracleCommand comando = new OracleCommand("ACTUALIZAR_DEOR_COMP", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;
            comando.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
            comando.Parameters.Add("P_TOTAL_COMPRA", OracleType.Int32).Value = total_compra;
            comando.Parameters.Add("P_INGREDIENTE_ID_INGREDIENTE", OracleType.Int32).Value = ingrediente_id_ingrediente;



            if (result == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Orden De Compra Actualizada");
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
    public void Agregar_DeorComp(int cantidad, int total_compra, int ingrediente_id_ingrediente)
    {
        try
        {
            con.Open();
            OracleCommand command = new OracleCommand("INSERTAR_DEOR_COMP", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add("P_CANTIDAD", OracleType.Int32).Value = cantidad;
            command.Parameters.Add("P_TOTAL_COMPRA", OracleType.Int32).Value = total_compra;
            command.Parameters.Add("P_INGREDIENTE_ID_INGREDIENTE", OracleType.Int32).Value = ingrediente_id_ingrediente;
            command.ExecuteNonQuery();
            MessageBox.Show("Orden De Compra Agregada");
        }

        catch (Exception)
        {
            MessageBox.Show("Error!!!, Algo salio mal");
        }
        con.Close();
    }


    public void Eliminar_DeorComp(int id_detalle)
    {
        try
        {
            DialogResult result = MessageBox.Show("¿Desea Eliminar La Orden De Compra?", "Eliminar", MessageBoxButtons.YesNo);

            con.Open();
            OracleCommand comando = new OracleCommand("ELIMINAR_DEOR_COMP", con);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_ID_DETALLE", OracleType.Int32).Value = id_detalle;

            if (result == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Orden De Compra Eliminada");
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

    public List<DeorComp> Listar_DeorComp()
    {
        List<Deor_Comp> usa = new List<Deor_Comp>();
        Deor_Comp dto = null;
        try
        {
            using (OracleConnection con = new OracleConnection())
            {

                con.Open();
                using (OracleCommand comando = new OracleCommand("SP_SELECT_DEOR_COMP", con))
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add(new OracleParameter("P_CURSOR", OracleType.Cursor)).Direction = System.Data.ParameterDirection.Output;

                    using (OracleDataReader dr = comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {

                        while (dr.Read())
                        {

                            dto = new DeorComp();
                            dto.Id_detalle = Convert.ToInt32(dr["ID_DETALLE"].ToString());
                            dto.Nombre = Convert.ToInt32(dr["CANTIDAD"].ToString());
                            dto.Apellido = Convert.ToInt32(dr["TOTAL_COMPRA"].ToString());
                            dto.Ingrediente_id_ingrediente = Convert.ToInt32(dr["INGREDIENTE_ID_INGREDIENTE"].ToString());

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
  

