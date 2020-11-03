using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Cliente
    {

        private int id_cliente;
        private string rut;
        private string nombre;
        private string apellido;


        public Cliente(int id_cliente, string rut, string nombre, string apellido)
        {
            this.id_cliente = id_cliente;
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public String Rut { get => rut; set => rut = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }




    }



}