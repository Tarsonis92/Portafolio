using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface CateProd_CRUD<T>
    {

        List<T> Listar();

        void Agregar_CateProd(int id_categoria, String nombre, String descripcion)
        void Actualizar_Cate_Prod(int id_categoria, String nombre, String descripcion)
        void Eliminar_Usuario(int id_categoria);


    }
}
