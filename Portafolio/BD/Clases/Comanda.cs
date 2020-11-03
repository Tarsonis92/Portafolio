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
        private int mesa_id_mesa;
        private DateTime fecha_orden;
        private DateTime hora_entrada;
        private DateTime hora_salida;


        public Comanda(int id_comanda, int mesa_id_mesa, DateTime fecha_orden, DateTime hora_entrada, DateTime hora_salida)
        {
            this.id_comanda = id_comanda;
            this.mesa_id_mesa = mesa_id_mesa;
            this.fecha_orden = fecha_orden;
            this.hora_entrada = hora_entrada;
            this.hora_salida = hora_salida;
        }


        public int Id_comanda{ get => id_comanda; set => id_comanda = value; }
        public int Mesa_id_mesa { get => mesa_id_mesa; set => mesa_id_mesa = value; }
        public int Fecha_orden { get => fecha_orden; set => fecha_orden = value; }
        public int Hora_entrada { get => hora_entrada; set => hora_entrada = value; }
        public int Hora_salida { get => hora_salida; set => hora_salida = value; }



    }


}