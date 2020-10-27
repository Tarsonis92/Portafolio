using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface DeorComp_CRUD<T>
    {

        List<T> Listar();

        void Agregar_DeorComp( int cantidad, int total_compra, int orden_compra_id_compra);
        void Actualizar_DeorComp(int id_detalle, int cantidad, int total_compra, int orden_compra_id_compra);
        void Eliminar_DeorComp(int id_detalle);


    }
}
