using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Cuenta
    {

        private int id_cuenta;
        private DateTime fecha_emision;
        private DateTime fecha_pago;
        private char estado_pago;
        private int vuelto;
        private int total_cuenta;
        private int comanda_id_comanda;
        private int cliente_id_cliente;
        private int tipo_pago_id_tipo;


        public Cuenta(int id_cuenta, DateTime fecha_emision, DateTime fecha_pago, char estado_pago, int vuelto, int total_cuenta,
            int comanda_id_comanda, int cliente_id_cliente, int tipo_pago_id_tipo)
        {
            this.id_cuenta = id_cuenta;
            this.fecha_emision = fecha_emision;
            this.fecha_pago = fecha_pago;
            this.estado_pago = estado_pago;
            this.vuelto = vuelto;
            this.total_cuenta = total_cuenta;
            this.comanda_id_comanda = comanda_id_comanda;
            this.cliente_id_cliente = cliente_id_cliente;
            this.tipo_pago_id_tipo = tipo_pago_id_tipo;
            
        }


        public int Id_cuenta { get => id_cuenta; set => id_cuenta = value; }
        public DateTime Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public char Estado_pago { get => estado_pago; set => estado_pago = value; }
        public int Vuelto { get => vuelto; set => vuelto = value; }

        public int Total_cuenta { get => total_cuenta; set => total_cuenta = value; }
        public int Comanda_id_comanda { get => comanda_id_comanda; set => comanda_id_comanda = value; }
        public int Cliente_id_cliente { get => cliente_id_cliente; set => cliente_id_cliente = value; }
        public int Tipo_pago_id_tipo { get => tipo_pago_id_tipo; set => tipo_pago_id_tipo = value; }
     




    }


}

