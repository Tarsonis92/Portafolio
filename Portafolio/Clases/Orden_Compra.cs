using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Orden_Compra
    {
        private int id_compra;
        private string fecha_emision;
        private string observaciones;
        

        public Orden_Compra(int id_compra, string fecha_emision, string observaciones)
        {
            this.id_compra = id_compra;
            this.fecha_emision = fecha_emision;
            this.observaciones = observaciones;
        }

        public int Id_compra { get => id_compra; set => id_compra = value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        
    }
}
