using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Tipo_Usuario 
    {

        private int id_tipo;
        private string nombre;

        public Tipo_Usuario()
        {
        }

        public Tipo_Usuario(int id_tipo, string nombre)
        {
            Id_tipo = id_tipo;
            Nombre = nombre;

        }

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

       
    }



  
}
