using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface DetaReser_CRUD<T>
    {

        List<T> Listar();

        void Agregar_DetaReser( int cantidad_personas, int reservacion_id_reserva);
        void Actualizar_DetaReser(int id_detalle, int cantidad_personas, int reservacion_id_reserva);
        void Eliminar_DetaReser(int id_detalle);


    }
}
