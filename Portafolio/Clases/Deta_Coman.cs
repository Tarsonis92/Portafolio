using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Deta_Coman
    {

        private int id_detalle;
        private int cantidad;
        private int producto_id_producto;
        private int comanda_id_comanda;


        public Deta_Coman(int id_detalle, int cantidad, int producto_id_producto, int comanda_id_comanda)
        {
            this.id_detalle = id_detalle;
            this.cantidad = cantidad;
            this.producto_id_producto = producto_id_producto;
            this.comanda_id_comanda = comanda_id_comanda;

        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Producto_id_producto { get => producto_id_producto; set => producto_id_producto = value; }
        public int Comanda_id_comanda { get => comanda_id_comanda; set => comanda_id_comanda = value; }



    }
}

