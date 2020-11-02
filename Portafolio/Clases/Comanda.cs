using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Comanda
    {
        private int id_comanda;
        private DateTime fecha_orden;
        private TimeSpan hora_entrada;
        private TimeSpan hora_salida;

        public Comanda(int id_comanda, DateTime fecha_orden, TimeSpan hora_entrada, TimeSpan hora_salida)
        {
            this.id_comanda = id_comanda;
            this.fecha_orden = fecha_orden;
            this.hora_entrada = hora_entrada;
            this.hora_salida = hora_salida;
        }

        public int Id_comanda { get => id_comanda; set => id_comanda = value; }
        public DateTime Fecha_orden { get => fecha_orden; set => fecha_orden = value; }
        public TimeSpan Hora_entrada { get => hora_entrada; set => hora_entrada = value; }
        public TimeSpan Hora_salida { get => hora_salida; set => hora_salida = value; }
    }
}
