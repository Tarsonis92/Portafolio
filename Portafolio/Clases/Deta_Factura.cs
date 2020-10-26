using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Deta_Factura
    {
        private int id_detalle;
        private int total_factura;
        private int vuelto;
        private DateTime fecha_pago;

        public Deta_Factura(int id_detalle, int total_factura, int vuelto, DateTime fecha_pago)
        {
            this.id_detalle = id_detalle;
            this.total_factura = total_factura;
            this.vuelto = vuelto;
            this.fecha_pago = fecha_pago;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Total_factura { get => total_factura; set => total_factura = value; }
        public int Vuelto { get => vuelto; set => vuelto = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
    }
}
