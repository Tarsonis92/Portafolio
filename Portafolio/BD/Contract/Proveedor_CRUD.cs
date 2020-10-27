using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Proveedor_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Proveedor( string nombre, string direccion, string rut, int telefono, string correo);
        void Actualizar_Proveedor(int id_proveedor, string nombre, string direccion, string rut, int telefono, string correo);
        void Eliminar_Proveedor(int id_proveedor);


    }
}
