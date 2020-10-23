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

        public bool conexion_validar(string id_usuario, string contrasena) {

            bool flag = false;

            OracleCommand ora = new OracleCommand
                ("SELECT * FROM USUARIO " +
                "WHERE NOMBRE =: nombre " +
                "AND CONTRASENA =: contrasena",con);
            
            ora.Parameters.AddWithValue(":nombre", id_usuario);
            ora.Parameters.AddWithValue(":contrasena",contrasena);

            OracleDataReader reader = ora.ExecuteReader();


            if (reader.Read())
            {

                con.Close();
                MessageBox.Show("Bienvenido "+id_usuario);

            }
            else {

                MessageBox.Show("No se pudo ingresar");
            
            }

            return flag;
        }

        
    }
}
