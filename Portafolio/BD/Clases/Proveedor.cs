using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Proveedor
    {
        private int id_proveedor;
        private string nombre;
        private string direccion;
        private string rut;
        private int telefono;
        private string correo;

        public Proveedor(int id_proveedor, string nombre, string direccion, string rut, int telefono, string correo)
        {
            this.id_proveedor = id_proveedor;
            this.nombre = nombre;
            this.direccion = direccion;
            this.rut = rut;
            this.telefono = telefono;
            this.correo = correo;
        }

        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Rut { get => rut; set => rut = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
