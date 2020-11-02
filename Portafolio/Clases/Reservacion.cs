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
        private int cantidad_personas;
        private int mesa_id_mesa;
        private int cliente_id_cliente;

        public Reservacion(int id_reserva, DateTime fecha_hora)
        {
            this.id_reserva = id_reserva;
            this.fecha_hora = fecha_hora;
            this.cantidad_personas = cantidad_personas;
            this.mesa_id_mesa = mesa_id_mesa;
            this.cliente_id_cliente = cliente_id_cliente;
        }

        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public DateTime Fecha_Hora { get => fecha_hora; set => fecha_hora = value; }
         public int Cantidad_personas { get => cantidad_personas; set => cantidad_personas = value; }
         public int Mesa_id_mesa { get => mesa_id_mesa; set => mesa_id_mesa = value; }
         public int  Cliente_id_cliente { get => cliente_id_cliente; set => cliente_id_cliente = value; }

    }
}
