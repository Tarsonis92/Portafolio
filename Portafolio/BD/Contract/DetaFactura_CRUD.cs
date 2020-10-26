using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface DetaFactura_CRUD<T>
    {

        List<T> Listar();

        void Agregar_DetaFactura(int id_detalle, int total_factura, int vuelto, DateTime fecha_pago, int factura_id_factura);
        void Actualizar_DetaFactura(int id_detalle, int total_factura, int vuelto, DateTime fecha_pago, int factura_id_factura);
        void Eliminar_DetaFactura(int id_detalle);


    }
}
