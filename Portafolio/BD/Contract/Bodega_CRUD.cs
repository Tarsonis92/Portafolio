using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Bodega_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Bodega((int id_bodega, int stock);
        void Actualizar_Bodega((int id_bodega,  int stock);
        void Eliminar_Bodega(int id_bodega);
    }
}
