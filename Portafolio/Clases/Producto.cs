using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Producto 
    {
        private int id_producto;
        private string nombre;
        private int precio;
        private string descripcion;

        public Producto(int id_producto, string nombre, int precio, string descripcion)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
