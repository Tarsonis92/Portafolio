using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Bodega
    {
        private int id_bodega;
        private string fecha_ingreso;
        private int stock;

        public Bodega(int id_bodega, string fecha_ingreso, int stock)
        {
            this.id_bodega = id_bodega;
            this.fecha_ingreso = fecha_ingreso;
            this.stock = stock;
        }

        public int Id_bodega { get => id_bodega; set => id_bodega = value; }
        public string Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
