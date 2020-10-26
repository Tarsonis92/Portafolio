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
        private DateTime fecha_emision;
        

        public Factura(int id_factura, DateTime fecha_emision)
        {
            this.id_factura = id_factura;
            this.fecha_emision = fecha_emision;
            
        }

        public int Id_factura { get => id_factura; set => id_factura = value; }
        public DateTime Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        
    }
}
