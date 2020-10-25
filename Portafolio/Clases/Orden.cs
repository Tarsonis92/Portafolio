using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Orden
    {
        private int id_orden;
        
        public Orden(int id_orden)
        {
            this.id_orden = id_orden;
        }

        public int Id_orden { get => id_orden; set => id_orden = value; }
        
    }
}
