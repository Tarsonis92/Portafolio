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
        private char estado;

        public Mesa(int id_mesa, int capacidad, char estado)
        {
            this.id_mesa = id_mesa;
            this.capacidad = capacidad;
            this.estado = estado;
        }

        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
