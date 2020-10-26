using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Deta_Reser
    {
        private int id_detalle;
        private int cantidad_personas;

        public Deta_Reser(int id_detalle, int cantidad_personas)
        {
            this.id_detalle = id_detalle;
            this.cantidad_personas = cantidad_personas;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad_personas { get => cantidad_personas; set => cantidad_personas = value; }
    }
}
