using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Metodos_CRUD<T>
    {

        List<T> Listar();

        void Agregar_DetaProducto( int cantidad, int ingrediente_id_ingrediente, int producto_id_producto);
        void Actualizar_DetaProducto(int id_detalle, int cantidad, int ingrediente_id_ingrediente, int producto_id_producto);
        void Eliminar_DetaProducto(int id_detalle);


    }
}
