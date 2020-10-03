using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Metodos_CRUD<T>
    {
        string Insertar(T dto);
        string Actualizar(T dto);
        string Eliminar(string dto);
        List<T> Listar();
    }
}
