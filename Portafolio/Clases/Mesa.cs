using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Mesa
    {
        private int id_mesa;
        private int capacidad;

        public Mesa(int id_mesa, int capacidad)
        {
            this.id_mesa = id_mesa;
            this.capacidad = capacidad;
        }

        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
    }
}
