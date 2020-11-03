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
        private int ingrediente_id_ingrediente;
        private int producto_id_producto;

        public Deta_Producto(int id_detalle, int cantidad,int ingrediente_id_ingrediente, int producto_id_producto)
        {
            this.id_detalle = id_detalle;
            this.cantidad = cantidad;
            this.ingrediente_id_ingrediente = ingrediente_id_ingrediente;
            this.producto_id_producto = producto_id_producto;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Ingrediente_id_ingrediente { get => ingrediente_id_ingrediente; set => ingrediente_id_ingrediente = value; }
        public int Producto_id_producto { get => producto_id_producto; set => producto_id_producto = value; }
    }
}
