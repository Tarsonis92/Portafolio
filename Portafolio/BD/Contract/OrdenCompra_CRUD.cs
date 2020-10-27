using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface OrdenCompra_CRUD<T>
    {

        List<T> Listar();

        void Agregar_OrdenCompra( DateTime fecha_emision, string observaciones, int proveedor_id_proveedor, int usuario_id_usuario, int estado_pago_id_estado);
        void Actualizar_OrdenCompra(int id_compra, DateTime fecha_emision, string observaciones, int proveedor_id_proveedor, int usuario_id_usuario, int estado_pago_id_estado);
        void Eliminar_OrdenCompra(int id_compra);


    }
}
