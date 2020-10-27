using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Producto_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Producto( string nombre, int precio, string descripcion, int cate_prod_id_categoria);
        void Actualizar_Producto(int id_producto, string nombre, int precio, string descripcion, int cate_prod_id_categoria);
        void Eliminar_Producto(int id_producto);


    }
}
