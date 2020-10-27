using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD
{
    public class Conexion
    {

        OracleConnection con = new OracleConnection("DATA SOURCE=xe; PASSWORD=porta_final;USER ID=porta_final");

        public Conexion()
        {
        }

        public void Conectar() {

            con.Open();

        }

        public void desconectar() {

            con.Close();
        }

        public bool conexion_validar(string nombre, string contrasena) {

            bool flag = false;

            OracleCommand ora = new OracleCommand
                ("SELECT * FROM USUARIO " +
                "WHERE NOMBRE =: nombre " +
                "AND CONTRASEÑA =: contraseña",con);
            
            ora.Parameters.AddWithValue(":nombre", nombre);
            ora.Parameters.AddWithValue(":contraseña",contrasena);

            OracleDataReader reader = ora.ExecuteReader();


            if (reader.Read())
            {

                con.Close();
                MessageBox.Show("Bienvenido "+nombre);

            }
            else {

                MessageBox.Show("No se pudo ingresar");
            
            }

            return flag;
        }

        
    }
}
