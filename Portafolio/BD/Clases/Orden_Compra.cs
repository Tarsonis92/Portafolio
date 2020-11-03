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
        private char estado_pago;
        private string observaciones;
        private int proveedor_id_proveedor;
        private int usuario_id_usuario;
        private int tipo_usuario_id_tipo;
        

        public Orden_Compra(int id_compra, string fecha_emision, string observaciones,char estado_pago,int proveedor_id_proveedor,int usuario_id_usuario,int tipo_usuario_id_tipo)
        {
            this.id_compra = id_compra;
            this.fecha_emision = fecha_emision;
            this.estado_pago = estado_pago;
            this.observaciones = observaciones;
            this.proveedor_id_proveedor = proveedor_id_proveedor;
            this.usuario_id_usuario = usuario_id_usuario;
            this.tipo_usuario_id_tipo = tipo_usuario_id_tipo;
        }

        public int Id_compra { get => id_compra; set => id_compra = value; }
        public string Fecha_emision { get => fecha_emision; set => fecha_emision = value; }
        public string Estado_pago { get => estado_pago; set => estado_pago = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Proveedor_id_proveedor { get => proveedor_id_proveedor; set => proveedor_id_proveedor = value; }
        public string Usuario_id_usuario { get => usuario_id_usuario; set => usuario_id_usuario = value; }
        public string Tipo_usuario_id_tipo { get => tipo_usuario_id_tipo; set => tipo_usuario_id_tipo = value; }
    }
}
