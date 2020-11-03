using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Deor_Comp
    {

        private int id_detalle;
        private int cantidad;
        private int total_compra;
        private int orden_compra_id_compra;
        private int ingrediente_id_ingrediente;

        public Deor_Comp(int id_detalle, int cantidad, int total_compra,int orden_compra_id_compra,int ingrediente_id_ingrediente)
        {
            this.id_detalle = id_detalle;
            this.cantidad = cantidad;
            this.total_compra = total_compra;
            this.orden_compra_id_compra = orden_compra_id_compra;
            this.ingrediente_id_ingrediente = ingrediente_id_ingrediente;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Total_compra { get => total_compra; set => total_compra = value; }
        public int Orden_compra_id_compra { get => orden_compra_id_compra; set => orden_compra_id_compra = value; }
        public int Ingrediente_id_ingrediente { get => ingrediente_id_ingrediente; set => ingrediente_id_ingrediente = value; }
    }
}
