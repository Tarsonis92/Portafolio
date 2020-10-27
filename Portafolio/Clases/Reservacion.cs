using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Reservacion
    {
        private int id_reserva;
        private DateTime fecha_hora;

        public Reservacion(int id_reserva, DateTime fecha_hora)
        {
            this.id_reserva = id_reserva;
            this.fecha_hora = fecha_hora;
        }

        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public DateTime Fecha_Hora { get => fecha_hora; set => fecha_hora = value; }

    }
}
