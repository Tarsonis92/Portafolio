using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Orden
    {
        private int id_orden;
        private string fecha_hora;

        public Orden(int id_orden, string fecha_hora)
        {
            this.id_orden = id_orden;
            this.fecha_hora = fecha_hora;
        }

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public string Fecha_hora { get => fecha_hora; set => fecha_hora = value; }
    }
}
