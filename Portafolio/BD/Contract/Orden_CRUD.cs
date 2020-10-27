using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Orden_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Orden( int mesa_id_mesa);
        void Actualizar_Orden(int id_orden, int mesa_id_mesa);
        void Eliminar_Orden(int id_orden);


    }
}
