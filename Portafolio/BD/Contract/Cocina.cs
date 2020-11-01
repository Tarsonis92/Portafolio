using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Cocina<T>
    {

        List<T> Listar();

       /* void Agregar_Tipo_Usuario(int id_tipo, string nombre);
        void Actualizar_Tipo_Usuario(int id_tipo, string nombre);
        void Eliminar_Tipo_Usuario(int id_tipo);*/


    }
}
