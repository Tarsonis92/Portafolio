using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
   public class Usuario : Tipo_Usuario
    {
        private string id_usuario;
        private string nombre;
        private string apellido;
        private string contrasena;
        private string correo;

        public Usuario()
        {
        }

        public Usuario(string id_usuario, string nombre, string apellido, string contrasena, string correo)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contrasena = contrasena;
            this.correo = correo;
        }

        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Correo { get => correo; set => correo = value; }


       
    }
}
