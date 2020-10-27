using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Mesa_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Mesa( int capacidad);
        void Actualizar_Mesa(int id_mesa, int capacidad);
        void Eliminar_Mesa(int id_mesa);


    }
}
