using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Factura
    {
        private int id_factura;
        private string fecha_emision;
        private string estado;

        public Factura(int id_factura, string fecha_emision, string estado)
        {
            this.id_factura = id_factura;
            this.fecha_emision = fecha_emision;
            this.estado = estado;
        }

        public int Id_factura { get => id_factura; set => id_factura = value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
