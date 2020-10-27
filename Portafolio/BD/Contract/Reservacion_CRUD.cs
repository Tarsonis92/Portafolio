using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Reservacion_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Reservacion( DateTime fecha_hora, int usuario_id_usuario, int mesa_id_mesa);
        void Actualizar_Reservacion(int id_reservacion, DateTime fecha_hora, int usuario_id_usuario, int mesa_id_mesa);
        void Eliminar_Reservacion(int id_reservacion);


    }
}
