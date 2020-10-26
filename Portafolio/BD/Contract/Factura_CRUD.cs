using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Factura_CRUD<T>
    {

        List<T> Listar();
  
        void Agregar_Factura(int id_factura, DateTime fecha_emision, char estado);
        void Actualizar_Factura(int id_factura, DateTime fecha_emision, char estado);
        void Eliminar_Factura(int id_factura);
    

    }
}
