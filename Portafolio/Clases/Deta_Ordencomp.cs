using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Deta_Ordencomp
    {

        private int id_detalle;
        private int cantidad;
        private int total_compra;

        public Deta_Ordencomp(int id_detalle, int cantidad, int total_compra)
        {
            this.id_detalle = id_detalle;
            this.cantidad = cantidad;
            this.total_compra = total_compra;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total_compra { get => total_compra; set => total_compra = value; }
    }
}
