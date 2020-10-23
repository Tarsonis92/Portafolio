using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Ord_Compra
    {
        private int id_compra;
        private string fecha_emision;
        private int numero_orden;
        private string observaciones;
        private string estado;

        public Ord_Compra(int id_compra, string fecha_emision, int numero_orden, string observaciones, string estado)
        {
            this.id_compra = id_compra;
            this.fecha_emision = fecha_emision;
            this.numero_orden = numero_orden;
            this.observaciones = observaciones;
            this.estado = estado;
        }

        public int Id_compra { get => id_compra; set => id_compra = value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public int Numero_orden { get => numero_orden; set => numero_orden = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
