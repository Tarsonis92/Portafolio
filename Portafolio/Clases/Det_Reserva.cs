using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Det_Reserva
    {
        private int id_detalle;
        private int cantidad_personas;
        private int cantidad_mesas;

        public Det_Reserva(int id_detalle, int cantidad_personas, int cantidad_mesas)
        {
            this.id_detalle = id_detalle;
            this.cantidad_personas = cantidad_personas;
            this.cantidad_mesas = cantidad_mesas;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad_personas { get => cantidad_personas; set => cantidad_personas = value; }
        public int Cantidad_mesas { get => cantidad_mesas; set => cantidad_mesas = value; }
    }
}
