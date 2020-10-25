using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Registro_Bodega
    {
        private int id_bodega;
        private DateTime fecha_ingreso;

        public Registro_Bodega(int id_bodega, DateTime fecha_ingreso)
        {
            this.id_bodega = id_bodega;
            this.fecha_ingreso = fecha_ingreso;
        }

        public int Id_bodega { get => id_bodega; set => id_bodega = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
    }
}
