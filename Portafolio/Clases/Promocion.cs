using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Promocion
    {
        private int id_promocion;
        private string nombre;
        private int precio_promocion;

        public Promocion(int id_promocion, string nombre, int precio_promocion)
        {
            this.id_promocion = id_promocion;
            this.nombre = nombre;
            this.precio_promocion = precio_promocion;
        }

        public int Id_promocion { get => id_promocion; set => id_promocion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio_promocion { get => precio_promocion; set => precio_promocion = value; }
    }
}
