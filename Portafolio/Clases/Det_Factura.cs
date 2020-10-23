using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Det_Factura
    {
        private int id_detalle;
        private int cantidad;
        private int total_factura;
        private int vuelto;

        public Det_Factura(int id_detalle, int cantidad, int total_factura, int vuelto)
        {
            this.id_detalle = id_detalle;
            this.cantidad = cantidad;
            this.total_factura = total_factura;
            this.vuelto = vuelto;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total_factura { get => total_factura; set => total_factura = value; }
        public int Vuelto { get => vuelto; set => vuelto = value; }
    }
}
