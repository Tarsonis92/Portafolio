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

        void Agregar_Usuario(string nombre, string apellido, string contrasena, string correo, int id_tipo);
        void Actualizar_Usuario(int id_usuario, string nombre, string apellido, string contrasena, string correo, int id_tipo);
        void Eliminar_Usuario(int id_usuario);


    }
}
