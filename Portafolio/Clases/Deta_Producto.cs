using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Deta_Producto
    {
        private int id_detalle;
        private int cantidad;

        public Deta_Producto(int id_detalle, int cantidad)
        {
            this.id_detalle = id_detalle;
            this.cantidad = cantidad;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
