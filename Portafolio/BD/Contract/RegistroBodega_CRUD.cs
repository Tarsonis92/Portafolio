using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface RegistroBodega_CRUD<T>
    {

        List<T> Listar();

        void Agregar_Registro_Bodega( DateTime fecha_ingreso, int deor_comp_id_detalle);
        void Actualizar_Registro_Bodega(int id_registro, DateTime fecha_ingreso, int deor_comp_id_detalle);
        void Eliminar_Registro_Bodega(int id_registro);


    }
}
