using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface EstadoPago_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Estado_Pago(int id_estado, string nombre);
        void Actualizar_Estado_Pago(int id_estado, string nombre);
        void Eliminar_Usuario(int id_estado);


    }
}
